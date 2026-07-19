public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest =0;
        HashSet<char> hs = new HashSet<char>();
        int left =0;
        for(int right=0;right < s.Length; right++){
            while(hs.Contains(s[right])){
                hs.Remove(s[left]);
                left++;
            }
            hs.Add(s[right]);
            int count = right-left+1;
            longest = longest > count ? longest : count;
        }
        return longest;
    }
}
