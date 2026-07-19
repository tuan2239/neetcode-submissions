public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int maxProfit = 0;
        for(int right =1; right < prices.Length; right++){
            int profit =0;
            if(prices[right] > prices[left]){
                profit = prices[right] - prices[left];
            }else{
                left= right;
            }
            if(maxProfit < profit){
                maxProfit = profit;
            }
        }   
        return maxProfit;
    }
}
