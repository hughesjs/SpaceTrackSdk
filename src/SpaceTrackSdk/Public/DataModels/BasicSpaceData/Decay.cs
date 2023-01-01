using System.Text.Json.Serialization;
using SpaceTrackSdk.Public.DataModels.Enums;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public class Decay
{
	[JsonPropertyName("SOURCE")]
	public required string Source { get; init; }

	[JsonPropertyName("MSG_TYPE")]
	public required string MsgType { get; init; }

	[JsonPropertyName("PRECEDENCE")]
	public required Precendence Precedence { get; init; }
	
	[JsonPropertyName("COUNTRY")]
	public required string Country { get; init; }
	
	[JsonPropertyName("OBJECT_NAME")]
	public required string ObjectName { get; init; }

	[JsonPropertyName("INTLDES")]
	public required string InternationalDesignator { get; init; }

	[JsonPropertyName("OBJECT_ID")]
	public required string ObjectId { get; init; }

	[JsonPropertyName("RCS")]
	public required int RadarCrossSection { get; init; }

	[JsonPropertyName("RCS_SIZE")]
	public string? RadarCrossSectionSize { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	public int? NoradCatId { get; init; }

	[JsonPropertyName("OBJECT_NUMBER")]
	public int? ObjectNumber { get; init; }

	[JsonPropertyName("MSG_EPOCH")]
	public DateTime? MessageEpoch { get; init; }

	[JsonPropertyName("DECAY_EPOCH")]
	public string? DecayEpoch { get; init; }

}