using System;
using System.Collections.Generic;
using System.Text;

namespace RoverOS
{
    public class Rover
    {
        public Rover(int[] location, Direction direction)
        {
            Direction = direction;
            Location = location;
            TotalDirection = (int)direction;
        }
        public Direction Direction { get; set; }
        public int[] Location { get; set; }
        public int MoveGridPoint { get; }
        public int TotalDirection { get; set; }
        public Direction FindDirection(Rotation rotation)
        {
            TotalDirection += (int)rotation;

            Direction = (Direction)Helper.Mod(TotalDirection, 4);

            return Direction;
        }

        public int[] MoveLocation(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    Location[1] += 1;
                    break;
                case Direction.E:
                    Location[0] += 1;
                    break;
                case Direction.S:
                    Location[1] -= 1;
                    break;
                case Direction.W:
                    Location[0] -= 1;
                    break;
                default:
                    break;
            }

            return Location;
        }

        public string NotifyCurrentPosition()
        {
            return $"{Location[0]} {Location[1]} {Direction}";
        }


    }

    public enum Rotation
    {
        L = -1,
        R = 1,
    };

    public enum Direction
    {
        N,
        E,
        S,
        W
    }

}
