# find the latest chromedriver version by scraping the link on the chromedriver webpage
# get the latest chromedriver version number from the end of the url 
# e.g. 2.37 from -> https://chromedriver.storage.googleapis.com/index.html?path=2.37/
# ------------------------------------------------------------------------------------

$res = Invoke-WebRequest "https://sites.google.com/a/chromium.org/chromedriver/downloads"
$url = ($res.Links | Where-Object -property href -match "^https://chromedriver.storage.googleapis.com/index.html\?path=" | select -property href)[0].href

$seperator = @("?path=")
$ver = $url.Split($seperator, [System.StringSplitOptions]::RemoveEmptyEntries)[1]

$file = "https://chromedriver.storage.googleapis.com/" + $ver + "chromedriver_win32.zip"
write-host "downloading $file"
Invoke-WebRequest $file -OutFile "FluentAutomation.SeleniumWebDriver\3rdPartyLib\chromedriver.exe"
write-host "Remember to update your path to include the chromedriver location."
write-host "see https://sites.google.com/a/chromium.org/chromedriver/getting-started"                  