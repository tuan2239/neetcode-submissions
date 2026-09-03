public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var list = new List<List<int>>();
        Array.Sort(nums);
        for(int i=0; i <= nums.Length-1; i++){
            if(i> 0 && nums[i] ==nums[i-1]){
                continue;
            }
            int left = i+1;
            int right = nums.Length -1;
            while(left < right){
                int total =nums[i]+ nums[left] + nums[right];
                if(total ==0){
                 
                    list.Add( new List<int>{nums[i], nums[left], nums[right]});
                    right--;
                    left++;
                    while(left < right && nums[left] == nums[left-1]){
                        left++;
                    }
                     while(left < right && nums[right] == nums[right+1]){
                        right--;
                    }
                }
                else if(total > 0){
                        right--;
                }
                else{
                    left++;
                }
            }
        }
        return list;
    }
}
