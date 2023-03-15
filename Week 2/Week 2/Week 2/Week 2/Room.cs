using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfSeats)
        {
            code = classCode;
            seats = numberOfSeats;
        }
    }
}
