using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bull_PC_game_
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new Chek();
            int number;

            Console.Write("Загадай число : ");
            number = Convert.ToInt32(Console.ReadLine());
            num.Cheking(number);
            num.GetInNum();
            Console.ReadKey();
        }
    }
}
