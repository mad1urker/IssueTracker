@echo off
dotnet ef migrations remove --project .\src\IssueTracker.Infrastructure\IssueTracker.Infrastructure.csproj --startup-project .\src\IssueTracker.Api\IssueTracker.Api.csproj