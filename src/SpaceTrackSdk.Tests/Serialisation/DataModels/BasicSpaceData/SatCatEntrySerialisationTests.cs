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

	protected override SatCatEntry DataObject => new()
	{
		InternationalDesignation = "1957-001A",
		NoradCatalogId = 1,
		ObjectType = "ROCKET BODY",
		SatelliteName = "SL-1 R/B",
		Country = "CIS",
		LaunchDate = new DateTime(1957,10,4),
		LaunchSite = "TTMTR",
		DecayDate = new DateTime(1957,12,1),
		Period = 96.19m,
		Inclination = 65.10m,
		Apogee = 938,
		Perigee = 214,
		Comment = null,
		CommentCode = '4',
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