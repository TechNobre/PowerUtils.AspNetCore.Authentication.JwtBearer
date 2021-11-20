# PowerUtils.AspNetCore.Authentication.JwtBearer
Utils, helpers, extensions and attributes to work with JWT authentication

![CI](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer/actions/workflows/main.yml/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/PowerUtils.AspNetCore.Authentication.JwtBearer.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.JwtBearer)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.AspNetCore.Authentication.JwtBearer.svg)](https://www.nuget.org/packages/PowerUtils.AspNetCore.Authentication.JwtBearer)




## Support to
- .NET 3.1, .NET 5.0 and .NET 6.0




## Features

- [Installation](#Installation)
- [Attributes](#Attributes)
  - [JWTAuthentication](#JWTAuthentication)


## Documentation

### Dependencies

- Microsoft.AspNetCore.Authentication.JwtBearer [NuGet](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/)

### How to use

#### Install NuGet package <a name="Installation"></a>
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



## Contribution

*Help me to help others*




## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.AspNetCore.Authentication.JwtBearer/blob/main/LICENSE)




## Release Notes


### v1.0.0 - 2021/11/20
- Kick start project