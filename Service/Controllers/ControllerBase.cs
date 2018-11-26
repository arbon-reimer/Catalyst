using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Service.Controllers
{
    public class ControllerBase : Controller
    {
        protected static HttpClient _HttpClient;
        public ControllerBase()
        {
            _HttpClient = new HttpClient();
        }
    }
}
