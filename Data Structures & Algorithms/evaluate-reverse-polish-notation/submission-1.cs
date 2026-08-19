public class Solution {
    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>();
        for (int i=0; i < tokens.Length;i++ ){
            if(tokens[i]=="+" || tokens[i]=="-" || tokens[i]=="*" || tokens[i]=="/"){
                var num1= st.Pop();
                var num2= st.Pop();
                if(tokens[i]=="+"){
                    st.Push(num2+num1);
                }
                else if(tokens[i]=="-"){
                    st.Push(num2-num1);
                }
                else if(tokens[i]=="*"){
                    st.Push(num2*num1);
                }
                else if(tokens[i]=="/"){
                    st.Push(num2/num1);
                }
            }
            else{
                st.Push(int.Parse(tokens[i]));
            }
        }
        return st.Peek();
    }
}
