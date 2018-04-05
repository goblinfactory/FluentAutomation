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