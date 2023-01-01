using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;
using SpaceTrackSdk.Public.DataModels.Enums;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class DecaySerialisationTests: SerialisationTestBase<Decay>
{
	protected override string RawJson => """
										{
										    "NORAD_CAT_ID": "1",
										    "OBJECT_NUMBER": "1",
										    "OBJECT_NAME": "SL-1 R/B",
										    "INTLDES": "1957-001A",
										    "OBJECT_ID": "1957-001A",
										    "RCS": "0",
										    "RCS_SIZE": "LARGE",
										    "COUNTRY": "CIS",
										    "MSG_EPOCH": null,
										    "DECAY_EPOCH": "1957-12-01 0:00:00",
										    "SOURCE": "satcat",
										    "MSG_TYPE": "Historical",
										    "PRECEDENCE": "1"
										}
										""";

	protected override Decay DataObject => new()
	{
		NoradCatId = 1,
		ObjectNumber = 1,
		ObjectName = "SL-1 R/B",
		InternationalDesignator = "1957-001A",
		ObjectId = "1957-001A",
		RadarCrossSection = 0,
		RadarCrossSectionSize = "LARGE",
		Country = "CIS",
		MessageEpoch = null,
		DecayEpoch = new(1957, 12, 1, 0, 0, 0),
		Source = "satcat",
		MessageType = "Historical",
		Precedence = Precendence.SatCat
	};
}