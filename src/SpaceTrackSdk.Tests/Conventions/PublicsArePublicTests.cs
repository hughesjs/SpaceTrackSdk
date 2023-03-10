using System.Reflection;
using System.Runtime.CompilerServices;
using SpaceTrackSdk.Public.Clients;

namespace SpaceTrackSdk.Tests.Conventions;

public class PublicsArePublicTests
{
	private const string PublicNamespaceFragment = "SpaceTrackSdk.Public";
    
	[Theory]
	[MemberData(nameof(PublicClassDataGenerator))]
	public void ClassesInPublicNamespaceArePublic(Type type)
	{
		type.IsPublic.ShouldBeTrue();
	}


	public static IEnumerable<object[]> PublicClassDataGenerator() => typeof(IClientAdapter<>).Assembly.GetTypes()
		.Where(t => t.Namespace != null && t.Namespace.Contains(PublicNamespaceFragment))
		.Where(t => t.GetCustomAttribute<CompilerGeneratedAttribute>() is null)
		.Select(t => new object[] {t});
}