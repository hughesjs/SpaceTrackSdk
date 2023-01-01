using JetBrains.Annotations;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;
using SpaceTrackSdk.Public.DataModels.Enums;

namespace SpaceTrackSdk.Tests.Serialisation.DataModels.BasicSpaceData;

[UsedImplicitly]
public class TrackingAndImpactPredictionSerialisationTests: SerialisationTestBase<TrackingAndImpactPrediction>
{
	protected override string RawJson => """
										{
										    "NORAD_CAT_ID": "60",
										    "MSG_EPOCH": "2012-03-28 12:30:00",
										    "INSERT_EPOCH": "2012-03-28 06:34:36",
										    "DECAY_EPOCH": "2012-03-28 01:14:00",
										    "WINDOW": "14",
										    "REV": "58623",
										    "DIRECTION": "descending",
										    "LAT": "-16.8",
										    "LON": "286.8",
										    "INCL": "49.9",
										    "NEXT_REPORT": "0",
										    "ID": "3027",
										    "HIGH_INTEREST": "N",
										    "OBJECT_NUMBER": "60"
										}
										""";

	protected override string ModelDef => """
											[
											    {
											        "Field": "NORAD_CAT_ID",
											        "Type": "int(10) unsigned",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "MSG_EPOCH",
											        "Type": "datetime",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0001-01-01 00:00:00",
											        "Extra": ""
											    },
											    {
											        "Field": "INSERT_EPOCH",
											        "Type": "datetime",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0001-01-01 00:00:00",
											        "Extra": ""
											    },
											    {
											        "Field": "DECAY_EPOCH",
											        "Type": "datetime",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0001-01-01 00:00:00",
											        "Extra": ""
											    },
											    {
											        "Field": "WINDOW",
											        "Type": "mediumint(3) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "REV",
											        "Type": "mediumint(8) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "DIRECTION",
											        "Type": "enum('ascending','descending')",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
											        "Extra": ""
											    },
											    {
											        "Field": "LAT",
											        "Type": "float",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "LON",
											        "Type": "float",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "INCL",
											        "Type": "float",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "NEXT_REPORT",
											        "Type": "mediumint(3) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "ID",
											        "Type": "int(10) unsigned",
											        "Null": "NO",
											        "Key": "",
											        "Default": "0",
											        "Extra": ""
											    },
											    {
											        "Field": "HIGH_INTEREST",
											        "Type": "enum('Y','N')",
											        "Null": "YES",
											        "Key": "",
											        "Default": null,
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

	protected override TrackingAndImpactPrediction DataObject => new()
	{
		NoradCatId = 60,
		MessageEpoch = new(2012,3,28,12,30,0),
		InsertEpoch = new(2012,3,28,6,34,36),
		DecayEpoch = new(2012,3,28,1,14,0),
		Window = 14,
		Revolutions = 58623,
		Direction = Direction.Descending,
		Latitude = -16.8f,
		Longitude = 286.8f,
		Inclination = 49.9f,
		NextReport = 0,
		Id = 3027,
		IsHighInterest = false,
		ObjectNumber = 60
	};
}