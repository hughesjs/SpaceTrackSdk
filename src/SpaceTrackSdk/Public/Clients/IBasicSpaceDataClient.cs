using SpaceTrackSdk.Public.DataModels.BasicSpaceData;

namespace SpaceTrackSdk.Public.Clients;

public interface IBasicSpaceDataClient
{
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