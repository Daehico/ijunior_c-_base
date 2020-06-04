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
            int heroDX, heroDY;
            int heroX = 3;
            int heroY = 1;
            bool canMove;
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
           
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(heroY, heroX);
                    map[heroX, heroY] = 'Y';
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            heroDX = -1;
                            heroDY = 0;
                            canMove = Move(heroDX, heroDY, heroX, heroY, map);
                            if(canMove == true)
                            {
                                heroX = MoveCursorX(heroDX, heroX);
                                heroY = MoveCursorY(heroDY, heroY);
                            }
                            
                            break;
                        case ConsoleKey.DownArrow:
                            heroDX = 1;
                            heroDY = 0;
                            canMove = Move(heroDX, heroDY, heroX, heroY, map);
                            if (canMove == true)
                            {
                                heroX = MoveCursorX(heroDX, heroX);
                                heroY = MoveCursorY(heroDY, heroY);
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            heroDX = 0;
                            heroDY = -1;
                            canMove = Move(heroDX, heroDY, heroX, heroY, map);
                            if (canMove == true)
                            {
                                heroX = MoveCursorX(heroDX, heroX);
                                heroY = MoveCursorY(heroDY, heroY);
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            heroDX = 0;
                            heroDY = 1;
                            canMove = Move(heroDX, heroDY, heroX, heroY, map);
                            if (canMove == true)
                            {
                                heroX = MoveCursorX(heroDX, heroX);
                                heroY = MoveCursorY(heroDY, heroY);
                            }
                            break;
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

        static bool Move(int DX, int DY,int heroX,int heroY, char[,] map)
        {
            if(map[heroX+DX, heroY+DY] != '#')
            {
                map[heroX, heroY] = ' ';
                map[heroX + DX, heroY + DY] = 'Y';
                Console.Clear();
                RenderMap(map);
                return true;
            }
            return false;
        }

        static int MoveCursorX(int DX, int x)
        {
            return x += DX;

        }

        static int MoveCursorY(int DY, int y)
        {
            return y += DY;
        }
    }
}
