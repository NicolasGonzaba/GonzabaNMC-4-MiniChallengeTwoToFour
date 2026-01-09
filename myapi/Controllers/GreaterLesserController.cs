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
    public class GreaterLesserController : ControllerBase
    {
        private readonly GreaterLesserServices _greaterLesserServices;

        public GreaterLesserController(GreaterLesserServices greaterLesserServices)
        {
            _greaterLesserServices=greaterLesserServices;
        }

        [HttpPost]
        [Route("GreaterOrLesser/{firstNumber}/{secondNumber}")]
         public string GreaterOrLesser(int firstNumber, int secondNumber)
        {
            return _greaterLesserServices.GreaterOrLesser(firstNumber, secondNumber);
            
        } 
    }
}