using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class GeneralPerturbationSerialisationTests: SerialisationTestBase<GeneralPerturbation>
{
	protected override string RawJson => """
										{
										    "CCSDS_OMM_VERS": "2.0",
										    "COMMENT": "GENERATED VIA SPACE-TRACK.ORG API",
										    "CREATION_DATE": "2022-12-11T18:16:13",
										    "ORIGINATOR": "18 SPCS",
										    "OBJECT_NAME": "CZ-2F R/B",
										    "OBJECT_ID": "2022-162B",
										    "CENTER_NAME": "EARTH",
										    "REF_FRAME": "TEME",
										    "TIME_SYSTEM": "UTC",
										    "MEAN_ELEMENT_THEORY": "SGP4",
										    "EPOCH": "2022-12-11T16:32:45.677184",
										    "MEAN_MOTION": "16.45663364",
										    "ECCENTRICITY": "0.00147770",
										    "INCLINATION": "41.4618",
										    "RA_OF_ASC_NODE": "212.0662",
										    "ARG_OF_PERICENTER": "219.1379",
										    "MEAN_ANOMALY": "204.8125",
										    "EPHEMERIS_TYPE": "0",
										    "CLASSIFICATION_TYPE": "U",
										    "NORAD_CAT_ID": "54380",
										    "ELEMENT_SET_NO": "999",
										    "REV_AT_EPOCH": "195",
										    "BSTAR": "0.00018379000000",
										    "MEAN_MOTION_DOT": "0.08877519",
										    "MEAN_MOTION_DDOT": "0.0000080912000",
										    "SEMIMAJOR_AXIS": "6528.917",
										    "PERIOD": "87.503",
										    "APOAPSIS": "160.430",
										    "PERIAPSIS": "141.135",
										    "OBJECT_TYPE": "ROCKET BODY",
										    "RCS_SIZE": "LARGE",
										    "COUNTRY_CODE": "PRC",
										    "LAUNCH_DATE": "2022-11-29",
										    "SITE": "JSC",
										    "DECAY_DATE": "2022-12-11",
										    "FILE": "3691205",
										    "GP_ID": "220029422",
										    "TLE_LINE0": "0 CZ-2F R/B",
										    "TLE_LINE1": "1 54380U 22162B   22345.68941756  .08877519  80912-5  18379-3 0  9996",
										    "TLE_LINE2": "2 54380  41.4618 212.0662 0014777 219.1379 204.8125 16.45663364  1954"
										}
										""";

	protected override GeneralPerturbation DataObject => new()
	{
		CcsdsOrbitDataMessageVersion = "2.0",
		Comment = "GENERATED VIA SPACE-TRACK.ORG API",
		CreationDate = new DateTime(2022,12,11,18,16,13),
		Originator = "18 SPCS",
		ObjectName = "CZ-2F R/B",
		ObjectId = "2022-162B",
		CenterName = "EARTH",
		ReferenceFrame = "TEME",
		TimeSystem = "UTC",
		MeanElementTheory = "SGP4",
		Epoch = new DateTime(2022,12,11,16,32,45,677,184),
		MeanMotion = 16.45663364m,
		Eccentricity = 0.00147770m,
		Inclination = 41.4618m,
		RightAscensionOfAscendingNode = 212.0662m,
		ArgumentOfPeriapsis = 219.1379m,
		MeanAnomaly = 204.8125m,
		EphemerisType = "0",
		ClassificationType = "U",
		NoradCatalogId = 54380,
		ElementSetNumber = 999,
		RevolutionsAtEpoch = 195,
		Bstar = 0.00018379m,
		MeanMotionDot = 0.08877519m,
		MeanMotionDdot = 0.0000080912m,
		SemiMajorAxis = 6528.917m,
		Period = 87.503m,
		Apoapsis = 160.430m,
		Periapsis = 141.135m,
		ObjectType = "ROCKET BODY",
		RadarCrossSectionSize = "LARGE",
		CountryCode = "PRC",
		LaunchDate = new DateTime(2022,11,29),
		Site = "JSC",
		DecayDate = new DateTime(2022,12,11),
		File = 3691205,
		Id = 220029422,
		TwoLineElementLine0 = "0 CZ-2F R/B",
		TwoLineElementLine1 = "1 54380U 22162B   22345.68941756  .08877519  80912-5  18379-3 0  9996",
		TwoLineElementLine2 = "2 54380  41.4618 212.0662 0014777 219.1379 204.8125 16.45663364  1954"
	};
}