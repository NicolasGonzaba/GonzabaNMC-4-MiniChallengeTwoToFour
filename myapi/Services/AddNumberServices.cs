using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class AddNumberServices
    {

        
        public string Add(int firstNumber, int secondNumber)
        {
            int sum=firstNumber+secondNumber;
            return $"{firstNumber} plus {secondNumber} makes {sum}.";
        } 
    }
}