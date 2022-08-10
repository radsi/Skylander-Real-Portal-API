using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SkylanderVPortal_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetSkylanderController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var payload = new SkylanderData
            {
                name = Global.name,
                element = Global.element,
                hat = Global.hat,
                path = Global.path,
                level = Global.level,
                coins = Global.coins
            };

            var stringPayload = JsonConvert.SerializeObject(payload);

            return stringPayload;
        }
    }
}
