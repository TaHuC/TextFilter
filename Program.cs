using System;
using System.Linq;

namespace TextFilter
{
	public class MainClass
	{
		public static void Main()
		{
			string[] getCensure = Console.ReadLine()
										 .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
										 .ToArray();

			var getAllText = Console.ReadLine();

			for (var i = 0; i < getCensure.Length; i++)
			{
				var starts = getCensure[i].Trim().Length;
				var setStars = string.Empty;

				for (var j = 0; j < starts; j++)
				{
					setStars += "*";
				}

				getAllText = getAllText.Replace(getCensure[i].Trim(), setStars);
			}

			Console.WriteLine(getAllText);
		}
	}
}
