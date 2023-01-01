namespace SpaceTrackSdk.Internal.Attributes;

[AttributeUsage(AttributeTargets.Property)]
internal class ModelDefinitionTypeOverrideAttribute : Attribute
{
	public ModelDefinitionTypeOverrideAttribute(Type overrideType)
	{
		OverrideType = overrideType;
	}

	public Type OverrideType { get; }
}