public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int longest = 0;
        var dict = new HashSet<char>();
        for (int right = 0; right < s.Length; right++) {
            while (dict.Contains(s[right])) {
                dict.Remove(s[left]);
                left++;
            }
            dict.Add(s[right]);
            int curr = right - left+1;
            longest = Math.Max(longest, curr);
        }
        return longest;
    }
}
