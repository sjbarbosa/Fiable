# Discountinued setup due to unavailability of tool in approach
[UI Automation Coding Challenge Specification](https://fiable.atlassian.net/wiki/external/Y2YzMWM1ZDYyZWQ1NGY1NGFkZmFkZmE4ZTllYWVmODE)
<Details close>
<br>
1. Download Visual Studio Code in https://code.visualstudio.com/ 
   <br><br>
2. Create folder preferabbly in C:\Playwright
   <br><br>
3. Open Command Prompt and execute the command to create a new prohject with dotnet new
   <br>
   dotnet new nunit -n Fiable
   <br>
   cd Fiable
   <br><br>
4. Install Playwright dependencies
   <br>
   dotnet add package Microsoft.Playwright.NUnit
   <br><br>
5. Build the project
   <br>
   dotnet build
   <br><br>
6. Install and open Powershell in https://github.com/sjbarbosa/fiable/edit/main/README.md
   <br><br>
7. Change directory to the project then execute the command to install browsers:
   <br>
   cd .\Playwright\Fiable\
   <br>
   pwsh bin/Debug/net9.0/playwright.ps1 install
</Details>

# Specflow BDD are discountinued
[Specflow](https://specflow.org/) is considered end-of-life (EOL) and will no longer be actively supported after December 31, 2024, meaning it is not recommended for new projects and users should consider migrating to alternative BDD frameworks due to Tricentis' decision to discontinue support for it. 

# Work around for BDD approach using Specflow
For this approach, we will be using [Reqnroll](https://reqnroll.net/)

Here's the community [github/reqnroll](https://github.com/reqnroll) for further technical information.
# Structure
The feature files are text files with the .feature extension. This feature files are in [Gherkin](https://cucumber.io/docs/gherkin/) format. The purpose of the feature files are to provide a high-level description and to group related test scenarios.

Hooks:

The step definitions provide the connection between your feature files and application interfaces such as methods/functionalities. Its expected that each feature corresponds to one step definition to make the framework more easier to maintain.

Hooks or event bindings are used to perform additional automation logic at specific times, such as any setup required prior to executing a scenario. In order to use hooks, you need to add the Binding attribute to your class. Hooks can be synchronous or asynchronous, allowing them to perform operations that can benefit from async programming patterns:

The pages files are where the locators or xpaths, methods are.

By default, every run takes a screenshot after each scenario.
```bin\Debug\net9.0\screenshots```

Programming Languages: C#

Test Design: Reqnroll (BDD test automation framework for .NET)

# Setup, running and debugging tests
1. Pull the main repository
2. Download Visual Studio
3. Open the Fiable.sln
4. Navigate to Extensions > Manage Extensions
5. Install Reqnroll for Visual Studio 2022 (v2024.8.234)
6. Navigate to Build > Build Solution
7. Navigate to View > Test Explorer
8. Click Run ![image](https://github.com/user-attachments/assets/251d5801-48cb-424d-9428-c237166718ca) from the Test Explorer section

# Assumptions and Limitations
1. Since Specflow resources are getting removed from open sources, Reqnroll will be used inable for us to use C# as programming language while using the integrated Playwright and BDD Cucumber.
2. As of now, we have limited resources to accomplish a full OOP Object Oriented Programming stucture such as the Fixtures, JSON files for data injection and many more.
