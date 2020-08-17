using HBCaseMarsRover.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HBCaseMarsRover.Business
{
    public class MarsRoverBusiness
    {
        #region Operations

        public void CalculateNewLocation(Plateau plateau, Robot robot, string commands)
        {
            MovesRobot(robot, commands);
            CheckAndFixLocation(plateau, robot);
        }

        /// <summary>
        /// Robot will be moved on plateau according to commnand letters
        /// </summary>
        /// <param name="robot"></param>
        /// <param name="plateau"></param>
        public void MovesRobot(Robot robot, string commands)
        {
            foreach (var command in commands)
            {
                robot.Move(command);
            }
        }

        #endregion

        #region Audits

        public void CheckAndFixLocation(Plateau plateau, Robot robot)
        {
            if (robot.PositionX > plateau.PositionX)
                robot.PositionX = plateau.PositionX;
            else if (robot.PositionX < 0)
                robot.PositionX = 0;

            if (robot.PositionY > plateau.PositionY)
                robot.PositionY = plateau.PositionY;
            else if (robot.PositionY < 0)
                robot.PositionY = 0;
        }

        #endregion
    }
}
