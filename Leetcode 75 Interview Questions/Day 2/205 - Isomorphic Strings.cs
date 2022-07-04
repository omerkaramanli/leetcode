public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length) return false;
        Dictionary<char, char> str = new Dictionary<char, char>();
        for(int i = 0; i<t.Length; i++){
            //Console.WriteLine($"{str.ContainsKey(s[i])}\t{s[i]}:{t[i]}");
            if(!str.ContainsKey(s[i]) && !str.ContainsValue(t[i]))
                    str.Add(s[i], t[i]);
            
        }
        var tmpStr = "";
        try{
            for(int i = 0; i<s.Length; i++){
                tmpStr += str[s[i]];
                //Console.WriteLine($"{s[i]}:{str[s[i]]}\t {tmpStr}");
            }
        }
        catch(Exception ex){
            return false;
        }
        
        if(tmpStr.Equals(t)) return true;
        
        
        return false;
        
    }
}