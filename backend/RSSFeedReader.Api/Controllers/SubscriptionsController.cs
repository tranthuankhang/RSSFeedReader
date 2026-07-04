using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionService _subscriptionService;

    public SubscriptionsController(SubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<Subscription>> Get() => Ok(_subscriptionService.GetAll());

    [HttpPost]
    public ActionResult<Subscription> Post([FromBody] CreateSubscriptionRequest request)
    {
        if (request is null || string.IsNullOrWhiteSpace(request.FeedUrl))
        {
            return BadRequest("Feed URL is required.");
        }

        var subscription = _subscriptionService.Add(request.FeedUrl);
        return Ok(subscription);
    }
}

public class CreateSubscriptionRequest
{
    public string? FeedUrl { get; set; }
}
