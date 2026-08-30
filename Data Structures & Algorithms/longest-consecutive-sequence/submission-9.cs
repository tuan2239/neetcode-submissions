public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hs  = new HashSet<int>(nums);
        int max =0;
        foreach(var data in nums){
            if(!hs.Contains(data-1)){
                int num = data;
                int count =1;
                while(hs.Contains(num+1)){
                    num++;
                    count++;
                }
                max = Math.Max(max, count);
            }
        }
        return max;
    }
}
