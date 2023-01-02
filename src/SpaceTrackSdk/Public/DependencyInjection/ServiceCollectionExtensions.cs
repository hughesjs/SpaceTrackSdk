using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SpaceTrackSdk.Internal.Auth;
using SpaceTrackSdk.Internal.Clients;
using SpaceTrackSdk.Internal.Clients.HttpMessageHandlers;
using SpaceTrackSdk.Public.Clients;
using SpaceTrackSdk.Public.Exceptions;
using SpaceTrackSdk.Public.Options;

namespace SpaceTrackSdk.Public.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddSpaceTrackServices(this IServiceCollection services, IConfiguration config)
	{
		IConfigurationSection optionsSect = config.GetSection(nameof(SpaceTrackSdkOptions));
		
		SpaceTrackSdkOptions options = optionsSect.Get<SpaceTrackSdkOptions>() ?? throw new SpaceTrackSdkException("You must add SpaceTrackSdkOptions to your Configuration Root");

		services.Configure<SpaceTrackSdkOptions>(optionsSect);

		services.AddSingleton<AuthCookieJar>();

		services.AddTransient<HttpClientHandler>();
		
		services.AddTransient<AuthCookieHandler>(sp =>
		{
			AuthCookieJar cookieJar = sp.GetRequiredService<AuthCookieJar>();
			IOptions<SpaceTrackSdkOptions> opt = sp.GetRequiredService<IOptions<SpaceTrackSdkOptions>>();
			AuthCookieHandler handler = new(cookieJar, opt);
			return handler;
		});

		services.AddHttpClient<IBasicSpaceDataClient, BasicSpaceDataClient>(c =>
		{
			c.BaseAddress = new(options.ApiUrl);
		}).AddHttpMessageHandler<AuthCookieHandler>().ConfigurePrimaryHttpMessageHandler<HttpClientHandler>();

		return services;
	}
}