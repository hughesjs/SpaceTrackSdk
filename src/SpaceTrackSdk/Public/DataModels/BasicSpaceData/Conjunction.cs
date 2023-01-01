using System.Text.Json.Serialization;
using SpaceTrackSdk.Internal.Attributes;
using SpaceTrackSdk.Internal.Serialisation.Converters;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record Conjunction
{
	[JsonPropertyName("CDM_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public required uint CdmId { get; init; }

	[JsonPropertyName("EMERGENCY_REPORTABLE")]
	[JsonConverter(typeof(YesNoBoolConverter.NotNullableConverter))]
	[ModelDefinitionTypeOverride(typeof(bool))]
	public required bool IsEmergencyReportable { get; init; }

	[JsonPropertyName("SAT_1_NAME")]
	public required string Satellite1Name { get; init; }

	[JsonPropertyName("SAT1_OBJECT_TYPE")]
	public required string Satellite1ObjectType { get; init; }

	[JsonPropertyName("SAT1_RCS")]
	public required string Satellite1RadarCrossSection { get; init; }

	[JsonPropertyName("SAT_1_EXCL_VOL")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	[ModelDefinitionTypeOverride(typeof(float))]
	public required float Satellite1ExclusionVolume { get; init; }

	[JsonPropertyName("SAT_2_NAME")]
	public required string Satellite2Name { get; init; }

	[JsonPropertyName("SAT2_OBJECT_TYPE")]
	public required string Satellite2ObjectType { get; init; }

	[JsonPropertyName("SAT2_RCS")]
	public required string Satellite2RadarCrossSection { get; init; }

	[JsonPropertyName("SAT_2_EXCL_VOL")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	[ModelDefinitionTypeOverride(typeof(float))]
	public required float Satellite2ExclusionVolume { get; init; }

	[JsonPropertyName("TCA")]
	public DateTime? TimeOfClosestApproach { get; init; }

	[JsonPropertyName("MIN_RNG")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public double? MinimumRange { get; init; }

	[JsonPropertyName("PC")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public double? ProbabilityOfCollision { get; init; }

	[JsonPropertyName("SAT_1_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? Satellite1Id { get; init; }

	[JsonPropertyName("SAT_2_ID")]
	[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
	public uint? Satellite2Id { get; init; }
	
	[JsonPropertyName("CREATED")]
	[JsonConverter(typeof(DateTimeConverter.Complex.NullableConverter))]
	public DateTime? Created { get; init; }

}
