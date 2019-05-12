using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo.Models
{
    public class Measurement
    {

        public int ID { get; set; }

        public string UUT { get; set; }

        public string CT { get; set; }

        public double Time { get; set; }

        public double Value { get; set; }

    }
}
