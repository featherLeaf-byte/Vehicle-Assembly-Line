using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class TechLightVehicle : Technician
    {
        public override string FeatureDescription()
        {
            return "Light Vehicle\n";
        }
        public override double Cost()
        {
            return 0;
        }

    }
}
