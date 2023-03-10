using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class BoxScoreSerialisationTests: SerialisationTestBase<BoxScore>
{
	protected override string RawJson => """
											{
											    "COUNTRY": "ARAB SATELLITE COMMUNICATIONS ORGANIZATION",
											    "SPADOC_CD": "AB",
											    "ORBITAL_TBA": "0",
											    "ORBITAL_PAYLOAD_COUNT": "14",
											    "ORBITAL_ROCKET_BODY_COUNT": "0",
											    "ORBITAL_DEBRIS_COUNT": "0",
											    "ORBITAL_TOTAL_COUNT": "14",
											    "DECAYED_PAYLOAD_COUNT": "1",
											    "DECAYED_ROCKET_BODY_COUNT": "0",
											    "DECAYED_DEBRIS_COUNT": "0",
											    "DECAYED_TOTAL_COUNT": "1",
											    "COUNTRY_TOTAL": "15"
											}
											""";

	protected override string ModelDef => """
											[
											    {
											        "Field": "COUNTRY",
											        "Type": "varchar(100)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "",
											        "Extra": ""
											    },
											    {
											        "Field": "SPADOC_CD",
											        "Type": "varchar(6)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "ORBITAL_TBA",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "ORBITAL_PAYLOAD_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "ORBITAL_ROCKET_BODY_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "ORBITAL_DEBRIS_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "ORBITAL_TOTAL_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "DECAYED_PAYLOAD_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "DECAYED_ROCKET_BODY_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "DECAYED_DEBRIS_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "DECAYED_TOTAL_COUNT",
											        "Type": "decimal(23,0)",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "COUNTRY_TOTAL",
											        "Type": "bigint(21)",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    }
											]
											""";

	protected override BoxScore DataObject => new()
	{
		Country = "ARAB SATELLITE COMMUNICATIONS ORGANIZATION",
		SpadocCode = "AB",
		OrbitalToBeAnalysed = 0,
		OrbitalPayloadCount = 14,
		OrbitalRocketBodyCount = 0,
		OrbitalDebrisCount = 0,
		OrbitalTotalCount = 14,
		DecayedPayloadCount = 1,
		DecayedRocketBodyCount = 0,
		DecayedDebrisCount = 0,
		DecayedTotalCount = 1,
		CountryTotal = 15
	};
}