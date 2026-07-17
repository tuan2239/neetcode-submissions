public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int count=0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == val){
                count++;
            }
            else if(count>0){
                nums[i-count] = nums[i];
                k++;
            }
            else{
                k++;
            }
        }
        return k;
    }
}