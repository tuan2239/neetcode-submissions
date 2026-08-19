public class Solution {
    public bool IsAnagram(string s, string t) {
        var arr1= new int[26];
        foreach(var ch in s){
            arr1[ch-'a']++;
        }
        var key1= string.Join(",",arr1);

        var arr2= new int[26];
        foreach(var ch in t){
            arr2[ch-'a']++;
        }
        var key2 = string.Join(",",arr2);

        for(int i=0; i< arr1.Length;i++){
            if(arr1[i] != arr2[i]){
                return false;
            }
        }
        return true;
    }
}
