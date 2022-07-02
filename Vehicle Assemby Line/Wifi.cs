using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    class Wifi : FeatureDecorator
    {
        Technician _feature;
        public Wifi(Technician feature) : base(feature)
        {
            _feature = feature;
        }
        public override string FeatureDescription()
        {
            if (_feature.FeatureDescription().Contains("Motorcycle"))
                return _feature.FeatureDescription() + " WiFi: R750\n";
            else if (_feature.FeatureDescription().Contains("Light"))
                return _feature.FeatureDescription() + " WiFi: R950\n";
            else if(_feature.FeatureDescription().Contains("Custom"))
                return _feature.FeatureDescription() + " WiFi: R950\n";
            else
                return _feature.FeatureDescription() + " WiFi: R1000\n";
        }
        public override double Cost()
        {
            if(_feature.FeatureDescription().Contains("Motorcycle"))
                return _feature.Cost() + 750;
            else if(_feature.FeatureDescription().Contains("Light"))
                return _feature.Cost() + 950;
            else if (_feature.FeatureDescription().Contains("Custom"))
                return _feature.Cost() + 950;
            else 
                return _feature.Cost() + 1000;
        }
    }
}
