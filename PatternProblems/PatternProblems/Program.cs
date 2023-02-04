using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintSquareBoardPattern(n));
            Console.WriteLine(PrintCheckBoardPattern(n));
        }
        public static string PrintSquareBoardPattern(int n)
        {
            string temp = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    temp += "#";
                }
                temp += "\n";
            }
            return temp;
        }
        public static string PrintCheckBoardPattern(int n)
        {
            string temp = "";
            for (int rows = 1; rows <= n; rows++)
            {
                if (rows % 2 == 0)
                {
                    temp += " ";
                }

                for (int col = 1; col <= n; col++)
                {
                    temp += "#";
                }

                temp += "\n";
            }
            return temp;
        }
    }
}
