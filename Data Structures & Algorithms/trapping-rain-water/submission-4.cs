public class Solution {
    public int Trap(int[] height) {
        int left =0; 
        int maxLeft=0;
        int right =height.Length-1;
        int maxRight=0;
        int maxWater =0;

        while(left < right){
            maxLeft = Math.Max(maxLeft, height[left]);
            maxRight = Math.Max(maxRight, height[right]);
            maxWater += maxLeft - height[left] + maxRight- height[right];

            if(height[left] <= height[right]){
                left++;
            }
            else{
                right--;
            }

        }
        return maxWater;

    }
}
