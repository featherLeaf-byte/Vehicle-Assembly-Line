using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class LightVehicle:Vehicle
    {
        ITechnician Technician;
        public LightVehicle() : base(new CarrierOption3(), new MediumEngine(), new CanTow())
        {
            this.Name = "Light Motor Vehicle";
        }
        public LightVehicle(ITechnician Technician) : base(new CarrierOption2(), new SmallEngine(), new NoTow())
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
