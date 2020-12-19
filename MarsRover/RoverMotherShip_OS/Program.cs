using RoverStation;
using System;
using System.Collections.Generic;

namespace RoverOS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type \"f\" for finish command");
            List<string> commandLines = new List<string>();
            string line = string.Empty;
            do
            {
                line = Console.ReadLine();
                commandLines.Add(line);
            } while (line.ToLower() != "f");

            for (int i = 1; i < commandLines.Count ; i++)
            {
                if (i % 2 == 0)
                {
                     //rover = RoverStation.DeployRover(commandLines[i - 1], commandLines[i]);
                    //Console.WriteLine(rover.NotifyCurrentPosition());
                }
            }

        }
        //IsValid letter kontrolü yapılması lazım
        public static bool IsValidDirection(string letter)
        { 
           return Enum.TryParse<Direction>(letter, out Direction direction);
        }

   
      



    }
}
