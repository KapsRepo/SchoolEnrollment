using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using KDI.Models;
using KDI.Services;
using Microsoft.Owin.Security.Twitter.Messages;
using Newtonsoft.Json;

namespace KDI.Controllers
{
    public class DataController : ApiController
    {
        // GET: api/Data
        public IEnumerable<City> Get()
        {
            var csv = new CSVReader();
            var data=csv.GetFile();

            
            var json = JsonConvert.SerializeObject(data);

            var list = new List<City>();
            list.Add(new City(){CityId = 1,CityName = "Pune",Population = "200000"});
            list.Add(new City() {  CityId = 2, CityName = "Pune", Population = "200000" });
            list.Add(new City() {  CityId = 3, CityName = "Delhi", Population = "400000" });
            list.Add(new City() {  CityId = 4, CityName = "Kolkotta", Population = "500000" });

            //json = JsonConvert.SerializeObject(list);
            
           // return json;
            return list;
        }
        [Route("Api/data/getSe")]
        public Dictionary<string, List<SchoolEnrollment>> GetSe()
        {
            var csv = new CSVReader();
            var data = csv.GetFile();

            return data;
        }

        // GET: api/Data/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Data
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Data/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Data/5
        public void Delete(int id)
        {
        }
    }
}
