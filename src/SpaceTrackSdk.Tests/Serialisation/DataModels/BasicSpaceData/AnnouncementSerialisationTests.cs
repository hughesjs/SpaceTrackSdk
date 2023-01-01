using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class AnnouncementSerialisationTests: SerialisationTestBase<Announcement>
{
	protected override string RawJson =>
									"""
									{
									    "announcement_type": "NEW FEATURE",
									    "announcement_text": "We have just finished deploying and testing the revised Files Panel changes to this testing website.  Please test this site as you would use the regular production site by running your daily/weekly procedures, including uploading and downloading files to ensure this website works as you would expect.\n\nPlease let admin@space-track.org know the results of your testing.  We look forward to pushing this code to production sometime in January after users are able to successfully test.",
									    "announcement_start": "2022-12-23 22:37:41",
									    "announcement_end": "2023-01-10 22:37:41"
									}
									""";

	protected override Announcement DataObject => new()
	{
		Type = "NEW FEATURE",
		Text = "We have just finished deploying and testing the revised Files Panel changes to this testing website.  Please test this site as you would use the regular production site by running your daily/weekly procedures, including uploading and downloading files to ensure this website works as you would expect.\n\nPlease let admin@space-track.org know the results of your testing.  We look forward to pushing this code to production sometime in January after users are able to successfully test.",
		Start = new(2022, 12, 23, 22, 37, 41),
		End = new(2023, 1, 10, 22, 37, 41)
	};
}