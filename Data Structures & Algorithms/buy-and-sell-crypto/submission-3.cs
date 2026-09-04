public class Solution {
    public int MaxProfit(int[] prices) {
        int left =0;
        int right = left+1;
        int max =0;
        if(prices.Length <= 0){
            return 0;
        }
        while (right < prices.Length){
            max = Math.Max(max, prices[right] - prices[left]);
            if(prices[right] < prices[left]){
                left = right;
            }
            right++;

        }
        return max;
    }
}
