public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hs = new HashSet<char>();
        int longest = 0;
        int left = 0;
        for (int right = 0; right < s.Length; right++) {
            if (!hs.Contains(s[right])) {
                hs.Add(s[right]);
            } 
            else {
                while (hs.Contains(s[right])) {
                    hs.Remove(s[left]);
                    left++;
                }
            }
             hs.Add(s[right]);
            longest = Math.Max(longest, right - left + 1);
            // Console.WriteLine("length = {0}", right - left + 1);
        }
        return longest;
    }
}
