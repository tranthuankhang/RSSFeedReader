using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Tests;

public class SubscriptionServiceTests
{
    [Fact]
    public void Add_StoresSubscription_WhenFeedUrlIsProvided()
    {
        var service = new SubscriptionService();

        var subscription = service.Add("https://example.com/feed");

        Assert.Equal("https://example.com/feed", subscription.FeedUrl);
        Assert.Single(service.GetAll());
    }

    [Fact]
    public void Add_Throws_WhenFeedUrlIsBlank()
    {
        var service = new SubscriptionService();

        Assert.Throws<ArgumentException>(() => service.Add("   "));
    }
}
