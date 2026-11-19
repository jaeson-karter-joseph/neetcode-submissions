public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counter = [];

        foreach (int num in nums)
        {
            if (!counter.ContainsKey(num))
                counter[num] = 0;

            counter[num]++;
        }

        var sorted = counter.OrderByDescending(x => x.Value);

        List<int> result = [];

        foreach (var item in sorted.Take(k))
        {
            result.Add(item.Key);
        }

        return result.ToArray();
    }
}
