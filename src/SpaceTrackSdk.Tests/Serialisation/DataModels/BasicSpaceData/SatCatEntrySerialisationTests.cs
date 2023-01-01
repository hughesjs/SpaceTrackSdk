using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class SatCatEntrySerialisationTests: SerialisationTestBase<SatCatEntry>
{
	protected override string RawJson => """
										{
										    "INTLDES": "1957-001A",
										    "NORAD_CAT_ID": "1",
										    "OBJECT_TYPE": "ROCKET BODY",
										    "SATNAME": "SL-1 R/B",
										    "COUNTRY": "CIS",
										    "LAUNCH": "1957-10-04",
										    "SITE": "TTMTR",
										    "DECAY": "1957-12-01",
										    "PERIOD": "96.19",
										    "INCLINATION": "65.10",
										    "APOGEE": "938",
										    "PERIGEE": "214",
										    "COMMENT": null,
										    "COMMENTCODE": "4",
										    "RCSVALUE": "0",
										    "RCS_SIZE": "LARGE",
										    "FILE": "1",
										    "LAUNCH_YEAR": "1957",
										    "LAUNCH_NUM": "1",
										    "LAUNCH_PIECE": "A",
										    "CURRENT": "Y",
										    "OBJECT_NAME": "SL-1 R/B",
										    "OBJECT_ID": "1957-001A",
										    "OBJECT_NUMBER": "1"
										}
										""";

	protected override string ModelDef => """
											[
											    {
											        "Field": "INTLDES",
											        "Type": "char(12)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "NORAD_CAT_ID",
											        "Type": "int(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "OBJECT_TYPE",
											        "Type": "varchar(12)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SATNAME",
											        "Type": "char(25)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "COUNTRY",
											        "Type": "char(6)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "LAUNCH",
											        "Type": "date",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "SITE",
											        "Type": "char(5)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "DECAY",
											        "Type": "date",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "PERIOD",
											        "Type": "decimal(12,2)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "INCLINATION",
											        "Type": "decimal(12,2)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "APOGEE",
											        "Type": "bigint(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "PERIGEE",
											        "Type": "bigint(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "COMMENT",
											        "Type": "char(32)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "COMMENTCODE",
											        "Type": "tinyint(3) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "RCSVALUE",
											        "Type": "int(1)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "RCS_SIZE",
											        "Type": "varchar(6)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "FILE",
											        "Type": "smallint(5) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "LAUNCH_YEAR",
											        "Type": "smallint(5) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "LAUNCH_NUM",
											        "Type": "smallint(5) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "LAUNCH_PIECE",
											        "Type": "varchar(3)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "CURRENT",
											        "Type": "enum('Y','N')",
											        "Null": "NO",
											        "Key": "",
											        "Default": "N",
											        "Extra": ""
											    },
											    {
											        "Field": "OBJECT_NAME",
											        "Type": "char(25)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "OBJECT_ID",
											        "Type": "char(12)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "OBJECT_NUMBER",
											        "Type": "int(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    }
											]
											""";

	protected override SatCatEntry DataObject => new()
	{
		InternationalDesignation = "1957-001A",
		NoradCatalogId = 1,
		ObjectType = "ROCKET BODY",
		SatelliteName = "SL-1 R/B",
		Country = "CIS",
		LaunchDate = new DateOnly(1957,10,4),
		LaunchSite = "TTMTR",
		DecayDate = new DateOnly(1957,12,1),
		Period = 96.19m,
		Inclination = 65.10m,
		Apogee = 938,
		Perigee = 214,
		Comment = null,
		CommentCode = 4,
		RadarCrossSectionValue = 0,
		RadarCrossSectionSize = "LARGE",
		FileNumber = 1,
		LaunchYear = 1957,
		LaunchNumber = 1,
		LaunchPiece = "A",
		IsCurrent = true,
		ObjectName = "SL-1 R/B",
		ObjectId = "1957-001A",
		ObjectNumber = 1
	};
}