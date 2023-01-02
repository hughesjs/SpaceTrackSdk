using System.Net;

namespace SpaceTrackSdk.Internal.Auth;

internal class AuthCookieJar
{
	public Cookie? Cookie { get; private set; }

	public void UpdateCookie(string setCookieHeader)
	{
		Dictionary<string, string?> cookieComponents = ParseComponents(setCookieHeader);

		Cookie = MakeCookie(cookieComponents);
	}

	private Cookie MakeCookie(Dictionary<string, string?> cookieComponents)
	{
		Cookie cookie = new();
		cookie.Name = "chocolatechip";
		foreach (KeyValuePair<string, string?> component in cookieComponents)
		{
			switch (component.Key)
			{
				case "chocolatechip":
				{
					cookie.Value = component.Value;
					break;
				}
				case "expires":
				{
					if (component.Value is null)
					{
						break;
					}
					cookie.Expires = DateTime.Parse(component.Value);
					break;
				}
				case "path":
				{
					cookie.Path = component.Value ?? string.Empty;
					break;
				}
				case "HttpOnly":
				{
					cookie.HttpOnly = true;
					break;
				}
				case "Secure":
				{
					cookie.Secure = true;
					break;
				}
			}
		} // }

		return cookie;
	}

	private Dictionary<string,string?> ParseComponents(string header)
	{
		Dictionary<string, string?> cookieComponents = new();
		string[] parts = header.Split(';');
		
		foreach (string part in parts)
		{
			string[] kvp = part.Split('=');
			if (kvp.Length == 2)
			{
				cookieComponents[kvp[0].Trim()] = kvp[1].Trim();
				continue;
			}

			cookieComponents[kvp[0].Trim()] = null;
		}

		return cookieComponents;
	}
}