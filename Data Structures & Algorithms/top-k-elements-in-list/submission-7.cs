public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        foreach(var num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }
            else{
                dict[num]=1;
            }
        }

        var heap = new PriorityQueue<int, int>();
        foreach(var num in dict){
            heap.Enqueue(num.Key, -num.Value);
        }
        var re = new int[k];
        for(int i=0; i <k; i++){
            re[i] = heap.Dequeue();
        }
        return re;
    }
}
