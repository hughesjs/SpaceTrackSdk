using SpaceTrackSdk.Public.Queries.Operators;

namespace SpaceTrackSdk.Public.Queries.Predicates;

public class FieldPredicate<T>: Predicate<Operator<T>>
{
	public FieldPredicate(string fieldName, Operator<T> value) : base(value)
	{
		Key = fieldName;
	}

	protected override string Key { get; }

	public override string GetQueryString() => $"{Key}/{Value.GetQueryString()}";
}