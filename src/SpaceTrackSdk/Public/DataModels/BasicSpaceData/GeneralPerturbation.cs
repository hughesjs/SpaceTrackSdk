using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record GeneralPerturbation
{
	[JsonPropertyName("GP_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required uint Id { get; init; }
	
	[JsonPropertyName("CCSDS_OMM_VERS")]
    public required string CcsdsOrbitDataMessageVersion { get; init; }

    [JsonPropertyName("COMMENT")]
    public required string Comment { get; init; }

    [JsonPropertyName("ORIGINATOR")]
    public required string Originator { get; init; }

    [JsonPropertyName("OBJECT_NAME")]
    public required string ObjectName { get; init; }

    [JsonPropertyName("OBJECT_ID")]
    public required string ObjectId { get; init; }

    [JsonPropertyName("CENTER_NAME")]
    public required string CenterName { get; init; }

    [JsonPropertyName("REF_FRAME")]
    public required string ReferenceFrame { get; init; }

    [JsonPropertyName("TIME_SYSTEM")]
    public required string TimeSystem { get; init; }

    [JsonPropertyName("MEAN_ELEMENT_THEORY")]
    public required string MeanElementTheory { get; init; }
  
    [JsonPropertyName("OBJECT_TYPE")]
    public required string ObjectType { get; init; }
    
    [JsonPropertyName("NORAD_CAT_ID")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public required uint NoradCatalogId { get; init; }
    
	[JsonPropertyName("EPHEMERIS_TYPE")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public short? EphemerisType { get; init; }
    
    [JsonPropertyName("CLASSIFICATION_TYPE")]
    public char? ClassificationType { get; init; }
    
    [JsonPropertyName("CREATION_DATE")]
    public DateTime? CreationDate { get; init; }

    [JsonPropertyName("EPOCH")]
    public DateTime? Epoch { get; init; }

    [JsonPropertyName("MEAN_MOTION")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? MeanMotion { get; init; }

    [JsonPropertyName("ECCENTRICITY")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Eccentricity { get; init; }

    [JsonPropertyName("INCLINATION")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Inclination { get; init; }

    [JsonPropertyName("RA_OF_ASC_NODE")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? RightAscensionOfAscendingNode { get; init; }

    [JsonPropertyName("ARG_OF_PERICENTER")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? ArgumentOfPeriapsis { get; init; }

    [JsonPropertyName("MEAN_ANOMALY")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? MeanAnomaly { get; init; }

    [JsonPropertyName("ELEMENT_SET_NO")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public ushort? ElementSetNumber { get; init; }

    [JsonPropertyName("REV_AT_EPOCH")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public uint? RevolutionsAtEpoch { get; init; }

    [JsonPropertyName("BSTAR")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Bstar { get; init; }

    [JsonPropertyName("MEAN_MOTION_DOT")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? MeanMotionDot { get; init; }
    
    [JsonPropertyName("MEAN_MOTION_DDOT")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? MeanMotionDdot { get; init; }

    [JsonPropertyName("SEMIMAJOR_AXIS")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? SemiMajorAxis { get; init; }

    [JsonPropertyName("PERIOD")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? Period { get; init; }

    [JsonPropertyName("APOAPSIS")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? Apoapsis { get; init; }

    [JsonPropertyName("PERIAPSIS")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? Periapsis { get; init; }

    [JsonPropertyName("RCS_SIZE")]
    public string? RadarCrossSectionSize { get; init; }
    
    [JsonPropertyName("COUNTRY_CODE")]
    public string? CountryCode { get; init; }
    
    [JsonPropertyName("LAUNCH_DATE")]
    public DateOnly? LaunchDate { get; init; }
    
    [JsonPropertyName("SITE")]
    public string? Site { get; init; }
    
    [JsonPropertyName("DECAY_DATE")]
    public DateOnly? DecayDate { get; init; }

    [JsonPropertyName("FILE")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public ulong? FileNumber { get; init; }

	[JsonPropertyName("TLE_LINE0")]
	public string? TwoLineElementLine0 { get; init; }
	
	[JsonPropertyName("TLE_LINE1")]
	public string? TwoLineElementLine1 { get; init; }
	
	[JsonPropertyName("TLE_LINE2")]
	public string? TwoLineElementLine2 { get; init; }


}