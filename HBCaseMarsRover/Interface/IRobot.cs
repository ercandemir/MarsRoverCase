using System;
using System.Collections.Generic;
using System.Text;

namespace HBCaseMarsRover.Interface
{
    public interface IRobot
    {
        #region Robots's basic informations

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string Direction { get; set; }

        #endregion

        #region Moves

        void Move(char command);

        void TurnRight();

        void TurnLeft();

        void Forward();

        #endregion

        #region Initial Operations

        void SetLocation(string locationInput);

        #endregion

        #region Outputs

        string GetLocation();

        #endregion
    }
}
