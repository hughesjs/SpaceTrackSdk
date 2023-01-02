using System.Net;
using SpaceTrackSdk.Internal.Auth;

namespace SpaceTrackSdk.Tests.Auth;

public class AuthCookieJarTests
{
	private readonly AuthCookieJar _cookieJar;

	public AuthCookieJarTests()
	{
		_cookieJar = new();
	}

	[Fact]
	public void CanParseCookieFromHeaderValue()
	{
		const string headerVal = "chocolatechip=h1g419d0u72u8eb7p9p1odlp42flgihr; expires=Mon, 02-Jan-2023 01:28:03 GMT; Max-Age=7200; path=/; HttpOnly;HttpOnly;Secure";
		
		_cookieJar.UpdateCookie(headerVal);

		Cookie result = _cookieJar.Cookie!;
		
		result.Name.ShouldBe("chocolatechip");
		result.Expires.ShouldBeEquivalentTo(DateTime.Parse("02-Jan-2023 01:28:03 GMT"));
		result.Path.ShouldBe("/");
		result.HttpOnly.ShouldBeTrue();
		result.Secure.ShouldBeTrue();
	}
}