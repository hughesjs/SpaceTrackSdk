using SpaceTrackSdk.Public.Clients;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Internal.Clients;

internal class BasicSpaceDataClient: IBasicSpaceDataClient
{
	public const string BasicSpaceDataEndpoint = "/basicspacedata/query/class/";
	public BasicSpaceDataClient(HttpClient client) {
		Announcements = new HttpClientAdapter<Announcement>(client, $"{BasicSpaceDataEndpoint}announcement");
		BoxScores = new HttpClientAdapter<BoxScore>(client, $"{BasicSpaceDataEndpoint}boxscore");
		Conjunctions = new HttpClientAdapter<Conjunction>(client, $"{BasicSpaceDataEndpoint}cdm_public");
		Decays = new HttpClientAdapter<Decay>(client, $"{BasicSpaceDataEndpoint}decay");
		GeneralPerturbations = new HttpClientAdapter<GeneralPerturbation>(client, $"{BasicSpaceDataEndpoint}gp");
		GeneralPerturbationHistory = new HttpClientAdapter<GeneralPerturbation>(client, $"{BasicSpaceDataEndpoint}gp_history");
		LaunchSites = new HttpClientAdapter<LaunchSite>(client, $"{BasicSpaceDataEndpoint}launch_site");
		SatCatChanges = new HttpClientAdapter<SatCatChange>(client, $"{BasicSpaceDataEndpoint}satcat_change");
		SatCatEntries = new HttpClientAdapter<SatCatEntry>(client, $"{BasicSpaceDataEndpoint}satcat");
		SatCatDebuts = new HttpClientAdapter<SatCatEntry>(client, $"{BasicSpaceDataEndpoint}satcat_debut");
		TrackingAndImpactPredictions = new HttpClientAdapter<TrackingAndImpactPrediction>(client, $"{BasicSpaceDataEndpoint}tip");
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
	public IClientAdapter<SatCatEntry> SatCatDebuts { get; }
	public IClientAdapter<TrackingAndImpactPrediction> TrackingAndImpactPredictions { get; }
}