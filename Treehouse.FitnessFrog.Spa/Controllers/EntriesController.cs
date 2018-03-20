using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class EntriesController : ApiController
    {

        public IEnumerable<Entry> Get()
        {
            var activityBiking = new Activity() { Name = "Biking" };
            return new List<Entry>()
            {
                new Entry(2018, 1 , 3, activityBiking, 10.0m),
                new Entry(2017, 10 , 27, activityBiking, 5.0m)
            };
        }

        public IEnumerable<Entry> Get(int id)
        {
            return null;
        }

        public void Post(Entry entry)
        {
            //return view();
        }

        public void Put(int id, Entry entry)
        {

        }

        public void Delete(int id)
        {

        }
    }
}