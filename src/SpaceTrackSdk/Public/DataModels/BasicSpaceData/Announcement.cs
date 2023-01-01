using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record Announcement
{
	[JsonPropertyName("announcement_type")]
	public required string Type { get; init; }

	[JsonPropertyName("announcement_text")]
	public required string Text { get; init; }

	[JsonPropertyName("announcement_start")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NotNullableConverter))]
	public required DateTime Start { get; init; }

	[JsonPropertyName("announcement_end")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NotNullableConverter))]
	public required DateTime End { get; init; }
}