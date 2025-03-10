public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int, int>();
        int i=0;
        foreach(int num in nums){
            var x=target-num;
            if(map.ContainsKey(x)){
                return new int[] {i, map[x]};
            }
            else{
                map[num] = i++;
            }
        }
        return new int[] {-1,-1};
    }
}