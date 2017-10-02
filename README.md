[![Build status](https://ci.appveyor.com/api/projects/status/7k2bj360hofsswo7/branch/master?svg=true)](https://ci.appveyor.com/project/bidwall/dotnet-top-5-repos/branch/master)

# Top5Repos 
Developed as a simple solution to a job interview technical test.

This is an ASP.net MVC 5 web application which lists the top five starred GitHub repositories, alongside some basic information for a given user.

It uses the [GitHub API](https://api.github.com) to query information about the user and their repositories.

This solution uses...

- C#
- ASP.net
- MVC 5
- Bower
- SimpleInjector
- NUnit
- Moq
- FluentAssertions
- nBuilder
- gulp

Install
------------

Restore nuget packages

`nuget install`

Restore npm packages

`npm install`

Restore bower packages

`bower install`

Restore static resources (minified css/js & bootstrap fonts)

`gulp`

> **Note:** You can find the .NET Core version of this web application [here](https://github.com/bidwall/Top5ReposCore)
