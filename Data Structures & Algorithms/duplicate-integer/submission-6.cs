public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums.Length);
        foreach(int i in nums){
            if(!seen.Add(i)){
                return true;
            }
        }
        return false;
        
    }
}