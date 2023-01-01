using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class ConjunctionSerialisationTests: SerialisationTestBase<Conjunction>
{
	protected override string RawJson => """
										{
										    "CDM_ID": "392735348",
										    "CREATED": "2022-12-02 02:09:06.000000",
										    "EMERGENCY_REPORTABLE": "Y",
										    "TCA": "2022-12-04T01:03:42.235000",
										    "MIN_RNG": "886",
										    "PC": "0.000173503",
										    "SAT_1_ID": "3740",
										    "SAT_1_NAME": "THOR ABLESTAR DEB",
										    "SAT1_OBJECT_TYPE": "DEBRIS",
										    "SAT1_RCS": "SMALL",
										    "SAT_1_EXCL_VOL": "5.00",
										    "SAT_2_ID": "87650",
										    "SAT_2_NAME": "UNKNOWN",
										    "SAT2_OBJECT_TYPE": "UNKNOWN",
										    "SAT2_RCS": "SMALL",
										    "SAT_2_EXCL_VOL": "5.00"
										}
										""";

	protected override string ModelDef => """
											[
											    {
											        "Field": "CDM_ID",
											        "Type": "int(10) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "CREATED",
											        "Type": "datetime(6)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "EMERGENCY_REPORTABLE",
											        "Type": "char(1)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "TCA",
											        "Type": "datetime(6)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "MIN_RNG",
											        "Type": "double",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "PC",
											        "Type": "double",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT_1_ID",
											        "Type": "int(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT_1_NAME",
											        "Type": "varchar(25)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT1_OBJECT_TYPE",
											        "Type": "varchar(25)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT1_RCS",
											        "Type": "varchar(6)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT_1_EXCL_VOL",
											        "Type": "varchar(62)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT_2_ID",
											        "Type": "int(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT_2_NAME",
											        "Type": "varchar(25)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT2_OBJECT_TYPE",
											        "Type": "varchar(25)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT2_RCS",
											        "Type": "varchar(6)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SAT_2_EXCL_VOL",
											        "Type": "varchar(62)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    }
											]
											""";

	protected override Conjunction DataObject => new()
	{
		CdmId = 392735348,
		Created = new(2022,12,02,02,09,06),
		IsEmergencyReportable = true,
		TimeOfClosestApproach = new(2022,12,04,01,03,42,235),
		MinimumRange = 886,
		ProbabilityOfCollision = 0.000173503,
		Satellite1Id = 3740,
		Satellite1Name = "THOR ABLESTAR DEB",
		Satellite1ObjectType = "DEBRIS",
		Satellite1RadarCrossSection = "SMALL",
		Satellite1ExclusionVolume = 5.0f,
		Satellite2Id = 87650,
		Satellite2Name = "UNKNOWN",
		Satellite2ObjectType = "UNKNOWN",
		Satellite2RadarCrossSection = "SMALL",
		Satellite2ExclusionVolume = 5.0f,
	};
}