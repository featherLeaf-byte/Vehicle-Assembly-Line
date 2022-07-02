using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class CarrierOption2 : ICarrierBehaviour
    {
        public void CarrierOption()
        {
            Console.WriteLine("2 people max, and bag");
        }
    }
}