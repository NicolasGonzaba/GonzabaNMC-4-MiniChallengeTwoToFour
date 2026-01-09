using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class GreaterLesserServices
    {
         public string GreaterOrLesser(int firstNumber, int secondNumber)
        {
            string result1="equal to";
            string result2="equal to";
            if (firstNumber > secondNumber)
            {
                result1="Greater than";
                result2="Less than";
            } else if(firstNumber < secondNumber){
                result2="Greater than";
                result1="Less than";
            }
            return $"{firstNumber} is {result1} {secondNumber}. {secondNumber} is {result2} {firstNumber}.";
            
        } 
    }
}