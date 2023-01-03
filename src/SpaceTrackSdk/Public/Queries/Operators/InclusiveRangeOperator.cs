using JetBrains.Annotations;
using SpaceTrackSdk.Public.Exceptions;

namespace SpaceTrackSdk.Public.Queries.Operators;

[UsedImplicitly]
public class InclusiveRangeOperator<TStart, TEnd>: Operator<TStart>
{
	private readonly TEnd _to;

	public InclusiveRangeOperator(TStart from, TEnd to) : base(from)
	{
		_to = to;
	}

	public override string Opcode => "--";

	public override string GetQueryString()
	{
		IQueryComponent? startComponent = Value as IQueryComponent;
		IQueryComponent? endComponent = _to as IQueryComponent;

		string? fromValue = startComponent?.GetQueryString();
		string? toValue = endComponent?.GetQueryString();
		
		if (Value is DateTime fromDate)
		{
			fromValue = fromDate.ToString(DateFormat);
		}
		
		if (_to is DateTime toDate)
		{
			toValue = toDate.ToString(DateFormat);
		}

		string start = fromValue ?? Value?.ToString() ?? throw new SpaceTrackSdkException("Start value on range operator not set correctly");
		string end = toValue ?? _to?.ToString() ?? throw new SpaceTrackSdkException("End value on range operator not set correctly");
		
		return $"{start}--{end}";
	}
}