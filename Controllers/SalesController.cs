using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SalesProjection.Models;

namespace SalesProjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private string jsonFile;

        public SalesController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            jsonFile = _hostingEnvironment.ContentRootPath + "\\SaleData.json";
        }

        // GET: api/Sale
        [HttpGet]
        public List<Sales> Get()
        {
                     
            try
            {

                //string projectRootPath = _hostingEnvironment.ContentRootPath;
                //jsonFile = projectRootPath + "\\SaleData.json";

                var options = new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };

                var jsonString = System.IO.File.ReadAllText(jsonFile);
                var jsonModel = System.Text.Json.JsonSerializer.Deserialize<List<Sales>>(jsonString, options);
                //var modelJson = System.Text.Json.JsonSerializer.Serialize(jsonModel, options);

                return jsonModel;


            }

            catch (Exception e)
            {
                throw e;
            }
            //return new string[] { "value1", "value2" };

           
        }

        // GET: api/Sale/5
        [HttpGet("{date}", Name = "Get")]
        public Sales Get(string date)
        {

            try
            {


                var options = new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };

                var jsonString = System.IO.File.ReadAllText(jsonFile);
                var jsonModel = System.Text.Json.JsonSerializer.Deserialize<List<Sales>>(jsonString, options);
                //var modelJson = System.Text.Json.JsonSerializer.Serialize(jsonModel, options);
                var getData = jsonModel.Where(t => t.Name == date).SingleOrDefault();

                return getData;


            }

            catch (Exception e)
            {
                throw e;
            }

            //return "value";
        }

        // POST: api/Sale
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Sale/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
