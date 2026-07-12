public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(var item in nums){
            if(dict.ContainsKey(item)){
                dict[item]++;
            }
            else{
                dict[item] = 0;
            }
        }
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        foreach(var item in dict){
            heap.Enqueue(item.Key, -item.Value);
        }
        int[] n = new int[k];
        for(int i=0; i < k; i++){
            n[i]= heap.Dequeue();
        }
        return n;
    }
}
