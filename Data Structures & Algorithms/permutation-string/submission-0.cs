public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int len = s1.Length;
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        foreach(var data in s1){
            arr1[data-'a']++;
        }

        int left =0;
        Dictionary<int, int> dict  = new Dictionary<int, int>();
        for(int right=0; right< s2.Length; right++){
            
            arr2[s2[right]-'a']++;

            if (right - left + 1 > len){
                arr2[s2[left]-'a']--;
                left++;
            }
            //khi arr2 bằng length arr1, sau đó so 2 chuỗi giống nhau
            if (right - left + 1 == len){
                if(issame(arr1, arr2)){
                    return true;
                }
            }
        }
        return false;
    }
    public bool issame(int[] arr1, int[] arr2){
        for(int i =0; i< 26;i++){
            if(arr1[i]!=arr2[i]){
                return false;
            }
        }
        return true;
    }
}
