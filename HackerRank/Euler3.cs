using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.HackerRank {
    public class Euler3 : Quiz {
        public override void Test () {

            long n = 3*3*7;

            long N = n;
            long p = 1, f;
            for (f = 2; f * f <= N; ++f)
                while (N % f == 0) {
                    p = f;
                    N /= f;
                }
            if (N > 1) p = N;
            Console.WriteLine (p);
            //GetBiggestPrime (10);
        }
        public void GetBiggestPrime (long n) {

            if (IsPrime (n)) {
                System.Console.WriteLine (n);
            } else {
                HashSet<long> hash = new HashSet<long> ();
                FindPrime (n, hash);
                long biggest = 0;
                foreach (var item in hash) {
                    if (item > biggest) biggest = item;
                }
                System.Console.WriteLine (biggest);
            }

        }
        private void FindPrime (long n, HashSet<long> hash) {
            if (n == 1 || n == 2) {
                hash.Add (n);
                return;
            } else {
                long squreRoot = (long) Math.Sqrt (n);
                long compareStart = 1;

                compareStart = squreRoot % 2 == 0 ? squreRoot - 1 : squreRoot;
                bool dividable = false;
                long firstFactor = 0;
                long secondFactor = 0;
                for (long i = compareStart; i > 1; i -= 2) {
                    if (n % i == 0) {
                        dividable = true;
                        firstFactor = i;
                        break;
                    }
                }
                if (n % 2 == 0) {
                    dividable = true;
                    firstFactor = 2;
                }
                if (dividable) {
                    if (IsPrime (firstFactor)) {
                        hash.Add (firstFactor);
                    } else {
                        FindPrime (firstFactor, hash);
                    }
                    secondFactor = n / firstFactor;
                    if (IsPrime (secondFactor)) {
                        hash.Add (secondFactor);
                    } else {
                        FindPrime (secondFactor, hash);
                    }
                }

            }
        }
        private bool IsPrime (long n) {
            if (n == 1 || n == 2) {
                return true;
            } else {
                long squreRoot = (long) Math.Sqrt (n);
                long compareStart = 1;
                if (squreRoot % 2 == 0) compareStart = squreRoot - 1;
                else compareStart = squreRoot;
                bool isPrime = true;

                for (long i = compareStart; i > 2; i -= 2) {
                    if (n % i == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (n % 2 == 0) {
                    isPrime = false;
                }
                return isPrime;
            }
        }
    }
}