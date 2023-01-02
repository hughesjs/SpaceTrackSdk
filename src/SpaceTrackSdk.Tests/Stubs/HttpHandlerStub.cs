using System.Text.Json;
using System.Text.RegularExpressions;
using AutoFixture;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Stubs;

public class HttpHandlerStub: DelegatingHandler
{
	private readonly Regex _classNameRegex = new(@"class\/(?<className>\w+)");
	private readonly Regex _limitRegex = new(@"limit\/(?<limit>\w+)");
	private readonly Fixture _fixture;

	public HttpHandlerStub()
	{
		_fixture = new();
		_fixture.Customize<DateOnly>(composer => composer.FromFactory<DateTime>(DateOnly.FromDateTime));
	}
	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		string path = request.RequestUri?.AbsolutePath ?? throw new("No Request URI");
		int limit = 5;

		string stubRoute = path;
		
		if (!path.Contains("ajaxauth"))
		{
			Match classMatch = _classNameRegex.Match(path);
			stubRoute = classMatch.Groups["className"].Value;
			
			Match limitMatch = _limitRegex.Match(path);
			limit = int.Parse(limitMatch.Groups["limit"].Value);
		}
		
		return stubRoute switch
		{
			"/ajaxauth/login" => CookieResponse(),
			"announcement" => ObjectResponse<Announcement>(limit),
			"boxscore" => ObjectResponse<BoxScore>(limit),
			"cdm_public" => ObjectResponse<Conjunction>(limit),
			"decay" => ObjectResponse<Decay>(limit),
			"gp_history" => ObjectResponse<GeneralPerturbation>(limit),
			"gp" => ObjectResponse<GeneralPerturbation>(limit),
			"launch_site" => ObjectResponse<LaunchSite>(limit),
			"satcat" => ObjectResponse<SatCatEntry>(limit),
			"satcat_debut" => ObjectResponse<SatCatEntry>(limit),
			"satcat_change" => ObjectResponse<SatCatChange>(limit),
			"tip" => ObjectResponse<TrackingAndImpactPrediction>(limit),
			_ => throw new("Unstubbed Endpoint")
		}
		
		;
		return null;
	}

	private Task<HttpResponseMessage> ObjectResponse<T>(int limit)
	{
		HttpResponseMessage message = new();
		T[] payload = _fixture.CreateMany<T>(limit).ToArray();
		string json = JsonSerializer.Serialize(payload);
		message.Content = new StringContent(json);
		return Task.FromResult(message);
	}

	private Task<HttpResponseMessage> CookieResponse()
	{
		HttpResponseMessage message = new();
		message.Headers.Add("Set-Cookie","chocolatechip=huzzah!");
		return Task.FromResult(message);
	}
}