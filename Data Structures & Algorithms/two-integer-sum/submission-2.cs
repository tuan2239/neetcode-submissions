public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int, int> hs = new Dictionary<int,int>();
       for(int i=0; i< nums.Length; i++){
        int need= target -nums[i];
        if(hs.ContainsKey(need)){
            return new int[]{hs[need], i};
        }
        else{
            hs.Add(nums[i], i);
        }
       }
       return [];
    }
}
