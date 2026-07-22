public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int left = 0;
        int right = heights.Length - 1;
        while (left < right) {
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);
            int total = width * height;
            if (heights[left] > heights[right]) {
                right--;
            } else if (heights[left] < heights[right]) {
                left++;
            }
            else{
                left++;
                right--;
            }

            max = Math.Max(max, total);
        }
        return max;
    }
}
