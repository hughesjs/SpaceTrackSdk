using JetBrains.Annotations;
using SpaceTrackSdk.Internal.Auth;

namespace SpaceTrackSdk.Tests.Fixtures;

[UsedImplicitly]
public class ClientTestFixture
{
	public ClientTestFixture()
	{
		CookieJar = new AuthCookieJar();
	}

	public object CookieJar { get; } // this is a mess, but I can't use internals with IClassFixture AFAICT
}