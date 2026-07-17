public class Solution {
                  public int[] ReplaceElements(int[] arr)
        {
               int currentMax = -1;

                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    int old = arr[i];
                    arr[i] = currentMax;
                    currentMax = Math.Max(currentMax, old);
                }

                return arr;
        }
}