using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Serialisation.Converters;

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
    [JsonConverter(typeof(DateTimeConverter.Simple.NullableConverter))]
    public DateTime? CreationDate { get; init; }

    [JsonPropertyName("EPOCH")]
    [JsonConverter(typeof(DateTimeConverter.Simple.NullableConverter))]
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

    [JsonPropertyName("NORAD_CAT_ID")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int? NoradCatalogId { get; init; }

    [JsonPropertyName("ELEMENT_SET_NO")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int? ElementSetNumber { get; init; }

    [JsonPropertyName("REV_AT_EPOCH")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int? RevolutionsAtEpoch { get; init; }

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
    public decimal? SemimajorAxis { get; init; }

    [JsonPropertyName("PERIOD")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Period { get; init; }

    [JsonPropertyName("APOAPSIS")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Apoapsis { get; init; }

    [JsonPropertyName("PERIAPSIS")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? Periapsis { get; init; }

    [JsonPropertyName("R_MIN")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? RadiusMin { get; init; }

    [JsonPropertyName("R_P")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public decimal? RadiusPerigee { get; init; }


}