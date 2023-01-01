using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record Announcement
{
	[JsonPropertyName("announcement_type")]
	public required string Type { get; init; }

	[JsonPropertyName("announcement_text")]
	public required string Text { get; init; }

	[JsonPropertyName("announcement_start")]
	public required DateTime Start { get; init; }

	[JsonPropertyName("announcement_end")]
	public required DateTime End { get; init; }
}