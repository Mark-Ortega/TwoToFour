using TwoToFour.Services.WakeUpTime;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour.Controllers;
[ApiController]
[Route("API")]
public class WakeUpTimeController : ControllerBase
{
    private readonly IWakeUpTimeService _wakeUpTime;

    public WakeUpTimeController(IWakeUpTimeService wakeUpTime)
    {
        _wakeUpTime = wakeUpTime;
    }
    [HttpGet]
    [Route("WakeUpTime")]
    public string SentenceMaker(string name, string time){
        return _wakeUpTime.WakeUpTime(name, time);
    }
}