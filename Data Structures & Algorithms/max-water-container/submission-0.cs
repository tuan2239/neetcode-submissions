public class Solution {
    public int MaxArea(int[] heights) {
        int left=0;
        int right = heights.Length-1;
        int max =0;
        while(left < right){
            int width = right - left;
            int height = heights[right] > heights[left] ? heights[left] :  heights[right];
            int total = width*height;

            if(max < total){
                max = total;
            }
            if(heights[right] > heights[left]){
                left++;
            }
            else{
                right--;
            }
        }
        return max;
    }
}
