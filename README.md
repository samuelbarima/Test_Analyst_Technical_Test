# Stage 2 — UI Automation Exercise

A small C# SpecFlow + Selenium suite targeting the public practice site
**https://www.saucedemo.com** (login: `standard_user` / `secret_sauce`).

## Prerequisites
- .NET SDK 8.0
- Google Chrome (recent version)
- An IDE (Visual Studio recommended)
- Internet access (the suite drives the live SauceDemo site; Selenium Manager
  downloads the matching driver automatically)

## Running the tests
```
dotnet restore
dotnet test
```
Set `"Headless": true` in `appsettings.json` if you prefer no visible browser.

## Project layout
```
Features/          Gherkin scenarios
StepDefinitions/   Step bindings
Pages/             Page objects (BasePage has wait helpers)
Hooks/             WebDriver lifecycle
Support/           Config loader
```

## Your tasks
The facilitator will walk you through these live. In short:
1. Run the suite and get it trustworthy and green.
2. Implement the pending **Complete a purchase** scenario.
3. (Stretch) Add a negative login test.

Talk through your thinking as you go — we care more about how you reason than
about finishing every item.
