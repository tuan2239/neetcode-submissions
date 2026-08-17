public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>(nums);
        int max =0;
        for(int i=0; i<nums.Length;i++){
            if(!hs.Contains(nums[i]-1)){

                int num=nums[i];
                int count=0;
                while(hs.Contains(num)){
                    count++;
                    num++;
                }
                max = Math.Max(max, count);
            }
        }

        return max;
    }
}
