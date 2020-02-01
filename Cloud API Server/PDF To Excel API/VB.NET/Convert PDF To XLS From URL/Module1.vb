'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

' Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
' If it's not then please replace this with with your hosting url.
Module Module1
 	' Direct URL of source PDF file.
	Const SourceFileUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf"
	' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
	const Pages as String = ""
	' PDF document password. Leave empty for unprotected documents.
	const Password As string = ""
	' Destination XLS file name
	const DestinationFile as string = ".\result.xls"

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Prepare URL for `PDF To XLS` API call
		Dim query As String = Uri.EscapeUriString(String.Format(
			"https://localhost/pdf/convert/to/xls?name={0}&password={1}&pages={2}&url={3}", 
			Path.GetFileName(DestinationFile),
			Password,
			Pages,
			SourceFileUrl))

		Try
			' Execute request
			Dim response As String = webClient.DownloadString(query)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then

				' Get URL of generated XLS file
				Dim resultFileUrl As String = json("url").ToString()

				' Download XLS file
				webClient.DownloadFile(resultFileUrl, DestinationFile)

				Console.WriteLine("Generated XLS file saved as ""{0}"" file.", DestinationFile)

			Else
				Console.WriteLine(json("message").ToString())
			End If

		Catch ex As WebException
			Console.WriteLine(ex.ToString())
		End Try

		webClient.Dispose()

		Console.WriteLine()
		Console.WriteLine("Press any key...")
		Console.ReadKey()

	End Sub

End Module
