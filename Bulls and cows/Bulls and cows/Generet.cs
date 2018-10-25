using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    public class Generet
    {
        public int[] Ganerete()
        {
            int value = new Random().Next(1, 9);
            int[] arrNum= new int[4];
            arrNum[0] = value;
            for (var i = 1; i < 4; i++)
            {
                gen1:
                int value1 = new Random().Next(0, 9);
                for (var j = 0; j < i; j++)
                {
                    if (arrNum[j] == value1)
                    {
                        goto gen1;
                    }  
                }
                arrNum[i] = value1;
            }
            return arrNum;
        }
         
    }
}
