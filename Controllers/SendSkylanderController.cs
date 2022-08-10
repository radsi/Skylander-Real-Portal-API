using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SkylanderVPortal_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendSkylanderController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var re = Request;
            var headers = re.Headers;

            Global.name = headers["name"];
            Global.element = headers["element"];
            Global.hat = headers["hat"];
            Global.path = headers["path"];
            Global.coins = int.Parse(headers["coins"]);
            Global.level = int.Parse(headers["level"]);

            return "Skylander data set succesfully";
        }
    }
}
