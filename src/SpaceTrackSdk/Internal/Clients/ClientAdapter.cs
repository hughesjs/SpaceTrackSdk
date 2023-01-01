using System.Net.Http.Json;
using SpaceTrackSdk.Public.Clients;

namespace SpaceTrackSdk.Internal.Clients;

internal class HttpClientAdapter<T>: IClientAdapter<T>
{
	private readonly HttpClient _client;
	private readonly string _endpoint;

	public HttpClientAdapter(HttpClient client, string endpoint)
	{
		_client = client;
		_endpoint = endpoint;
	}

	public async Task<T?> Get() => await _client.GetFromJsonAsync<T>($"{_endpoint}/limit/1");
	
	public async Task<List<T>?> GetMany() => await _client.GetFromJsonAsync<List<T>>(_endpoint);
}