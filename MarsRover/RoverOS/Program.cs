using System;
using System.Collections.Generic;
using System.Threading;

namespace RoverOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome Rover Operating System ***");
            Console.WriteLine("Connecting RoverStation on Mars...");
            Thread.Sleep(1000);
            Console.WriteLine("Connected to RoverStation bringing online");
            Console.WriteLine("NOTE: Please type f for finish commands and enter deploy rovers");

            List<string> commandLines = new List<string>();
            string line;
            do
            {
                line = Console.ReadLine();
                commandLines.Add(line);
            } while (line.ToLower() != "f");

            for (int i = 1; i < commandLines.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    var rover = RoverStation.DeployRover(commandLines[i - 1], commandLines[i]);
                    Console.WriteLine(rover.NotifyCurrentPosition());
                }
            }

        }

    }
}
