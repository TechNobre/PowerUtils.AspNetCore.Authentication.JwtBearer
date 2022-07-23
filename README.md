# PowerUtils.AspNetCore.Authentication.JwtBearer

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer/main/assets/logo/logo_128x128.png)

***Utils, helpers, extensions and attributes to work with JWT authentication***

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.AspNetCore.Authentication.JwtBearer.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.JwtBearer)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.AspNetCore.Authentication.JwtBearer.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.JwtBearer)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer.svg)](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer/blob/main/LICENSE)


- [Support](#support-to)
- [Dependencies](#dependencies)
- [How to use](#how-to-use)
  - [Installation](#Installation)
  - [Attributes](#Attributes)
    - [JWTAuthentication](#JWTAuthentication)
- [Contribution](#contribution)
- [License](./LICENSE)
- [Changelog](./CHANGELOG.md)



## Support to <a name="support-to"></a>
- .NET 6.0
- .NET 5.0
- .NET 3.1



## Dependencies <a name="dependencies"></a>

- Microsoft.AspNetCore.Authentication.JwtBearer [NuGet](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/)



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="Installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.JwtBearer

**Nuget**
```bash
Install-Package PowerUtils.AspNetCore.Authentication.JwtBearer
```

**.NET CLI**
```
dotnet add package PowerUtils.AspNetCore.Authentication.JwtBearer
```

### Attributes <a name="Attributes"></a>

#### JWTAuthentication; <a name="JWTAuthentication"></a>
Attribute to limit access to a controller or action with a JWT token

```csharp
[JWTAuthentication]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return this.Ok();
    }
}
```

```csharp
[ApiController]
public class TestController : ControllerBase
{
    [JWTAuthentication]
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return this.Ok();
    }
}
```



## Contribution <a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer/compare)