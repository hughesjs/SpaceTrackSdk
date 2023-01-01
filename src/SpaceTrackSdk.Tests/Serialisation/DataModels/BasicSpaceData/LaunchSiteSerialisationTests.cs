using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class LaunchSiteSerialisationTests: SerialisationTestBase<LaunchSite>
{
	protected override string RawJson => """
										{
										    "SITE_CODE": "AFETR",
										    "LAUNCH_SITE": "AIR FORCE EASTERN TEST RANGE"
										}
										""";

	protected override LaunchSite DataObject => new()
	{
		Name = "AIR FORCE EASTERN TEST RANGE",
		Code = "AFETR"
	};
}