public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(var data in strs){
            int[] arr =new int[26];
            foreach(var ch in data){
                arr[ch-'a']++;
            }
            var key = string.Join(',',arr);
if(dict.ContainsKey(key)){
    dict[key].Add(data);
}
else{
    dict.Add(key, new List<string>{data});
}
        }
        return dict.Values.ToList();
    }
}
