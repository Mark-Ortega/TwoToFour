namespace TwoToFour.Services.WakeUpTime;

public class WakeUpTimeService : IWakeUpTimeService
{
    public string WakeUpTime(string name, string time)
    {
        return $"your name is {name} and you woke up at {time}.";
    }
}
