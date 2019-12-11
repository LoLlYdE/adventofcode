using System;
using System.IO;
using System.Collections.Generic;

namespace day6 {
	class Program {
		static void Main(string[] args) {
			string[] orbits = File.ReadAllLines("./orbits.txt");
			Dictionary<string, orbit_object> toSort = new Dictionary<string, orbit_object>();

			foreach (string item in orbits) {
				string[] parameters = item.Split(')');
				toSort[parameters[0]] = new orbit_object(parameters[0]);
				toSort[parameters[1]] = new orbit_object(parameters[1]);
			}

			foreach (string item in orbits) {
				string[] parameters = item.Split(')');
				toSort[parameters[0]].addObject(toSort[parameters[1]]);
			}
			Console.WriteLine($"Total number of orbits: {toSort["COM"].getOrbits(0)}");
			var YOU = toSort["COM"].getPathToRoot("YOU");
			var SAN = toSort["COM"].getPathToRoot("SAN");
			YOU.Reverse();
			SAN.Reverse();
			while (YOU[0].Equals(SAN[0])) {
				var toRemove = YOU[0];
				YOU.Remove(toRemove);
				SAN.Remove(toRemove);
			}
			var len = YOU.Count + SAN.Count - 2;
			Console.WriteLine($"transfers needed between YOU and SAN: {len}");
			Console.ReadLine();
		}
	}
	class orbit_object {
		public string self_id;
		public List<orbit_object> objects;
		orbit_object parent;
		public orbit_object(string id, orbit_object parent_obj = null) {
			self_id = id;
			objects = new List<orbit_object>();
			parent = parent_obj;
		}

		public void addObject(orbit_object child) {
			objects.Add(child);
			child.parent = this;
		}

		public void Print() {
			foreach (orbit_object obj in objects) {
				Console.WriteLine($"{self_id}){obj.self_id}");
				obj.Print();
			}
		}

		public int getOrbits(int i) {
			int orbits = i;
			foreach (orbit_object obj in objects) {
				orbits += obj.getOrbits(i + 1);
			}
			return orbits;
		}

		public orbit_object getRoot() {
			if(parent == null) {
				return this;
			}
			else {
				return parent.getRoot();
			}
		}

		public List<string> getPathToRoot(string search) {
			if (search.Equals(self_id)) {
				var l = new List<string>();
				l.Add(self_id);
				return l;
			}
			else {
				foreach (orbit_object item in objects) {
					var t = item.getPathToRoot(search);
					if ( t != null) {
						t.Add(self_id);
						return t;
					}
				}
			}
			return null;
		}
	}
}
