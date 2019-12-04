using System;
using System.Collections.Generic;
using System.Linq;

namespace day4 {
	class Program {
		static void Main(string[] args) {
			part2();

		}

		private static void part2() {
			int start = 147981, end = 691423, counter = 0;
			for (int i = start; i <= end; i++) {
				if (hasTwoAdjecent(i) && neverDecreasing(i)) {
					counter++;
				}
			}
			Console.WriteLine(counter);
			Console.ReadLine();
		}

		static void part1() {
			int start = 147981, end = 691423, counter = 0;
			for (int i = start; i <= end; i++) {
				if (hasAdjecent(i) && neverDecreasing(i)) {
					counter++;
				}
			}
			Console.WriteLine(counter);
			Console.ReadLine();
		}

		private static bool neverDecreasing(int i) {
			char[] t = i.ToString().ToArray();
			for (int j = 0; j < t.Length - 1; j++) {
				if (int.Parse(t[j].ToString()) > int.Parse(t[j + 1].ToString())) return false;
			}
			return true;
		}

		private static bool hasAdjecent(int i) {
			char[] t = i.ToString().ToArray();
			for (int j = 0; j < t.Length - 1; j++) {
				if (t[j].Equals(t[j + 1])) return true;
			}
			return false;
		}

		private static bool hasTwoAdjecent(int i) {
			char[] t = i.ToString().ToArray();
			bool two = false;
			int two_digit = 0;
			
			for (int j = 0; j < t.Length - 1; j++) {
				if (two == false) {
					if (t[j].Equals(t[j + 1]) && int.Parse(t[j].ToString()) != two_digit) {
						two = true;
						two_digit = int.Parse(t[j].ToString());
					}
				} else {
					if (t[j].Equals(t[j + 1])) {
						if (two_digit == int.Parse(t[j].ToString())) {
							two = false;
						}
					}
				}

			}
			return two;
		}
	}
}
