using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Attributes;
using SpaceTrackSdk.Internal.Serialisation.Converters;
using SpaceTrackSdk.Public.DataModels.Enums;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public class Decay
{
	[JsonPropertyName("SOURCE")]
	public required string Source { get; init; }

	[JsonPropertyName("MSG_TYPE")]
	public required string MessageType { get; init; }

	[JsonPropertyName("PRECEDENCE")]
	[JsonConverter(typeof(JsonStringEnumConverter))]
	[ModelDefinitionTypeOverride(typeof(Precendence))]
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
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required int RadarCrossSection { get; init; }

	[JsonPropertyName("RCS_SIZE")]
	public string? RadarCrossSectionSize { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? NoradCatId { get; init; }

	[JsonPropertyName("OBJECT_NUMBER")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? ObjectNumber { get; init; }

	[JsonPropertyName("MSG_EPOCH")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NullableConverter))]
	public DateTime? MessageEpoch { get; init; }

	[JsonPropertyName("DECAY_EPOCH")]
	[JsonConverter(typeof(DateTimeConverter.Simple.NullableConverter))]
	[ModelDefinitionTypeOverride(typeof(DateTime?))]
	public DateTime? DecayEpoch { get; init; }

}