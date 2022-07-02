using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    abstract class Vehicle:IVehicle
    {
        public Vehicle()
        {

        }
        public abstract void Update();
        public string Name { get; set; }
        public ICarrierBehaviour CarrierBehaviour { get ; set; }
        public IEngineBehaviour EngineBehaviour { get; set; }
        public ITowBehaviour TowBehaviour { get; set; }

        public Vehicle(ICarrierBehaviour CarrierBehaviour, IEngineBehaviour EngineBehaviour, ITowBehaviour TowBehaviour)
        {
            this.CarrierBehaviour = CarrierBehaviour;
            this.EngineBehaviour = EngineBehaviour;
            this.TowBehaviour = TowBehaviour;
        }

        public void CarrierOption()
        {
            CarrierBehaviour.CarrierOption();
        }
        public void Engine()
        {
            EngineBehaviour.Engine();
        }
        public void VehicleTow()
        {
            TowBehaviour.VehicleTow();
        }
    }
}
