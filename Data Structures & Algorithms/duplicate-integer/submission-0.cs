public class Solution {
    public bool hasDuplicate(int[] nums) {
        // Array.Sort(nums);
        // for (int i=0; i < nums.Length-1; i++){
        //     int j = i+1;
        //     if(nums[i]==nums[j]){
        //         return true;
        //     }
        // }
        // return false;
        HashSet<int> set = new HashSet<int>();
        
        foreach(int num in nums){
            if(!set.Add(num)){
                return true;
            }
        }
        return false;
    }
}