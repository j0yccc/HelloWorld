using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    public class HelloWorld
    {

        public HelloWorld()
        {

        }

        public string HelloWorldString()
        {
            return "Hello World!!";
        }

        public string ReverseString(string x)
        {
            var result = "";
            if (string.IsNullOrEmpty(x))
            {
                return "Empty string";
            }

            for (var i = x.Length - 1; i >= 0; i--)
            {
                result += x[i];
            }

            return result;
        }

        public int ReverseInteger(int x)
        {
            var r = 0;

            var result = 0;

            while (x != 0)
            {
                r = x % 10;
                x = x / 10;
                result = result * 10 + r;
            }
            return result;
        }

        public string RemoveDuplicateChar(string str)
        {
            var result = "";
            var table = "";

            char[] characters = str.ToCharArray();

            foreach (var character in characters)
            {
                if (table.IndexOf(character) == -1)
                {
                    table += character;
                    result += character;
                }
            }

            return result;
        }

        public int RemoveDuplicateInteger(int[] numbers)
        {
            var count = 1;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else if (numbers.Length == 1)
            {
                return 1;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] != numbers[i])
                {
                    count++;
                    numbers[count] = numbers[i];
                }
            }

            return count;
        }

        public string[] RemoveDuplicateStringInTwoArrays(string[] array1, string[] array2)
        {
            var table = new List<string>();

            for (int i = 0; i < array1.Length; i++)
            {
                table.Add(array1[i]);
            }

            for (int j = 0; j < array2.Length; j++)
            {
                if (table.IndexOf(array2[j]) == -1)
                {
                    table.Add(array2[j]);
                }
            }

            return table.ToArray();
        }

        public int CountCharacter(string word)
        {
            var count = 0;

            if (word == "")
            {
                count = 0;
            }
            else
            {
                var characters = word.ToCharArray();

                foreach (var character in characters)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountWord(string sentence)
        {
            var count = 0;
            var words = sentence.Split(' ');

            foreach (var word in words)
            {
                count++;
            }

            return count;
        }

        public int SumOfDigit(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }

        public bool PalindromeNumber(int x)
        {
            var reverse = 0;

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            while (x > reverse)
            {
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }

            return x == reverse || x == reverse / 10;
        }

        public bool PalindromeString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                var strLower = str.ToLower();
                var characters = str.ToLower().ToCharArray();
                Array.Reverse(characters);
                var reverseStr = new String(characters);

                if (strLower == reverseStr)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // bool flag = false;
            // for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            // {
            //     if (str[i] != str[j])
            //     {
            //         flag = false;
            //         break;
            //     }
            //     else
            //         flag = true;
            // }
            // if (flag)
            // {
            //     Console.WriteLine("Palindrome");
            // }
            // else
            //     Console.WriteLine("Not Palindrome");
        }

        public bool AnagramString(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            var s1Array = s1.ToLower().ToCharArray();
            var s2Array = s2.ToLower().ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            s1 = new string(s1Array);
            s2 = new string(s2Array);

            return s1 == s2;
        }

        public void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        public void RotateRight(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = 0; j < size - 1; j++)
            {
                temp = array[0];
                array[0] = array[j + 1];
                array[j + 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        public int FindPatternCount(string pattern, string str)
        {
            int count = 0;

            for (int i = 0; i < pattern.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (pattern[i] == str[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public int FindRepeatedNumberInArray(int[] nums)
        {
            var result = new List<int>();
            foreach (var num in nums)
            {
                if (result.Contains(num))
                {
                    return num;
                }
                result.Add(num);
            }

            return 0;
        }

        public string FindLongestCommonPrefix(string[] strs)
        {

            var prefixString = "";

            if (strs == null || strs.Length == 0)
            {
                return string.Empty;
            }
            else if (strs.Length == 1)
            {
                return strs[0];
            }

            for (int i=0; i < strs[0].Length; i++)
            {
                foreach(var str in strs)
                {
                    if(i > str.Length - 1)
                    {
                        return prefixString;
                    }
                    if (strs[0][i] != str[i])
                    {
                        return prefixString;
                    }
                }
                prefixString += strs[0][i];
            }

            return prefixString;
        }
    }
}