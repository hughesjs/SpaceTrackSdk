[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/SpaceTrackSdk/dotnet-ci.yml?label=BUILD%20CI&style=for-the-badge&branch=master)](https://github.com/hughesjs/SpaceTrackSdk/actions)
[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/SpaceTrackSdk/dotnet-cd.yml?label=BUILD%20CD&style=for-the-badge&branch=master)](https://github.com/hughesjs/SpaceTrackSdk/actions)
[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/SpaceTrackSdk?style=for-the-badge)](https://nuget.org/packages/PGFPlots.NET/)
![GitHub top language](https://img.shields.io/github/languages/top/hughesjs/SpaceTrackSdk?style=for-the-badge)
[![GitHub](https://img.shields.io/github/license/hughesjs/SpaceTrackSdk?style=for-the-badge)](LICENSE)
![FTB](https://raw.githubusercontent.com/hughesjs/custom-badges/master/made-in/made-in-scotland.svg)

⚠ Please note, this SDK is still in very active development, features may be added and removed, although I will try and keep on top of using proper semantic versioning. ⚠

---

# SpaceTrackSdk

## Introduction

This is a C# library to enable developers to interact with the [United States Strategic Command Space Tracker](https://space-track.org) (space-track.org).

This documentation will be updated with more detail as functionality is added to the project.

## How To Use

### Installation

As with most C# packages, install it through Nuget via your IDE or the CLI.
```cs
dotnet add <csproj> package SpaceTrackSdk
```
It is also available as a package from the Github Image Repo.

### Configuring DI

Currently, the SDK is designed in such a way that it plugs in via `Microsoft.DependencyInjection`. If there is a big desire for this to change in the future, I might reconsider this.

For now, once you've got your `IServiceCollection`, you need to call the extension method `services.AddSpaceTrackServices(configuration)`.

From here, you'll be able to resolve or inject the `IBasicSpaceDataClient` which gives you access to everything on the `BasicSpaceData` API.

```cs
ServiceCollection services = new();
services.AddSpaceTrackServices(config);
IServiceProvider provider = services.BuildServiceProvider();

IBasicSpaceDataClient service = provider.GetRequiredService<IBasicSpaceDataClient>();
```

### Fetching Data

Fetching data is done through the `IBasicSpaceDataClient` interface. 

```cs
public interface IBasicSpaceDataClient
{
	public IClientAdapter<Announcement> Announcements { get; }
	public IClientAdapter<BoxScore> BoxScores { get; }
	public IClientAdapter<Conjunction> Conjunctions { get; }
	public IClientAdapter<Decay> Decays { get; }
	public IClientAdapter<GeneralPerturbation> GeneralPerturbations { get; }
	public IClientAdapter<GeneralPerturbation> GeneralPerturbationHistory { get; }
	public IClientAdapter<LaunchSite> LaunchSites { get; } 
	public IClientAdapter<SatCatChange> SatCatChanges { get; }
	public IClientAdapter<SatCatEntry> SatCatEntries { get; }
	public IClientAdapter<SatCatEntry> SatCatDebuts { get; }
	public IClientAdapter<TrackingAndImpactPrediction> TrackingAndImpactPredictions { get; }
}
```

Every endpoint provides an instance of an `IClientAdapter<T>`, this is a very simple interfact that allows for you to `Get()` or `GetMany()`.

```cs
public interface IClientAdapter<T>
{
	public Task<T?> Get(string predicates = "");
	public Task<List<T>?> GetMany(string predicates = "");
}
```

You can optionally provide a list of pre-formatted predicates such as `/limit/5`.

There are plans to add predicate classes and a query builder to the solution in due time.