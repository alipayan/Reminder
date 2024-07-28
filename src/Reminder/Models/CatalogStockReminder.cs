using MongoDB.Bson;
using MongoDB.EntityFrameworkCore;
using Reminder.Subscriptions.CatalogRemindMessageSubscribe;

namespace Reminder.Models;

[Collection("catalogstockreminders")]
public class CatalogStockReminder
{
    public ObjectId Id { get; set; }

    public required string Message { get; set; }

    public Guid UserId { get; set; }

    public required string Slug { get; set; }

    public required NotifyChannel NotifyChannel { get; set; }

}
