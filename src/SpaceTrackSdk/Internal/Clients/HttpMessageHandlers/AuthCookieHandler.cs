using System.Net;
using Microsoft.Extensions.Options;
using SpaceTrackSdk.Internal.Auth;
using SpaceTrackSdk.Public.Options;

namespace SpaceTrackSdk.Internal.Clients.HttpMessageHandlers;

internal class AuthCookieHandler : DelegatingHandler
{
	private readonly AuthCookieJar _cookieJar;
	private readonly IOptions<SpaceTrackSdkOptions> _options;

	public AuthCookieHandler(HttpMessageHandler innerHandler, AuthCookieJar cookieJar, IOptions<SpaceTrackSdkOptions> options)
	{
		InnerHandler = innerHandler;
		_cookieJar = cookieJar;
		_options = options;
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (_cookieJar.Cookie is null || _cookieJar.Cookie.Expired)
		{
			await UpdateCookie(cancellationToken);
		}

		List<string> cookieValues = new();
		if (request.Headers.TryGetValues("Cookie", out IEnumerable<string>? cookies))
		{
			cookieValues.AddRange(cookies);
		}

		Cookie authCookie = _cookieJar.Cookie!;
		cookieValues.Add($"{authCookie.Name}={authCookie.Value}");
		
		request.Headers.Add("Cookie", cookieValues);

		HttpResponseMessage res = await base.SendAsync(request, cancellationToken);

		return res;
	}

	private async Task UpdateCookie(CancellationToken cancellationToken)
	{
		Dictionary<string, string> content = new()
		{
			{ "identity", _options.Value.Username },
			{ "password", _options.Value.Password }
		};

		HttpRequestMessage authMessage = new()
		{
			Content = new FormUrlEncodedContent(content),
			Method = HttpMethod.Post,
			RequestUri = new($"{_options.Value.ApiUrl}{_options.Value.AuthEndpoint}")
		};

		HttpResponseMessage response = await base.SendAsync(authMessage, cancellationToken);

		if (response.Headers.TryGetValues("Set-Cookie", out var values))
		{
			_cookieJar.UpdateCookie(values.Single());
		}
	}
}