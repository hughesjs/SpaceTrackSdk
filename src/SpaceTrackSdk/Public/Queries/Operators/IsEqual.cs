namespace SpaceTrackSdk.Public.Queries.Operators;

public class IsEqual<T> : Operator<T?>
{
	public IsEqual(T? value) : base(value) { }

	protected override string Opcode => string.Empty;
}