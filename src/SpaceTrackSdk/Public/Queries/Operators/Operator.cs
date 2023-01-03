namespace SpaceTrackSdk.Public.Queries.Operators;

public abstract class Operator<T>: IQueryComponent
{
	protected T Value { get; }

	protected abstract string Opcode { get; }
	protected Operator(T value)
	{
		Value = value;
	}

	public virtual string GetQueryString() => $"{Opcode}{Value?.ToString() ?? "null-val"}";

}