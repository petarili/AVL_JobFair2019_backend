using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AVLCarMeasurementDemo.Controllers
{
  [Route("api/[controller]")]
  [EnableCors("AllowOrigin")]
  [ApiController]
  public class LaboratoryController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "AVL Laboratory CO2 Emission Test initiated..." };
    }
  }
}