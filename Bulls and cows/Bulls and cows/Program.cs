using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    class Program
    {
        static void Main(string[] args)
        {
            var Num = new Generet();
            var chek = new Chech();
            int[] numb = Num.Ganerete();
            for (int i = 0; i < numb.Length; i++)
            {
                Console.Write(numb[i]);
            }
            Console.WriteLine();
            string game = "YOU LOST";
            int number;
            while (game != "YOU WIN")
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                game = chek.Chek(number, numb);
                Console.WriteLine(game);
            }


            Console.ReadKey();
        }
    }

}
