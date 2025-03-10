namespace palindrome;

public class UnitTest1
{
    private Solution solution = new Solution();

    [Fact]
    public void Test1()
    {
        int input = 121;
        bool expected = true;
        bool actual = solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        int input = -121;
        bool expected = false;
        bool actual = solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        int input = 12021;
        bool expected = true;
        bool actual = solution.IsPalindrome(input);
        Assert.Equal(expected, actual);
    }
}