public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max =0;
        int left =0;
        var hs = new HashSet<char>();
        for(int right =0;right < s.Length; right++){
            if(!hs.Contains(s[right])){
                int len = right - left + 1;
                max = Math.Max(len, max);
            }
            else{
                while(hs.Contains(s[right])){
                    hs.Remove(s[left]);
                    left++;
                }
            }
            hs.Add(s[right]);
        }
        return max;
    }
}
