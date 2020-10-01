# The authentication key (API Key).
# Get your own by registering at https://app.pdf.co/documentation/api
$API_KEY = "***********************************"

# Direct URL of source PDF file.
$SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

# Search string.
$SearchString = 'Notes'

# Prepare URL for PDF text search API call.
# See documentation: https://app.pdf.co/documentation/api/1.0/pdf/find.html
$queryFindText = "https://api.pdf.co/v1/pdf/find?url=$($SourceFileURL)&searchString=$($SearchString)"
$queryFindText = [System.Uri]::EscapeUriString($queryFindText)

$queryFindText = "https://api.pdf.co/v1/pdf/find"

# Prepare request body (will be auto-converted to JSON by Invoke-RestMethod)
# See documentation: https://apidocs.pdf.co
$bodyFindText = @{
    "url" = $SourceFileURL
    "searchString" = $SearchString
} | ConvertTo-Json

try {
    # Execute request
    $responseFindText = Invoke-WebRequest -Method Post -Headers @{ "x-api-key" = $API_KEY; "Content-Type" = "application/json" } -Body $bodyFindText -Uri $queryFindText

    $jsonResponseFindText = $responseFindText.Content | ConvertFrom-Json

    if ($jsonResponseFindText.error -eq $false) {

        # Display search information
        $itemFindText = $jsonResponseFindText.body[0];

        Write-Host "Found text at coordinates $($itemFindText.left), $($itemFindText.top)"

        #Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
        $Pages = ""

        # PDF document password. Leave empty for unprotected documents.
        $Password = ""

        # Destination PDF file name
        $DestinationFile = "./result.pdf"

        # Text annotation params
        $Type = "annotation";
        $X = $itemFindText.left;
        $Y = $itemFindText.top + 25;
        $Text = "Some notes will go here... Some notes will go here.... Some notes will go here.....";
        $FontName = "Times New Roman";
        $FontSize = 12;
        $Color = "FF0000";

        $resultFileName = [System.IO.Path]::GetFileName($DestinationFile)

        # * Add Text *
        # Prepare request to `PDF Edit` API endpoint
        $query = "https://api.pdf.co/v1/pdf/edit/add"

        # Prepare request body (will be auto-converted to JSON by Invoke-RestMethod)
        # See documentation: https://apidocs.pdf.co
        $body = @{
            "name" = $resultFileName
            "password" = $Password
            "pages" = $Pages
            "url" = $SourceFileUrl
            "type" = $Type
            "x" = $X
            "y" = $Y
            "text" = $Text
            "fontname" = $FontName
            "size" = $FontSize
            "color" = $Color
        } | ConvertTo-Json
        
        try {
            # Execute request
            $response = Invoke-WebRequest -Method Post -Headers @{ "x-api-key" = $API_KEY; "Content-Type" = "application/json" } -Body $body -Uri $query
            
            $jsonResponse = $response.Content | ConvertFrom-Json

            if ($jsonResponse.error -eq $false) {
                # Get URL of generated barcode image file
                $resultFileUrl = $jsonResponse.url
                
                # Download output file
                Invoke-WebRequest -Uri $resultFileUrl -OutFile $DestinationFile

                Write-Host "Generated PDF saved to '$($DestinationFile)' file."
            }
            else {
                # Display service reported error
                Write-Host $jsonResponse.message
            }
        }
        catch {
            # Display request error
            Write-Host $_.Exception
        }
    }
    else {
        # Display service reported error
        Write-Host $jsonResponse.message
    }
}
catch {
    # Display request error
    Write-Host $_.Exception
}