using System.Reflection;
using System.Runtime.CompilerServices;
using SpaceTrackSdk.Internal.Clients;

namespace SpaceTrackSdk.Tests.Conventions;

public class InternalsAreNotPublicTests
{
	private const string PublicNamespaceFragment = "SpaceTrackSdk.Internal";
    
	[Theory]
	[MemberData(nameof(PublicClassDataGenerator))]
	public void ClassesInInternalsNamespaceAreNotPublic(Type type)
	{
		type.IsPublic.ShouldBeFalse();
	}


	public static IEnumerable<object[]> PublicClassDataGenerator() => typeof(BasicSpaceDataClient).Assembly.GetTypes()
		.Where(t => t.Namespace != null && t.Namespace.Contains(PublicNamespaceFragment))
		.Where(t => t.GetCustomAttribute<CompilerGeneratedAttribute>() is null)
		.Select(t => new object[] {t});
}