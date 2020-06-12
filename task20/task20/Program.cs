using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroDX = 0, heroDY = 0;
            int heroX = 3;
            int heroY = 1;
            bool canMove = false;
            char[,] map =
           {
            {'#','#','#','#','#','#','#','#','#','#','#','#' },
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            {'#',' ',' ','#','#','#','#',' ',' ',' ',' ','#' },
            {'#',' ',' ',' ','#','#',' ',' ',' ','#',' ','#' },
            {'#',' ',' ',' ',' ','#',' ',' ',' ','#','#','#' },
            {'#','#','#','#','#','#','#','#','#','#','#','#' }
        };
            RenderMap(map);
            map[heroX, heroY] = 'Y';
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(heroY, heroX);
                   
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ShooseDirectionmove(key,ref heroDX,ref heroDY);
                    canMove = CheckWalls(map,heroX,heroDX,heroY,heroDY);
                    if( canMove == true)
                    {
                        Move(map, ref heroX, ref heroY, heroDX, heroDY);
                    }                   
                }
            }
        }

        static void RenderMap(char[,] mapArray)
        {
            for (int i = 0; i < mapArray.GetLength(0); i++)
            {
                for (int j = 0; j < mapArray.GetLength(1); j++)
                {
                    Console.Write(mapArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Move( char[,] map,ref int heroX,ref int heroY,  int DX,int DY)
        {           
                map[heroX, heroY] = ' ';
                map[heroX + DX, heroY + DY] = 'Y';
                heroX += DX;
                heroY += DY;
                Console.Clear();
                RenderMap(map);           
        }

        static void ShooseDirectionmove(ConsoleKeyInfo key, ref int DX, ref int DY)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = -1;
                    DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1;
                    DY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0;
                    DY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0;
                    DY = 1;
                    break;
            }
        }
        static bool CheckWalls (char[,] map,int heroX,int DX,int heroY,int DY)
        {
            return map[heroX + DX, heroY + DY] != '#';
        }
    }
}