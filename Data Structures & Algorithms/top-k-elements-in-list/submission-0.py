
from collections import Counter
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        c = Counter(nums)
        c = c.most_common(k)
        ans = []
        for i in c :
            ans.append(i[0])
        print(c)
        return ans

        