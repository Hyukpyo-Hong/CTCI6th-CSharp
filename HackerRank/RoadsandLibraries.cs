using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CrackingTheCode6th.HackerRank {
    //https://www.hackerrank.com/challenges/torque-and-development/problem
    public class RoadsandLibraries : Quiz {
        public override void Test () {
            int[][] cities = new int[12709][];
            var fileStream = new FileStream ("./HackerRank/JourneytotheMoon.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader (fileStream, Encoding.UTF8)) {
                string line;
                int idx = 0;
                string[] cities_temp;
                while ((line = streamReader.ReadLine ()) != null) {
                    cities_temp = line.Split (' ');
                    cities[idx++] = Array.ConvertAll (cities_temp, Int32.Parse);
                }
            }

            System.Console.WriteLine ("9234981465 Cost:" + roadsAndLibraries (96295, 99058, 75153, cities));

            cities = new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 1 },
                new int[] { 2, 3 }
            };
            System.Console.WriteLine ("4 Cost:" + roadsAndLibraries (3, 2, 1, cities));

            cities = new int[][] {
                new int[] { 8, 2 },
                new int[] { 2, 9 },
            };
            System.Console.WriteLine ("805 Cost:" + roadsAndLibraries (9, 91, 84, cities));

            cities = new int[][] {
                new int[] { 2, 1 },
                new int[] { 5, 3 },
                new int[] { 5, 1 },
                new int[] { 3, 4 },
                new int[] { 3, 1 },
                new int[] { 5, 4 },
                new int[] { 4, 1 },
                new int[] { 5, 2 },
                new int[] { 4, 2 },
            };
            System.Console.WriteLine ("184 Cost:" + roadsAndLibraries (5, 92, 23, cities));

            cities = new int[][] {
                new int[] { 6, 4 },
                new int[] { 3, 2 },
                new int[] { 7, 1 },
            };
            System.Console.WriteLine ("80 Cost:" + roadsAndLibraries (8, 10, 55, cities));

            cities = new int[][] { };
            System.Console.WriteLine ("5 Cost:" + roadsAndLibraries (1, 5, 3, cities));

            cities = new int[][] { };
            System.Console.WriteLine ("204 Cost:" + roadsAndLibraries (2, 102, 1, cities));

        }

        static long roadsAndLibraries (long n, long c_lib, long c_road, int[][] cities) {
            if (c_lib <= c_road || cities.Length == 0) {
                return c_lib * n;
            }

            Dictionary<int, City> citySet = new Dictionary<int, City> ();
            City start;
            City destination;
            foreach (var city in cities) {
                if (citySet.ContainsKey (city[0])) {
                    start = citySet[city[0]];
                } else {
                    start = new City (city[0]);
                    citySet.Add (city[0], start);
                }
                if (citySet.ContainsKey (city[1])) {
                    destination = citySet[city[1]];
                } else {
                    destination = new City (city[1]);
                    citySet.Add (city[1], destination);
                }
                start.Add (destination);
                destination.Add (start);
            }
            Tester tester = new Tester ();
            IList<long> group = new List<long> ();

            foreach (var city in citySet) {
                if (!city.Value.Connected) {
                    group.Add (tester.Count (city.Value) - 1);
                }
            }

            long cost = 0;

            //Linked City
            foreach (var number in group) {
                cost += (number * c_road) + c_lib;
            }

            //Independant City
            cost += (n - citySet.Count) * c_lib;

            return cost;
        }

    }

    public class Tester {
        public long Count (City city) {
            city.Connected = true;
            long count = 1;
            foreach (var neightbor in city.Neighbor) {
                if (!neightbor.Connected) count += Count (neightbor);
            }

            return count;
        }
    }
    public class City {
        public int Name { get; set; }
        public HashSet<City> Neighbor { get; set; } = new HashSet<City> ();
        public bool Connected { get; set; } = false;
        public City (int name) {
            this.Name = name;
        }
        public void Add (City city) {
            this.Neighbor.Add (city);
        }
    }
}