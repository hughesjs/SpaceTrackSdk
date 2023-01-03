using JetBrains.Annotations;
using SpaceTrackSdk.Public.Exceptions;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class StartsWithOperator<T>: Operator<T>
{
	public StartsWithOperator(T value) : base(value) { }

	public override string Opcode => "^";

	public override string GetQueryString()
	{
		if (Value is null || Value?.ToString()?.Length < 2)
		{
			throw new SpaceTrackSdkException("Starts with predicate requires at least 2 characters");
		}
		return base.GetQueryString();
	}
}