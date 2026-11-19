public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] indexOfs = new int[26];
        int[] indexOft = new int[26];
        if (s.Length == t.Length) {
            for (int i = 0; i < s.Length; i++) {
                indexOfs[s[i] - 'a'] += 1;
            }
            for (int i = 0; i < t.Length; i++) {
                indexOft[t[i] - 'a'] += 1;
            }
            for(int i = 0 ; i < 26; i ++){
                if (indexOfs[i] != indexOft[i]) {
                    return false;
                }
            }
            return true;
        } else {
            return false;
        }
    }
}
