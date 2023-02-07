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
            //Console.WriteLine(PrintSquareBoardPattern(n));
            //Console.WriteLine(PrintCheckBoardPattern(n));
            //Console.WriteLine(PatternA(n));
            //Console.WriteLine(PatternB(n));
            //Console.WriteLine(PatternC(n));
            //Console.WriteLine(PatternD(n));
            //Console.WriteLine(SquarePatternE(n));
            //Console.WriteLine(ReverseZPatternF(n));
            //Console.WriteLine(ZPatternG(n));
            //Console.WriteLine(PatternH(n));
            //Console.WriteLine(PatternB1(n));
            //onsole.WriteLine(PatternI(n));
            //Console.WriteLine(AlphaPattern(n));
            //Console.WriteLine(NumberPattern1(n));
            //Console.WriteLine(NumberPattern2(n));
            //Console.WriteLine(Pattern1(n));
            //Console.WriteLine(Pattern2(n));
            //Console.WriteLine(Pattern3(n));
            //Console.WriteLine(Pattern4(n));
            //Console.WriteLine(Pattern5(n));
            //Console.WriteLine(InvertedPyramid(n));
            //Console.WriteLine(PyramidPattern(n)+InvertedPyramid(n));
            //Console.WriteLine(PatternPyramidC(n));
            //Console.WriteLine(NoPramidPatternD(n));
            //Console.WriteLine(NoPramidPatternE(n));
            Console.WriteLine(NoPramidPatternF(n));
        }
        public static string PrintSquareBoardPattern(int n)
        {
            string temp = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    temp += "# ";
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
                    temp += "# ";
                }

                temp += "\n";
            }
            return temp;
        }

        public static string PatternA(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string PatternB(int n)
        {
            string temp = "";

            for (int row = 1; row <= n; row++)
            {
                for (int col = n; col >= row; col--)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string PatternC(int n)
        {
            string temp = "";
            int space = 1;

            for (int row = 1; row <= n; row++)
            {
                for (space = 1; space <= row - 1; space++)
                {
                    temp += "  ";
                }

                for (int col = space; col <= n; col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }

            return temp;
        }


        public static string PatternD(int n)
        {
            string temp = "";
            for (int row = 0; row <= n; row++)
            {
                for (int space = 1; space <= n - row; space++)
                {
                    temp += "  ";
                }
                for (int col = 1; col <= row; col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }


        public static string SquarePatternE(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {

                    if (row == 1 || row == n || col == 1 || col == n)
                    {
                        temp += "# ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
            }
            return temp;
        }


        public static string ReverseZPatternF(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == 1 || row == n || row == col)
                    {
                        temp += "# ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
            }
            return temp;
        }


        public static string ZPatternG(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == 1 || row == n || col + row == n + 1)
                    {
                        temp += "# ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
            }
            return temp;
        }

        public static string PatternH(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == 1 || row == n || row == col || row + col == n + 1)
                    {
                        temp += "# ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
            }
            return temp;
        }

        public static string PatternB1(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= (n - row) + 1; col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string PatternI(int n)
        {
            string temp = "";
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col == 1 || col == n || row == 1 || row == n || row == col || row + col == n + 1)
                    {
                        temp += "# ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
            }
            return temp;
        }

        public static string AlphaPattern(int n)
        {
            string temp = "";
            int alpha = 96;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    alpha = alpha + 1;
                    temp += ((char)alpha).ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }


        public static string NumberPattern1(int n)
        {
            string temp = "";
            int alpha = 48;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    int ascii = alpha + row;
                    temp += ((char)ascii).ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string NumberPattern2(int n)
        {
            string temp = "";
            int alpha = 48;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    alpha = alpha + 1;
                    temp += ((char)alpha).ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string Pattern1(int n)
        {
            string temp = "";
            for (int row = 1; row <= 2*n-1; row++)
            {
                int hash = row;
                if (row > n)
                { 
                    hash=2*n-row;
                }
                for (int col = 1; col <= hash; col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string Pattern2(int n)
        {
            string temp = "";
            for (int row = 1; row <= 2 * n - 1; row++)
            {
                int one = row;
                if(row>n)
                {
                one=2*n-row;
                }

                for (int col = 1; col <= one; col++)
                {
                    temp += "1 ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string Pattern3(int n)
        {
            int alpha = 96;
            string temp = "";
            for (int row = 1; row <= 2 * n - 1; row++)
            {
                int letters = row;
                if (row > n)
                {
                    letters = 2 * n - row;
                }
                for (int col = 1; col <= letters; col++)
                {
                    alpha = alpha + 1;
                    temp += ((char)alpha).ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string Pattern4(int n)
        {
            string temp = "";
            for(int row=1;row<=2*n;row++)
            {
                for (int col = 1; col <=n; col++)
                {
                    if (row == col || row + col == 2*n + 1)
                    {
                        temp += "# ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
            }
            return temp;
        }

        public static string Pattern5(int n)
        {
            string temp = "";
            for (int row = 1; row <= 2 * n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == col || row + col == 2 * n + 1)
                    {
                        temp += "1 ";
                    }
                    else
                    {
                        temp += "  ";
                    }
                }
                temp += "\n";
                
            }
            return temp;
        }

        public static string InvertedPyramid(int n)
        {
            string temp = "";
            int space = 0;
            for (int row = 1; row <= n; row++)
            {
                for (space = 1; space <= row - 1; space++)
                {
                    temp += "  ";
                }
                for (int col = space; col <= n + n - 1 - (row - 1); col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }
    
        public static string PyramidPattern(int n)
        {
            string temp = "";
            int space=0;
            for (int row = 1; row <= n; row++)
            {
                for (space = 1; space <= n - row; space++)
                {
                    temp += "  ";
                }
                for (int col = space; col <= n + n - 1 - (n - row); col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string PatternPyramidC(int n)
        {
            string temp = "";
            int space = 0;
            for (int row = 1; row <= n + n - 1; row++)
            {
                int spacelimit = n - row;
                if (row > n)
                {
                    spacelimit = row - n;
                }
                for (space = 1; space <= spacelimit; space++)
                {
                    temp += "  ";
                }
                for (int col = space; col <= n + n - 1 - (spacelimit); col++)
                {
                    temp += "# ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string NoPramidPatternD(int n)
        {
            string temp = "";
            int alpha = 48;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    int ascii = alpha + col;
                    temp += ((char)ascii).ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string NoPramidPatternE(int n)
        {
            string temp = "";
            int space = 0;
            int alpha = 48;
            for (int row = 1; row <= n; row++)
            {
                for (space = 1; space <= row - 1; space++)
                {
                    temp += "  ";
                }
                for (int col = 1; col <= n - (row - 1); col++)
                {
                    int ascii = alpha + col;
                    temp += ((char)ascii).ToString()+" ";
                }
                temp += "\n";
            }
            return temp;
        }

        public static string NoPramidPatternF(int n)
        {
            string temp = "";
            int ascii = 48;
            for (int row = 1; row <= n; row++)
            {
                for (int space = 1; space <= n - row; space++)
                {
                    temp += "  ";
                }
                for (int col = n - (n - row); col >= 1; col--)
                { 
                    int alpha=ascii+col;
                    temp += ((char)alpha).ToString() + " ";
                }
                temp += "\n";
            }
            return temp;
        }
    }
    }

