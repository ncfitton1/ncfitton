using Xunit;
namespace TestProject1;

public class UnitTest1
{
    private Solution solution = new Solution();

    [Fact]
    public void Test1()
    {
        int[] nums = {2,4,7,3,6};
        int target = 7;
        int[] expected = {3,1};
        var actual = solution.TwoSum(nums, target);
        Assert.Equal(expected, actual);
        Console.WriteLine();
    }
}