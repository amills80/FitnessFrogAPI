using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class IntensitiesController : ApiController
    {
        //private IntensitiesRepository _intensitiesRepository = null;
        //public IntensitiesController(IntensitiesRepository intensitiesRepository)
        //{
        //    _intensitiesRepository = intensitiesRepository;
        //}

        public IHttpActionResult Get()
        {
            var intensities = Enum.GetValues(typeof(Entry.IntensityLevel))
                .Cast<Entry.IntensityLevel>()
                .Select(li => new { id = (int)li, name = li.ToString() })
                .ToList();
            return Ok(intensities);
        }
    }
}