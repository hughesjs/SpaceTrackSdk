using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpaceTrackSdk.Internal.Auth;
using SpaceTrackSdk.Public.Clients;
using SpaceTrackSdk.Public.DependencyInjection;

namespace SpaceTrackSdk.Tests.DependencyInjection;

public class ServiceCollectionExtensionsTests
{
	private readonly ServiceProvider _serviceProvider;
	
	public ServiceCollectionExtensionsTests()
	{
		IConfigurationBuilder configBuilder = new ConfigurationBuilder();
		configBuilder.AddEnvironmentVariables();
		IConfigurationRoot config = configBuilder.Build();
		
		ServiceCollection services = new();
		services.AddSpaceTrackServices(config);
		
		_serviceProvider = services.BuildServiceProvider();
	}

	[Fact]
	public void CanResolveClient()
	{
		IBasicSpaceDataClient? service = _serviceProvider.GetService<IBasicSpaceDataClient>();

		service.ShouldNotBeNull();
		service.Announcements.ShouldNotBeNull();
		service.BoxScores.ShouldNotBeNull();
		service.Conjunctions.ShouldNotBeNull();
		service.LaunchSites.ShouldNotBeNull();
		service.Decays.ShouldNotBeNull();
		service.GeneralPerturbations.ShouldNotBeNull();
		service.GeneralPerturbationHistory.ShouldNotBeNull();
		service.SatCatChanges.ShouldNotBeNull();
		service.SatCatDebuts.ShouldNotBeNull();
		service.SatCatEntries.ShouldNotBeNull();
		service.TrackingAndImpactPredictions.ShouldNotBeNull();
	}

	[Fact]
	public void ResolvedClientActuallyWorks()
	{
		IBasicSpaceDataClient service = _serviceProvider.GetRequiredService<IBasicSpaceDataClient>();

		service.Announcements.Get().ShouldNotBeNull();
	}

	[Fact]
	public void CookieJarIsASingleton()
	{
		AuthCookieJar jarOne = _serviceProvider.GetRequiredService<AuthCookieJar>();
		AuthCookieJar jarTwo = _serviceProvider.GetRequiredService<AuthCookieJar>();
		
		jarOne.ShouldBe(jarTwo);
	}
}