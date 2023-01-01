using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record SatCatChange
{
	[JsonPropertyName("CURRENT_NAME")]
	public required string CurrentName { get; init; }

	[JsonPropertyName("PREVIOUS_NAME")]
	public required string PreviousName { get; init; }

	[JsonPropertyName("CURRENT_INTLDES")]
	public required string CurrentInternationalDesignation { get; init; }

	[JsonPropertyName("PREVIOUS_INTLDES")]
	public required string PreviousInternationalDesignation { get; init; }

	[JsonPropertyName("CURRENT_COUNTRY")]
	public required string CurrentCountry { get; init; }

	[JsonPropertyName("PREVIOUS_COUNTRY")]
	public required string PreviousCountry { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? NoradCatId { get; init; }

	[JsonPropertyName("OBJECT_NUMBER")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? ObjectNumber { get; init; }

	[JsonPropertyName("CURRENT_LAUNCH")]
	public DateOnly? CurrentLaunch { get; init; }

	[JsonPropertyName("PREVIOUS_LAUNCH")]
	public DateOnly? PreviousLaunch { get; init; }

	[JsonPropertyName("CURRENT_DECAY")]
	public DateOnly? CurrentDecay { get; init; }

	[JsonPropertyName("PREVIOUS_DECAY")]
	public DateOnly? PreviousDecay { get; init; }

	[JsonPropertyName("CHANGE_MADE")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NullableConverter))]
	public DateTime? ChangeMade { get; init; }
}