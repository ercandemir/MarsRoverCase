using HBCaseMarsRover.Interface;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace HBCaseMarsRover.Model
{
    public class Robot : IRobot
    {
        #region Props and ctor

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string Direction { get; set; }

        public Robot(string locationInput)
        {
            SetLocation(locationInput);
        }

        #endregion

        #region Moves

        public void Move(char command)
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Forward();
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (this.Direction)
            {
                case "N":
                    this.Direction = "E";
                    break;
                case "E":
                    this.Direction = "S";
                    break;
                case "S":
                    this.Direction = "W";
                    break;
                case "W":
                    this.Direction = "N";
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (this.Direction)
            {
                case "N":
                    this.Direction = "W";
                    break;
                case "E":
                    this.Direction = "N";
                    break;
                case "S":
                    this.Direction = "E";
                    break;
                case "W":
                    this.Direction = "S";
                    break;
                default:
                    break;
            }
        }

        public void Forward()
        {
            switch (this.Direction)
            {
                case "N":
                    this.PositionY += 1;
                    break;
                case "S":
                    this.PositionY -= 1;
                    break;
                case "E":
                    this.PositionX += 1;
                    break;
                case "W":
                    this.PositionX -= 1;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Initial Operations
        /// <summary>
        /// Robot's initial position will be set here
        /// </summary>
        /// <param name="locationInput"></param>
        public void SetLocation(string locationInput)
        {
            string[] parameters = locationInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            this.PositionX = Convert.ToInt32(parameters[0]);
            this.PositionY = Convert.ToInt32(parameters[1]);
            this.Direction = parameters[2];
        }

        #endregion

        #region Outputs

        /// <summary>
        /// Sends back of Robot's current location
        /// </summary>
        /// <returns></returns>
        public string GetLocation()
        {
            return string.Format("{0} {1} {2}", this.PositionX, this.PositionY, this.Direction);
        }

        #endregion
    }
}
