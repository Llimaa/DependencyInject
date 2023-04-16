namespace DependencyInject.Services;

public class DateService : IDateService
{
    private readonly DateTime _date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, new Random().Next(1,30));

    public DateTime GetNewDate() => _date;
}
