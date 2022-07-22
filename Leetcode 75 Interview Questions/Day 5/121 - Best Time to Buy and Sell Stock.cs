public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0, right = 1;
        int max = 0; 
        
        while(right<prices.Length){
            int profit = prices[right]-prices[left];
            if(prices[left]>prices[right]){
                left = right;
            }
            else{
                if(profit>max) max = profit;
            }                
            right++;
        }
        return max;
    }
}