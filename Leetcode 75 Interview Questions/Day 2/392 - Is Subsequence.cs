public class Solution {
    public bool IsSubsequence(string s, string t) {
        foreach(char ch in s){
            int i = t.IndexOf(ch);
            if(i==-1)return false;
            t = t.Substring(i+1);
        }
        return true;
    }
}