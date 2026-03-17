@echo off
dotnet ef migrations add %1 --project .\src\IssueTracker.Infrastructure\IssueTracker.Infrastructure.csproj --startup-project .\src\IssueTracker.Api\IssueTracker.Api.csproj