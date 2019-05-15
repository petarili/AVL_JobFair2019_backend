using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AVLCarMeasurementDemo.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AVLCarMeasurementDemo.Controllers
{
  [EnableCors("AllowOrigin")]
  public class MeasurementsController : ODataController
  {
    private CarMeasurementContext _db;


    public MeasurementsController(CarMeasurementContext context)
    {
      _db = context;
      if (context.Measurements.Count() == 0)
      {
        foreach (var b in DataSource.GetMeasurements())
        {
          context.Measurements.Add(b);
        }
        context.SaveChanges();
      }
    }


    [EnableQuery]
    public IActionResult Get()
    {
      DataGenerator generator = new DataGenerator(_db);
      generator.RecordNewData();    
      
      return Ok(_db.Measurements);
    }

    [EnableQuery]
    public IActionResult Get(int key)
    {
      return Ok(_db.Measurements.FirstOrDefault(c => c.ID == key));
    }

    [EnableQuery]
    public IActionResult Post([FromBody]Measurement measurement)
    {
      _db.Measurements.Add(measurement);
      _db.SaveChanges();
      return Created(measurement);
    }
  }
}

