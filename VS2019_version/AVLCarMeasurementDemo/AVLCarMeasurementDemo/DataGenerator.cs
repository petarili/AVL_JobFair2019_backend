using AVLCarMeasurementDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo
{
  public class DataGenerator
  {

    CarMeasurementContext _db;

    public DataGenerator(CarMeasurementContext _db)
    {
      this._db = _db;
    }

    public void RecordNewData()
    {
      int measurementId = _db.Measurements.Last<Measurement>().ID + 1;
      double time = _db.Measurements.Last<Measurement>().Time + 0.5;
      Random r = new Random();
      double range = 500;

      _db.Measurements.Add(new Measurement
      {
        ID = measurementId,
        UUT = "BMW M2",
        CT = "CO2 Emission",
        Time = time,
        Value = r.NextDouble() * range
      });

      ++measurementId;
      time += 0.5;

      _db.Measurements.Add(new Measurement
      {
        ID = measurementId,
        UUT = "BMW M2",
        CT = "CO2 Emission",
        Time = time,
        Value = r.NextDouble() * range
      });

      ++measurementId;
      time += 0.5;

      _db.Measurements.Add(new Measurement
      {
        ID = measurementId,
        UUT = "BMW M2",
        CT = "CO2 Emission",
        Time = time,
        Value = r.NextDouble() * range
      });

      ++measurementId;
      time += 0.5;

      _db.Measurements.Add(new Measurement
      {
        ID = measurementId,
        UUT = "Audi Q8",
        CT = "CO2 Emission",
        Time = time,
        Value = r.NextDouble() * range
      });

      ++measurementId;
      time += 0.5;

      _db.Measurements.Add(new Measurement
      {
        ID = measurementId,
        UUT = "Audi Q8",
        CT = "CO2 Emission",
        Time = time,
        Value = r.NextDouble() * range
      });

      ++measurementId;
      time += 0.5;

      _db.Measurements.Add(new Measurement
      {
        ID = measurementId + 1,
        UUT = "Audi Q8",
        CT = "CO2 Emission",
        Time = time,
        Value = r.NextDouble() * range
      });
      _db.SaveChanges();
    }
  }
}
