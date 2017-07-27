using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controller
{
    public class CitiesController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new { id = 1, Name = "name"},
                new { id = 2, Name = "name2"}
            });
        }
    }
}
