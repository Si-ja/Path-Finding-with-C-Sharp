﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Rooms
{
    /// <summary>
    /// Class holding information on how a square room looks in the variable "room".
    /// </summary>
    public class SquareRoom : Room
    {
        public override bool[][] room { get; set; } = new bool[5][];
        public override String room_name { get; set; } = "Square shaped Room";

        public SquareRoom()
        {
            InitializeSquareRoom();
        }

        private void InitializeSquareRoom()
        {
            room[0] = new bool[5] { true, true, true, true, true };
            room[1] = new bool[5] { true, false, false, false, true };
            room[2] = new bool[5] { true, false, false, false, true };
            room[3] = new bool[5] { true, false, false, false, true };
            room[4] = new bool[5] { true, true, true, true, true };
        }
    }
}
