using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    public class Chech : Generet
    {

        public string Chek(int number, int[] num)
        {
            int cows = 0, bulls = 0;
            int[] ChNum = new int[4];
            for (int i = 3; i > -1; i--)
            {
                ChNum[i] = number % 10;
                number = number / 10;
                for (int j = 0; j < 4; j++)
                {
                    if ((ChNum[i] == num[j]) && (i == j))
                    {
                        bulls++;
                    }
                    if ((ChNum[i] == num[j]) && (i != j))
                    {
                        cows++;
                    }
                }
            }
            if (bulls > 3)
            {
                return ("YOU WIN");
            }
            else
            {
                return ($"Быков -> {bulls} | Коров -> {cows} ");
            }
        }
    }
}

