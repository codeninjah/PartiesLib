using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiesLib
{
	public class Parties
	{
		string lines1 = "";
		string lines2 = "";
		
		Tuple<string, DateTime, DateTime> kurser = new Tuple<string, DateTime, DateTime>("C#", 2018-01-01, 2018-02-05);

		public static string Transform(string input1, string input2)
		{

			var stringReader1 = new StringReader(input1);
			string output = "";
			while (true)
			{
				var lines1 = stringReader1.ReadLine();
				if (lines1 == null)
					break;
				string[] lines1delat = lines1.Split(';');
				var stringReader2 = new StringReader(input2);
				while (true)
				{
					var lines2 = stringReader2.ReadLine();
					if (lines2 == null)
						break;
					string[] lines2delat = lines2.Split(';');
					var datum2 = DateTime.Parse(lines2delat[2]);
					var datum1 = DateTime.Parse(lines2delat[1]);
					var days = datum2.Day - datum1.Day;
					var kurs = lines2delat[0];
					var namn = lines1delat[0];

					output += $"Kursen {kurs} pågår i {days} dagar med följande deltagare: {namn}";
				}

			}
			return output;
		}
		
	}
}

