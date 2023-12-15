int targetNum = 6;
int[] sets = new int[3] { 3, 2, 4 };
int[] result = TwoSum(sets, targetNum);
Console.WriteLine($"Output: [{string.Join(",", result)}]");

static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> seen = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (seen.ContainsKey(complement))
        {
            return new int[] { seen[complement], i };
        }
        seen.Add(nums[i], i);
    }
    throw new ArgumentException("No two sum solution");
}
