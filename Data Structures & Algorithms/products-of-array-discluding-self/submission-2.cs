public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        int prefixProduct = 1;
        for(int i=0;i<nums.Length;i++){
            answer[i] = prefixProduct;
            prefixProduct = prefixProduct * nums[i];
        }
        int suffixProduct = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            answer[i] = answer[i] * suffixProduct;
            suffixProduct *= nums[i];
        }
        return answer;
    }
}
