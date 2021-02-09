namespace RaindropsTests
{
	public class Raindrops
	{
		private string _response = "";

		public string PlingPlangPlong(int n)
		{
			if (n % 3 == 0)
			{
				_response += "Pling";
			}
			if (n % 5 == 0)
			{
				_response += "Plang";
			}
			if (n % 7 == 0)
			{
				_response += "Plong";
			}
			if (_response == "")
			{
				_response += $"{n}";
			}
			return _response;
		}

	}
}
