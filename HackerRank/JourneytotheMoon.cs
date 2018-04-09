using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.HackerRank {
    public class JourneytotheMoon : Quiz {
        //https://www.hackerrank.com/challenges/journey-to-the-moon/problem
        public override void Test () {
            int n = 5;
            int[][] astronaut = new int[][] {
                new int[] { 0, 1 },
                new int[] { 2, 3 },
                new int[] { 0, 4 }
            };
            long result = journeyToMoon (n, astronaut);
            Console.WriteLine (result);

            n = 4;
            astronaut = new int[][] {
                new int[] { 0, 2 },
            };
            result = journeyToMoon (n, astronaut);
            Console.WriteLine (result);

            n = 100000;
            astronaut = new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
            };
            result = journeyToMoon (n, astronaut);
            Console.WriteLine (result);
        }

        static long journeyToMoon (int n, int[][] astronaut) {
            Dictionary<int, Astronaut> astronautList = new Dictionary<int, Astronaut> ();
            Astronaut person;
            Astronaut person2;

            foreach (var item in astronaut) {
                if (astronautList.ContainsKey (item[0])) {
                    person = astronautList[item[0]];
                } else {
                    person = new Astronaut (item[0]);
                    astronautList.Add (item[0], person);
                }
                if (astronautList.ContainsKey (item[1])) {
                    person2 = astronautList[item[1]];
                } else {
                    person2 = new Astronaut (item[1]);
                    astronautList.Add (item[1], person2);
                }
                person.Add (person2);
                person2.Add (person);
            }
            List<int> count = new List<int> ();
            Tester tester = new Tester ();
            foreach (var item in astronautList) {
                if (!item.Value.Visited) {
                    count.Add (tester.CountGroup (item.Value));
                }
            }
            long result = 0;
            int numberOfSingle = n - astronautList.Count;
            for (int i = 0; i < count.Count; i++) {
                for (int j = i + 1; j < count.Count; j++) {
                    result += count[i] * count[j];
                }
                result += count[i] * numberOfSingle;
            }
            if (numberOfSingle > 1) {
                // numberOfsingle Combination 2
                // n! / 2!(n-2)!
                int N = numberOfSingle;
                long combination = 1;

                if (N - 2 == 0) {
                    result += 1;
                } else {
                    for (long i = N; i > N - 2; i--) {
                        combination = combination * i;
                    }                 
                    result += (combination / 2);
                }
            }
            return result;
        }
        public class Astronaut {
            public int ID { get; set; }
            public HashSet<Astronaut> Pairs { get; set; } = new HashSet<Astronaut> ();
            public bool Visited { get; set; } = false;
            public Astronaut (int id) {
                this.ID = id;
            }
            public void Add (Astronaut a) {
                Pairs.Add (a);
            }
        }
        public class Tester {
            public int CountGroup (Astronaut astronaut) {

                astronaut.Visited = true;
                int count = 1;
                foreach (var pairs in astronaut.Pairs) {
                    if (!pairs.Visited) {
                        count += CountGroup (pairs);
                    }
                }
                return count;
            }

        }
    }
}