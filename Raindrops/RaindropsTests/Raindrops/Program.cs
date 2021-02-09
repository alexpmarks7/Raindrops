using System.Collections.Generic;

namespace Raindrops
{
	public class Program
	{
		private static List<int> _factors;
		private static string _response = "";

		public static void Main(string[] args)
		{

		}

		public string PlingPlangPlong(int n)
		{
			_factors = Factors(n);
			if (_factors.Contains(3))
			{ 
				_response += "Pling";				
			}
			if (_factors.Contains(5))
			{
				_response += "Plang";
			}
			if (_factors.Contains(7))
			{
				_response += "Plong";
			}
			else
			{
				_response = $"{n}";
			}
			return _response;
		}

		public static List<int> Factors(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0) _factors.Add(i);
			}
			return _factors;
		}
	}
}