public class Solution {
    public int SingleNumber(int[] nums) {
        var myDict = new Dictionary<int, int>();
        foreach(int i in nums){
            if(myDict.ContainsKey(i)){
                myDict[i]++;
            }
            else{
                myDict.Add(i,1);
            }
        }
        return myDict.FirstOrDefault(x => x.Value == 1).Key;;
    }
}