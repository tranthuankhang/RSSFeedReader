using RSSFeedReader.Api.Models;

namespace RSSFeedReader.Api.Services;

public class SubscriptionService
{
    private readonly List<Subscription> _subscriptions = [];

    public IReadOnlyList<Subscription> GetAll() => _subscriptions;

    public Subscription Add(string feedUrl)
    {
        if (string.IsNullOrWhiteSpace(feedUrl))
        {
            throw new ArgumentException("Feed URL is required.", nameof(feedUrl));
        }

        var cleanedUrl = feedUrl.Trim();
        var subscription = new Subscription { FeedUrl = cleanedUrl };
        _subscriptions.Add(subscription);
        return subscription;
    }
}
