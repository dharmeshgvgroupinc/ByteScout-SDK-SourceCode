package com.company;

import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.*;

import java.io.*;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Main
{
    // (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

    // The authentication key (API Key).
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "***********************************";

    // Direct URL of source PDF file.
    final static String SourceFileUrl = "https://s3-us-west-2.amazonaws.com/bytescout-com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf";
    // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    final static String Pages = "";
    // PDF document password. Leave empty for unprotected documents.
    final static String Password = "";
    // Destination XLSX file name
    final static Path DestinationFile = Paths.get(".\\result.xlsx");


    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `PDF To XLSX` API call
        String query = String.format(
                "https://bytescout.io/v1/pdf/convert/to/xlsx?name=%s&password=%s&pages=%s&url=%s",
                DestinationFile.getFileName(),
                Password,
                Pages,
                SourceFileUrl);

        // Prepare request
        Request request = new Request.Builder()
                .url(query)
                .addHeader("x-api-key", API_KEY) // (!) Set API Key
                .build();
        // Execute request
        Response response = webClient.newCall(request).execute();

        if (response.code() == 200)
        {
            // Parse JSON response
            JsonObject json = new JsonParser().parse(response.body().string()).getAsJsonObject();

            boolean error = json.get("error").getAsBoolean();
            if (!error)
            {
                // Get URL of generated XLSX file
                String resultFileUrl = json.get("url").getAsString();

                // Download XLSX file
                downloadFile(webClient, resultFileUrl, DestinationFile.toFile());

                System.out.printf("Generated XLSX file saved as \"%s\" file.", DestinationFile.toString());
            }
            else
            {
                // Display service reported error
                System.out.println(json.get("message").getAsString());
            }
        }
        else
        {
            // Display request error
            System.out.println(response.code() + " " + response.message());
        }
    }

    public static void downloadFile(OkHttpClient webClient, String url, File destinationFile) throws IOException
    {
        // Prepare request
        Request request = new Request.Builder()
                .url(url)
                .build();
        // Execute request
        Response response = webClient.newCall(request).execute();

        byte[] fileBytes = response.body().bytes();

        // Save downloaded bytes to file
        OutputStream output = new FileOutputStream(destinationFile);
        output.write(fileBytes);
        output.flush();
        output.close();

        response.close();
    }
}