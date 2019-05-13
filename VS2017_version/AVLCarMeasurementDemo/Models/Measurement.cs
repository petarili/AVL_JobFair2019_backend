using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo.Models
{
  public class Measurement
  {

    public int ID { get; set; }

    public UnitUnderTest UnitUnderTest { get; set; }

    public ChannelType ChannelType { get; set; }

    public int Time { get; set; }

    public decimal Value { get; set; }

  }
}
