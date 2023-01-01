using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record TrackingAndImpactPrediction
{
	[JsonPropertyName("MSG_EPOCH")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NotNullableConverter))]
	public required DateTime MessageEpoch { get; init; }

	[JsonPropertyName("INSERT_EPOCH")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NotNullableConverter))]
	public required DateTime InsertEpoch { get; init; }

	[JsonPropertyName("DECAY_EPOCH")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NotNullableConverter))]
	public required DateTime DecayEpoch { get; init; }

	[JsonPropertyName("WINDOW")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required ushort Window { get; init; }

	[JsonPropertyName("REV")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required ushort Revolutions { get; init; }

	[JsonPropertyName("DIRECTION")]
	public required string Direction { get; init; }

	[JsonPropertyName("LAT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required float Latitude { get; init; }

	[JsonPropertyName("LON")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required float Longitude { get; init; }

	[JsonPropertyName("INCL")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required float Inclination { get; init; }

	[JsonPropertyName("NEXT_REPORT")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required ushort NextReport { get; init; }

	[JsonPropertyName("ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required int Id { get; init; }

	[JsonPropertyName("HIGH_INTEREST")]
	[JsonConverter(typeof(YesNoBoolConverter.NotNullableConverter))]
	public required bool IsHighInterest { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public int? NoradCatId { get; init; }

	[JsonPropertyName("OBJECT_NUMBER")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public int? ObjectNumber { get; init; }
}