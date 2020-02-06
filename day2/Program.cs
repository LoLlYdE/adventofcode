using System;

namespace adventofcode_2019 {
	class Program {
		static void Main(string[] args) {
			int[] program = { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 6, 19, 1, 19, 6, 23, 2, 23, 6, 27, 2, 6, 27, 31, 2, 13, 31, 35, 1, 9, 35, 39, 2, 10, 39, 43, 1, 6, 43, 47, 1, 13, 47, 51, 2, 6, 51, 55, 2, 55, 6, 59, 1, 59, 5, 63, 2, 9, 63, 67, 1, 5, 67, 71, 2, 10, 71, 75, 1, 6, 75, 79, 1, 79, 5, 83, 2, 83, 10, 87, 1, 9, 87, 91, 1, 5, 91, 95, 1, 95, 6, 99, 2, 10, 99, 103, 1, 5, 103, 107, 1, 107, 6, 111, 1, 5, 111, 115, 2, 115, 6, 119, 1, 119, 6, 123, 1, 123, 10, 127, 1, 127, 13, 131, 1, 131, 2, 135, 1, 135, 5, 0, 99, 2, 14, 0, 0 };
			int[] initial = { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 6, 19, 1, 19, 6, 23, 2, 23, 6, 27, 2, 6, 27, 31, 2, 13, 31, 35, 1, 9, 35, 39, 2, 10, 39, 43, 1, 6, 43, 47, 1, 13, 47, 51, 2, 6, 51, 55, 2, 55, 6, 59, 1, 59, 5, 63, 2, 9, 63, 67, 1, 5, 67, 71, 2, 10, 71, 75, 1, 6, 75, 79, 1, 79, 5, 83, 2, 83, 10, 87, 1, 9, 87, 91, 1, 5, 91, 95, 1, 95, 6, 99, 2, 10, 99, 103, 1, 5, 103, 107, 1, 107, 6, 111, 1, 5, 111, 115, 2, 115, 6, 119, 1, 119, 6, 123, 1, 123, 10, 127, 1, 127, 13, 131, 1, 131, 2, 135, 1, 135, 5, 0, 99, 2, 14, 0, 0 };
			bool HCF = false;
			int expected = 19690720;

			for (int i = 0; (i < 100 && !HCF); i++) {
				for (int j = 0; (j < 100 && !HCF); j++) {
					Console.WriteLine($"testing i = {i}; j = {j} ...");
					Array.Copy(initial,program,initial.Length);
					program[1] = i;
					program[2] = j;
					bool abort = false;
					int pc = 0;
					while (!abort) {
						switch (program[pc]) {
							case 1:
								program[program[pc + 3]] = program[program[pc + 1]] + program[program[pc + 2]];
								break;
							case 2:
								program[program[pc + 3]] = program[program[pc + 1]] * program[program[pc + 2]];
								break;
							default:
								abort = true;
								break;
						}
						pc += 4;
					}
					Console.WriteLine($"expected result: {expected} actual result: {program[0]}");
					if (program[0] == expected) {
						Console.WriteLine($"result is {program[1] * 100 + program[2]}");
						HCF = true;
					}
				}
			}
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
