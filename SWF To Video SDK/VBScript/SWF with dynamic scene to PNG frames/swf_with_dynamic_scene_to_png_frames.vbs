'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all

' Create an instance of SWFToVideo ActiveX object
Set converter = CreateObject("BytescoutSWFToVideo.SWFToVideo")

' Set debug log
'converter.SetLogFile "log.txt"

' Register SWFToVideo
converter.RegistrationName = "demo"
converter.RegistrationKey = "demo"

' uncomment to enable PNG with transparency
' converter.RGBAMode = true ' enable BEFORE setting InputSWFFileName property

' Set input SWF file
converter.InputSWFFileName = "DynamicScene.swf"

' Set output movie dimensions
converter.OutputWidth = 640
converter.OutputHeight = 480

' converter.StartFrame = 25

Converter.UseConversionTimeoutFor1FrameSWFOnly = false
Converter.ConversionTimeout = 60 ' 60 seconds

Converter.SWFConversionMode = 0
Converter.ConvertAllToPNG "."

' converter.ConvertToPNG "output.png"


Set converter = Nothing
