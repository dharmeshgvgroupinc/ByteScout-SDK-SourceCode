## simple barcode reading in VBScript and ByteScout BarCode Reader SDK

### Tutorial: how to do simple barcode reading in VBScript

The sample source codes on this page will demonstrate you how to make simple barcode reading in VBScript. Simple barcode reading in VBScript can be implemented with ByteScout BarCode Reader SDK. ByteScout BarCode Reader SDK is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format.

VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout BarCode Reader SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. This basic programming language sample code for VBScript will do the whole work for you in implementing simple barcode reading in your app.

Our website provides free trial version of ByteScout BarCode Reader SDK. It comes along with all these source code samples with the goal to help you with your VBScript application implementation.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****TestBarcodeReading.vbs:**
    
```
Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
bc.BarcodeTypesToFind.SetAll1D()

bc.ReadFromFile "BarcodePhoto.jpg"

For i = 0 To bc.FoundCount - 1
     Msgbox "Found barcode on page #" & CStr(bc.GetFoundBarcodePage(i)) & " with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i) & vbCRLF & " and confidence=" & Cstr(bc.GetFoundBarcodeConfidence(i))
Next

Set bc = Nothing

```

<!-- code block end -->