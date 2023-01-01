using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record GeneralPerturbation
{
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
    
    [JsonPropertyName("EPHEMERIS_TYPE")]
    public required string EphemerisType { get; init; }

    [JsonPropertyName("CLASSIFICATION_TYPE")]
    public required string ClassificationType { get; init; }
    
    [JsonPropertyName("OBJECT_TYPE")]
    public required string ObjectType { get; init; }
    
    [JsonPropertyName("FILE")]
    public required string File { get; init; }

    [JsonPropertyName("CREATION_DATE")]
    public DateTime? CreationDate { get; init; }

    [JsonPropertyName("EPOCH")]
    public DateTime? Epoch { get; init; }

    [JsonPropertyName("MEAN_MOTION")]
    public decimal? MeanMotion { get; init; }

    [JsonPropertyName("ECCENTRICITY")]
    public decimal? Eccentricity { get; init; }

    [JsonPropertyName("INCLINATION")]
    public decimal? Inclination { get; init; }

    [JsonPropertyName("RA_OF_ASC_NODE")]
    public decimal? RightAscensionOfAscendingNode { get; init; }

    [JsonPropertyName("ARG_OF_PERICENTER")]
    public decimal? ArgumentOfPeriapsis { get; init; }

    [JsonPropertyName("MEAN_ANOMALY")]
    public decimal? MeanAnomaly { get; init; }

    [JsonPropertyName("NORAD_CAT_ID")]
    public int? NoradCatalogId { get; init; }

    [JsonPropertyName("ELEMENT_SET_NO")]
    public int? ElementSetNumber { get; init; }

    [JsonPropertyName("REV_AT_EPOCH")]
    public int? RevolutionsAtEpoch { get; init; }

    [JsonPropertyName("BSTAR")]
    public decimal? Bstar { get; init; }

    [JsonPropertyName("MEAN_MOTION_DOT")]
    public decimal? MeanMotionDot { get; init; }
    
    [JsonPropertyName("MEAN_MOTION_DDOT")]
    public decimal? MeanMotionDdot { get; init; }

    [JsonPropertyName("SEMIMAJOR_AXIS")]
    public decimal? SemimajorAxis { get; init; }

    [JsonPropertyName("PERIOD")]
    public decimal? Period { get; init; }

    [JsonPropertyName("APOAPSIS")]
    public decimal? Apoapsis { get; init; }

    [JsonPropertyName("PERIAPSIS")]
    public decimal? Periapsis { get; init; }

    [JsonPropertyName("R_MIN")]
    public decimal? RadiusMin { get; init; }

    [JsonPropertyName("R_P")]
    public decimal? RadiusPerigee { get; init; }


}