public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int prelix = 1;
        for(int i =0; i< nums.Length; i++){
            result[i] = prelix;
            prelix = prelix*nums[i];
        }
        int suflix = 1;
        for(int i =nums.Length-1; i>=0 ; i--){
            result[i] *= suflix;
            suflix = suflix*nums[i];
        }
        return result;
    }
}
