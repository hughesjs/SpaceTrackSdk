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