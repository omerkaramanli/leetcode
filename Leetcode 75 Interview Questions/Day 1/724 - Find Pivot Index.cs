public class Solution {
    public int PivotIndex(int[] nums) {
        int sumLeft = 0, sumRight = nums.Sum();
        for(int i = 0; i<nums.Length; i++){
            sumRight -= nums[i];
            if(sumRight == sumLeft) return i;
            sumLeft += nums[i];
        }
        
        return -1;
        
    }
}