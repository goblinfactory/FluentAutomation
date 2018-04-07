## FluentAutomation API - Simple Fluent API for UI Automation

Please post ideas and new functionality that you'd like to see on our new UserVoice site: [http://fluentapi.uservoice.com](http://fluentapi.uservoice.com)

Browse the docs and follow [@stirno](http://twitter.com/intent/user?screen_name=stirno) on Twitter.

full links to docs coming shortly. 

* [temporary getting started docs](/Docs/v3/temporary-doc-index.md) 

### Building the solution and running the unit tests

1. run `update-chrome-driver.ps1` to download and unpack (unzip) the latest chrome driver.
1. make sure chromedriver is in your system path. *(not 100% certain this is required as the chromedriver is an embedded resource in the project?)*
1. ?? not sure... need to test, disable chrome script debugging
1. build the solution
1. right click on the test project `FluentAutomation.TestApplication` and select `View -> in browser`. This will start iisexpress.
1. Run or debug any unit test you want to.

### rough release notes : this fix

- add linqpad script `Docs\refresh-temporary-index.linq` to generate temporary documentation index `Docs\temporary-doc-index.md`
- fix false negative test, `ScreenShotOnFailedAction()`
- I've removed chromedriver.exe from the project and have written a powershell script `update-chrome-driver.ps1`
- i've added the readme and powershell script the solution items, that's the only reason the sln file has been modified.
- webdriver changes to the API 
  * `Timeouts().ImplicitlyWait` -> `Timeouts().ImplicitWait`
  * update `Webdriver` from ver `2.41` to `3.11`
  * `browserCapabilities.IsJavaScriptEnabled` no longer supported, changed to `browserCapabilities.SetCapability("javascriptEnabled", true);`
- Remove `Click(x,y)` and replace with message not supported use Click(element, x, y)` 
- Add new test FindSpecificElementTest()`
- Fix false negative `SelectedIndexFailed()`
- Fix false negative `SelectValueFailed()`
- Fix false negative `SelectTextFailed()`
- Fix false negative `ScreenshotOnFailedAction()`

### failing tests

Tests marked with "Flakey" pass if you run them on their own immediately after doing a full test run (run all) from resharper.

```csharp
1. Actions.ClickTests
   * .XYClicks()
1. Actions.DragTests
   * .DragAndDropByPosition()
   * .DragAndDropBySelector()
   * .DragAndDropBySelectorOffset()
1. Actions.HoverTests
   * .HoverXY()
   * .Scroll()
1. Actions.PressTypeTests
   * .PressType() <-- FLAKEY
1. Actions.SelectTests
   * .SelectIndexFailed() fixed
   * .SelectTextFailed() fixed
   * .SelectValueFailed() fixed
   * Actions.SwitchTests
   * .FrameSwitchTest() <-- FLAKEY
1. Actions.TakeScreenshotTests
   * .ScreenshotOnFailedAssert() fixed
   * . Actions.WaitTests
   * .WaitUntil() <-- FLAKEY
```

### random ideas and notes

- setup CICD on appVeyor so that I can have all code at very least build server tested with 100% passing tests before submitting pull requests.
- add cake build script to do build, run tests and create package.
- add in the sales pitch sample code (valid useful end to end sample) to the home page so that folk can see the difference between raw Selenium vs FluentAutomation.