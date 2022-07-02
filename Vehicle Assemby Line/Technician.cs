using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    abstract class Technician:ITechnician
    {
        public abstract string FeatureDescription();
        public abstract double Cost();
        public double stateCost { get; set; }

        List<IVehicle> Observers = new List<IVehicle>();
        
        public void Attach(IVehicle observer)
        {
            Observers.Add(observer);
        }
        public void Detach(IVehicle observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IVehicle observer in Observers)
                observer.Update();
        }
        public void setState(double cost)
        {
            this.stateCost = cost;
            Notify();
        }
        public double getState()
        {
            return this.stateCost;
        }

    }
}
