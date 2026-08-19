public class MinStack {
    Stack<int> st;
    Stack<int> minst;

    public MinStack() {
        st = new Stack<int>();    
        minst = new Stack<int>();    
    }
    
    public void Push(int val) {
        st.Push(val);
        if(minst.Count==0 || minst.Peek() >= val){
            minst.Push(val);
        }
    }
    
    public void Pop() {
        var remove = st.Pop();
        if(minst.Peek() == remove){
            minst.Pop();
        }

    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minst.Peek();
    }
}
