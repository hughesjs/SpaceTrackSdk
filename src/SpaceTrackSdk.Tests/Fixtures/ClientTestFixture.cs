using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SpaceTrackSdk.Internal.Clients;
using SpaceTrackSdk.Internal.Clients.HttpMessageHandlers;
using SpaceTrackSdk.Public.Clients;
using SpaceTrackSdk.Public.DependencyInjection;
using SpaceTrackSdk.Public.Options;
using SpaceTrackSdk.Tests.Stubs;

namespace SpaceTrackSdk.Tests.Fixtures;

[UsedImplicitly]
public class ClientTestFixture
{
	public ServiceProvider ServiceProvider { get; }

	public ClientTestFixture()
	{
		bool useRealApi = Environment.GetEnvironmentVariable("TEST_REAL_API") is not null;
		
		Console.WriteLine(useRealApi ? "Using real API" : "Using stubbed API");
		
		IConfigurationBuilder configBuilder = new ConfigurationBuilder();
		configBuilder.AddEnvironmentVariables();
		IConfigurationRoot config = configBuilder.Build();
		
		ServiceCollection services = new();
		services.AddSpaceTrackServices(config);

		if (!useRealApi)
		{
			services.RemoveAll(typeof(IBasicSpaceDataClient));

			services.AddTransient<HttpHandlerStub>();
			services.AddHttpClient<IBasicSpaceDataClient, BasicSpaceDataClient>((sp, c) =>
			{
				SpaceTrackSdkOptions options = sp.GetRequiredService<IOptions<SpaceTrackSdkOptions>>().Value;
				c.BaseAddress = new(options.ApiUrl);
			}).AddHttpMessageHandler<AuthCookieHandler>().ConfigurePrimaryHttpMessageHandler<HttpHandlerStub>();
		}

		ServiceProvider = services.BuildServiceProvider();
	}
}