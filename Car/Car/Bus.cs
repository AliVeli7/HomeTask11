using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class Bus:Car
    {
        public int PassangerCount;

        public Bus():base()
        {
            
        }

        public Bus(string brand, string model):base(brand,model)
        {
           
        }

        public Bus(string brand, string model, string color, int maxSpeed,int passangerCount):base(brand,model,color,maxSpeed)
        {
            PassangerCount = passangerCount;
        }
    }

    
}
