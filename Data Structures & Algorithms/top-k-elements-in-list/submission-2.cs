public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        foreach(var data in dict){
            heap.Enqueue(data.Key, -data.Value);
        }
        int[] arr = new int[k];
        for(int i =0; i<k; i++){
            arr[i] = heap.Dequeue();
        }
        return arr;
    }
}
