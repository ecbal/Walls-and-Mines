using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace ConsoleApp72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Write("***************\r\n***************\r\n***************\r\n***************\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n***************\r\n***************\r\n***************\r\n***************\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n***************\r\n***************\r\n***************\r\n***************");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("***************\r\n***************\r\n***************\r\n***************\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n***************\r\n***************\r\n***************\r\n***************\r\n******         \r\n******\r\n******\r\n******\r\n***************\r\n***************\r\n***************\r\n***************");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n         ******\r\n    \r\n");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("***************************      *************************** \r\n***************************      ***************************\r\n***************************      ***************************\r\n***************************      ***************************\r\n******                           ******               ******\r\n******                           ******               ******\r\n******                           ******               ******\r\n******                           ******               ******\r\n******                           ******               ******\r\n******     ****************      ******               ******\r\n******     ****************      ******               ******\r\n******     ****************      ******               ******\r\n******     ****************      ******               ******\r\n******              *******      ******               ******\r\n******              *******      ******               ******\r\n******              *******      ******               ******\r\n***************************      ***************************\r\n***************************      ***************************\r\n***************************      ***************************\r\n***************************      ***************************\r\n");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;
            char[,] map = new char[23, 53];
            for (int i = 0; i < map.GetLength(0); i++)// for vertical border walls
            {
                map[i, 0] = '#';
                map[i, 52] = '#';
            }
            for (int i = 0; i < map.GetLength(1); i++)// for horizantal border walls
            {
                map[0, i] = '#';
                map[22, i] = '#';
            }
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == '#')
                    {
                        continue;
                    }
                    else
                    {
                        map[i, j] = ' ';
                    }
                }
            }

            
            Random rand = new Random();
            int counter, wall_status;
            bool[,] walls = new bool[40, 4];
            int p = 0;


            while (p < 40)
            {
                counter = 0;
                for (int j = 0; j < walls.GetLength(1); j++)
                {
                    wall_status = rand.Next(1, 3);
                    if (wall_status == 1)
                    {
                        walls[p, j] = true;
                        counter++;
                    }
                    else if (wall_status == 2)
                    {
                        walls[p, j] = false;
                    }
                }
                if (counter < 4 && counter > 0)
                {
                    p++;
                }
            }
            for (int i = 0; i < walls.GetLength(0); i++)
            {
                for (int j = 0; j < walls.GetLength(1); j++)
                {
                    if (walls[i, j] == true)
                    {
                        if (j == 0)
                        {
                            map[5 * (i / 10) + 2, 5 * (i % 10) + 2] = '#';
                            map[5 * (i / 10) + 2, 5 * (i % 10) + 3] = '#';
                            map[5 * (i / 10) + 2, 5 * (i % 10) + 4] = '#';
                            map[5 * (i / 10) + 2, 5 * (i % 10) + 5] = '#';
                        }
                        else if (j == 1)
                        {
                            map[5 * (i / 10) + 2, 5 * (i % 10) + 5] = '#';
                            map[5 * (i / 10) + 3, 5 * (i % 10) + 5] = '#';
                            map[5 * (i / 10) + 4, 5 * (i % 10) + 5] = '#';
                            map[5 * (i / 10) + 5, 5 * (i % 10) + 5] = '#';
                        }
                        else if (j == 2)
                        {
                            map[5 * (i / 10) + 5, 5 * (i % 10) + 2] = '#';
                            map[5 * (i / 10) + 5, 5 * (i % 10) + 3] = '#';
                            map[5 * (i / 10) + 5, 5 * (i % 10) + 4] = '#';
                            map[5 * (i / 10) + 5, 5 * (i % 10) + 5] = '#';

                        }
                        else if (j == 3)
                        {
                            map[5 * (i / 10) + 2, 5 * (i % 10) + 2] = '#';
                            map[5 * (i / 10) + 3, 5 * (i % 10) + 2] = '#';
                            map[5 * (i / 10) + 4, 5 * (i % 10) + 2] = '#';
                            map[5 * (i / 10) + 5, 5 * (i % 10) + 2] = '#';

                        }
                    }
                }
            }
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] != '#')
                    {
                        map[i, j] = ' ';
                    }
                }
            }
            int botcounter = 0;
            int randombotx, randomboty;
            while (botcounter<2)
            {
                randombotx = rand.Next(0, 53);
                randomboty = rand.Next(0, 23);
                if (map[randomboty,randombotx]!='#')
                {
                    map[randomboty, randombotx] = 'X';
                    botcounter++;
                }
                
            }

            botcounter= 0;
            while (botcounter < 2)
            {
                randombotx = rand.Next(0, 53);
                randomboty = rand.Next(0, 23);
                if (map[randomboty, randombotx] != '#')
                {
                    map[randomboty, randombotx] = 'Y';
                    botcounter++;
                }

            }
            int cursorx = 1, cursory = 1; // position of cursor
            
            ConsoleKeyInfo cki; // required for readkey
            
            int counter4 = 0,randomnumberx,randomnumbery,randomnumber;
            while (counter4 < 20)
            {
                randomnumbery = rand.Next(0, 53);
                randomnumberx = rand.Next(0, 23);
                randomnumber = rand.Next(0, 10);
                if(randomnumber<=5)
                {
                    if(map[randomnumberx,randomnumbery]==' ')
                    {
                        map[randomnumberx, randomnumbery] = '1';
                        counter4++;
                    }
                }
                else if (randomnumber > 5&& randomnumber<=8)
                {
                    if (map[randomnumberx, randomnumbery] == ' ')
                    {
                        map[randomnumberx, randomnumbery] = '2';
                        counter4++;
                    }
                }
                else if (randomnumber == 9)
                {
                    if (map[randomnumberx, randomnumbery] == ' ')
                    {
                        map[randomnumberx, randomnumbery] = '3';
                        counter4++;
                    }
                }


            }
           
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
            int movementcounter = 0;
            bool gameoverflag=false;
            //// --- Main game loop
            DateTime startTime = DateTime.Now;
            int time = 0,counter3=0;
            int score = 0, energy = 200, mine = 0, minex = cursorx, miney = cursory;
            while (true)
            {
                movementcounter++;
                bool flag = true;
                if (Console.KeyAvailable)
                { // true: there is a key in keyboard buffer
                    cki = Console.ReadKey(true); // true: do not write character
                    if (energy == 0)
                    {
                        if (movementcounter % 2 == 0)
                        {
                            if (cki.Key == ConsoleKey.RightArrow && cursorx < 51 && map[cursory, cursorx + 1] != '#')
                            {
                                minex = cursorx;
                                miney = cursory;

                                map[cursory, cursorx] = ' ';
                                cursorx++;
                                if (energy != 0)
                                {
                                    energy--;
                                }

                            }

                            if (cki.Key == ConsoleKey.LeftArrow && cursorx >= 1 && map[cursory, cursorx - 1] != '#')
                            {
                                minex = cursorx;
                                miney = cursory;

                                map[cursory, cursorx] = ' ';

                                cursorx--;
                                if (energy != 0)
                                {
                                    energy--;
                                }
                            }

                            if (cki.Key == ConsoleKey.UpArrow && cursory >= 1 && map[cursory - 1, cursorx] != '#')
                            {
                                minex = cursorx;
                                miney = cursory;

                                map[cursory, cursorx] = ' ';

                                cursory--;
                                if (energy != 0)
                                {
                                    energy--;
                                }
                            }

                            if (cki.Key == ConsoleKey.DownArrow && cursory < 21 && map[cursory + 1, cursorx] != '#')
                            {

                                minex = cursorx;
                                miney = cursory;

                                map[cursory, cursorx] = ' ';

                                if (energy != 0)
                                {
                                    energy--;
                                }
                                cursory++;


                            }

                        }
                    }
                    else
                    {
                        if (cki.Key == ConsoleKey.RightArrow && cursorx < 51 && map[cursory, cursorx + 1] != '#')
                        {
                            minex = cursorx;
                            miney = cursory;

                            map[cursory, cursorx] = ' ';
                            cursorx++;
                            if (energy != 0)
                            {
                                energy--;
                            }

                        }

                        if (cki.Key == ConsoleKey.LeftArrow && cursorx >= 1 && map[cursory, cursorx - 1] != '#')
                        {
                            minex = cursorx;
                            miney = cursory;

                            map[cursory, cursorx] = ' ';

                            cursorx--;
                            if (energy != 0)
                            {
                                energy--;
                            }
                        }

                        if (cki.Key == ConsoleKey.UpArrow && cursory >= 1 && map[cursory - 1, cursorx] != '#')
                        {
                            minex = cursorx;
                            miney = cursory;

                            map[cursory, cursorx] = ' ';

                            cursory--;
                            if (energy != 0)
                            {
                                energy--;
                            }
                        }

                        if (cki.Key == ConsoleKey.DownArrow && cursory < 21 && map[cursory + 1, cursorx] != '#')
                        {

                            minex = cursorx;
                            miney = cursory;

                            map[cursory, cursorx] = ' ';

                            if (energy != 0)
                            {
                                energy--;
                            }
                            cursory++;


                        }
                    }
                    
                    
                    if (cki.Key == ConsoleKey.Spacebar&&mine!=0)
                    {
                        map[miney, minex] = '+';
                        mine--;
                    }

                    if (cki.Key == ConsoleKey.Escape)
                    {
                        Console.SetCursorPosition(60, 4);
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"GAME OVER");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        break;
                    }  
                }
                int xory;
                
                while(true)
                {
                    if (movementcounter % 150 == 0)
                    {
                        randombotx = rand.Next(0, 23);
                        randomboty = rand.Next(0, 53);
                        xory = rand.Next(0, 2);
                        if (xory == 0  && map[randombotx,randomboty]==' ')
                        {
                            map[randombotx, randomboty] = 'X';
                            break;
                        }
                        else if (xory == 1 && map[randombotx, randomboty] == ' ')
                        {
                            map[randombotx, randomboty] = 'Y';
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                
                int beforebotx=0, beforeboty=0;
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == 'X' && movementcounter % 2 == 0 && (beforebotx != j || beforeboty != i))
                        {
                            if (j < cursorx && map[i, j + 1] != '#' && map[i, j + 1] != 'X' && map[i, j + 1] != 'Y')
                            {

                                if (map[i,j+1]=='+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i, j + 1] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i, j + 1] = 'X';
                                    beforebotx= j+1;
                                    beforeboty = i;
                                }
                                
                            }
                            else if (j > cursorx && map[i, j - 1] != '#' && map[i, j - 1] != 'X' && map[i, j - 1] != 'Y')
                            {
                                if (map[i, j - 1] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i, j - 1] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i, j - 1] = 'X';
                                    beforebotx = j - 1;
                                    beforeboty = i;
                               
                                }
                            }
                            else if (i > cursory && map[i - 1, j] != '#' && map[i - 1, j] != 'X' && map[i - 1, j] != 'Y') 
                            {
                                if (map[i-1, j] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i-1, j] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i-1, j] = 'X';
                                    beforebotx = j;
                                    beforeboty = i-1;
                            
                                }
                            }
                            else if (i < cursory && map[i + 1, j] != '#' && map[i + 1, j] != 'X' && map[i + 1, j] != 'Y')
                            {
                                if (map[i + 1, j] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i+1, j] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i + 1, j] = 'X';
                                    beforebotx = j;
                                    beforeboty = i + 1;
                                   
                                }
                            }                          
                        }
                    }
                }
                beforebotx = 0;
                beforeboty = 0;
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == 'Y' && movementcounter % 2 == 0 && (beforebotx != j || beforeboty != i))
                        {
                            
                            if (i > cursory && map[i - 1, j] != '#' && map[i - 1, j] != 'X' && map[i - 1, j] != 'Y')
                            {
                                if (map[i - 1, j] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i - 1, j] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i - 1, j] = 'Y';
                                    beforebotx = j;
                                    beforeboty = i - 1;

                                }
                            }
                            else if (i < cursory && map[i + 1, j] != '#' && map[i + 1, j] != 'X' && map[i + 1, j] != 'Y')
                            {
                                if (map[i + 1, j] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i + 1, j] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i + 1, j] = 'Y';
                                    beforebotx = j;
                                    beforeboty = i + 1;

                                }
                            }
                            else if (j < cursorx && map[i, j + 1] != '#' && map[i, j + 1] != 'X' && map[i, j + 1] != 'Y')
                            {

                                if (map[i, j + 1] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i, j + 1] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i, j + 1] = 'Y';
                                    beforebotx = j + 1;
                                    beforeboty = i;
                                }

                            }
                            else if (j > cursorx && map[i, j - 1] != '#' && map[i, j - 1] != 'X' && map[i, j - 1] != 'Y')
                            {
                                if (map[i, j - 1] == '+')
                                {
                                    map[i, j] = ' ';
                                    score += 300;
                                    map[i, j - 1] = ' ';
                                }
                                else
                                {
                                    map[i, j] = ' ';
                                    map[i, j - 1] = 'Y';
                                    beforebotx = j - 1;
                                    beforeboty = i;

                                }
                            }
                        }
                    }
                }

                int randomwall1 = rand.Next(0, 40);
                int randomwall2 = rand.Next(0, 4);
                int counter5 = 0;
                bool wallflag = false;

                for (int i = 0; i < 4; i++)
                {
                    if (walls[randomwall1,i]==true)
                    {
                        counter5++;
                    }
                }


                while(true)
                {
                    randomwall2 = rand.Next(0, 4);
                    if (walls[randomwall1, randomwall2] == false && counter5 != 3)
                    {
                        walls[randomwall1, randomwall2] = true;
                        break;
                    }
                    else if (walls[randomwall1, randomwall2] == true && counter5 != 1)
                    {
                        walls[randomwall1, randomwall2] = false;
                        break;
                    }
                }
                
                

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] == '#')
                        {
                            map[i, j] = ' ';
                        }
                        
                    }
                }

                for (int i = 0; i < walls.GetLength(0); i++)
                {
                    for (int j = 0; j < walls.GetLength(1); j++)
                    {
                        if (walls[i, j] == true)
                        {
                            if (j == 0)
                            {
                                map[5 * (i / 10) + 2, 5 * (i % 10) + 2] = '#';
                                map[5 * (i / 10) + 2, 5 * (i % 10) + 3] = '#';
                                map[5 * (i / 10) + 2, 5 * (i % 10) + 4] = '#';
                                map[5 * (i / 10) + 2, 5 * (i % 10) + 5] = '#';
                            }
                            else if (j == 1)
                            {
                                map[5 * (i / 10) + 2, 5 * (i % 10) + 5] = '#';
                                map[5 * (i / 10) + 3, 5 * (i % 10) + 5] = '#';
                                map[5 * (i / 10) + 4, 5 * (i % 10) + 5] = '#';
                                map[5 * (i / 10) + 5, 5 * (i % 10) + 5] = '#';
                            }
                            else if (j == 2)
                            {
                                map[5 * (i / 10) + 5, 5 * (i % 10) + 2] = '#';
                                map[5 * (i / 10) + 5, 5 * (i % 10) + 3] = '#';
                                map[5 * (i / 10) + 5, 5 * (i % 10) + 4] = '#';
                                map[5 * (i / 10) + 5, 5 * (i % 10) + 5] = '#';

                            }
                            else if (j == 3)
                            {
                                map[5 * (i / 10) + 2, 5 * (i % 10) + 2] = '#';
                                map[5 * (i / 10) + 3, 5 * (i % 10) + 2] = '#';
                                map[5 * (i / 10) + 4, 5 * (i % 10) + 2] = '#';
                                map[5 * (i / 10) + 5, 5 * (i % 10) + 2] = '#';

                            }
                        }

                    }
                }

                Console.Clear();
                for (int i = 0; i < map.GetLength(0); i++)// for vertical border walls
                {
                    map[i, 0] = '#';
                    map[i, 52] = '#';
                }
                for (int i = 0; i < map.GetLength(1); i++)// for horizantal border walls
                {
                    map[0, i] = '#';
                    map[22, i] = '#';
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i,j]=='1'|| map[i, j] == '2' || map[i, j] == '3')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (map[i, j] == 'X' || map[i, j] == 'Y')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (map[i, j] == '+')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write(map[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.Write(map[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
                
                Console.SetCursorPosition(cursorx, cursory);
                if (map[cursory,cursorx]=='1'&&flag==true)
                {
                    score += 10;
                    map[cursory, cursorx] = ' ';
                }
                else if (map[cursory, cursorx] == '2')
                {
                    score += 30;
                    energy+= 50;
                    map[cursory, cursorx] = ' ';

                }
                else if (map[cursory, cursorx] == '3')
                {
                    score += 90;
                    energy+= 200;
                    mine += 1;
                    map[cursory, cursorx] = ' ';

                }
                if (map[cursory, cursorx] == 'Y' || map[cursory, cursorx] == 'X')
                {
                    
                    Console.SetCursorPosition(60, 0);
                    Console.Write($"Time: {counter3 / 5}");
                    Console.SetCursorPosition(60, 1);
                    Console.Write($"Energy: {energy}");
                    Console.SetCursorPosition(60, 2);
                    Console.Write($"Score: {score}");
                    Console.SetCursorPosition(60, 3);
                    Console.Write($"Mine: {mine}");
                    Console.SetCursorPosition(60, 4);
                    Console.BackgroundColor= ConsoleColor.DarkRed;
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.Write($"GAME OVER");
                    Console.BackgroundColor= ConsoleColor.Black;
                    Console.ForegroundColor= ConsoleColor.White;
                    Thread.Sleep(3000);
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("P");
                Console.ForegroundColor = ConsoleColor.White;
                
                DateTime currentTime = DateTime.Now;
                int elapsedTime = (int)(currentTime - startTime).TotalSeconds;
                Console.SetCursorPosition(60, 0);
                Console.Write($"Time: {counter3/5}");
                Console.SetCursorPosition(60, 1);
                Console.Write($"Energy: {energy}");
                Console.SetCursorPosition(60, 2);
                Console.Write($"Score: {score}");
                Console.SetCursorPosition(60, 3);
                Console.Write($"Mine: {mine}");
              
                counter3++;
                int randomm, randomm2, randomm3;
                if (map[cursory, cursorx] == '+')
                {
                    Console.SetCursorPosition(60, 4);
                    Console.Write($"GAME OVER");
                    Thread.Sleep(3000);
                    break;
                }
                if (counter3 % 150 == 0)
                {
                    while (true)
                    {
                        randomm = rand.Next(0, 53);
                        randomm2 = rand.Next(0, 23);
                        randomm3 = rand.Next(0, 3);
                        if (map[randomm2, randomm] == ' ')
                        {
                            if (randomm3 ==0)
                            {
                                map[randomm2, randomm] = '1';
                                break;
                            }
                            else if (randomm3==1)
                            {
                                map[randomm2, randomm] = '2';       
                                break;
                            }
                            else
                            {
                                map[randomm2, randomm] = '3';
                                break;
                            }
                        }
                    }
                }
                Thread.Sleep(200);
            }

               
        }
    }
}
