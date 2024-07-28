using MassTransit;
using Reminder.Infrastructure;

namespace Reminder.Subscriptions.CatalogRemindMessageSubscribe;

public class CatalogStockAvailableEventConsumer(ReminderDbContext dbContext) : IConsumer<CatalogItemStockAvailableEvent>
{
    private readonly ReminderDbContext _dbContext = dbContext;
    public async Task Consume(ConsumeContext<CatalogItemStockAvailableEvent> context)
    {
        //var reminder = await _dbContext.CatalogStockReminders
        //    .Where(x => context.Message.Slugs.Contains(x.Slug))
        //    .Select(x => new BatchNotifyItme
        //    {
        //        Channel = x.NotifyChannel,
        //        Message = x.Message,
        //        UserId = x.UserId
        //    }).ToListAsync();










    }
}
