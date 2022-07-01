public class Solution {
    public uint reverseBits(uint n) {
        string s = Convert.ToString(n, 2);
        s = new string('0',32-s.Length)+s;
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );        
        return Convert.ToUInt32(new string( charArray ),2);
    }
}