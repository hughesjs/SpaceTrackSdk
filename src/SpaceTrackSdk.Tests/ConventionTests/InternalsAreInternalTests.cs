using SpaceTrackSdk.Internal.Clients;

namespace SpaceTrackSdk.Tests.ConventionTests;

public class InternalsAreNotPublicTests
{
	private const string PublicNamespaceFragment = "SpaceTrackSdk.Internal";
    
	[Theory]
	[MemberData(nameof(PublicClassDataGenerator))]
	public void ClassesInInternalsNamespaceAreNotPublic(Type type)
	{
		type.IsPublic.ShouldBeFalse();
	}


	public static IEnumerable<object[]> PublicClassDataGenerator() => typeof(SpaceTrackClient).Assembly.GetTypes()
		.Where(t => t.Namespace != null && t.Namespace.Contains(PublicNamespaceFragment))
		.Select(t => new object[] {t});
}