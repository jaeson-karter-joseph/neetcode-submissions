class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        d = {}
        for num in nums:
            d[num]=d.get(num,0)+1
        for k,v in d.items():
            if v > 1:
                return True
        return False