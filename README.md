# portfolio
[![Build Status](https://dev.azure.com/katysorourke/katy-devops-project/_apis/build/status/katyfoxdev%20-%20CI?branchName=master)](https://dev.azure.com/katysorourke/katy-devops-project/_build/latest?definitionId=11&branchName=master)
https://katyfoxdev.azurewebsites.net/

## About this Project
This site itself is a sample of my work, and it's also a site that I can use as a blog and a personal portfolio. The portfolio piece will be built last. 

## Technology 
This is a ASP.NET Core MVC Web Application. It uses .NET Core 2.1.1. 
It uses Entity Framework Core to interface with a SQL Server database.
It uses Swashbuckle to document the API, the UI can be accessed at /swagger. 
It is deployed to an Azure Web App that uses a SQL Azure database. 
The builds and releases are automated using Azure DevOps pipeline that is 
triggered from a commit to master in the GitHub repo. NUnit test suite is run as a
part of the build process, and the build fails and is not released to production
if any tests fail. 

## Release Notes
Although this site is released with every commit to GitHub, the notable
pieces of functionality that are completed are listed below.

11/13/2019
- Blog page to view blog posts
- BlogPost API for managing blog posts
- About me page

11/14/2019
- Styling enhancements
- Site background photo 

11/15/2019
- Unit tests 

11/19/2019
- Integrated Okta authentication, which protects my swagger endpoints. The rest of the app is accessible, and the login link will soon only be present on the Blog Post Management page that I need to create
- Moved sensitive data to the appsettings.Development.json and removed that file from source control 
