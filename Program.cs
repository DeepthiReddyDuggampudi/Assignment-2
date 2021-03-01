using System;
using System.Linq;
using System.Collections.Generic;

namespace Dassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 2, 4, 0, 0, 9, 8, 0, 1 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                
        
                    int intial = 0, mid = n;//intialisation for first and mid element
                    int[] newList = new int[2 * n];//new list
                    for (int j = 0; j < 2 * n; j = j + 2)
                   {
                        newList[j] = nums[intial++];//appending at jth position
                        newList[j + 1] = nums[mid++];//appending at (j+mid)th position
                    }

                    Console.WriteLine(string.Join(",", newList));


                
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                if (ar2.Length == 0)
                {
                    throw new Exception();
                }
                else
                {
                    //swapping between temporary variable and the current index value
                    for (int a = 0, b = 0; b < ar2.Length; b++)
                        if (ar2[b] != 0)
                        {
                            int temp = ar2[a];
                            ar2[a++] = ar2[b];
                            ar2[b] = temp;
                        }
                    Console.WriteLine(string.Join(",", ar2));

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ////Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                if (nums.Length == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Dictionary<int, int> dict = new Dictionary<int, int>();

                    int counts = 0;
                    for (int i = 0; i < nums.Length; ++i)
                    {
                        if (dict.ContainsKey(nums[i]))
                        {
                            counts += dict[nums[i]];
                            ++dict[nums[i]];
                        }
                        else
                        {
                            dict.Add(nums[i], 1);
                        }
                    }
                    Console.WriteLine(counts);
                }
            }

            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                if (nums == null || nums.Length < 2)
                    Console.WriteLine("provide proper input");

                Dictionary<int, int> dic = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (dic.ContainsKey(target - nums[i]))
                        Console.WriteLine(i + "," + dic[target - nums[i]]);
                    else if (!dic.ContainsKey(nums[i]))
                        dic.Add(nums[i], i);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                if (s.Length != indices.Length)
                {
                    throw new Exception();
                }
                foreach (int a in indices)
                {
                    if (a < 0 || a > indices.Length)
                    {
                        throw new Exception();
                    }
                }

                char[] chars = s.ToCharArray();//converting string to charecters
                for (int i = 0; i < indices.Length; i++)
                {
                    chars[indices[i]] = s[i];//creating a new list of charecters based on indices of chars
                }

                Console.WriteLine(new string(chars));

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s, string t)
        {
            try
            {
                if (s.Length != t.Length) { return false; }

                int[] sMap = new int[128];//creating a new list for mapping 
                int[] tMap = new int[128];//creating a new list for mapping

                for (int i = 0; i < s.Length; i++)
                {
                    /**/
                    if (sMap[s[i]] == 0 && tMap[t[i]] == 0)//mapping list based on values and comparing the values with other array
                    {
                        sMap[s[i]] = t[i];
                        tMap[t[i]] = s[i];
                    }
                    else if (sMap[s[i]] != t[i] || tMap[t[i]] != s[i])//checking the charecter mapping for both the lists 
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                if (items.GetLength(0) > 1000)
                {
                    throw new Exception();
                }
                
                Dictionary<int, List<int>> scoresDict = new Dictionary<int, List<int>>();//dictionary declaration
                for (int i = 0; i < items.GetLength(0); i++)//getting the length of first dimension
                {
                    //creating a dictionary which has iD as key and corresponding values - {1:[1,2,3],2:[5,6,7]}
                    if (scoresDict.ContainsKey(items[i, 0]))
                    {
                        
                        List<int> firstList = scoresDict[items[i, 0]];
                        if (items[i, 1] > 100)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            firstList.Add(items[i, 1]);
                            scoresDict[items[i, 0]] = firstList;
                        }
                    }
                    else
                    {
                        List<int> checkList = new List<int>();
                        if (items[i, 1] > 100)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            checkList.Add(items[i, 1]);
                            scoresDict.Add(items[i, 0], checkList);
                        }
                    }
                }
                if (scoresDict.Count > 100 || scoresDict.Count == 1)
                {
                    throw new Exception();
                }
                foreach (KeyValuePair<int, List<int>> val in scoresDict)
                {
                    //iterating through dictionary and getting the key followed by the first 5 large values
                    if (val.Value.Count < 5)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        var final = val.Value;
                        final.Sort();
                        final.Reverse();
                        var final_ = final.GetRange(0, 5);
                        Console.WriteLine((val.Key, final_.Sum() / 5));
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                while (true)
                {
                    var sumOfSquare = 0;
                    while (n > 0)
                    {
                        // getting reminder and squaring it
                         var digit = n % 10;
                        sumOfSquare += digit * digit;
                        n /= 10;//diving to get the divident
                    }

                    if (sumOfSquare > 9)//checking if num is greater than 9 and updating the value of n;
                    {
                        n = sumOfSquare;
                        continue;
                    }

                    return sumOfSquare == 1 || sumOfSquare == 7;//checking for numbers from 1 to 9 and happy number occurs only at 1 and 7
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                if (prices.Length == 0 || prices.Length == 1)
                { // Check for the Edge Cases
                    return 0;
                }
                int minValue = prices[0];
                int maxValue = prices[0];
                int maxProfit = 0; //default value to be returned
                for (int i = 1; i < prices.Length; i++)
                {
                    if (maxValue < prices[i])
                    {
                        maxValue = prices[i];
                        maxProfit = Math.Max(maxProfit, maxValue - minValue);
                    }

                    else if (minValue > prices[i])
                    {
                        maxProfit = Math.Max(maxProfit, maxValue - minValue); // check the maxValue before updating
                        maxValue = prices[i]; //Since the MaxValue is not Valid anymore has we have to buy before sell
                        minValue = prices[i];
                    }
                }
                return Math.Max(maxProfit, maxValue - minValue);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                if (steps <= 0)
                {
                    throw new Exception();
                }
                if (steps == 1)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    int[] dp = new int[steps + 1];//creating a list to store the values
                    dp[0] = dp[1] = 1;//declaring 0th and 1st element for fibonacci series
                    for (int i = 2; i <= steps; i++)
                        dp[i] = dp[i - 1] + dp[i - 2];//fibonacci series formula
                    Console.WriteLine(dp[steps]);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
