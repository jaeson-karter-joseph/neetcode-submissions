public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> seen = [];
        foreach(int num in nums){
            seen.Add(num);
        }

        int maxLength = 0;
        foreach(int num in seen){
            if(!seen.Contains(num - 1)){
                int current = num;
                int count = 1;
                while(seen.Contains(current+1)){
                    current++;
                    count++;
                }
                maxLength = Math.Max(count,maxLength);
            }
        }
        return maxLength;
        
    }
}
