public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var data in strs){
            int[] arr = new int[26];
            foreach(var ch in data){
                arr[ch-'a']++;
            } 
            var key = string.Join(",", arr);
            if(dict.ContainsKey(key)){
                dict[key].Add(data);
            }
            else{
                dict[key] = new List<string>(){data};
            }
        }
        return dict.Values.ToList();
    }
}
