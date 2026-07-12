public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] n = new int[26];
            foreach(char ch in str){                
                n[ch - 'a']++;
            }
            string key = string.Join(",",n);

            if(dict.ContainsKey(key)){
                dict[key].Add(str);
            }
            else{
                dict.Add(key, new List<string>(){str});
            }
        }
        return dict.Values.ToList();
    }
}
