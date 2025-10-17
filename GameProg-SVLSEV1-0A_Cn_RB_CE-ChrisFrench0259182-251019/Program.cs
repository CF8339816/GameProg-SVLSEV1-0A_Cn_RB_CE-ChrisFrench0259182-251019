using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
        static int mapX = 15;
        static int mapY = 19;






        static void Main(string[] args)
        { 

            DrawMap();
            Console.ReadKey(true);

            spawnGrounds();
            SpawnVirus();

            while (true)
            {
                UpdateMap();
                DrawMap();
                Thread.Sleep(1000); // Wait for 1 second
            }



        }
        //methods Below
        //m1
        static void spawnGrounds()
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
        /*  static void SpawnVirus()
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
                      Virus.Add((15, 10));
                      Virus.Add((1, 13));

                      bool isVirus = false;
                      foreach (var virus in Virus)
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

                      //(int x, int y) newPos = virusMove(virus.x, virus.y);

                      //// Check if position is valid
                      //if (newPos.x == virusMove.x  && newPos.y == virusMove.y)
                      //{
                      //    Virus.Add(virus);
                      //    continue; // Virus didn't move, no chance to spawn
                      //}

                      //string terrain = grounds[newPos.y, newPos.x];

                      //if (terrain == "^") //defines mountian not passable
                      //{
                      //    Virus.Add(virus); // Add original position back
                      //}
                      //else if (terrain == "~") // defines  water , becomes wet virus
                      //{
                      //    WetVirus.Add(newPos);


                      //    if (random.Next(10) == 0)
                      //    {
                      //        nextVirus.Add(virus);
                      //    }
                      //}
                      //else // Regular move onto grass
                      //{
                      //    Virus.Add(newPos);

                      //    // 10% chance to spawn a new virus at the previous location
                      //    if (random.Next(10) == 0)
                      //    {
                      //        Virus.Add(Virus);
                      //    }
                      //}




                      Console.Write(grounds[x, y] + " "); // writes the array
                  }
                  Console.WriteLine();  //skips a line 





                  Console.ResetColor(); // this works this time  it didn not in the challenge i used  it last . sweet!
                  }
                  Console.WriteLine();
              }

          }
          */

        //m3

        //m4
        private static void DrawMap()
        {
            Console.Clear();
            for (int x = 0; x < mapX; x++)
            {
                for (int y = 0; y < mapY; y++)
                {
                    // Check if a virus exists at this position
                    if (virus.Contains((x, y)))
                    {
                        Console.Write('X'); // Draw a virus
                    }
                    else
                    {
                        Console.Write(grounds[x, y]); // Draw the map terrain
                    }
                }
                Console.WriteLine();
            }
        }

        //m5
        static void UpdateMap()
        {
            var newVirus = new List<(int x, int y)>();

            for (int i = 0; i < virus.Count; i++)
            {
                var (x, y) = virus[i];
                int newX = x;
                int newY = y;

                
                var oldPosition = (x, y); // logs old position

               
                int direction = random.Next(4);  //random movement
                switch (direction)
                {
                    case 0: newY--; break; // Up
                    case 1: newY++; break; // Down
                    case 2: newX--; break; // Left
                    case 3: newX++; break; // Right
                }

                // 2. Check for boundaries
                if (newX >= 0 && newX < mapX && newY >= 0 && newY < mapY)
                {
                    
                    char terrain = grounds[newY, newX];
                    if (terrain == "-" || terrain == "~") // moves virus on grass and water but not mountian
                    {
                        virus[i] = (newX, newY); // Update virus position
                    }
                }

               
                
                if (random.Next(10) == 0 && grounds[oldPosition.y, oldPosition.x] == "-")// spawns virus with a 10% chance to spawn a new virus at old position
                {
                    newVirus.Add(oldPosition);
                }
            }

            virus.AddRange(newVirus); // Add any newly spawned viruses
        }


        //m6

        //m7


    }









