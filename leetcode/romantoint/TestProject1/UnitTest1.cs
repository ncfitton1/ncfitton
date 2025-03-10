namespace TestProject1;

public class UnitTest1
{
    private Solution solution = new Solution();

    [Fact]
    public void Test1()
    {
        var result = solution.RomanToInt("III");
        Assert.Equal(3, result);
    }

   [Fact]
    public void Test2()
    {
        var result = solution.RomanToInt("LVIII");
        Assert.Equal(58, result);
    }

   [Fact]
    public void Test3()
    {
        var result = solution.RomanToInt("MCMXCIV");
        Assert.Equal(1994, result);
    }
}