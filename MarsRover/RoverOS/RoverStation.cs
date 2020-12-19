using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOS
{
    public static class RoverStation
    {
        public static Rover DeployRover(string startingPosition, string moveCommand)
        {
            var startingPositionArr = startingPosition.Split(" ");
            var direction = Enum.Parse<Direction>(startingPositionArr[2]);

            var rover = new Rover(new int[2], direction);
            rover.Location[0] = Convert.ToInt32(startingPositionArr[0]);
            rover.Location[1] = Convert.ToInt32(startingPositionArr[1]);

            var moveCommandArr = moveCommand.ToCharArray();

            for (int i = 0; i < moveCommandArr.Length; i++)
            {
                if (moveCommandArr[i] == 'M')
                {
                    rover.MoveLocation(rover.Direction);
                }
                else
                {
                    rover.FindDirection(Enum.Parse<Rotation>(moveCommandArr[i].ToString()));
                }
            }

            return rover;
        }

    }
}
