//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Net;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace ByteScoutWebApiExample
{
    class Program
    {
        // The authentication key (API Key).
        // Get your own by registering at https://app.pdf.co/documentation/api
        const String API_KEY = "*****************************************";

        // Source PDF file
        const string SourceFile = @".\sample.pdf";

        // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
        const string Pages = "";

        // PDF document password. Leave empty for unprotected documents.
        const string Password = "";

        // Search string. 
        const string SearchString = @"\d{1,}\.\d\d"; // Regular expression to find numbers like '100.00'
                                                     // Note: do not use `+` char in regex, but use `{1,}` instead.
                                                     // `+` char is valid for URL and will not be escaped, and it will become a space char on the server side.

        // Enable regular expressions (Regex) 
        const bool RegexSearch = true;

        // (!) Make asynchronous job
        const bool Async = true;

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

                if (json["error"].ToObject<bool>() == false)
                {
                    // Get URL to use for the file upload
                    string uploadUrl = json["presignedUrl"].ToString();
                    string uploadedFileUrl = json["url"].ToString();

                    // 2. UPLOAD THE FILE TO CLOUD.
                    webClient.Headers.Add("content-type", "application/octet-stream");
                    webClient.UploadFile(uploadUrl, "PUT", SourceFile); // You can use UploadData() instead if your file is byte[] or Stream

                    // 3. MAKE UPLOADED PDF FILE SEARCHABLE

                    // Prepare URL for `PDF Text Search` API call
                    // See documentation: https://app.pdf.co/documentation/api/1.0/pdf/find.html
                    query = Uri.EscapeUriString(string.Format(
                                "https://api.pdf.co/v1/pdf/find?password={0}&pages={1}&url={2}&searchString={3}&regexSearch={4}&async={5}",
                                Password,
                                Pages,
                                uploadedFileUrl,
                                SearchString,
                                RegexSearch,
                                Async));

                    // Execute request
                    response = webClient.DownloadString(query);

                    // Parse JSON response
                    json = JObject.Parse(response);

                    if (json["error"].ToObject<bool>() == false)
                    {
                        // Asynchronous job ID
                        string jobId = json["jobId"].ToString();

                        // URL of generated json file that will available after the job completion
                        string resultFileUrl = json["url"].ToString();

                        // Check the job status in a loop. 
                        // If you don't want to pause the main thread you can rework the code 
                        // to use a separate thread for the status checking and completion.
                        do
                        {
                            string status = CheckJobStatus(jobId); // Possible statuses: "InProgress", "Failed", "Aborted", "Finished".

                            // Display timestamp and status (for demo purposes)
                            Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + status);

                            if (status == "Finished")
                            {
                                // Execute request
                                string respFileJson = webClient.DownloadString(resultFileUrl);

                                // Parse JSON response
                                JArray jsonFoundInformation = JArray.Parse(respFileJson);

                                // Display found information in console
                                foreach (JToken item in jsonFoundInformation)
                                {
                                    Console.WriteLine($"Found text \"{item["text"]}\" at coordinates {item["left"]}, {item["top"]}");
                                }

                                break;
                            }
                            else if (status == "InProgress")
                            {
                                // Pause for a few seconds
                                Thread.Sleep(3000);
                            }
                            else
                            {
                                Console.WriteLine(status);
                                break;
                            }
                        }
                        while (true);
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
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            webClient.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }


        static string CheckJobStatus(string jobId)
        {
            using (WebClient webClient = new WebClient())
            {
                // Set API Key
                webClient.Headers.Add("x-api-key", API_KEY);

                string url = "https://api.pdf.co/v1/job/check?jobid=" + jobId;

                string response = webClient.DownloadString(url);
                JObject json = JObject.Parse(response);

                return Convert.ToString(json["Status"]);
            }
        }

    }
}
