namespace SpaceTrackSdk.Public.Exceptions;

public class SpaceTrackSdkException: Exception
{
	public SpaceTrackSdkException()
	{
	}

	public SpaceTrackSdkException(string? message) : base(message)
	{
	}

	public SpaceTrackSdkException(string? message, Exception? innerException) : base(message, innerException)
	{
	}
}