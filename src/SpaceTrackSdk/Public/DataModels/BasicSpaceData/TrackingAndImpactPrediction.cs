using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;
using SpaceTrackSdk.Public.DataModels.Enums;

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
	public required uint Window { get; init; }

	[JsonPropertyName("REV")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required uint Revolutions { get; init; }



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
	public required uint NextReport { get; init; }

	[JsonPropertyName("ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required uint Id { get; init; }

	[JsonPropertyName("HIGH_INTEREST")]
	[JsonConverter(typeof(YesNoBoolConverter.NullableConverter))]
	public bool? IsHighInterest { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? NoradCatId { get; init; }

	[JsonPropertyName("OBJECT_NUMBER")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? ObjectNumber { get; init; }
	
	[JsonPropertyName("DIRECTION")]
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public Direction? Direction { get; init; }
}