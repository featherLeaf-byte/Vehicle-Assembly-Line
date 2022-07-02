using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class CustomVehicle:Vehicle
    {
        ITechnician Technician;
        public CustomVehicle(ICarrierBehaviour CarrierBehaviour, IEngineBehaviour EngineBehaviour, ITowBehaviour TowBehaviour) : base(CarrierBehaviour, EngineBehaviour, TowBehaviour)
        {
            this.Name = "Custom Vehicle";
        }
        public CustomVehicle(ITechnician Technician) 
        {
            this.Technician = Technician;
            this.Technician.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("R"+((Technician)this.Technician).getState());
        }
    }
}
