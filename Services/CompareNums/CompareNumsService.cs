namespace TwoToFour.Services.CompareNums;
public class CompareNumsService : ICompareNumsService
{
    public string NumCompare(int numOne, int numTwo)
    {
        string part1;
        string part2;
        if (numOne < numTwo)
        {
            part1 = $"{numOne} is less than {numTwo}";
        }
        else if (numOne > numTwo)
        {
            part1 = $"{numOne} is greater than {numTwo}";
        }
        else if (numOne == numTwo)
        {
            part1 = $"{numOne} is equal to {numTwo}";
        }
        else
        {
            return "Either you got here through some weird glitch or this thing is broken";
        }

        if (numTwo < numOne)
        {
            part2 = $"{numTwo} is less than {numOne}";
        }
        else if (numTwo > numOne)
        {
            part2 = $"{numTwo} is greater than {numOne}";
        }
        else if (numTwo == numOne)
        {
            part2 = $"{numTwo} is equal to {numOne}";
        }
        else
        {
            return "Either you got here through some weird glitch or this thing is broken";
        }
        return $"{part1}, and {part2}.";

    }
}