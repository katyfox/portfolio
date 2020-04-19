# portfolio
[![Build Status](https://dev.azure.com/katysorourke/katy-devops-project/_apis/build/status/katyfoxdev%20-%20CI?branchName=master)](https://dev.azure.com/katysorourke/katy-devops-project/_build/latest?definitionId=11&branchName=master)

## Link to production
https://katyfoxdev.azurewebsites.net/

## About this Project
The vision for this site is to be my lifestyle blog. I want to be able to blog about nutrition, recipes, fitness, self-care, engineering, pregnancy, motherhood, etc. I want to be able to make it beautiful, so it represents me and so I can enjoy working on it each weekend. The primary purpose is to be a creative outlet for me, almost like a diary. It's not necessarily intended to bring a lot of viewers to it or to become popular. However, I do still want it to be easy for a viewer to navigate, find content, comment on blog posts, contact me via email without displaying my personal email address. The secondary purpose of the blog is to be able to give other people a window into me as a person in cases where I'm applying for a new job. I'd love for a potential employer or new team to be able to take a look at my blog and get a sense of who I am, which is also where the porfolio aspect comes in. The third purpose of this site is to be able to development portfolio. However, I do not have a lot of projects at this point that I'd like to showcase, so no need to worry about that now. 

## Technology 
This is a ASP.NET Core MVC Web Application that uses .NET Core 2.1.1, 
Entity Framework Core with a SQL Server database,
Swashbuckle to document the API (UI can be accessed at https://.../swagger),
and Okta for user and API authentication. 


It is deployed to an Azure Web App that uses a SQL Azure database. 
The builds and releases are automated using Azure DevOps pipeline that is 
triggered from a commit to master in the GitHub repo. NUnit test suite is run as a
part of the build process, and the build fails and is not released to production
if any tests fail. 

## Release Notes
Although this site is released with every commit to GitHub, the notable
pieces of functionality that are completed are listed below.

11/20/2019
- Hid the Blog section for now until I have the management piece fleshed out
- Added the basics for creating, updating, deleting, and listing the blog posts 
- Added the concept of blog post tag, so each post can be tagged with different categories 

11/19/2019
- Integrated Okta authentication, which protects my swagger endpoints. The rest of the app is accessible, and the login link will soon only be present on the Blog Post Management page that I need to create
- Moved sensitive data to the appsettings.Development.json and removed that file from source control 
- Updated About Me page with real content and new photo 

11/15/2019
- Unit tests 

11/14/2019
- Styling enhancements
- Site background photo 

11/13/2019
- Blog page to view blog posts
- BlogPost API for managing blog posts
- About me page
