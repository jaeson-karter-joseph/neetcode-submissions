public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded_string = new StringBuilder();
        foreach(string word in strs){
            encoded_string.Append(word.Length);
            encoded_string.Append('#');
            encoded_string.Append(word);
        }
        return encoded_string.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int pointer = 0;
        while(pointer < s.Length){
            int seperatorIndex = s.IndexOf('#',pointer);
            int lenght = int.Parse(s.Substring(pointer, seperatorIndex - pointer));
            string word = s.Substring(seperatorIndex + 1, lenght);
            result.Add(word);
            pointer = seperatorIndex + 1 + lenght;
        }
        return result;
   }
}
