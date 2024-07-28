namespace Reminder.Subscriptions.CatalogRemindMessageSubscribe;

public record CatalogRemindMessage
    (Guid UserId,
    string Slug,
    string Message,
    NotifyChannel Channel);

[Flags]
public enum NotifyChannel
{
    SMS = 0,
    Email = 1,
    MSTeams = 2,
    Telegram = 3
}
