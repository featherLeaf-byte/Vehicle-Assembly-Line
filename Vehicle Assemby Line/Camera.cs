using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
     class Camera:FeatureDecorator
    {
        Technician _feature;
        public Camera(Technician feature) : base(feature)
        {
            _feature = feature;
        }
        public override string FeatureDescription()
        {
            if (_feature.FeatureDescription().Contains("Motorcycle"))
                return _feature.FeatureDescription() + " Camera: R200\n";
            else if (_feature.FeatureDescription().Contains("Light"))
                return _feature.FeatureDescription() + " Camera: R400\n";
            else if(_feature.FeatureDescription().Contains("Custom"))
                return _feature.FeatureDescription() + " Camera: R400\n";
            else
                return _feature.FeatureDescription() + " Camera: R600\n";
        }
        public override double Cost()
        {
            if (_feature.FeatureDescription().Contains("Motorcycle"))
                return _feature.Cost() + 200;
            else if (_feature.FeatureDescription().Contains("Light"))
                return _feature.Cost() + 400;
            else if (_feature.FeatureDescription().Contains("Custom"))
                return _feature.Cost()+400;
            else
                return _feature.Cost() + 600;
        }
    }
}
