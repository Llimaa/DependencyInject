using DependencyInject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInject.Controllers;

[ApiController]
[Route("[controller]")]
public class DependencyInjectController: ControllerBase 
{
    private readonly IDateService _dateService;
    private readonly Date02Service _date02Service;

    public DependencyInjectController(IDateService dateService, Date02Service date02Service)
    {
        _dateService = dateService;
        _date02Service = date02Service;
    }

    [HttpGet]
    public IActionResult Get() 
    {
        var result = new List<DateTime>();
            result.Add(_dateService.GetNewDate());
            result.Add(_date02Service.GetNewDate());
        return Ok(result);
    }
}