public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int left =0;
        int right = heights.Length-1;
        while(left<right){
            int width = right-left;
            int height = heights[left]>heights[right]? heights[right]:heights[left];
            int total = width*height;
            if(total > max){
                max = total;
            }

            if(heights[left]>heights[right]){
                right--;
            }
            else{
                left++;
            }

        }
        return max;
    }
}
