using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class HeavydutyVehicle:Vehicle
    {
        ITechnician Technician;
        public HeavydutyVehicle():base(new CarrierOption4(), new LargeEngine(), new CanTow())
        {
            this.Name = "Heavyduty Vehicle";
        }
        public HeavydutyVehicle(ITechnician Technician) : base(new CarrierOption2(), new SmallEngine(), new NoTow())
        {
            this.Technician = Technician;
            this.Technician.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine(((Technician)this.Technician).getState().ToString("C"));

        }
    }
}
