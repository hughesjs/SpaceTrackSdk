using JetBrains.Annotations;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public abstract class Operator<T>: IQueryOperator
{
	protected const string DateFormat = "yy-MM-dd HH:mm:ss";
	protected T Value { get; }

	public abstract string Opcode { get; }
	protected Operator(T value)
	{
		Value = value;
	}

	public virtual string GetQueryString()
	{
		IQueryOperator? component = Value as IQueryOperator;

		string? value = Value.ToString();
		if (component is not null)
		{
			value = component.GetQueryString();
		}

		if (Value is DateTime date)
		{
			value = date.ToString(DateFormat);
		}
		

		return $"{Opcode}{value ?? "null-val"}";
	}
}