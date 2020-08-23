# DIContextAutoLoader.Microsoft.Extensions.DependencyInjection

[![NuGet version (DIContextAutoLoader.Microsoft.Extensions.DependencyInjection)](https://img.shields.io/nuget/v/DIContextAutoLoader.Microsoft.Extensions.DependencyInjection.svg?style=flat-square)](https://www.nuget.org/packages/DIContextAutoLoader.Microsoft.Extensions.DependencyInjection/)

Extension of [DIContextAutoLoader](https://github.com/dgenezini/DIContextAutoLoader) to use with .Net Core Dependency Injection.

# Package

```
    Install-Package DIContextAutoLoader.Microsoft.Extensions.DependencyInjection
```

# Usage

```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AutoLoadServices(typeof(SomeTypeInAssembly).Assembly);
 
        ...
    }
}
```
