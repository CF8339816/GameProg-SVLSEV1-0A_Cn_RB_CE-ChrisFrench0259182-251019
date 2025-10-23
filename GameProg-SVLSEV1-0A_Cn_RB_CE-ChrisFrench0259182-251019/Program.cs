using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameProg_SVLSEV1_0A_Cn_RB_CE_ChrisFrench0259182_251019
// aka : C# Challenge: Super Virus Land Simulation Extreme V1.0 Alpha Codename Red Blobs (((Collector's Edition)))
{
    //code  written  by: Chris French 0259182
    //notes:
    //references used:
    // * google searches: how to change colors inan  array based on value, how to  move  around  an array randomly
    // * books: C# players guide fifth edition -RB Whitaker, C# in a nutshell -Joseph Albahari
    // * previous assignments

    internal class Program
    {
        ////variables




        static string[,] grounds = {

                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"^" ,"^" ,"^" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"^" ,"-" ,"^" ,"^" ,"^" ,"^" },
                { "~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"^" ,"^" ,"^" ,"^" ,"^","-"  },
                { "-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"^" ,"^" ,"^" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"^" ,"^","-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"^" ,"^" ,"^" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"~" ,"~" ,"-" ,"-" ,"-","-" ,"^" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"~" ,"~" ,"~" ,"-" ,"-","-" ,"^" ,"^","-" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"~" ,"~" ,"~" ,"-" ,"-","-" ,"^" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"~" ,"~" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"~" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },

            };

        // static string grass = "-";
        //static string hill = "^";
        // static string water = "~";

        static List<(int x, int y)> VirusA = new List<(int x, int y)>(); // makes new lists for array  modification
        static List<(int x, int y)> VirusB = new List<(int x, int y)>();
        static List<(int x, int y)> VirusC = new List<(int x, int y)>();



        // static List<(int x, int y)> WetVirus = new List<(int x, int y)>();
        static Random random = new Random(); //declairs new random
        //static List<(int x, int y)> nextVirus = new List<(int x, int y)>(); //  new list  for creatioion of next movement
        //static List<(int x, int y)> nextWetVirus = new List<(int x, int y)>();
        //static List<(int x, int y)> virusMove;
        static List<(int x, int y)> virus;
        static Random randomMove = new Random();






        static void Main(string[] args)
        {

            DrawMap();
            Console.ReadKey(true);

            SpawnVirus();
            Console.ReadKey(true);

            vMove();
           Console.ReadKey(true);


        }
        //methods Below
        //m1
        static void DrawMap()
        {

            for (int x = 0; x < grounds.GetLength(0); x++) // Rows
            {
                for (int y = 0; y < grounds.GetLength(1); y++) // Columns
                {

                    switch (grounds[x, y]) //creates the function to   change the colours based on  the case definetions below
                    {
                        case "-": // Grass
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "~": // Water
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "^": // Mountain
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }



                    Console.Write(grounds[x, y] + " ");
                }
                Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        //m2
        static void SpawnVirus()
        {
            // Random randomLocation = new Random();  declairs new random

            Console.Clear();


            for (int x = 0; x < grounds.GetLength(0); x++) // Rows
            {
                for (int y = 0; y < grounds.GetLength(1); y++) // Columns
                {

                    switch (grounds[x, y])
                    {
                        case "-": // Grass
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "~": // Water
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "^": // Mountain
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }

                    VirusA.Add((5, 5));
                    grounds[5,5]= null;

                    bool isVirus = false;
                    foreach (var virus in VirusA)
                    {
                        if ((virus.x == x && virus.y == y))
                        {
                            if (virus.x == x && virus.y == y)
                            {
                                isVirus = true;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("X");
                                break;
                            }
                        }
                    }

                    //Console.Write(grounds[x, y] + " ");

                                                        
                    VirusB.Add((15, 10));
                    grounds[15, 10] = null;

                    bool amVirus = false;
                    foreach (var virus in VirusB)
                    {
                        if ((virus.x == x && virus.y == y))
                        {
                            if (virus.x == x && virus.y == y)
                            {
                                amVirus = true;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("@");
                                break;
                            }
                        }
                    }

                    //Console.Write(grounds[x, y] + " ");

                    VirusC.Add((1, 13));
                    grounds[1, 13] = null;


                    bool areVirus = false;
                    foreach (var virus in VirusC)
                    {
                        if ((virus.x == x && virus.y == y))
                        {
                            if (virus.x == x && virus.y == y)
                            {
                                areVirus = true;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("&");
                                break;
                            }
                        }
                    }

                    Console.Write(grounds[x, y] + " ");

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //m3
        static void vMove()
        {

            Console.Clear();

            for (int x = 0; x < grounds.GetLength(0); x++) // Rows
            {
                for (int y = 0; y < grounds.GetLength(1); y++) // Columns
                {

                    switch (grounds[x, y])
                    {
                        case "-": // Grass
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "~": // Water
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "^": // Mountain
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }


                    int randomMove = random.Next(1, 5);
                    Console.ReadKey();

                    //Console.Write(grounds[x, y] + " ");

                    bool isVirus = false;
                    {
                        Console.Clear();
                        foreach (var virus in VirusA)
                        {
                            if (randomMove == 1)
                            {
                                if ((virus.x == x && virus.y == y))
                                {
                                    if (virus.x == x && virus.y == y)
                                    {
                                        isVirus = true;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("X");
                                        break;
                                    }
                                }
                            VirusA.Add((x--, y));
                            grounds[x, y] = null;
                            Console.Clear();
                           // Console.Write(grounds[x, y] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    foreach (var virus in VirusA)
                    {
                        if (randomMove == 2)
                        {
                            if ((virus.x == x && virus.y == y))
                            {
                                if (virus.x == x && virus.y == y)
                                {
                                    isVirus = true;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("X");
                                    break;
                                }
                            VirusA.Add((x++, y));
                            grounds[x, y] = null;
                            Console.Clear();
                           // Console.Write(grounds[x, y] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    foreach (var virus in VirusA)
                    {
                        if (randomMove == 3)
                        {
                            if ((virus.x == x && virus.y == y))
                            {
                                if (virus.x == x && virus.y == y)
                                {
                                    isVirus = true;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("X");
                                    break;
                                }
                            VirusA.Add((x, y--));
                            grounds[x, y] = null;
                            Console.Clear();
                            //Console.Write(grounds[x, y] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    foreach (var virus in VirusA)
                    {
                        if (randomMove == 4)
                        {
                            if ((virus.x == x && virus.y == y))
                            {
                                if (virus.x == x && virus.y == y)
                                {
                                    isVirus = true;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("X");
                                    break;
                                }
                            VirusA.Add((x, y++));
                            grounds[x, y] = null;
                            Console.Clear();
                            //Console.Write(grounds[x, y] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    Console.Write(grounds[x, y] + " ");
                }

                Console.WriteLine();
            }
        }


    //m4


    //m5


    //m6

    //m7


        
        
    }
}







