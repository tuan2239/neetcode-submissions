public class Solution {
            public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int n = target - nums[i];
                if (dict.ContainsKey(n))
                {
                    return new int[] { dict[n], i};
                }
                dict.Add(nums[i], i);
            }

            return [];
        }
}
