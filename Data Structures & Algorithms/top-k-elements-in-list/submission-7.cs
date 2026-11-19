public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> counter = [];

        foreach (int num in nums)
        {
            counter[num] = counter.GetValueOrDefault(num) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var item in counter)
        {
            int frequency = item.Value;

            if (buckets[frequency] == null)
                buckets[frequency] = [];

            buckets[frequency].Add(item.Key);
        }

        List<int> result = [];

        for (int i = buckets.Length - 1; i >= 0; i--)
        {
            if (buckets[i] != null)
            {
                foreach (int num in buckets[i])
                {
                    result.Add(num);

                    if (result.Count == k)
                        return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}