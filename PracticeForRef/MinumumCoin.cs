using System;
namespace CrackingTheCode6th.PracticeForRef {
    public class MinumumCoin : Quiz {

        public override void Test () {
            Console.WriteLine ("Input Expected Number: ");
            int expected = Int32.Parse (Console.ReadLine ());
            int[] coins = new int[] { 1, 3, 5 };
            Coins result = new Coins { Count = 0, One = 0, Five = 0, Three = 0 };
            result = GetMinimum (coins, expected, result);
            System.Console.WriteLine ("Required minimum number of Coins is : " + result.Count);
            System.Console.WriteLine (string.Format ("One: {0}, Three: {1}, Five:{2}", result.One, result.Three, result.Five));

        }

        private Coins GetMinimum (int[] coins, int expected, Coins dto) {
            if (expected == 0) return new Coins { Count = 0, One = 0, Five = 0, Three = 0 };
            else if (expected < 0) return new Coins { Count = Int32.MaxValue };

            int current = 0;
            Coins temp = new Coins { Count = Int32.MaxValue, One = 0, Five = 0, Three = 0 };
            foreach (int coin in coins) {
                Coins sub_temp = GetMinimum (coins, expected - coin, dto);
                if (sub_temp.Count < temp.Count) {
                    temp = sub_temp;
                    current = coin;
                }
            }
            if (current == 1) temp.One++;
            if (current == 3) temp.Three++;
            if (current == 5) temp.Five++;
            temp.Count++;
            return temp;
        }
    }

    public struct Coins {
        public int Count;
        public int One;
        public int Three;
        public int Five;
    }
}