<a id="readme-top"></a>
<!-- PROJECT LOGO -->
<br />
<div align="center">
<a>
  <img src="wwwroot/Assets/svg/logo.svg" width="80" height="80" >
</a>
</div>
<h3 align="center">RandomStrangerStack</h3>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#tests">Tests</a></li>
      </ul>
    </li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->

## About The Project

![site_screenshot.png](wwwroot/Assets/site_screenshot.png)

There are many great README templates available on GitHub; however, I didn't
find one that really suited my needs so I created this enhanced one. I want to
create a README template so amazing that it'll be the last one you ever need --
I think this is it.

Of course, no one template will serve all projects since your needs may be
different. So I'll be adding more in the near future. You may also suggest
changes by forking this repo and creating a pull request or opening an issue.
Thanks to all the people have contributed to expanding this template!

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With

This is most of the tech I built the project with.

* [![C#][C#]][C#-url]
* [![Blazor][Blazor]][Blazor-url]
* [![.net][.net]][.net-url]
* [![HTML][HTML]][HTML-url]
* [![CSS][CSS]][CSS-url]

### Nuget packages:

- Markdig _for parsing markdown to
  html_ [markdig github](https://github.com/xoofx/markdig)
- Moq _for mocking the HttpClient to test
  UserService_  [Moq github](https://github.com/devlooped/moq?tab=readme-ov-file#what)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->

## Getting Started

This is how to get up and running with the project.

### Prerequisites

In order to build project, you need to install .NET 10.0

* Install nuget packages
  ```sh
  dotnet restore
  ```
* Compile project into runnable files
  ```sh
  dotnet build
  ```

### Running the project

```bash
dotnet watch
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->

## Usage

Use this space to show useful examples of how a project can be used. Additional
screenshots, code examples and demos work well in this space. You may also link
to more resources.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<! -- TESTING -->

## Testing

### Overview

I have used xUnit for the testing framework and Moq for mocking HTTP
dependencies.

### Structure

exam_blazor_wasm.Tests/

```
|-Unit/
  |- UserServiceTests.cs
  |- FilterTests.cs
  |- ResultTest.cs

|- Integration
  |- ApiIntegrationTests.cs
```

## Running Tests

```bash
cd exam_blazor_wasm.tests
dotnet test
```

### Test Coverage

**UserService Tests**

* `GetUsersAsync_ReturnsUsers_WhenApiSucceeds`  - Here we test that the api
  response maps correctly User model.
* `GetUsersAsync_ReturnsFailure_WhenApiReturnsError` - Here we test the error
  handling when the api fails.
* `GetUsersAsync_ReturnsFailure_WhenNoDataReceived` - Here we make sure the
  handling of an empty response returns an error.

**Filter Tests**

- `Filter_ByName_ReturnsMatchingUsers` - Here we check that the filter works
  with name.
- `Filter_ByGender_ReturnsMatchingUsers` - We check that we can filter by
  gender.
- `Filter_ByCountry_ReturnsMatchingUsers` - We check that filter by country also
  works.
- `Filter_EmptySearch_ReturnsAllUsers` - We check empty search returns all
  users.

**Result Pattern Tests**
Instead of throwing exceptions when something goes wrong or when the api returns
the correct data, We use a result object and update the IsSuccess = false/true,

- `Success_ReturnsIsSuccessTrue` - we check that the api works, and we get a
  result with `IsSuccess = true` and the actual data
- `Failure_ReturnsIsSuccessFalse` - Verifies failure result and update
  `IsSuccess = false` and an error message.


**Integration Tests** 
- `GetUsersAsync_ReturnsRealUsers_FromApi` - We test the code against the actual api, and verify that we get data back.

<!-- ACKNOWLEDGMENTS -->

## Acknowledgments

These are the pages I have gotten inspiration and fonts, icons, illustrations
etc.

* [Syntax.fm (Typography page)](https://syntax.fm/system/typography)
* [Tailwind(CSS classes inspiration)](https://tailwindcss.com/docs/installation/using-vite)
* [Undraw(Landing page illustration)](https:https://undraw.co/illustrations/3)
* [Realfavicongenerator(Favicon icons)](https://realfavicongenerator.net/your-favicon-is-ready)
* [Google fonts(Icons and fonts)](https://fonts.google.com/icons)
* [Img Shields](https://shields.io)
* [Best-README-Template](https://github.com/othneildrew/Best-README-Template)

## Ai use

Can be found in the AIUSE.md file.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[HTML]: https://img.shields.io/badge/HTML5-E34F26?logo=html5&logoColor=fff&style=for-the-badge

[HTML-url]: https://developer.mozilla.org/en-US/docs/Web/HTML

[CSS]: https://img.shields.io/badge/CSS-639?logo=css&logoColor=fff&style=for-the-badge

[CSS-url]: https://developer.mozilla.org/en-US/docs/Web/CSS

[C#]:https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white

[C#-url]: https://learn.microsoft.com/en-us/dotnet/csharp/

[.net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge

[.net-url]: https://learn.microsoft.com/en-us/dotnet

[Blazor]:https://img.shields.io/badge/Blazor-512BD4?logo=blazor&logoColor=fff&style=for-the-badge

[Blazor-url]: https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor




