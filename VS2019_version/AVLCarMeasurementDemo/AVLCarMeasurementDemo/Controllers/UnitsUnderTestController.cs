using System.Linq;
using AVLCarMeasurementDemo.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AVLCarMeasurementDemo.Controllers
{
  [EnableCors("AllowOrigin")]
  public class UnitsUnderTestController : ODataController
  {
    private CarMeasurementContext _db;

    public UnitsUnderTestController(CarMeasurementContext context)
    {
      _db = context;
      if (context.UnitsUnderTest.Count() == 0)
      {
        foreach (var b in DataSource.GetUnitsUnderTest())
        {
          context.UnitsUnderTest.Add(b);
        }
        context.SaveChanges();
      }
    }

    [EnableQuery]
    public IActionResult Get()
    {
      return Ok(_db.UnitsUnderTest);
    }

    [EnableQuery]
    public IActionResult Get(int key)
    {
      return Ok(_db.UnitsUnderTest.FirstOrDefault(c => c.ID == key));
    }
  }
}