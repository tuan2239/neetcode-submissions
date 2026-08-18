public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var arr = new int[nums.Length];
        int left =1;
        for(int i=0; i< nums.Length;i++){
            arr[i] = left;
            left = left * nums[i];
        }


        int right =1;
        for(int i=nums.Length-1; i>=0 ;i--){
            arr[i] = arr[i]*right;
            right = right * nums[i];
        }
        return arr;
    }
}
