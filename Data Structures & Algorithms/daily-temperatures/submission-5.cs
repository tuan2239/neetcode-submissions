public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var arr = new int[temperatures.Length];
        var st =new Stack<int>();
        for(int i=0; i< temperatures.Length; i++){
           while(st.Count() > 0 && temperatures[i] > temperatures[st.Peek()]){
            var preday = st.Pop();
            arr[preday] = i- preday;
           }
           st.Push(i);
        }
        return arr;
    }
}
