public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dict = new Dictionary<int, int>();

        for(int i=0;i<nums.Length;i++){
            int need = target - nums[i];
            if(dict.ContainsKey(need)){
                return new int[]{dict[need], i};
            }
            else{
                dict.Add(nums[i], i);
            }
        }
        return [];
    }
}
