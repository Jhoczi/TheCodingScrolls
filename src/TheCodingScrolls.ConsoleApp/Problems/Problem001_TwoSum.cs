namespace TheCodingScrolls.ConsoleApp.Problems;
/*

Title: 01. Two Sum

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.


Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:
Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
*/

public class Problem001_TwoSum : IProblem
{
    public string Name => "Two Sum (LeetCode 1)";

    public void Run()
    {
        // static int[] TwoSum(int[] nums, int target) 
        // {
        //     for (int i = 0; i < nums.Length - 1; i++)
        //     {
        //         for (int j = i+1; j < nums.Length; j++)
        //         {
        //             if (nums[i] + nums[j] == target)
        //             {
        //                 return [i, j];
        //             }
        //         }
                
        //     }

        //     return [0,0];
        // }

        static int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.TryGetValue(complement, out int index))
                {
                    return [index, i];
                }

                map[nums[i]] = i;
            }

            return [-1, -1];
        }

        var example1 = TwoSum([2,7,11,15], 9);
        Console.WriteLine($"Output: {example1.First()},{example1.Last()}");

        var example2 = TwoSum([3,2,4], 6);
        Console.WriteLine($"Output: {example2.First()},{example2.Last()}");

        var example3 = TwoSum([3,3], 6);
        Console.WriteLine($"Output: {example3.First()},{example3.Last()}");
    }
}
