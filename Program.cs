using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace DemoXO1
{
    internal class Program
    {
        static void Main(string[] args)
        { int i, j,f;
            int xo;
            string temp;
            int r,pob,nech,igr;
            igr = 0;
            while (igr == 0)
            {
                xo = 2;
                r = 4;
                Board nextboard = new Board();
                nextboard.Writes();
                while (r == 4)
                {
                    f = 0;
                    if (xo == 2)
                        Console.WriteLine("Ход крестиком. Введите координаты:");
                    else
                        Console.WriteLine("Ход ноликом. Введите координаты:");
                    while (f == 0)
                    {
                        temp = Console.ReadLine();
                        i = Convert.ToInt32(temp[0]) - '0';
                        j = Convert.ToInt32(temp[2]) - '0';
                        f = nextboard.tap(i, j, xo);
                    }
                    nextboard.Writes();
                    pob = nextboard.win(xo);
                    if (pob == 0)
                    {
                        nech = nextboard.is_nothing();
                        if (nech == 1) r = 3;
                    }
                    else if (xo == 2) r = 2;
                    else r = 1;
                    if (xo == 2) xo = 1;
                    else xo = 2;
                }
                if (r == 1) Console.WriteLine("Нолики победили");
                if (r == 2) Console.WriteLine("Крестики победили");
                if (r == 3) Console.WriteLine("Ничья");
                Console.WriteLine("Игра окончена");
                Console.WriteLine("Чтобы сыграть снова нажмите 0, иначе нажмите 1");
                temp = Console.ReadLine();
                igr = Convert.ToInt32(temp[0]) - '0';
                if (igr == 0) r = 4;
            }
        }
    }
}
