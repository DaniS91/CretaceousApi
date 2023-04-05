# Building an API Practice 
![Made with C#](	https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![Made with .NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
### by Dani Steely

## A practice exercise corresponding to an Epicodus lesson in the C# course section [Building an API](https://www.learnhowtoprogram.com/c-and-net-part-time/building-an-api): [Exploring the dotnet new Web API Template](https://www.learnhowtoprogram.com/c-and-net-part-time/building-an-api/exploring-the-dotnet-new-web-api-template). This project uses [Swashbuckle](https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio-code), an implementation of [Swagger](https://swagger.io/tools/swaggerhub/) documentation

#### In this lesson, we built an API called Cretaceous Park sharing data about a wildlife park. We scaffolded an ASP.NET Core web API, covering the following topics:
* How web APIs receive and respond to requests, and how they differ from MVC web apps.
* The appsettings.{Environment}.json file.
* Configuring logging and allowed hosts in appsettings.json.
* How to build and configure the host for a Web API.
* Using HTTP in development for web APIs.
* Optionally updating our project's ports in launchSettings.json.
* Running the boilerplate app and using Swagger UI to explore endpoints.


#### Steps:
* create a new directory called CretaceousApi.Solution
* within that directory, run the following command::
```
  $ dotnet new webapi -o CretaceousApi --framework net6.0
```
* Make sure to initialize git and add a .gitignore file when you create a new API project, and make sure appsettings.json, obj, and bin are listed in your .gitignore, as per usual.
* disable a nullable context for the entire project. Comment out the line that enables nullable types within CreatceousApi.csproj
* configure Program.cs for adding controllers and for using Swashbuckle
* the Program.cs file contains commants for future reference about the last step
* create .gitignore file containging the following files:
* commit the change to .gitignore file
* create EnvironmentalVariables.cs file which will include the following code:
```csharp
  namespace ConsoleApiCall.Keys
{
  public static class EnvironmentVariables
  {
    public static string ApiKey = "[YOUR-API-KEY-HERE]";
  }
}
```
* replace \[YOUR-API-KEY-HERE] with your api key from NYT
* you will need to update the generated Program.cs file with the code that is provided by the lesson, which creates an ApiHelper class and ApiCall method that handles the Api call and uses RestSharp objects to create requests
* run the program with 
```
$ dotnet run
```