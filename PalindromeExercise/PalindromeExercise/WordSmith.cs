using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}

		public bool IsAPalindrome(string word)
		{
			word = word.ToLower();
			if (word[0] == word[word.Length - 1])
			{
				return true;
			} else
			{
				return false;
			}
		}
	}
}

/*
 * In your WordSmith class, you will create a method (IsAPalindrome) that 
 * will take a parameter of type string and return a value of type bool. 
 * If the given input is a palindrome – return true, else return false. 
 * You will finish this method after you write your tests.
 */