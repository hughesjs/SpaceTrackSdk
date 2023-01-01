using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record SatCatEntry
{
	[JsonPropertyName("INTLDES")]
	public required string InternationalDesignation { get; init; }

	[JsonPropertyName("OBJECT_TYPE")]
	public required string ObjectType { get; init; }
	
	[JsonPropertyName("OBJECT_ID")]
	public required string ObjectId { get; init; }

	[JsonPropertyName("SATNAME")]
	public required string SatelliteName { get; init; }

	[JsonPropertyName("COUNTRY")]
	public required string Country { get; init; }

	
	[JsonPropertyName("RCSVALUE")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required int RadarCrossSectionValue { get; init; }

	[JsonPropertyName("RCS_SIZE")]
	public required string RadarCrossSectionSize { get; init; }

	[JsonPropertyName("FILE")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required ushort FileNumber { get; init; }

	[JsonPropertyName("LAUNCH_YEAR")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required ushort LaunchYear { get; init; }

	[JsonPropertyName("LAUNCH_NUM")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required ushort LaunchNumber { get; init; }

	[JsonPropertyName("LAUNCH_PIECE")]
	public required string LaunchPiece { get; init; }

	[JsonPropertyName("CURRENT")]
	[JsonConverter(typeof(YesNoBoolConverter.NotNullableConverter))]
	public required bool IsCurrent { get; init; }

	[JsonPropertyName("OBJECT_NAME")]
	public required string ObjectName { get; init; }
	
	[JsonPropertyName("SITE")]
	public required string LaunchSite { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? NoradCatalogId { get; init; }

	[JsonPropertyName("LAUNCH")]
	public DateOnly? LaunchDate { get; init; }

	[JsonPropertyName("DECAY")]
	public DateOnly? DecayDate { get; init; }

	[JsonPropertyName("PERIOD")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? Period { get; init; }

	[JsonPropertyName("INCLINATION")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public decimal? Inclination { get; init; }

	[JsonPropertyName("APOGEE")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public ulong? Apogee { get; init; }

	[JsonPropertyName("PERIGEE")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public ulong? Perigee { get; init; }
	
	[JsonPropertyName("OBJECT_NUMBER")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? ObjectNumber { get; init; }

	[JsonPropertyName("COMMENTCODE")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public ushort? CommentCode { get; init; }
	
	[JsonPropertyName("COMMENT")]
	public string? Comment { get; init; }
}