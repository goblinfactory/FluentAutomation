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

- 72 passing tests, and 12 failing. I have not yet started digging in to why they're failing, whether it's timing with new chrome updates, or the new chrome javascript debugging. For now I wanted to get this up as soon as possible since I have a significant project that relies heavily on FA.

  - update, 3:43pm 6 April : seems the tests are mostly repeatable.

- I'll be looking in the failing tests tomorrow, below is the results so far, all the really critical items appear to be working;

**what appears to still be broken with my (this) latest update to support Chrome 65**

With two test runs I got the same results exception for the two tests `PressType()` and `WaitUntil()` which passed once, then failed the second time.
I've not tested a third time yet. All tests in red below are failed tests. I have not listed the passing tests. 72 test passed.

For a full list of the test results see here : <a href="failing-tests.png">full test results (resharper test run with chrome65)</a>

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
.ScreenshotOnFailedAction()
.ScreenshotOnFailedAssert()

Actions.WaitTests
.WaitUntil() <-- FLAKEY

```




#### Alan's TODO list : what to do before creating new package

- I have not reviwed release notes, if I can't actually fix this, then ...no point!
- setup CICD on appVeyor so that I can have all code at very least build server tested with 100% passing tests before submitting pull requests.
- test running the solution not as admininistrator
- run tests a few times and see if the tests are consistent
- run invididual tests and see if they're stable
- run tests with and without stickysessions
- investigate individual causes of test failures, see very briefly if I can debug each easily?
- see if these are timing issues?
- If certain features are consistently **not** working then consider (if necessary) creating a new release that supports chrome65 but has fewer features, but which features are reliably available.  Impact is that folk would be concerned that this could be a pattern going forward and stop using FluentAutomation for their projects.
- approach some of the other contributors and ask for volunteers to help fix the new bugs 
- find out from @stirno if he thinks there are other better projects taking over this space?
- if the project is or has reached end of life, then consider if there is a simpler subset that I could release for my own testing based on the following philosophy
   - don't try to be able to reproduce a human user
   - force a subset the designer of a SPA or web app can design against, to keep his app testable.
   - don't bring out an API to be able to test anything
   - Keep the API as simple as possible so that it can have any driver hooked up, and will weather future browser changes.
- Consider accessibility testing, and if there a legal reason for actually using the full accesibility set of features.
- add cake build script to do build, run tests and create package.

#### draft release notes (super rough)

- I've removed chromedriver.exe from the project and have written a powershell script `update-chrome-driver.ps1`
- i've added the readme and powershell script the solution items, that's the only reason the sln file has been modified.
- webdriver changes to the API 
  * `Timeouts().ImplicitlyWait` -> `Timeouts().ImplicitWait`
  * update `Webdriver` from ver `2.41` to `3.11`
  * `browserCapabilities.IsJavaScriptEnabled` no longer supported, changed to `browserCapabilities.SetCapability("javascriptEnabled", true);`
 
#### test notes - first observations

- `ScreenshotOnFailedAction()` looks like a false negative, the test needs to inject a dateTime provider, or test a file matching a regex is created, instead of looking for an exact dateTime filename in temp.