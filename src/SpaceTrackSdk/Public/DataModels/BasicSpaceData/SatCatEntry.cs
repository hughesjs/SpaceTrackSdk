using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record SatCatEntry
{
	[JsonPropertyName("INTLDES")]
	public required string InternationalDesignation { get; init; }

	[JsonPropertyName("OBJECT_TYPE")]
	public required string ObjectType { get; init; }

	[JsonPropertyName("SATNAME")]
	public required string SatelliteName { get; init; }

	[JsonPropertyName("COUNTRY")]
	public required string Country { get; init; }
	
	[JsonPropertyName("COMMENT")]
	public required string Comment { get; init; }
	
	[JsonPropertyName("RCSVALUE")]
	public required int RadarCrossSectionValue { get; init; }

	[JsonPropertyName("RCS_SIZE")]
	public required string RadarCrossSectionSize { get; init; }

	[JsonPropertyName("FILE")]
	public required ushort FileNumber { get; init; }

	[JsonPropertyName("LAUNCH_YEAR")]
	public required ushort LaunchYear { get; init; }

	[JsonPropertyName("LAUNCH_NUMBER")]
	public required ushort LaunchNumber { get; init; }

	[JsonPropertyName("LAUNCH_PIECE")]
	public required string LaunchPiece { get; init; }

	[JsonPropertyName("CURRENT")]
	public required bool IsCurrent { get; init; }

	[JsonPropertyName("OBJECT_NAME")]
	public required string ObjectName { get; init; }
	
	[JsonPropertyName("SITE")]
	public required string LaunchSite { get; init; }
	
	[JsonPropertyName("NORAD_CAT_ID")]
	public int? NoradCatalogId { get; init; }

	[JsonPropertyName("LAUNCH")]
	public DateTime? LaunchDate { get; init; }

	[JsonPropertyName("DECAY")]
	public DateTime? DecayDate { get; init; }

	[JsonPropertyName("PERIOD")]
	public decimal? Period { get; init; }

	[JsonPropertyName("INCLINATION")]
	public decimal? Inclination { get; init; }

	[JsonPropertyName("APOGEE")]
	public ulong? Apogee { get; init; }

	[JsonPropertyName("PERIGEE")]
	public ulong? Perigee { get; init; }

	[JsonPropertyName("COMMENTCODE")]
	public char? CommentCode { get; init; }
}