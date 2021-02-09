using System.Text;

namespace RaindropsTests
{
	public class Raindrops
	{
		private StringBuilder _response = new StringBuilder();

		public string PlingPlangPlong(int n)
		{

			if (n % 3 == 0)
			{
				_response.Append("Pling");
			}
			if (n % 5 == 0)
			{
				_response.Append("Plang");
			}
			if (n % 7 == 0)
			{
				_response.Append("Plong");
			}
			if (_response.ToString() == "")
			{
				_response.Append($"{n}");
			}
			return _response.ToString();
		}

	}
}
