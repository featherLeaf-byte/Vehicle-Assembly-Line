using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class Motorcycle:Vehicle
    {
        ITechnician Technician;

        public Motorcycle() :base(new CarrierOption2(), new SmallEngine(), new NoTow())
        {
            this.Name = "Motorcycle";
        }
        public Motorcycle(ITechnician Technician) : base(new CarrierOption2(), new SmallEngine(), new NoTow())
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
