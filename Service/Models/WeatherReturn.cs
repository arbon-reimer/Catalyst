using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Models
{
    public class WeatherReturn
    {
        public int HttpReturnCode { get; set; }
        public bool IsError { get; set; }
        public string Location { get; set; }
        public string MaxTemp { get; set; }
        public string MinTemp { get; set; }
    }
}
