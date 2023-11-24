# 🚀 UnitTest

Welcome to Unit Test! This repository showcases a snazzy example of Unit Testing classes and individual functions in an ASP.NET application. I have spiced things up with some unit tests using xUnit, FakeItEasy, and Fluent Assertions.
All these functions have very predictable results as to not over complicate the tests. 

## 🏗️ Project Structure

Here's the lowdown on our project components:

- **NetworkService:** This is just a basically defined class it maybe incomplete but it basically shows how a normal class would be perfect for testing.

- **NetworkServiceTests:** Our test suite where we put the `NetworkService` through its paces. We're using xUnit for the groove, FakeItEasy for the mock party, and Fluent Assertions for the assertive vibes. 💪

- **TestedFunction:** Is basically a simple function that does a simple thing with a very predictable result. I created this to manually create and walkthrough a unit test of this class.

- **TestedFunctionTests:** Where I handle the testing process without the use of fluent assertion commands. 

## 🛠️ Dependencies

- **[xUnit](https://xunit.net/):** A testing framework that keeps things simple and snappy. 🚦

- **[FakeItEasy](https://fakeiteasy.github.io/):** Our backstage pass to mocking – perfect for faking it 'til you make it! 🎭

- **[Fluent Assertions](https://fluentassertions.com/introduction):** Making assertions a breeze with a touch of flair. Fluent and fabulous! 💬

## 🎭 Test Descriptions

- **NetworkService_SendPing_ReturnString:**
  - Pings away and checks results with the help of FakeItEasy and Fluent Assertions. 🚀

- **NetworkService_PingTimeOut_ReturnInt:**
  - Parameterized party to test the `PingTimeOut` method. Flexes xUnit's theory muscles and Fluent Assertions' flair. 🎉

- **NetworkService_LastPingDate_ReturnDate:**
  - Takes a date stroll with the `LastPingDate` method. Checks the vibes using Fluent Assertions. 📅

- **NetworkService_GetPingOptions_ReturnObject:**
  - Tests the `GetPingOptions` method. Fluent Assertions keeps things sharp on object types and properties. 🧐

- **NetworkService_MostRecentPings_ReturnObject:**
  - Tests the `MostRecentPings` method. Checks the type and specific properties with Fluent Assertions. 🕵️

Happy coding! 🚀
