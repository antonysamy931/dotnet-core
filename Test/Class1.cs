using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test
{
    public class Class1
    {        
        public Class1()
        {
        }

        public string GetMessage()
        {
            return "Mark antony created sub class library and get messages from that library";
        }

        public dynamic GetResults()
        {
            SignalRContext context = new SignalRContext();
            return context.ConnectionMapping.ToList();
        }
    }
}
