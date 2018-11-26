using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Service.Controllers
{

    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly string _weatherAppAPIKey;
        private readonly string _weatherAppAPIUrl;

        public WeatherController(IConfiguration config) : base()
        {
            _weatherAppAPIKey = config.GetValue<string>("AppSettings:WeatherAPIKey");
            _weatherAppAPIUrl = config.GetValue<string>("AppSettings:WeatherAPIUrl");
        }
        // GET api/weather/5
        [HttpGet("{query}")]
        public async Task<IActionResult> Get(string query)
        {
            if (Int32.TryParse(query, out int isInt))
            {
                //is numeric, get by zip code
                query = isInt.ToString();
            }
            query += ",us";
            string _url = String.Format(_weatherAppAPIUrl, query, _weatherAppAPIKey);
            //call API 
            _HttpClient.DefaultRequestHeaders.Accept.Clear();
            var weatherInfo = await _HttpClient.GetStringAsync(new Uri(_url));
            //evaluate return
            XDocument weatherDocument = XDocument.Load(weatherInfo);
            if(weatherDocument.Root.Name.LocalName == "weatherdata")
            {

            }
            else
            {

            }
        }

    }
}
