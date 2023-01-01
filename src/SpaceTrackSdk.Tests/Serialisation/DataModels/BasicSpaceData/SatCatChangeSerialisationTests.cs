using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

public class SatCatChangeSerialisationTests: SerialisationTestBase<SatCatChange>
{
	protected override string RawJson => """
										{
										    "NORAD_CAT_ID": "42077",
										    "OBJECT_NUMBER": "42077",
										    "CURRENT_NAME": "TK-1 DEB",
										    "PREVIOUS_NAME": "TK-1 DEB",
										    "CURRENT_INTLDES": "2017-012C",
										    "PREVIOUS_INTLDES": "2017-012C",
										    "CURRENT_COUNTRY": "PRC",
										    "PREVIOUS_COUNTRY": "PRC",
										    "CURRENT_LAUNCH": "2017-03-02",
										    "PREVIOUS_LAUNCH": "2017-03-02",
										    "CURRENT_DECAY": "2017-05-21",
										    "PREVIOUS_DECAY": null,
										    "CHANGE_MADE": "2017-05-23 15:29:53"
										}
										""";

	protected override SatCatChange DataObject => new()
	{
		NoradCatId = 42077,
		ObjectNumber = 42077,
		CurrentName = "TK-1 DEB",
		PreviousName = "TK-1 DEB",
		CurrentInternationalDesignation = "2017-012C",
		PreviousInternationalDesignation = "2017-012C",
		CurrentCountry = "PRC",
		PreviousCountry = "PRC",
		CurrentLaunch = new DateTime(2017,3,2),
		PreviousLaunch = new DateTime(2017,3,2),
		CurrentDecay = new DateTime(2017,5,21),
		PreviousDecay = null,
		ChangeMade = new DateTime(2017,5,23,15,29,53)
	};
}