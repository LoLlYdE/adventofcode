using System;

namespace Intcode_computer {
	public class Computer {
		int[] program;
		public Computer(int[] intcode_program) {
			program = intcode_program;
		}
		public void compute() {

			bool abort = false;
			int pc = 0;
			while (!abort) {
				string code = program[pc].ToString();
				int opcode;
				string toparse;
				if (code.ToString().Length > 2) {
					opcode = int.Parse(code.Substring(code.Length - 2));
					toparse = code.Substring(0, code.Length - 2);
				}
				else {
					opcode = int.Parse(code);
					toparse = "";
				}
				int mode = 0;
				int.TryParse(toparse, out mode);
				int[] modearr = mode.toArray();
				int par1 = 0, par2 = 0, par3 = 0, t = 0;
				switch (opcode) {
					case 1:
						getParameters(program, pc, modearr, out par1, out par2);

						t = program[pc + 3];
						program[t] = par1 + par2;

						pc += 4;
						break;
					case 2:
						getParameters(program, pc, modearr, out par1, out par2);

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
						}
						else {
							writeOutput(program[t]);
						}
						pc += 2;
						break;
					case 5:
						getParameters(program, pc, modearr, out par1, out par2);
						if (par1 != 0) {
							pc = par2;
							break;
						}
						pc += 3;
						break;
					case 6:
						getParameters(program, pc, modearr, out par1, out par2);
						if (par1 == 0) {
							pc = par2;
							break;
						}
						pc += 3;
						break;
					case 7:
						getParameters(program, pc, modearr, out par1, out par2);
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
						getParameters(program, pc, modearr, out par1, out par2);
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

		public void writeOutput(int v) {
			Console.WriteLine(v);
		}

		public int readInput() {
			Console.WriteLine("Program needs input:");
			return int.Parse(Console.ReadLine());
		}

		private void getParameters(int[] program, int pc, int[] mode, out int par1, out int par2, out int par3) {
			int t = 0;
			getParameters(program, pc, mode, out par1, out par2);
			if (mode[0] == 0) {
				t = program[pc + 3];
				par3 = program[t];
			}
			else {
				par3 = program[pc + 3];
			}
		}

		private void getParameters(int[] program, int pc, int[] mode, out int par1, out int par2) {
			int t = 0;
			getParameters(program, pc, mode, out par1);
			if (mode[1] == 0) {
				t = program[pc + 2];
				par2 = program[t];
			}
			else {
				par2 = program[pc + 2];
			}
		}

		private void getParameters(int[] program, int pc, int[] mode, out int par1) {
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
