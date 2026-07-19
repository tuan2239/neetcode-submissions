public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] result = new int[k];
        foreach(var data in nums){
            if(dict.ContainsKey(data)){
                dict[data]++;
            }
            else{
                dict[data]=1;
            }
        }
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach(var data in dict){
            heap.Enqueue(data.Key, -data.Value);
        }
        
        for(int i =0; i< k;i++){
            result[i] = heap.Dequeue();
        }
        return result;
    }
}
