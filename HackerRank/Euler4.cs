using System;
using System.Collections.Generic;
using CrackingTheCode6th;

namespace CrackingTheCode6th.HackerRank
{
    public class Euler4 : Quiz
    {
        HashSet<int> palindrome = new HashSet<int>();

        public override void Test()
        {
            int temp;
            for (int i = 101; i < 999; i++)
            {
                for (int j = 101; j < 999; j++)
                {
                    temp = i*j;
                    if(Palindrome(temp)){
                        palindrome.Add(temp);
                    }
                }
            }

            Run(101110); // 101101            
            Run(800000); // 793397
        }

        private void Run(int v)
        {
            for (int i = v; i >= 101101; i--)
            {
                if(palindrome.Contains(i)){
                    System.Console.WriteLine(i);
                    break;
                }
            }
        }

        private bool Palindrome(int num)
        {
            string str = num.ToString();
            string opp = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                opp += str[i];
            }
            return str == opp;
        }
    }
}