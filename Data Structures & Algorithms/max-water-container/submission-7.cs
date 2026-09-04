public class Solution {
    public int MaxArea(int[] heights) {
        int left =0;
        int right = heights.Length-1;
        int maxWater = 0;
        while(left < right){
            int height = Math.Min(heights[left], heights[right]);
            int width = right  - left;
            int water = height*width;
            maxWater = Math.Max(maxWater, water);
            if(heights[left] >= heights[right]){
                right--;
            }
            else{
                left++;
            }
        }
return maxWater;
    }
}
