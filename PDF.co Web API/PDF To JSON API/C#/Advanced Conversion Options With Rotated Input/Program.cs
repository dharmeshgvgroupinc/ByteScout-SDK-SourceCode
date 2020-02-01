//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ByteScoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key).
        // Get your own by registering at https://app.pdf.co/documentation/api
        const String API_KEY = "*************************************";

        // Source PDF file
        const string SourceFile = @".\sample-rotated.pdf";
        // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
        const string Pages = "";
        // PDF document password. Leave empty for unprotected documents.
        const string Password = "";
        // Destination JSON file name
        const string DestinationFile = @".\result.json";

        // Sample profile that sets advanced conversion options
        // Advanced options are properties of JSONExtractor class from ByteScout PDF Extractor SDK used in the back-end:
        // https://cdn.bytescout.com/help/BytescoutPDFExtractorSDK/html/87ce5fa6-3143-167d-abbd-bc7b5e160fe5.htm

        /*
         Valid RotationAngle values:
            0 - no rotation
            1 - 90 degrees
            2 - 180 degrees
            3 - 270 degrees
        */
        static string Profiles = File.ReadAllText("profile.json");

        static void Main(string[] args)
        {
            // Create standard .NET web client instance
            WebClient webClient = new WebClient();

            // Set API Key
            webClient.Headers.Add("x-api-key", API_KEY);

            // 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
            // * If you already have a direct file URL, skip to the step 3.

            // Prepare URL for `Get Presigned URL` API call
            string query = Uri.EscapeUriString(string.Format(
                "https://api.pdf.co/v1/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}",
                Path.GetFileName(SourceFile)));

            try
            {
                // Execute request
                string response = webClient.DownloadString(query);

                // Parse JSON response
                JObject json = JObject.Parse(response);

                if (json["status"].ToString() != "error")
                {
                    // Get URL to use for the file upload
                    string uploadUrl = json["presignedUrl"].ToString();
                    string uploadedFileUrl = json["url"].ToString();

                    // 2. UPLOAD THE FILE TO CLOUD.

                    webClient.Headers.Add("content-type", "application/octet-stream");
                    webClient.UploadFile(uploadUrl, "PUT", SourceFile); // You can use UploadData() instead if your file is byte[] or Stream
                    webClient.Headers.Remove("content-type");

                    // 3. CONVERT UPLOADED PDF FILE TO JSON

                    // Prepare URL for `PDF To JSON` API call
                    query = Uri.EscapeUriString(string.Format(
                        "https://api.pdf.co/v1/pdf/convert/to/json?name={0}&password={1}&pages={2}&url={3}&profiles={4}",
                        Path.GetFileName(DestinationFile),
                        Password,
                        Pages,
                        uploadedFileUrl,
                        Profiles));

                    // Execute request
                    response = webClient.DownloadString(query);

                    // Parse JSON response
                    json = JObject.Parse(response);

                    if (json["status"].ToString() != "error")
                    {
                        // Get URL of generated JSON file
                        string resultFileUrl = json["url"].ToString();

                        // Download JSON file
                        webClient.DownloadFile(resultFileUrl, DestinationFile);

                        Console.WriteLine("Generated JSON file saved as \"{0}\" file.", DestinationFile);
                    }
                    else
                    {
                        Console.WriteLine(json["message"].ToString());
                    }
                }
                else
                {
                    Console.WriteLine(json["message"].ToString());
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.ToString());
            }

            webClient.Dispose();


            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
