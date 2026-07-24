public class Solution {
// nums=[-1,0,2,4,6,8]
// target=4
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right){
            int mid = left + (right - left) / 2; //2
            if (nums[mid] == target) {
                return mid;
            }

            if (nums[mid] > target) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return -1;
    }
}
