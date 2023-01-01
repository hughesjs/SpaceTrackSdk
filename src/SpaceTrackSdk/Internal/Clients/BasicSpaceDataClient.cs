using SpaceTrackSdk.Public.Clients;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Internal.Clients;

internal class BasicSpaceDataClient: IBasicSpaceDataClient
{
	public const string BasicSpaceDataEndpoint = "/basicspacedata";
	private const string ClassQueryPrefix = "/class/query";
	public BasicSpaceDataClient(HttpClient client)
	{
		Announcements = new HttpClientAdapter<Announcement>(client, $"{ClassQueryPrefix}/announcement");
		BoxScores = new HttpClientAdapter<BoxScore>(client, $"{ClassQueryPrefix}/boxscore");
		Conjunctions = new HttpClientAdapter<Conjunction>(client, $"{ClassQueryPrefix}/cdm_public");
		Decays = new HttpClientAdapter<Decay>(client, $"{ClassQueryPrefix}/decay");
		GeneralPerturbations = new HttpClientAdapter<GeneralPerturbation>(client, $"{ClassQueryPrefix}/gp");
		GeneralPerturbationHistory = new HttpClientAdapter<GeneralPerturbation>(client, $"{ClassQueryPrefix}/gp_history");
		LaunchSites = new HttpClientAdapter<LaunchSite>(client, $"{ClassQueryPrefix}/launch_site");
		SatCatChanges = new HttpClientAdapter<SatCatChange>(client, $"{ClassQueryPrefix}/satcat_change");
		SatCatEntries = new HttpClientAdapter<SatCatEntry>(client, $"{ClassQueryPrefix}/satcat");
		SatCatDebut = new HttpClientAdapter<SatCatEntry>(client, $"{ClassQueryPrefix}/satcat_debut");
		TrackingAndImpactPredictions = new HttpClientAdapter<TrackingAndImpactPrediction>(client, $"{ClassQueryPrefix}/tip");
	}

	public IClientAdapter<Announcement> Announcements { get; }
	public IClientAdapter<BoxScore> BoxScores { get; }
	public IClientAdapter<Conjunction> Conjunctions { get; }
	public IClientAdapter<Decay> Decays { get; }
	public IClientAdapter<GeneralPerturbation> GeneralPerturbations { get; }
	public IClientAdapter<GeneralPerturbation> GeneralPerturbationHistory { get; }
	public IClientAdapter<LaunchSite> LaunchSites { get; }
	public IClientAdapter<SatCatChange> SatCatChanges { get; }
	public IClientAdapter<SatCatEntry> SatCatEntries { get; }
	public IClientAdapter<SatCatEntry> SatCatDebut { get; }
	public IClientAdapter<TrackingAndImpactPrediction> TrackingAndImpactPredictions { get; }
}