using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record BoxScore
{
	[JsonPropertyName("COUNTRY")]
	public required string Country { get; init; }

	[JsonPropertyName("SPADOC_CD")]
	public required string SpadocCode { get; init; }

	[JsonPropertyName("ORBITAL_TBA")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? OrbitalToBeAnalysed { get; init; }

	[JsonPropertyName("ORBITAL_PAYLOAD_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? OrbitalPayloadCount { get; init; }

	[JsonPropertyName("ORBITAL_ROCKET_BODY_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? OrbitalRocketBodyCount { get; init; }

	[JsonPropertyName("ORBITAL_DEBRIS_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? OrbitalDebrisCount { get; init; }

	[JsonPropertyName("ORBITAL_TOTAL_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? OrbitalTotalCount { get; init; }

	[JsonPropertyName("DECAYED_PAYLOAD_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? DecayedPayloadCount { get; init; }

	[JsonPropertyName("DECAYED_ROCKET_BODY_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? DecayedRocketBodyCount { get; init; }

	[JsonPropertyName("DECAYED_DEBRIS_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? DecayedDebrisCount { get; init; }

	[JsonPropertyName("DECAYED_TOTAL_COUNT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? DecayedTotalCount { get; init; }

	[JsonPropertyName("COUNTRY_TOTAL")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required long CountryTotal { get; init; }

}