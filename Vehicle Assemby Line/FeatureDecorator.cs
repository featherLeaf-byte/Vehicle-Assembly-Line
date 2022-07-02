using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Assembly_Line
{
    abstract class FeatureDecorator : Technician
    {
        Technician _feature = null;
        public FeatureDecorator(Technician feature)
        {
            _feature = feature;
        }
        public override string FeatureDescription()
        {
            return _feature.FeatureDescription();
        }
    }
}
