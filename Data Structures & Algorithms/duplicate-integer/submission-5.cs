public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = [];
        foreach(int i in nums){
            if(!seen.Add(i)){
                return true;
            }
        }
        return false;
        
    }
}