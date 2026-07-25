public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        foreach(var data in s){
            if(data == '(' || data == '{'|| data == '['){
                st.Push(data);
            }
            else{
                if (st.Count == 0)
    return false;
                var alo = st.Pop();
                if(data == ')' && alo =='('){
                    continue;
                }
                if(data == '}' && alo =='{'){
                    continue;
                }
                if(data == ']' && alo =='['){
                    continue;
                }
                else{
                    return false;
                }
            }
        }
        return st.Count== 0;
    }
}
