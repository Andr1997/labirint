using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace labirint
{
    class Program
    {
        static void Main(string[] args)
        {
            PathFinder(".W....W....W.W....W....W.");
            Console.ReadKey();
        }

        public static bool PathFinder(string maze)
        {
            int sqrt = Convert.ToInt32(Math.Sqrt(maze.Length));
            int x, y;
            bool d, r, u, l;
            d = r = u = l = true;
            x = y = 0;
            char [,] tab = new char[sqrt,sqrt];
            tab = FormateArray(maze, sqrt);

            List<string> infoData = new List<string>();
            


        Down:
            {
                if (x < sqrt)
                {
                    if (tab[x, y] != 'W')
                    {
                        tab[x, y] = '+';
                        infoData.Add("Down");
                        x++;
                    }
                    else goto Right;
                }
                else goto Right;
            }

        Right:
            {
                if (y < sqrt)
                {
                    if (tab[x, y] != 'W')
                    {
                        tab[x, y] = '+';
                        infoData.Add("Right");
                        y++;
                    }
                    else goto Up;
                }
                else goto Up;
            }

        Up:
            {
                if (x > sqrt)
                {
                    if (tab[x, y] != 'W')
                    {
                        tab[x, y] = '+';
                        infoData.Add("Up");
                        x--;
                    }
                    else goto Left;
                }
                else goto Left;
            }
        Left:
            {
                if (y > sqrt)
                {
                    if (tab[x, y] != 'W')
                    {
                        tab[x, y] = '+';
                        infoData.Add("Left");
                        y--;
                    }
                    //else goto Up;
                }
                //else goto Down;
            }
            Afisare(tab,sqrt);

            return false;
        }

        

        public static char[,] FormateArray(string maze , int sqrt )
        {
            char[,] arr = new char[sqrt,sqrt];
            char[] tabchar = new char[100];

            for (int i = 0; i < sqrt; i++)
            {
                for (int j = 0; j < sqrt; j++)
                {
                    tabchar = maze.ToCharArray();
                    arr[i, j] = tabchar[0];
                    maze = maze.Remove(0, 1);
                }
            }

            return arr;
        }


        public static void Afisare(char[,] arr, int sqrt)
        {
            for (int i = 0; i < sqrt; i++)
            {
                for (int j = 0; j < sqrt; j++)
                {
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }

    }
}
