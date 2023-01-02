namespace SpaceTrackSdk.Public.Queries.Operators;

public class NotEqual<T>: Operator<T?>
{
	public NotEqual(T? value) : base(value) { }

	protected override string Opcode => "<>";
}