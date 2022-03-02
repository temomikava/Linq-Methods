public class Program
{
	public static void Main()
    {
    }
	
}
public static class Extention
{
	//Create a function that takes an array arr and a number n and returns
	//a sorted array of two integers from this array, whose product is that of the number n.

	public static int[] TwoProduct(this int[] arr, int n)
	{
		return arr
				 .Where(x => x != 0 && arr
				 .Any(y => n % y == 0 && y * x == n))
				 .OrderBy(x => x)
				 .ToArray();
	}

	//Given a string, reverse all the words which have odd length. The even length words are not changed.

	public static string ReverseOdd(this string str)
	{
		return
			string.Join(" ", str.Split(' ')
				  .Select(x => x.Length % 2 != 0 ? string.Concat(x.Reverse()) : x));

	}

	//ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
	//Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.

	public static bool ValidatePIN(this string pin)
	{
		return pin.All(x => char.IsDigit(x)) && (pin.Length == 4 || pin.Length == 6);
	}

	//Write a function that returns the longest common ending between two strings.
	public static string LongestCommonEnding(this string str1, string str2)
	{
		var a = string.Concat(str1.Reverse());
		var b = string.Concat(str2.Reverse());
		int minLength = a.Length > b.Length ? b.Length : a.Length;
		string result = "";
		int i = 0;
		while (i < minLength && a[i] == b[i])
		{
			result += a[i];
			i++;
		}
		return string.Concat(result.Reverse());

	}

	//This number sequence can start with any positive integer n. s is the sum of the individual digits in n.
	//If s divides into n evenly then the next term of the series is n//s.
	//Otherwise the next term is n*s. Eventually the series will reach a dead end with two numbers alternating:
	//58, 754, 12064, 928, 17632, 928, 17632. This series has a length of 5 with 17632 as the last term.
	//Compose a function that takes a positive integer and returns its series length and its last term.
	public static long[] DeadEnd(long n)
	{
		List<long> list = new List<long>();
		while (!list.Contains(n))
		{
			list.Add(n);
			long sumOfDigits = n.ToString().ToCharArray().Sum(c => c - '0');
			n = n % sumOfDigits == 0 ? n / sumOfDigits : n * sumOfDigits;
		}
		return new long[] { list.Count(), list.Last() };
	}



}


