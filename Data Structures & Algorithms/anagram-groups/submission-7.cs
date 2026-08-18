public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict  = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            var arr  = new int[26];
            foreach(var ch in str){
                arr[ch-'a']++;
            }
            var key = string.Join(",", arr).ToString();
            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>(){str};
            }
            else{
                dict[key].Add(str);
            }
        }
        return dict.Values.ToList();
    }
}
