@echo off
dotnet ef database update --project .\src\IssueTracker.Infrastructure\IssueTracker.Infrastructure.csproj --startup-project .\src\IssueTracker.Api\IssueTracker.Api.csproj