namespace SpaceTrackSdk.Public.Queries.Operators;

public interface IQueryOperator : IQueryComponent
{
	public string Opcode { get; }
}