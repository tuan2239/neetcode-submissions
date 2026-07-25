public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var st = new Stack<int>();
        var arr = new int[temperatures.Length];
        for(int i =0; i < temperatures.Length;i++){
            if(i==0){
                st.Push(i);
            }
            else{
                while( st.Count > 0 && temperatures[st.Peek()] < temperatures[i]){
                    arr[st.Peek()] = i-st.Peek();
                    st.Pop();
                }
                    Console.WriteLine($"AAA {1} ",st);
                st.Push(i);
            }
        }
        return arr;


    }
}
