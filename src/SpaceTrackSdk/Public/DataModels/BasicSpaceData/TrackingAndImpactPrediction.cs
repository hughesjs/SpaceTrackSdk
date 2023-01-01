using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record TrackingAndImpactPrediction
{
	[JsonPropertyName("MSG_EPOCH")]
	public required DateTime MessageEpoch { get; init; }

	[JsonPropertyName("INSERT_EPOCH")]
	public required DateTime InsertEpoch { get; init; }

	[JsonPropertyName("DECAY_EPOCH")]
	public required DateTime DecayEpoch { get; init; }

	[JsonPropertyName("WINDOW")]
	public required ushort Window { get; init; }

	[JsonPropertyName("REV")]
	public required ushort Revolutions { get; init; }

	[JsonPropertyName("DIRECTION")]
	public required string Direction { get; init; }

	[JsonPropertyName("LAT")]
	public required float Latitude { get; init; }

	[JsonPropertyName("LON")]
	public required float Longitude { get; init; }

	[JsonPropertyName("INCL")]
	public required float Inclination { get; init; }

	[JsonPropertyName("NEXT_REPORT")]
	public required ushort NextReport { get; init; }

	[JsonPropertyName("ID")]
	public required int Id { get; init; }

	[JsonPropertyName("HIGH_INTEREST")]
	public required bool IsHighInterest { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	public int? NoradCatId { get; init; }

	[JsonPropertyName("OBJECT_NUMBER")]
	public int? ObjectNumber { get; init; }
}