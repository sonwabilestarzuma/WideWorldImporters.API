# WideWorldImporters.API
Creating Web API in ASP.NET Core 2.0
Added these nuget packages for WideWorldImporters.API.IntegrationTests project.
1.Microsoft.AspNetCore.Mvc
2. Microsoft.AspNetCore.Mvc.Core
3. Microsoft.AspNetCore.Diagnostics
4. Microsoft.AspNetCore.TestHost
5. Microsoft.Extensions.Configuration.Json

What is the difference between unit tests and integration tests? For unit tests,
we simulate all dependencies for Web API project and for integration tests,
we run a process that simulates Web API execution, this means Http requests.

For this project, integration tests will perform Http requests, each Http request will perform operations to an existing database in SQL Server instance. We'll work with a local instance of SQL Server, this can change according to your working environment, I mean the scope for integration tests.
