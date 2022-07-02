using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class CanTow : ITowBehaviour
    {
        public void VehicleTow()
        {
            Console.WriteLine("Can Tow");
        }
    }
}
