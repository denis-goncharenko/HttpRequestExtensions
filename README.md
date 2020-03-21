# HttpRequestExtensions

The HttpRequestExtensions is a [Nuget Package](https://www.nuget.org/packages/UrlCombine) for getting absolute or relative url.
This library return absolute and relative url from HttpRequest.

## Usages

### Add using
``` csharp
  using HttpRequestExtensions;
```

### Examples

#### Get Absolute Uri

``` csharp
    HttpContext.Request.GetAbsoluteUri();
```
or
``` csharp
    HttpContextExtensions.GetAbsoluteUri(HttpContext.Request);
```

#### Get Absolute Uri with Query String

``` csharp
    HttpContext.Request.GetAbsoluteUriWithQueryString();
```
or
``` csharp
    HttpContextExtensions.GetAbsoluteUriWithQueryString(HttpContext.Request);
```

#### Get Relative Path with Query String

``` csharp
    HttpContext.Request.GetRelativePathWithQueryString();
```
or
``` csharp
    HttpContextExtensions.GetRelativePathWithQueryString(HttpContext.Request);
```