public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> seen = [];
        foreach(string str in strs){
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            if(!seen.ContainsKey(key)){
                seen[key] = new List<string>();
            }
            seen[key].Add(str);
        }
        List<List<string>> result = [];
        foreach(KeyValuePair<string, List<string>> item in seen){
            result.Add(item.Value);
        }
        return result;
    }
}
