namespace TestProject1;

public class UnitTest1
{
    private Solution _solution;
    [Fact]
    public void Test1()
    {
        _solution = new Solution();
        string[] strs = new string[] { "flower", "flow", "flight" };
        string expected = "fl";
        string actual = _solution.LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        _solution = new Solution();
        string[] strs = new string[] { "dog", "racecar", "car" };
        string expected = "";
        string actual = _solution.LongestCommonPrefix(strs);
        Assert.Equal(expected, actual);
    }
}