using System;
using System.Collections.Generic;
using System.Text;

// Two Sum
// Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, two distinct zero-based indices of any two of the numbers, whose sum is equal to the target sum. If there are no two numbers, the function should return null.

// For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:

// 0 and 3 (or 3 and 0) as 3 + 7 = 10
// 1 and 5 (or 5 and 1) as 1 + 9 = 10
// 2 and 4 (or 4 and 2) as 5 + 5 = 10
class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        List<Tuple<int, int>> twoSumsIndexes = new List<Tuple<int, int>>();
        List<Tuple<int, int>> twoSumsIntegers = new List<Tuple<int, int>>();

        for (var i = 0 ; i <list.Count ; i++)
        {
            for (var j= 0 ; j <list.Count ; j++)
            {
                if (list[i] + list[j] == sum && i != j)
                {
                    //twoSumsIndexes.Add(new Tuple<int, int>(i, j));
                    //twoSumsIntegers.Add(new Tuple<int, int>(list[i], list[j]));
                    
                    return new Tuple<int, int>(i, j);
                    
                }
            }
        }

        return null;
        //throw new NotImplementedException("Waiting to be implemented.");

    }

    // public static void Main(string[] args)
    // {
    //     Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
    //     if(indices != null) 
    //     {
    //         Console.WriteLine(indices.Item1 + " " + indices.Item2);
    //     }
    // }
}