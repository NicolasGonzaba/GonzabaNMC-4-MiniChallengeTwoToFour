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
    public class AddNumbersController : ControllerBase
    {
        private readonly AddNumberServices _addNumberServices;

        public AddNumbersController(AddNumberServices addNumberServices)
        {
            _addNumberServices=addNumberServices;
        }

        [HttpPost]
        [Route("AddTwoNumbers/{firstNumber}/{secondNumber}")]
        public string Add(int firstNumber, int secondNumber)
        {
            return _addNumberServices.Add(firstNumber,  secondNumber);
        } 
    }
}