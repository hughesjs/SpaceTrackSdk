using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record LaunchSite
{
	[JsonPropertyName("SITE_CODE")]
	public required string Code { get; init; }
	
	[JsonPropertyName("LAUNCH_SITE")]
	public required string Name { get; init; }
}