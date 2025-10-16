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
    internal class Program
    {
        //variables

       


        static string[,] grounds = {
             
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"^" ,"^" ,"^" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"^" ,"-" ,"-" ,"-" ,"-" ,"-"  },
                { "~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"^" ,"^" ,"^" ,"-" ,"-" ,"-"  },
                { "-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"^" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"^" ,"-" ,"-" ,"-" ,"-"  },
                { "-" ,"-" ,"~" ,"~" ,"-" ,"-" ,"-" ,"-","-" ,"-" ,"-" ,"-" ,"-" ,"-" ,"-"  },
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
        static string Virus;



        static void Main(string[] args)
        {





            for (int x = 0; x < grounds.GetLength(0); x++) // Rows
            {
                for (int y = 0; y < grounds.GetLength(1); y++) // Columns
                {
                    // attempting to set foreground colours  for values when printing the map
                    //foreach(string ground in grounds)

                    //if (ground == grass)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Green;
                    //    }
                    //else if (ground == hill)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Gray;
                    //}
                    //else if (ground == water)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Blue;
                    //}
                    //else
                    //{
                    //    Console.ForegroundColor = ConsoleColor.White;
                    //}


                    switch (grounds[x, y] + " ")
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
            }


           //int startIndex = 0, 6;
           // string newValue = "X";

          
           // grounds[startIndex] = newValue;

       
           // for (int x = 0; x < grounds.GetLength(0); x++) 
           // {
           //     for (int y = 0; y < grounds.GetLength(1); y++) 
           //     {

           //         Console.Write(grounds[x, y] + " ");
                    
           //     }
           // }
        }




        //methods Below
        //m1

        //m2


        //m3


        //m4


        //m5


        //m6


        //m7







    }
}
