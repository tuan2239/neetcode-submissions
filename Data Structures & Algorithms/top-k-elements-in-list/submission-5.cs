public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(var data in nums){
            if(dict.ContainsKey(data)){
                dict[data]++; 
            }
            else{
                dict[data] = 1;
            }
        }
        var heap = new PriorityQueue<int, int>();
        foreach(var data in dict){
            heap.Enqueue(data.Key, -data.Value);
        }
        var arr = new int[k];
        for(int i=0; i < k;i++){
            arr[i] = heap.Dequeue();
        }
        return arr;
    }
}
