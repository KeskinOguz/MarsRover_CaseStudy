using RoverOS;
using System;
using Xunit;

namespace RoverStation_XUnitTest
{
    public class RoverStationTest
    {
        [Fact]
        public void DeployRover_ShouldGiveCorrectPosition()
        {
            var startingPosition = "3 3 E";
            var moveCommand = "MMRMMRMRRM";

            var rover = RoverStation.DeployRover(startingPosition, moveCommand);

            Assert.Equal("5 1 E", rover.NotifyCurrentPosition());

        }
    }
}
