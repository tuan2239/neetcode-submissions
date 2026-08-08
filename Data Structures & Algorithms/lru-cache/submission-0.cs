public class LRUCache {
    private int capacity1;
     private LinkedList<(int key, int value)> linkedlist;
    private Dictionary<int, LinkedListNode<(int key, int value)>> dict;

    public LRUCache(int capacity) {
        capacity1 = capacity;
        linkedlist = new LinkedList<(int key, int value)>();
        dict = new Dictionary<int, LinkedListNode<(int key, int value)>>();
    }
    
    public int Get(int key) {
        if(dict.ContainsKey(key)){
            var node = dict[key];
            linkedlist.Remove(node);
            linkedlist.AddFirst(node);
            return node.Value.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(dict.ContainsKey(key)){
            var node = dict[key];
            node.Value = (key, value);
            linkedlist.Remove(node);
            linkedlist.AddFirst(node);
            return;
        }

        var newnode = new LinkedListNode<(int key, int value)>((key, value));
        linkedlist.AddFirst(newnode);
        dict.Add(key, newnode);
        if(linkedlist.Count() > capacity1){
            var last = linkedlist.Last;
            dict.Remove(last.Value.key);
            linkedlist.RemoveLast();
        }
    }
}
