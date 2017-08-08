'*******************************************************************
'       ByteScout Watermarking SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Watermarking

Module Module1

    Sub Main()
        ' Create Watermarker instance
        Dim waterMarker As New Watermarker()

        ' Initialize library
        waterMarker.InitLibrary("demo", "demo")

        ' Add images to apply watermarks to
        waterMarker.AddInputFile("my_sample_image2.jpg", "my_sample_image2_output.jpg")
        waterMarker.AddInputFile("my_sample_image3.jpg", "my_sample_image3_output.jpg")

        ' Create new watermark
        Dim preset As New Presets.TextFitsPage()

        ' Set watermark text
        preset.Text = "Bytescout Watermarking"

        ' Add watermark to watermarker
        waterMarker.AddWatermark(preset)

        ' Apply watermarks
        waterMarker.Execute()

    End Sub

End Module
