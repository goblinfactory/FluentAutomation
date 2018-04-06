## FluentAutomation API - Simple Fluent API for UI Automation

Please post ideas and new functionality that you'd like to see on our new UserVoice site: [http://fluentapi.uservoice.com](http://fluentapi.uservoice.com)

Visit our public site at [http://fluent.stirno.com](http://fluent.stirno.com) orfollow [@stirno](http://twitter.com/intent/user?screen_name=stirno) on Twitter.

### Building the solution and running the unit tests

1. run `update-chrome-driver.ps1` to download and unpack (unzip) the latest chrome driver.
1. make sure chromedriver is in your system path. *(not 100% certain this is required as the chromedriver is an embedded resource in the project?)*
1. ?? not sure... need to test, disable chrome script debugging
1. build the solution
1. right click on the test project `FluentAutomation.TestApplication` and select `View -> in browser`. This will start iisexpress.
1. Run or debug any unit test you want to.

### current status of this (Alan's) fork (not yet ready for pull request)

### failing tests

Tests marked with "Flakey" pass if you run them on their own immediately after doing a full test run (run all) from resharper.

```csharp

- Actions.ClickTests
.XYClicks()

- Actions.DragTests
.DragAndDropByPosition()
.DragAndDropBySelector()
.DragAndDropBySelectorOffset()

- Actions.HoverTests
.HoverXY()
.Scroll()

- Actions.PressTypeTests
.PressType() <-- FLAKEY

Actions.SelectTests
.SelectIndexFailed()
.SelectTextFailed()
.SelectValueFailed()

Actions.SwitchTests
.FrameSwitchTest() <-- FLAKEY

Actions.TakeScreenshotTests
.ScreenshotOnFailedAssert()

Actions.WaitTests
.WaitUntil() <-- FLAKEY

```

#### random ideas and notes

- setup CICD on appVeyor so that I can have all code at very least build server tested with 100% passing tests before submitting pull requests.
- test running the solution not as admininistrator
- run tests a few times and see if the tests are consistent
- run invididual tests and see if they're stable
- run tests with and without stickysessions
- investigate individual causes of test failures, see very briefly if I can debug each easily?
- see if these are timing issues?
- add cake build script to do build, run tests and create package.

#### rough release notes : this fix

- fix false negative test, `ScreenShotOnFailedAction()`
- I've removed chromedriver.exe from the project and have written a powershell script `update-chrome-driver.ps1`
- i've added the readme and powershell script the solution items, that's the only reason the sln file has been modified.
- webdriver changes to the API 
  * `Timeouts().ImplicitlyWait` -> `Timeouts().ImplicitWait`
  * update `Webdriver` from ver `2.41` to `3.11`
  * `browserCapabilities.IsJavaScriptEnabled` no longer supported, changed to `browserCapabilities.SetCapability("javascriptEnabled", true);`
 
#### test notes - first observations

- `ScreenshotOnFailedAction()` looks like a false negative, the test needs to inject a dateTime provider, or test a file matching a regex is created, instead of looking for an exact dateTime filename in temp.