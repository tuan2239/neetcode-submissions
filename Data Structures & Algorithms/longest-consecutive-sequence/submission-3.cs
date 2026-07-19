public class Solution {
    public int LongestConsecutive(int[] nums) {
        int max = 0;
        HashSet<int> hs = new HashSet<int>(nums);
        foreach(var data in nums){
            
            if(!hs.Contains(data-1)){
                int current = data;
                int length = 1;
                while(hs.Contains(current+1)){
                    length++;
                    current++;
                }
                max = max > length ? max : length;
            }
        }

        return max;

    }
}
