using TwoToFour.Services.CompareNums;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour.Controllers;
[ApiController]
[Route("API")]
public class CompareNumsController : ControllerBase
{
    private readonly ICompareNumsService _compareNums;

    public CompareNumsController(ICompareNumsService compareNums)
    {
        _compareNums = compareNums;
    }
    [HttpGet]
    [Route("CompareNums")]
    public string CompareNums(int numOne, int numTwo)
    {
        return _compareNums.NumCompare(numOne, numTwo);
    }
}
