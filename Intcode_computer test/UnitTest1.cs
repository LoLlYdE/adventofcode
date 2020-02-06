using Microsoft.VisualStudio.TestTools.UnitTesting;
using Intcode_computer;
using System;
using System.IO;

namespace Intcode_computer_test {
	[TestClass]
	public class UnitTest1 {
		[TestMethod]
		public void TestMethod1() {
			int[] input = { 1, -1, int.MaxValue, int.MinValue, 7 };
			int[] output = new int[5];
			
			for (int i = 0; i < input.Length; i++) {
				var sw = new StringWriter();
				Console.SetOut(sw);
				Computer.writeOutput(input[i]);
				var t = sw.ToString().Trim();
				output[i] = int.Parse(t);
			}
			CollectionAssert.AreEqual(input, output);
		}
	}
}
