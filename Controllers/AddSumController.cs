using TwoToFour.Services.AddSum;
using Microsoft.AspNetCore.Mvc;

namespace TwoToFour.Controllers;
[ApiController]
[Route("API")]
public class AddSumController : ControllerBase
{
    private readonly IAddSumService _addSum;

    public AddSumController(IAddSumService addSum)
    {
        _addSum = addSum;
    }
    [HttpGet]
    [Route("AddSum")]
    public int AdditionSum(int numOne, int numTwo)
    {
        return _addSum.AdditionSum(numOne, numTwo);
    }
}