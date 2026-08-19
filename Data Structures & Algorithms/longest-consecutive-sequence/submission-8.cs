public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hs= new HashSet<int>(nums);
        int max =0;
        foreach(var num in hs){
            if(!hs.Contains(num-1)){
                int count=1;
                int cur=num;
                while(hs.Contains(cur+1)){
                    count++;
                    cur++;
                }
                max = Math.Max(max, count);
            }
        }
        return max;
    }
}
