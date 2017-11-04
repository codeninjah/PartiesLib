using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartiesLib;

namespace PartieTestsLib
{
	[TestClass]
	public class PartiesTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			string input1 = "Alice;C#;SQL\nBob; SQL\n Carol; MVC; C#";
			string input2 = "C#;2018-01-01;2018-02-05\nSQL; 2018-02-10;2018-03-25\nMVC;2018-04-01;2018-05-15";
			var expected = $"Kursen C# pågår i 35 dagar med följande deltagare: Alice, Carol\nKursen SQL pågår i 43 dagar med följande deltagare: Alice, Bob\nKursen MVC pågår i 44 dagar med följande deltagare:Carol";
			string output = Parties.Transform(input1, input2);
			Assert.AreEqual(expected, output);
		} 
	}
}
