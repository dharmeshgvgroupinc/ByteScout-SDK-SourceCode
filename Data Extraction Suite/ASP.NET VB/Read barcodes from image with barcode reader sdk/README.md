## How to read barcodes from image with barcode reader sdk in ASP.NET VB with ByteScout Data Extraction Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to read barcodes from image with barcode reader sdk in ASP.NET VB

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can be applied to read barcodes from image with barcode reader sdk using ASP.NET VB.

 These ASP.NET VB code samples for ASP.NET VB guide developers to speed up coding of the application when using ByteScout Data Extraction Suite. Follow the instructions from scratch to work and copy the ASP.NET VB code. Enjoy writing a code with ready-to-use sample codes in ASP.NET VB.

ByteScout provides the free trial version of ByteScout Data Extraction Suite along with the documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****About.aspx:**
    
```
<%@ Page Title="About Us" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="About.aspx.vb" Inherits="Barcodes_From_Image.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    ## 
        About
    
    <p>
        Put content here.
    </p>
</asp:Content>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****About.aspx.designer.vb:**
    
```
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



Partial Public Class About
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****About.aspx.vb:**
    
```
Public Class About
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Barcodes From Image.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>
    </SchemaVersion>
    <ProjectGuid>{9CA09A3E-8A71-4C59-A592-A7A239E13ADF}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <RootNamespace>Barcodes_From_Image</RootNamespace>
    <AssemblyName>Barcodes From Image</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <MyType>Custom</MyType>
    <UseIISExpress>false</UseIISExpress>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\</OutputPath>
    <DocumentationFile>Barcodes From Image.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DocumentationFile>Barcodes From Image.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader, Version=5.10.0.914, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Core" />
    <Reference Include="System.Web" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.ApplicationServices" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Collections.Specialized" />
    <Import Include="System.Configuration" />
    <Import Include="System.Text" />
    <Import Include="System.Text.RegularExpressions" />
    <Import Include="System.Web" />
    <Import Include="System.Web.Caching" />
    <Import Include="System.Web.SessionState" />
    <Import Include="System.Web.Security" />
    <Import Include="System.Web.Profile" />
    <Import Include="System.Web.UI" />
    <Import Include="System.Web.UI.WebControls" />
    <Import Include="System.Web.UI.WebControls.WebParts" />
    <Import Include="System.Web.UI.HtmlControls" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="About.aspx" />
    <Content Include="Account\ChangePassword.aspx" />
    <Content Include="Account\ChangePasswordSuccess.aspx" />
    <Content Include="Account\Login.aspx" />
    <Content Include="Account\Register.aspx" />
    <Content Include="Styles\Site.css" />
    <Content Include="Default.aspx" />
    <Content Include="Global.asax" />
    <Content Include="Scripts\jquery-1.4.1-vsdoc.js" />
    <Content Include="Scripts\jquery-1.4.1.js" />
    <Content Include="Scripts\jquery-1.4.1.min.js" />
    <Content Include="Web.config" />
    <Content Include="Web.Debug.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Web.Release.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="About.aspx.designer.vb">
      <DependentUpon>About.aspx</DependentUpon>
    </Compile>
    <Compile Include="About.aspx.vb">
      <DependentUpon>About.aspx</DependentUpon>
      <SubType>ASPXCodebehind</SubType>
    </Compile>
    <Compile Include="Account\ChangePassword.aspx.designer.vb">
      <DependentUpon>ChangePassword.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\ChangePassword.aspx.vb">
      <DependentUpon>ChangePassword.aspx</DependentUpon>
      <SubType>ASPXCodebehind</SubType>
    </Compile>
    <Compile Include="Account\ChangePasswordSuccess.aspx.designer.vb">
      <DependentUpon>ChangePasswordSuccess.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\ChangePasswordSuccess.aspx.vb">
      <DependentUpon>ChangePasswordSuccess.aspx</DependentUpon>
      <SubType>ASPXCodebehind</SubType>
    </Compile>
    <Compile Include="Account\Login.aspx.designer.vb">
      <DependentUpon>Login.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\Login.aspx.vb">
      <DependentUpon>Login.aspx</DependentUpon>
      <SubType>ASPXCodebehind</SubType>
    </Compile>
    <Compile Include="Account\Register.aspx.designer.vb">
      <DependentUpon>Register.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\Register.aspx.vb">
      <DependentUpon>Register.aspx</DependentUpon>
      <SubType>ASPXCodebehind</SubType>
    </Compile>
    <Compile Include="Default.aspx.vb">
      <SubType>ASPXCodeBehind</SubType>
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="Default.aspx.designer.vb">
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="Global.asax.vb">
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\MyExtensions\MyWebExtension.vb">
      <VBMyExtensionTemplateID>Microsoft.VisualBasic.Web.MyExtension</VBMyExtensionTemplateID>
      <VBMyExtensionTemplateVersion>1.0.0.0</VBMyExtensionTemplateVersion>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="Site.Master.designer.vb">
      <DependentUpon>Site.Master</DependentUpon>
    </Compile>
    <Compile Include="Site.Master.vb">
      <DependentUpon>Site.Master</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <Content Include="Account\Web.config" />
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <Content Include="Site.Master" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="App_Data\" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.targets" />
  <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets" />
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>False</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>33897</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>
          </IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
          <UseCustomServer>False</UseCustomServer>
          <CustomServerUrl>
          </CustomServerUrl>
          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx:**
    
```
<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Barcodes_From_Image._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Web Barcode Reader Tester (C#)</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Click browse button to upload an image<br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <br />
        <asp:Button id="UploadButton" 
           Text="Upload file"
           runat="server">
       </asp:Button> 
        <br />
       <br />
        <asp:Label id="UploadStatusLabel" Text="" runat="server"></asp:Label> 
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox><br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="74px" Width="71px" /></div>
    </form>
</body>
</html>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.designer.vb:**
    
```
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class _Default

    '''<summary>
    '''Head1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Head1 As Global.System.Web.UI.HtmlControls.HtmlHead

    '''<summary>
    '''form1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents form1 As Global.System.Web.UI.HtmlControls.HtmlForm

    '''<summary>
    '''FileUpload1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents FileUpload1 As Global.System.Web.UI.WebControls.FileUpload

    '''<summary>
    '''UploadButton control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents UploadButton As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''UploadStatusLabel control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents UploadStatusLabel As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ListBox1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ListBox1 As Global.System.Web.UI.WebControls.ListBox

    '''<summary>
    '''Image1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Image1 As Global.System.Web.UI.WebControls.Image
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.vb:**
    
```
Imports System.IO
Imports Bytescout.BarCodeReader

Public Class _Default
    Inherits System.Web.UI.Page

    ' IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    ' Temporary folder access is required for web application when you use ByteScout SDK in it.
    ' If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    ' SOLUTION:

    ' If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    ' If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    ' In this case
    ' - check the User or User Group your web application is running under
    ' - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    ' - restart your web application and try again

    Private Sub UploadButton_Click(sender As Object, e As System.EventArgs) Handles UploadButton.Click

        Dim savePath As String = "\uploads\"

        If (FileUpload1.HasFile) Then

            Dim virtualFilePath As String = Path.Combine(savePath, FileUpload1.FileName)

            Dim serverFilePath As String = Server.MapPath(virtualFilePath)
            If Not Directory.Exists(Path.GetDirectoryName(serverFilePath)) Then
                Directory.CreateDirectory(Path.GetDirectoryName(serverFilePath))
            End If

            FileUpload1.SaveAs(serverFilePath)

            Dim image As System.Drawing.Image = Nothing

            Try
                Using fileStream As FileStream = File.OpenRead(serverFilePath)
                    image = System.Drawing.Image.FromStream(fileStream)
                End Using

            Catch ex As Exception

            End Try

            If image Is Nothing Then
                UploadStatusLabel.Visible = True
                UploadStatusLabel.Text = "Your file is not an image."
                Image1.Visible = False
                ListBox1.Visible = False
            Else
                UploadStatusLabel.Visible = False
                Image1.ImageUrl = virtualFilePath
                Image1.Visible = True
                Image1.Width = image.Width
                Image1.Height = image.Height
                ListBox1.Items.Clear()
                ListBox1.Visible = True

                FindBarcodes(serverFilePath)

                If ListBox1.Items.Count = 0 Then
                    ListBox1.Items.Add("No barcodes found")
                End If

            End If

        Else
            'Notify the user that a file was not uploaded.
            UploadStatusLabel.Text = "You did not specify a file to upload."
        End If

    End Sub

    Private Sub FindBarcodes(fileName As String)

        Dim reader As Reader = New Reader()

        ' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
		' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
		' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
		reader.BarcodeTypesToFind.SetAll1D()

        ' reader.MediumTrustLevelCompatible = True ' uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

        reader.ReadFromFile(fileName)

        For Each barcode As FoundBarcode In reader.FoundBarcodes
            ListBox1.Items.Add(String.Format("{0} : {1}", barcode.Type, barcode.Value))
        Next

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Global.asax.vb:**
    
```
Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Site.Master.designer.vb:**
    
```
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class SiteMaster

    '''<summary>
    '''Head1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Head1 As Global.System.Web.UI.HtmlControls.HtmlHead

    '''<summary>
    '''HeadContent control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents HeadContent As Global.System.Web.UI.WebControls.ContentPlaceHolder

    '''<summary>
    '''Form1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Form1 As Global.System.Web.UI.HtmlControls.HtmlForm

    '''<summary>
    '''HeadLoginView control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents HeadLoginView As Global.System.Web.UI.WebControls.LoginView

    '''<summary>
    '''NavigationMenu control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents NavigationMenu As Global.System.Web.UI.WebControls.Menu

    '''<summary>
    '''MainContent control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents MainContent As Global.System.Web.UI.WebControls.ContentPlaceHolder
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Site.Master.vb:**
    
```
Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.Debug.config:**
    
```
<?xml version="1.0"?>

<!-- For more information on using web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 -->

<configuration xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform">
  <!--
    In the example below, the "SetAttributes" transform will change the value of 
    "connectionString" to use "ReleaseSQLServer" only when the "Match" locator 
    finds an atrribute "name" that has a value of "MyDB".
    
    <connectionStrings>
      <add name="MyDB" 
        connectionString="Data Source=ReleaseSQLServer;Initial Catalog=MyReleaseDB;Integrated Security=True" 
        xdt:Transform="SetAttributes" xdt:Locator="Match(name)"/>
    </connectionStrings>
  -->
  <system.web>
    <!--
      In the example below, the "Replace" transform will replace the entire 
      <customErrors> section of your web.config file.
      Note that because there is only one customErrors section under the 
      <system.web> node, there is no need to use the "xdt:Locator" attribute.
      
      <customErrors defaultRedirect="GenericError.htm"
        mode="RemoteOnly" xdt:Transform="Replace">
        <error statusCode="500" redirect="InternalError.htm"/>
      </customErrors>
    -->
  </system.web>
</configuration>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.Release.config:**
    
```
<?xml version="1.0"?>

<!-- For more information on using web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 -->

<configuration xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform">
  <!--
    In the example below, the "SetAttributes" transform will change the value of 
    "connectionString" to use "ReleaseSQLServer" only when the "Match" locator 
    finds an atrribute "name" that has a value of "MyDB".
    
    <connectionStrings>
      <add name="MyDB" 
        connectionString="Data Source=ReleaseSQLServer;Initial Catalog=MyReleaseDB;Integrated Security=True" 
        xdt:Transform="SetAttributes" xdt:Locator="Match(name)"/>
    </connectionStrings>
  -->
  <system.web>
    <compilation xdt:Transform="RemoveAttributes(debug)" />
    <!--
      In the example below, the "Replace" transform will replace the entire 
      <customErrors> section of your web.config file.
      Note that because there is only one customErrors section under the 
      <system.web> node, there is no need to use the "xdt:Locator" attribute.
      
      <customErrors defaultRedirect="GenericError.htm"
        mode="RemoteOnly" xdt:Transform="Replace">
        <error statusCode="500" redirect="InternalError.htm"/>
      </customErrors>
    -->
  </system.web>
</configuration>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.config:**
    
```
<?xml version="1.0"?>

<!--
  For more information on how to configure your ASP.NET application, please visit
  http://go.microsoft.com/fwlink/?LinkId=169433
  -->

<configuration>
  <connectionStrings>
    <add name="ApplicationServices"
         connectionString="data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnetdb.mdf;User Instance=true"
         providerName="System.Data.SqlClient" />
  </connectionStrings>

  <system.web>
    <compilation debug="true" strict="false" explicit="true" targetFramework="4.0" />

    <authentication mode="Forms">
      <forms loginUrl="~/Account/Login.aspx" timeout="2880" />
    </authentication>

    <membership>
      <providers>
        <clear/>
        <add name="AspNetSqlMembershipProvider" type="System.Web.Security.SqlMembershipProvider" connectionStringName="ApplicationServices"
             enablePasswordRetrieval="false" enablePasswordReset="true" requiresQuestionAndAnswer="false" requiresUniqueEmail="false"
             maxInvalidPasswordAttempts="5" minRequiredPasswordLength="6" minRequiredNonalphanumericCharacters="0" passwordAttemptWindow="10"
             applicationName="/" />
      </providers>
    </membership>

    <profile>
      <providers>
        <clear/>
        <add name="AspNetSqlProfileProvider" type="System.Web.Profile.SqlProfileProvider" connectionStringName="ApplicationServices" applicationName="/"/>
      </providers>
    </profile>

    <roleManager enabled="false">
      <providers>
        <clear/>
        <add name="AspNetSqlRoleProvider" type="System.Web.Security.SqlRoleProvider" connectionStringName="ApplicationServices" applicationName="/" />
        <add name="AspNetWindowsTokenRoleProvider" type="System.Web.Security.WindowsTokenRoleProvider" applicationName="/" />
      </providers>
    </roleManager>

  </system.web>

  <system.webServer>
     <modules runAllManagedModulesForAllRequests="true"/>
  </system.webServer>
</configuration>

```

<!-- code block end -->