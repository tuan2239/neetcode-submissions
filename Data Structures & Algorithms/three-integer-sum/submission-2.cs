public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right) {
                var total = nums[i] + nums[left] + nums[right];
                if (total > 0) {
                    right--;
                }
                if (total < 0) {
                    left++;
                }
                if (total == 0) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                                           while (left < right && nums[left] == nums[left - 1])
                       {
                           left++;
                       }

                       while (left < right && nums[right] == nums[right + 1])
                       {
                           right--;
                       }
                }
            }
        }
        return result;
    }
}
