using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controller
{
    [Route("api/cities")]
    public class CitiesController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            var a = new JsonResult(CitiesDataStore.Current);
            return Ok(a);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            //var a = new JsonResult();
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
    }
}
