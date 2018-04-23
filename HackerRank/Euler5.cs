using System;
using System.Collections.Generic;
using CrackingTheCode6th;

namespace CrackingTheCode6th.HackerRank
{
    public class Euler5 : Quiz
    {
        Dictionary<int, int> TotalPrimes = new Dictionary<int, int>();
        Dictionary<int, double> Answer = new Dictionary<int, double>();
        Dictionary<int, int> SubPrimes = new Dictionary<int, int>();
        public override void Test()
        {
            for (int i = 1; i <= 40; i++)
            {
                SubPrimes = GetPrimes(i);
                foreach (var item in SubPrimes)
                {
                    if (!TotalPrimes.ContainsKey(item.Key)) TotalPrimes[item.Key] = 0;
                    if (TotalPrimes[item.Key] < item.Value)
                    {
                        TotalPrimes[item.Key] += item.Value - TotalPrimes[item.Key];
                    }
                }
                if (!Answer.ContainsKey(i)) Answer[i] = 1;
                foreach (var item in TotalPrimes)
                {                    
                    Answer[i] *= Math.Pow(item.Key,item.Value);
                }
            }
            
            System.Console.WriteLine(Answer[3]);
            System.Console.WriteLine(Answer[10]);
        }

        public static Dictionary<int, int> GetPrimes(int value)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            if (value == 1)
            {
                temp[1] = 1;
                return temp;
            }
            for (int i = 2; i <= value; i++)
            {
                while (value % i == 0)
                {
                    if (!temp.ContainsKey(i))
                    {
                        temp[i] = 0;
                    }
                    temp[i]++;
                    value /= i;
                }
            }
            return temp;
        }


    }
}