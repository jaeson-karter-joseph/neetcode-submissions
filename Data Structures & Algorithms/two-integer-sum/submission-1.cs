public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> seen = [];
        for(int i = 0; i < nums.Length; i ++){
            int required = target - nums[i];
            if(seen.ContainsKey(required)){
                return [seen[required], i];
            }
            seen[nums[i]] = i;
        }
        return [];
    }
}
