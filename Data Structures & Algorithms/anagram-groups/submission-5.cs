public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string> >();
        foreach(var str in strs){
            var arr = new int[26];
            foreach(var data in str){
                arr[data-'a']++;
            }
              var key = string.Join(",", arr);
            if(dict.ContainsKey(key)){
                dict[key].Add(str);
            }
            else{
                dict[key]= new List<string>{str};
            }
        }
        return dict.Values.ToList();
    }
}
