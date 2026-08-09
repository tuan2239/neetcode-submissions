public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int need =0;
        var dict = new Dictionary<int, int>();
        for(int i =0; i < nums.Length;i++){
            need = target-nums[i];
            if(dict.ContainsKey(need)){
                return [dict[need], i];
            }
            else{
                dict[nums[i]]= i;
            }
        }
        return [];
    }
}
