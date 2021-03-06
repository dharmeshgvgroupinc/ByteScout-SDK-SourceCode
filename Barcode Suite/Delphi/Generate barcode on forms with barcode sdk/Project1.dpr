//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2020 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

{

 IMPORTANT NOTICE for DELPHI 2007, Delphi 2006 or earlier versions:
 -----------------------------------------------------------------------
 Usual approach with type library import (so called "early binding") will crash with "stackoverflow" or "floating point error" due to issues in this versions of Delphi. 
 SOLUTION: Please use so called "late binding" that requires NO type library import and works by creating objects at the runtime like this:  
 // -----------------
 program Project1;
 uses
   SysUtils,
   ComObj,
   ActiveX;
 var
 extractor: Variant;
 begin
 CoInitialize(nil);
 // Create and initialize 
 extractor := CreateOleObject('Bytescout.PDFExtractor.CSVExtractor') ;
 // as usual 
 extractor.LoadDocumentFromFile ('../../sample3.pdf');
 // …
 // destroy the object by setting to varEmpty
 extractor := varEmpty;  
 end.
 // -----------------  

}

program Project1;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
