using Reminder.Infrastructure;

namespace Reminder.Extensions;

public static class WebApplication‌BuilderExtenstions
{
    public static void BrokerConfig(this IHostApplicationBuilder builder)
    {

    }
    public static void ConfigureDbContext(this IHostApplicationBuilder builder)
    {
        //add from shortener of nabi

        var setting = builder.Configuration.Get<RemindOptions>();
        builder.Services.AddDbContext<ReminderDbContext>(options =>
        {

        });
    }
}
