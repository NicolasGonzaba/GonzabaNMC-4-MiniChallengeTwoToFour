using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameTimeController : ControllerBase
    {
         private readonly NameTimeServices _nameTimeServices;

        public NameTimeController(NameTimeServices nameTimeServices)
        {
            _nameTimeServices=nameTimeServices;
        }

        [HttpPost]
        [Route("WhenYouWokeUp/{Name}/{WakeUpTime}")]
        public string WakeUp(string Name, string WakeUpTime)
        {
            return _nameTimeServices.WakeUp(Name, WakeUpTime);
        } 
    }
}