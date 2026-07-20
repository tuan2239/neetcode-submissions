public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int left = 0;
        int right = heights.Length - 1;
        while (left < right) {
            int width = right - left;
            int height = heights[right] > heights[left] ? heights[left] : heights[right];
            int total = width * height;
            if (total > max) {
                max = total;
            }
            if (heights[right] > heights[left]) {
                left++;
            }
            else {
                right--;
            }
        }
        return max;
    }
}
