public class Solution {

 public string Encode(IList<string> strs)
{
    StringBuilder sb = new StringBuilder();
    foreach (var item in strs)
    {
        var encode = item.Length + "#" + item;
        sb.Append(encode);
    }
    return sb.ToString();
}

public List<string> Decode(string s)
{
    List<string> list = new List<string>();
    for (int i = 0; i < s.Length; i++)
    {
        int j = i;
        while (s[j] != '#')
        {
            j++;
        }
        int length = int.Parse(s.Substring(i, j - i));
        string word = s.Substring(j + 1, length);
        list.Add(word);
        i = j + length;

    }
    return list;
}
}
