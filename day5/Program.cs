using System;

namespace day5 {
	class Program {
		static int[] program = { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 101, 20, 183, 224, 101, -63, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 6, 224, 224, 1, 223, 224, 223, 1101, 48, 40, 225, 1101, 15, 74, 225, 2, 191, 40, 224, 1001, 224, -5624, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 2, 224, 1, 223, 224, 223, 1101, 62, 60, 225, 1102, 92, 15, 225, 102, 59, 70, 224, 101, -885, 224, 224, 4, 224, 1002, 223, 8, 223, 101, 7, 224, 224, 1, 224, 223, 223, 1, 35, 188, 224, 1001, 224, -84, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 2, 224, 1, 223, 224, 223, 1001, 66, 5, 224, 1001, 224, -65, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 3, 224, 1, 223, 224, 223, 1002, 218, 74, 224, 101, -2960, 224, 224, 4, 224, 1002, 223, 8, 223, 1001, 224, 2, 224, 1, 224, 223, 223, 1101, 49, 55, 224, 1001, 224, -104, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 6, 224, 1, 224, 223, 223, 1102, 43, 46, 225, 1102, 7, 36, 225, 1102, 76, 30, 225, 1102, 24, 75, 224, 101, -1800, 224, 224, 4, 224, 102, 8, 223, 223, 101, 2, 224, 224, 1, 224, 223, 223, 1101, 43, 40, 225, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 1008, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 329, 1001, 223, 1, 223, 8, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 344, 1001, 223, 1, 223, 1007, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 359, 101, 1, 223, 223, 1008, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 374, 1001, 223, 1, 223, 1107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 389, 1001, 223, 1, 223, 107, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 404, 101, 1, 223, 223, 1007, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 419, 101, 1, 223, 223, 7, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 434, 1001, 223, 1, 223, 1007, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 449, 101, 1, 223, 223, 107, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 464, 1001, 223, 1, 223, 1108, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 479, 101, 1, 223, 223, 8, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 494, 101, 1, 223, 223, 7, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 509, 1001, 223, 1, 223, 1107, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 524, 1001, 223, 1, 223, 1108, 677, 226, 224, 1002, 223, 2, 223, 1005, 224, 539, 1001, 223, 1, 223, 1108, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 554, 101, 1, 223, 223, 108, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 569, 1001, 223, 1, 223, 8, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 584, 101, 1, 223, 223, 108, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 599, 1001, 223, 1, 223, 108, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 614, 101, 1, 223, 223, 1008, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 629, 1001, 223, 1, 223, 107, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 644, 101, 1, 223, 223, 1107, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 659, 1001, 223, 1, 223, 7, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 674, 101, 1, 223, 223, 4, 223, 99, 226 };
		static void Main(string[] args) {
			
			bool abort = false;
			int pc = 0;
			while (!abort) {
				string code = program[pc].ToString();
				int opcode;
				string toparse;
				if (code.ToString().Length > 2) {
					opcode = int.Parse(code.Substring(code.Length - 2));
					toparse = code.Substring(0, code.Length - 2);
				} else {
					opcode = int.Parse(code);
					toparse = "";
				}
				int mode = 0;
				int.TryParse(toparse, out mode);
				int[] modearr = mode.toArray();
				int par1 = 0, par2 = 0, par3 = 0, t = 0;
				switch (opcode) {
					case 1:
						getParameters(pc, modearr, out par1, out par2);

						t = program[pc + 3];
						program[t] = par1 + par2;
						
						pc += 4;
						break;
					case 2:
						getParameters(pc, modearr, out par1, out par2);

						t = program[pc + 3];
						program[t] = par1 * par2;
						pc += 4;
						break;
					case 3:
						int pos = program[pc + 1];
						int input = readInput();
						program[pos] = input;
						pc += 2;
						break;
					case 4:
						t = program[pc + 1];
						if (modearr[2] == 1) {
							writeOutput(t);
						} else {
							writeOutput(program[t]);
						}
						pc += 2;
						break;
					case 5:
						getParameters(pc, modearr, out par1, out par2);
						if (par1 != 0) {
							pc = par2;
							break;
						}
						pc += 3;
						break;
					case 6:
						getParameters(pc, modearr, out par1, out par2);
						if (par1 == 0) {
							pc = par2;
							break;
						}
						pc += 3;
						break;
					case 7:
						getParameters(pc, modearr, out par1, out par2);
						par3 = program[pc + 3];
						if (par1 < par2) {
							program[par3] = 1;
						}
						else {
							program[par3] = 0;
						}
						pc += 4;
						break;
					case 8:
						getParameters(pc, modearr, out par1, out par2);
						par3 = program[pc + 3];
						if (par1 == par2) {
							program[par3] = 1;
						}
						else {
							program[par3] = 0;
						}
						pc += 4;
						break;
					default:
						abort = true;
						break;
				}
						
			}
			Console.WriteLine();
			Console.ReadLine();
		}

		private static void writeOutput(int v) {
			Console.WriteLine(v);
		}

		private static int readInput() {
			Console.WriteLine("Program needs input:");
			return int.Parse(Console.ReadLine());
		}

		private static void getParameters(int pc, int[] mode, out int par1, out int par2, out int par3) {
			int t = 0;
			getParameters(pc, mode, out par1, out par2);
			if (mode[0] == 0) {
				t = program[pc + 3];
				par3 = program[t];
			}
			else {
				par3 = program[pc + 3];
			}
		}

		private static void getParameters(int pc, int[] mode, out int par1, out int par2) {
			int t = 0;
			getParameters(pc, mode, out par1);
			if (mode[1] == 0) {
				t = program[pc + 2];
				par2 = program[t];
			}
			else {
				par2 = program[pc + 2];
			}
		}

		private static void getParameters(int pc, int[] mode, out int par1) {
			int t = 0;
			if (mode[2] == 0) {
				t = program[pc + 1];
				par1 = program[t];
			}
			else {
				par1 = program[pc + 1];
			}
		}
	}
	static class Extensions {
		public static int[] toArray(this int input) {
			string t = input.ToString();
			int[] arr = new int[t.Length];
			int counter = 0;
			foreach (char item in t) {
				arr[counter] = int.Parse(t.ToCharArray()[counter++].ToString());
			}
			if (counter != 3) {
				int[] arr2 = new int[3];
				arr.CopyTo(arr2, 3 - arr.Length);
				arr = arr2;
			}
			return arr;
		}
	}
}
