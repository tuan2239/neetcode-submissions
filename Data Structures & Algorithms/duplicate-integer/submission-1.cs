public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        foreach(var data in nums){
            if(!hs.Add(data)){
                return true;
            }
        }
        return false;
    }
}