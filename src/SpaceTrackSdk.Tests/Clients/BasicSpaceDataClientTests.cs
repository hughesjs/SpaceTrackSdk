using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SpaceTrackSdk.Internal.Auth;
using SpaceTrackSdk.Internal.Clients;
using SpaceTrackSdk.Internal.Clients.HttpMessageHandlers;
using SpaceTrackSdk.Public.Clients;
using SpaceTrackSdk.Public.DataModels.BasicSpaceData;
using SpaceTrackSdk.Public.Options;
using SpaceTrackSdk.Tests.Fixtures;

namespace SpaceTrackSdk.Tests.Clients;

public class BasicSpaceDataClientTests: IClassFixture<ClientTestFixture>
{
	private readonly IBasicSpaceDataClient _client;

	public BasicSpaceDataClientTests(ClientTestFixture clientTestFixture)
	{
		_client = clientTestFixture.ServiceProvider.GetRequiredService<IBasicSpaceDataClient>();
	}

	[Fact]
	public async Task CanFetchSingleAnnouncement()
	{
		Announcement? announcement = await _client.Announcements.Get();

		announcement.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyAnnouncements()
	{
		List<Announcement>? announcements = await _client.Announcements.GetMany("limit/5");

		announcements.ShouldNotBeNull();
		announcements.Count.ShouldBeLessThanOrEqualTo(5);
	}

	[Fact]
	public async Task CanFetchSingleBoxScore()
	{
		BoxScore? boxScore = await _client.BoxScores.Get();

		boxScore.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyBoxScores()
	{
		List<BoxScore>? boxScores = await _client.BoxScores.GetMany("limit/5");

		boxScores.ShouldNotBeNull();
		boxScores.Count.ShouldBe(5);
	}
	
	[Fact]
	public async Task CanFetchSingleConjunction()
	{
		Conjunction? conjunctions = await _client.Conjunctions.Get();

		conjunctions.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyConjunctions()
	{
		List<Conjunction>? conjunctions = await _client.Conjunctions.GetMany("limit/5");

		conjunctions.ShouldNotBeNull();
		conjunctions.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleDecay()
	{
		Decay? decay = await _client.Decays.Get();

		decay.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyDecays()
	{
		List<Decay>? decays = await _client.Decays.GetMany("limit/5");

		decays.ShouldNotBeNull();
		decays.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleGeneralPerturbation()
	{
		GeneralPerturbation? generalPerturbation = await _client.GeneralPerturbations.Get();

		generalPerturbation.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyGeneralPerturbations()
	{
		List<GeneralPerturbation>? generalPerturbations = await _client.GeneralPerturbations.GetMany("limit/5");

		generalPerturbations.ShouldNotBeNull();
		generalPerturbations.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleGeneralPerturbationHistory()
	{
		GeneralPerturbation? generalPerturbationHistory = await _client.GeneralPerturbationHistory.Get("NORAD_CAT_ID/25544");

		generalPerturbationHistory.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyGeneralPerturbationHistory()
	{
		List<GeneralPerturbation>? generalPerturbationHistory = await _client.GeneralPerturbationHistory.GetMany("NORAD_CAT_ID/25544/limit/5"); // This endpoint needs limiting

		generalPerturbationHistory.ShouldNotBeNull();
		generalPerturbationHistory.Count.ShouldBe(5);
	}

		[Fact]
	public async Task CanFetchSingleLaunchSite()
	{
		LaunchSite? launchSite = await _client.LaunchSites.Get();

		launchSite.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyLaunchSites()
	{
		List<LaunchSite>? launchSites = await _client.LaunchSites.GetMany("limit/5");

		launchSites.ShouldNotBeNull();
		launchSites.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleSatCatChange()
	{
		SatCatChange? satCatChange = await _client.SatCatChanges.Get();

		satCatChange.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManySatCatChanges()
	{
		List<SatCatChange>? satCatChanges = await _client.SatCatChanges.GetMany("limit/5");

		satCatChanges.ShouldNotBeNull();
		satCatChanges.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleSatCatEntry()
	{
		SatCatEntry? satCatEntry = await _client.SatCatEntries.Get();

		satCatEntry.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManySatCatEntries()
	{
		List<SatCatEntry>? satCatEntries = await _client.SatCatEntries.GetMany("limit/5");

		satCatEntries.ShouldNotBeNull();
		satCatEntries.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleSatCatDebut()
	{
		SatCatEntry? satCatDebut = await _client.SatCatDebuts.Get();

		satCatDebut.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManySatCatDebut()
	{
		List<SatCatEntry>? satCatDebut = await _client.SatCatDebuts.GetMany("limit/5");

		satCatDebut.ShouldNotBeNull();
		satCatDebut.Count.ShouldBe(5);
	}

	[Fact]
	public async Task CanFetchSingleTrackingAndImpactPrediction()
	{
		TrackingAndImpactPrediction? trackingAndImpactPrediction = await _client.TrackingAndImpactPredictions.Get();

		trackingAndImpactPrediction.ShouldNotBeNull();
	}
	
	[Fact]
	public async Task CanFetchManyTrackingAndImpactPredictions()
	{
		List<TrackingAndImpactPrediction>? trackingAndImpactPredictions = await _client.TrackingAndImpactPredictions.GetMany("limit/5");

		trackingAndImpactPredictions.ShouldNotBeNull();
		trackingAndImpactPredictions.Count.ShouldBe(5);
	}

	
}