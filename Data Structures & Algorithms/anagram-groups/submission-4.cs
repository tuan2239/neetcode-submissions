public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach(var data in strs){
            int[] arr = new int[26];
            foreach(var ch in data){
                arr[ch-'a']++;
            }
            var key = string.Join(",",arr);

            if(!dict.ContainsKey(key)){
                dict.Add(key,new List<string>{data});
            }
            else{
                dict[key].Add(data);
            }

        }
        Console.WriteLine($"aa: {0}", dict.Values.ToList());
        return dict.Values.ToList();
    }
}
