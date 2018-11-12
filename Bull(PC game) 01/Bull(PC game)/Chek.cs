using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bull_PC_game_
{
    class Chek
    {
        private static int[] InNum = new int[4];

        public void GetInNum()
        {
            Console.WriteLine($"PC WIN NUMBER");
            for (int i=0; i<4;i++)
            {
                Console.Write($"{InNum[i]}");
            }
        }

        public void Cheking(int number)
        {
            int k = 0, k1 = 0, bulls=0;

            int[] ChNum = new int[4];
            
            for (var i = 3; i != -1; i--)
            {
                 ChNum[i] = number % 10;
                 number = number / 10;
            }
            int dig = 0;
            while (bulls != 4)
            {
                if (InNum[k] != ChNum[k])
                {
                    k1++;
                    InNum[k] = dig;
                    dig++;
                    //Console.WriteLine($"{InNum[k]}");
                }
                else
                {
                    if (k < 4)
                    {
                        //Console.WriteLine($"----{k}----");
                        k++;
                        dig = 0;
                        bulls++;
                    }
                }
            }
        }
    }
}
