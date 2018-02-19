using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARHAB
{
    public class FlightsModule : NancyModule
    {
        public FlightsModule()
        {
            Get("/", args => "Hello World");
        }
    }
}
