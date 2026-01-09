using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class NameTimeServices
    {
        public string WakeUp(string Name, string WakeUpTime)
        {
            return $"Hello {Name}, You woke up at {WakeUpTime}.";
        } 
    }
}