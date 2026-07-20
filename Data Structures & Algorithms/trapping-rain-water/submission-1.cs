public class Solution {
    public int Trap(int[] height) {
        int water = 0;
        int left = 0;
        int right = height.Length - 1;
        int maxL = 0;
        int maxR = 0;

        while (left < right) {
            maxL = maxL > height[left] ? maxL : height[left];
            maxR = maxR > height[right] ? maxR : height[right];

            if (maxL < maxR) {
                water += maxL - height[left];
                left++;

            } else {
                water += maxR - height[right];
                right--;
            }
        }
        return water;
    }
}
