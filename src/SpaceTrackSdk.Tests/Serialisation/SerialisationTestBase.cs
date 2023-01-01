using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using SpaceTrackSdk.Internal.Attributes;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;
using SpaceTrackSdk.Public.DataModels.Enums;

namespace SpaceTrackSdk.Tests.Serialisation;

public abstract class SerialisationTestBase<T> where T : class
{
	protected SerialisationTestBase()
	{
		// ReSharper disable once VirtualMemberCallInConstructor
		ModelDefinition[] propertyDefinitions = JsonSerializer.Deserialize<ModelDefinition[]>(ModelDef)!;
		_parsedModelDefinition = propertyDefinitions.ToDictionary(md => md.Field, md => md);
	}

	protected abstract string RawJson { get; }

	protected abstract string ModelDef { get; }
	protected abstract T DataObject { get; }

	private readonly Regex _jsonMinifier = new("(\"(?:[^\"\\\\]|\\\\.)*\")|\\s+");

	private readonly Dictionary<string, ModelDefinition> _parsedModelDefinition;

	[Fact]
	public void CanSerialiseObject()
	{
		string serialisedAnnouncement = JsonSerializer.Serialize(RawJson);
		string minified = _jsonMinifier.Replace(serialisedAnnouncement, "$1");
		serialisedAnnouncement.ShouldBe(minified);
	}

	[Fact]
	public void CanDeserialiseObject()
	{
		T? result = JsonSerializer.Deserialize<T>(RawJson);

		result.ShouldNotBeNull();
		result.ShouldBeEquivalentTo(DataObject);
	}

	[Theory]
	[MemberData(nameof(PropertyTestDataGenerator))]
	public void ParameterTypesAreCorrect(PropertyInfo propertyInfo)
	{
		string jsonPropertyName = propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name ?? propertyInfo.Name;
		ModelDefinition propertyDef = _parsedModelDefinition[jsonPropertyName];

		Type modelDefinedType = ModelTypeMapper.First(mtm => mtm.Key.IsMatch(propertyDef.Type)).Value;

		if (propertyDef.IsNullable && modelDefinedType.IsValueType)
		{
			modelDefinedType = typeof(Nullable<>).MakeGenericType(modelDefinedType);
		}
		
		ModelDefinitionTypeOverrideAttribute? overrideAttribute = propertyInfo.GetCustomAttribute<ModelDefinitionTypeOverrideAttribute>();
		if (overrideAttribute is not null)
		{
			modelDefinedType = overrideAttribute.OverrideType;
		}
		
		
		propertyInfo.PropertyType.ShouldBe(modelDefinedType);
	}


	public static IEnumerable<object[]> PropertyTestDataGenerator()
		=> typeof(T).GetProperties().Cast<object>().Select(o => new[] { o }).ToArray();

	private static readonly Dictionary<Regex, Type> ModelTypeMapper = new()
	{
		{ new(@"^.*(var)?char(?!\(1\)).*$"), typeof(string) },
		{ new(@"^.*char\(1\).*$"), typeof(char) },
		{ new(@"^(int|mediumint)\(\d+\)\s?(signed)?$"), typeof(int) },
		{ new(@"^(smallint|tinyint)\(\d+\)\s?(signed)?$"), typeof(short) },
		{ new(@"^bigint\(\d+\)\s?(signed)?$"), typeof(long) },
		{ new(@"^(int|mediumint)\(\d+\)\s?(unsigned)$"), typeof(uint) },
		{ new(@"^(smallint|tinyint)\(\d+\)\s?(unsigned)$"), typeof(ushort) },
		{ new(@"^bigint\(\d+\)\s?(unsigned)$"), typeof(ulong) },
		{ new(@"^.*decimal.*$"), typeof(decimal) },
		{ new(@"^.*double.*$"), typeof(double) },
		{ new(@"^.*float.*$"), typeof(float) },
		{ new(@"^.*date(?!time).*$"), typeof(DateOnly) },
		{ new(@"^.*datetime.*$"), typeof(DateTime) },
		{ new(@"^enum\('(Y|y)(es|ES)?','(N|n)(o|O)?'\)$"), typeof(bool) },
		{ new(@"^enum\('(A|a)(scending|SCENDING)','(D|d)(escending|ESCENDING)'\)$"), typeof(Direction) },
	};
}