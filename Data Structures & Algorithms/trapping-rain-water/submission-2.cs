public class Solution {
    public int Trap(int[] height) {
        int water =0;
        int left=0;
        int right=height.Length -1;
        int maxleft=0;
        int maxRight =0;

        while(left < right){
            if(height[left] < height[right]){
                maxleft = Math.Max(maxleft, height[left]);
                water +=  maxleft - height[left];
                left++;
            }
            else{
                maxRight = Math.Max(maxRight, height[right]);
                water +=  maxRight - height[right];
                right--;
            }


        }
        return water;
    }
}
