using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class TechCustomVehicle:Technician
    {
        public override string FeatureDescription()
    {
        return "Custom Vehicle\n";
    }
    public override double Cost()
    {
        return 0;
    }

}
}
