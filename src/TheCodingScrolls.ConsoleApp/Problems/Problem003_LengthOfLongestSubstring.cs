using System.Security.Cryptography.X509Certificates;

namespace TheCodingScrolls.ConsoleApp.Problems;

/*
Given a string s, find the length of the longest substring without duplicate characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

public class Problem003_LengthOfLongestSubstring : IProblem
{
    public string Name => "Length of longest substring (LeetCode 3)";

    public void Run()
    {
        static int LengthOfLongestSubstring(string s)
        {
            int counter = 0;
            int max = 0;
            var chars = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var searchIndex = chars.IndexOf(s[i]);
                if (searchIndex != -1)
                {
                    chars.RemoveRange(0,searchIndex + 1);
                    counter = chars.Count;
                }

                chars.Add(s[i]);
                counter++; 

                if (max < counter)
                {
                    max = counter; // 3
                }
            }
            return max;
        }

        var testSubstring1 = "abcabcbb";
        var result1 = LengthOfLongestSubstring(testSubstring1);
        Console.WriteLine($"First result: {result1}");

        var testSubstring2 = "bbbbb";
        var result2 = LengthOfLongestSubstring(testSubstring2);
        Console.WriteLine($"Second result: {result2}");

        var testSubstring3 = "pwwkew";
        var result3 = LengthOfLongestSubstring(testSubstring3);
        Console.WriteLine($"Third result: {result3}");

        var testSubstring4 = " ";
        var result4 = LengthOfLongestSubstring(testSubstring4);
        Console.WriteLine($"Fourth result: {result4}");

        var testSubstring5 = "dvdf";
        var result5 = LengthOfLongestSubstring(testSubstring5);
        Console.WriteLine($"Fifth result: {result5}");

        var testSubstring6 = "ckilbkd";
        var result6 = LengthOfLongestSubstring(testSubstring6);
        Console.WriteLine($"Sixth result: {result6}");
    }
}
