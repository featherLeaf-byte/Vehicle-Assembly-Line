using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class TechHeavydutyVehicle : Technician
    {
        public override string FeatureDescription()
        {
            return "Motorcycle\n";
        }
        public override double Cost()
        {
            return 0;
        }

    }
}
