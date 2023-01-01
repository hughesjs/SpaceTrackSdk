using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record ModelDefinition
{
	[JsonPropertyName("Field")]
	public required string Field { get; init; }

	[JsonPropertyName("Type")]
	public required string Type { get; init; }

	[JsonPropertyName("Null")]
	[JsonConverter(typeof(YesNoBoolConverter.NotNullableConverter))]
	public required bool IsNullable { get; init; }

	[JsonPropertyName("Key")]
	public string? Key { get; init; }

	[JsonPropertyName("Default")]
	public string? Default { get; init; }

	[JsonPropertyName("Extra")]
	public string? Extra { get; init; }
}