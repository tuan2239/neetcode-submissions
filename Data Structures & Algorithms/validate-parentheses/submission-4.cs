public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                st.Push(s[i]);
            }
            else if (s[i] == '[') {
                st.Push(s[i]);
            }
            else if (s[i] == '{') {
                st.Push(s[i]);
            }

            else{
                if(st.Count==0){
                    return false;
                }
                var ch = st.Pop();
                if(s[i] == ')' && ch != '(') return false;
                if(s[i] == ']' && ch != '[') return false;
                if(s[i] == '}' && ch != '{') return false;
            }
        }
        return st.Count==0;
    }
}
