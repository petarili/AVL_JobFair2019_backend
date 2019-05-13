using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo.Models
{
  public class ChannelChartConfiguration
  {
    public int ID { get; set; }

    public ChannelType ChannelType { get; set; }

    public string LineColor { get; set; }

    public int MinRange { get; set; }

    public int MaxRange { get; set; }


  }
}
