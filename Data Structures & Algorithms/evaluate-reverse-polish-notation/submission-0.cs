public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();
        foreach (var data in tokens) {
            if (data == "+" || data == "-" || data == "*" || data == "/") {
                int right = st.Pop();
                int left = st.Pop();
                switch (data) {
                    case "+":
                        st.Push(left+right);
                        break;
                    case "-":
                    st.Push(left-right);
                        break;
                    case "*":
                    st.Push(left*right);
                        break;
                    case "/":
                    st.Push(left/right);
                        break;
                }
            } else {
                st.Push(int.Parse(data));
            }
        }
        return st.Pop();
    }
}
