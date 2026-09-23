# bmi2026lab
BMI lab

### How to start

The app can be started from CLI using `dotnet run --project bmi2021`

or it can be started through vscode by

1. Pressing F5 (for debug mode) or ctrl+F5 (for non debug)
2. Choose the project and C# launcher (this is only for first run)


### How to deploy

Create Publish resources by running `dotnet publish -c Release`

Use the Azure plugin to publish the app  - https://learn.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vscode?view=aspnetcore-10.0



##### Issues encountered

Issue 1 -  Subscription doesn't have access to region

To fix this pick from one of these Allowed regions - ["germanywestcentral","switzerlandnorth","austriaeast","italynorth","spaincentral"]

Issue 2 - The subscription is not registered to use namespace 'Microsoft.OperationalInsights'

To fix this:
1. Go to the Azure Portal.
2. Search for and open Subscriptions.
3. Select your active subscription.
4. In the left-hand menu, click on Resource providers.
5. Type Microsoft.OperationalInsights into the search filter.
6. Select it and click the Register button at the top.

----

### Install githooks

1. Run `chmod +x .githooks/commit-msg`
2. Run `git config core.hooksPath .githooks`
