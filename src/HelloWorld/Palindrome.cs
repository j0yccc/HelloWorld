using System;
// Palindrome

// A palindrome is a word that reads the same backward or forward.

// Write a function that checks if a given word is a palindrome. Character case should be ignored.

// For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
         if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            else
            {
                var strLower = word.ToLower();
                var characters = word.ToLower().ToCharArray();
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
    }

    // public static void Main(string[] args)
    // {
    //     Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    // }
}