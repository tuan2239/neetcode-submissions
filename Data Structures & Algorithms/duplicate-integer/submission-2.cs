public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hs = new HashSet<int>();
        foreach(var data in nums){
            if(hs.Contains(data)){
                return true;
            }
            else{
                hs.Add(data);
            }
        }
        return false;
    }
}