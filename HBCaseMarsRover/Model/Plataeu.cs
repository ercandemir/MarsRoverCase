using System;
using System.Collections.Generic;
using System.Text;

namespace HBCaseMarsRover.Model
{
    public class Plateau
    {
        #region Properties

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        #endregion

        public Plateau(string plateau)
        {
            string[] parameters = plateau.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            this.PositionX = Convert.ToInt32(parameters[0]);
            this.PositionY = Convert.ToInt32(parameters[1]);
        }


    }
}
