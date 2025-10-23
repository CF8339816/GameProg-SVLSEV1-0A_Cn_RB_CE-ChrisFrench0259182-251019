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

        static List<(int x, int y)> Virus = new List<(int x, int y)>(); // makes new lists for array  modification
                                                                        // static List<(int x, int y)> WetVirus = new List<(int x, int y)>();
        static Random random = new Random(); //declairs new random
        //static List<(int x, int y)> nextVirus = new List<(int x, int y)>(); //  new list  for creatioion of next movement
        //static List<(int x, int y)> nextWetVirus = new List<(int x, int y)>();
        //static List<(int x, int y)> virusMove;
        static List<(int x, int y)> virus;
        static Random randommove = new Random();






        static void Main(string[] args)
        {

            DrawMap();
            Console.ReadKey(true);

            SpawnVirus();





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



                    Console.Write(grounds[x, y] + " "); // writes the array
                }
                Console.WriteLine();  //skips a line


                Console.ForegroundColor = ConsoleColor.White; // sets colour back to white

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

                    Virus.Add((5, 5));


                    Console.WriteLine();
                    Console.Clear();
                    Console.Write(grounds[x, y] + " ");


                    int randomNumber = random.Next(1, 5);
                    Console.ReadKey();

                    Console.Write(grounds[x, y] + " ");

                    bool isVirus = false;
                    {
                        foreach (var virus in Virus)
                        {
                            if (randomNumber == 1)
                            {
                                if ((virus.x == x && virus.y == y))
                                {
                                    if (virus.x == x && virus.y == y)
                                    {
                                        isVirus = true;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("X");
                                        break;
                                    }
                                }
                            }
                        }
                        
                    }
                        Virus.Add((x--, y));


                        foreach (var virus in Virus)
                    {
                        if (randomNumber == 2)
                        {
                            if ((virus.x == x && virus.y == y))
                            {
                                if (virus.x == x && virus.y == y)
                                {
                                    isVirus = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("X");
                                    break;
                                }
                            }
                        }
                    }
                        Virus.Add((x++,y ));


                    foreach (var virus in Virus)
                    {
                        if (randomNumber == 3)
                        {
                            if ((virus.x == x && virus.y == y))
                            {
                                if (virus.x == x && virus.y == y)
                                {
                                    isVirus = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("X");
                                    break;
                                }
                            }
                        }
                    }
                    Virus.Add((x, y--));

                    foreach (var virus in Virus)
                    {
                        if (randomNumber == 3)
                        {
                            if ((virus.x == x && virus.y == y))
                            {
                                if (virus.x == x && virus.y == y)
                                {
                                    isVirus = true;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("X");
                                    break;
                                }
                            }
                        }
                    }
                    Virus.Add((x, y++));



                    Console.Write(grounds[x, y] + " "); 
                }



                Console.WriteLine(); 





                Console.ResetColor(); // this works this time  it didn not in the challenge i used  it last . sweet!
            }
           
        }

    }


    //m3
    //static void vMove()
    //    {
    //        int randomNumber = random.Next(1, 5);
    //        Console.ReadKey();

    //        bool isVirus = false;

    //        foreach (var virus in Virus)
    //        {
    //            if (randomNumber == 1)
    //            {
                
    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.Write("X");
    //            }

    //            if (randomNumber == 2)
    //            {

    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.Write("X");
    //            }

    //            if (randomNumber == 3)
    //            {

    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.Write("X");
    //            }

    //            if (randomNumber == 4)
    //            {

    //                Console.ForegroundColor = ConsoleColor.Red;
    //                Console.Write("X");
    //            }
    //        }

    //        Console.Write(grounds[x, y] + " ");



    //        //m4
    //        bool isVirus = false;
    //        foreach (var virus in Virus)
    //        {
    //            if ((virus.x == x && virus.y == y))
    //            {
    //                if (virus.x == x && virus.y == y)
    //                {
    //                    isVirus = true;
    //                    Console.ForegroundColor = ConsoleColor.Red;
    //                    Console.Write("X");
    //                    break;
    //                }
    //            }
    //        }

            //m5


            //m6

            //m7


        }







