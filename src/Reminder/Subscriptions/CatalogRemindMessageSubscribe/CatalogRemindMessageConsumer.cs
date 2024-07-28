using MassTransit;
using Reminder.Infrastructure;

namespace Reminder.Subscriptions.CatalogRemindMessageSubscribe;

public class CatalogRemindMessageConsumer(ReminderDbContext context) : IConsumer<CatalogRemindMessage>
{
    private readonly ReminderDbContext _dbContext = context;
    public async Task Consume(ConsumeContext<CatalogRemindMessage> context)
    {
        _dbContext.CatalogStockReminders.Add(new Models.CatalogStockReminder
        {
            Message = context.Message.Message,
            Slug = context.Message.Slug,
            NotifyChannel = context.Message.Channel,
            UserId = context.Message.UserId
        });

        await _dbContext.SaveChangesAsync();
    }
}
