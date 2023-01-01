using System.Text.Json.Serialization;

namespace SpaceTrackSdk.Public.DataModels.BasicSpaceData;

public record Conjunction
{
	[JsonPropertyName("CDM_ID")]
	public required int CdmId { get; init; }

	[JsonPropertyName("CREATED")]
	public required DateTime Created { get; init; }

	[JsonPropertyName("EMERGENCY_REPORTABLE")]
	public required char EmergencyReportable { get; init; }

	[JsonPropertyName("SAT_1_NAME")]
	public required string Satellite1Name { get; init; }

	[JsonPropertyName("SAT1_OBJECT_TYPE")]
	public required string Satellite1ObjectType { get; init; }

	[JsonPropertyName("SAT1_RCS")]
	public required string Satellite1RadarCrossSection { get; init; }

	[JsonPropertyName("SAT_1_EXCL_VOL")]
	public required string Satellite1ExclusionVolume { get; init; }

	[JsonPropertyName("SAT_2_NAME")]
	public required string Satellite2Name { get; init; }

	[JsonPropertyName("SAT2_OBJECT_TYPE")]
	public required string Satellite2ObjectType { get; init; }

	[JsonPropertyName("SAT2_RCS")]
	public required string Satellite2RadarCrossSection { get; init; }

	[JsonPropertyName("SAT_2_EXCL_VOL")]
	public required string Satellite2ExclusionVolume { get; init; }

	[JsonPropertyName("TCA")]
	public DateTime? TimeOfClosestApproach { get; init; }

	[JsonPropertyName("MIN_RNG")]
	public double? MinimumRange { get; init; }

	[JsonPropertyName("PC")]
	public double? ProbabilityOfCollision { get; init; }

	[JsonPropertyName("SAT_1_ID")]
	public int? Satellite1Id { get; init; }

	[JsonPropertyName("SAT_2_ID")]
	public int? Satellite2Id { get; init; }

}
