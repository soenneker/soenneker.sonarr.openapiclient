[![](https://img.shields.io/nuget/v/soenneker.sonarr.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sonarr.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sonarr.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sonarr.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sonarr.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sonarr.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sonarr.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.sonarr.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Sonarr.OpenApiClient

Generated Sonarr API client for series, episodes, files, calendars, queues, commands, indexers, download clients, quality profiles, notifications, and server configuration.

## Installation

```bash
dotnet add package Soenneker.Sonarr.OpenApiClient
```

For application registration and configuration-based authentication, use `Soenneker.Sonarr.OpenApiClientUtil`. Instantiate this package directly when you need to supply your own Kiota request adapter.

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Sonarr.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("http://localhost:8989/")
};
httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = httpClient.BaseAddress.ToString().TrimEnd('/')
};

var sonarr = new SonarrOpenApiClient(adapter);
var status = await sonarr.Api.V3.System.Status.GetAsync(
    cancellationToken: cancellationToken);
```

Most application endpoints are under `client.Api.V3`. Some operations modify or delete Sonarr data; review the request builder and model before calling non-GET methods.
