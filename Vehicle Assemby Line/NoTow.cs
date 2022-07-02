using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class NoTow:ITowBehaviour
    {
        public void VehicleTow()
        {
            Console.WriteLine("No Tow");
        }
    }
}
