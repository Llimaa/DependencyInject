namespace DependencyInject.Services;

public class Date02Service : IDateService
{
    private readonly IDateService _dateService;

    public Date02Service(IDateService dateService) =>
        (_dateService) = (dateService);

    public DateTime GetNewDate() => _dateService.GetNewDate();
}
