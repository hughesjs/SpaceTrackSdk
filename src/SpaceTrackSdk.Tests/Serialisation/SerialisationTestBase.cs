using System.Text.Json;
using System.Text.RegularExpressions;

namespace SpaceTrackSdk.Tests.Serialisation;

public abstract class SerialisationTestBase<T> where T : class
{
	protected abstract string RawJson { get; }
	protected abstract T DataObject { get; }

	private readonly Regex _jsonMinifier = new("(\"(?:[^\"\\\\]|\\\\.)*\")|\\s+");

	[Fact]
	public void CanSerialiseObject()
	{
		string serialisedAnnouncement = JsonSerializer.Serialize(RawJson);
		string minified = _jsonMinifier.Replace (serialisedAnnouncement, "$1");
		serialisedAnnouncement.ShouldBe(minified);
	}
	
	[Fact]
	public void CanDeserialiseObject()
	{
		T? result = JsonSerializer.Deserialize<T>(RawJson);

		result.ShouldNotBeNull();
		result.ShouldBeEquivalentTo(DataObject);
	}
}