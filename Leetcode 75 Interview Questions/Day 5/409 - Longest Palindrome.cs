public class Solution {
    public int LongestPalindrome(string s) {
        var freq = s.GroupBy(x=> x)
                        .Select(x=>new {Character = x.Key, Count = x.Count()})
                        .OrderByDescending(x=> x.Count);
        bool longestOdd = false;
        int count = 0;
        foreach(var fr in freq){
            Console.WriteLine($"{fr.Character}:{fr.Count}");
            if(!longestOdd && fr.Count%2==1){
                longestOdd = true;
                count+=fr.Count;
            }
            
            else
                count+=fr.Count%2==0?fr.Count:fr.Count-1;
            
        }
        
        return count;
        
    }
}