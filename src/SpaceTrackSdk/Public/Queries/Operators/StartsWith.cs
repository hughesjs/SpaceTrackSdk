using SpaceTrackSdk.Public.Exceptions;

namespace SpaceTrackSdk.Public.Queries.Operators;

public class StartsWith<T>: Operator<T>
{
	public StartsWith(T value) : base(value) { }

	protected override string Opcode => "^";

	public override string GetQueryString()
	{
		if (Value is null || Value?.ToString()?.Length >= 2)
		{
			throw new SpaceTrackSdkException("Starts with predicate requires at least 2 characters");
		}
		return base.GetQueryString();
	}
}