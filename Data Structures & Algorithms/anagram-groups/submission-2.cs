public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        List<List<string>> ls = new List<List<string>>();

        foreach(var data in strs){
            int[] arr =new int[26];
            foreach(char ch in data){
                arr[ch-'a']++;
            }
            var key = string.Join(',',arr);
            if(!dict.ContainsKey(key)){
                dict.Add(key, new List<string>(){data} ) ;
            }
            else{
                dict[key].Add(data);
            }
        }
        return dict.Values.ToList();;
    }
}
