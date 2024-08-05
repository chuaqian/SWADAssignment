using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWADAssgClasses
{
    public class Accident
    {
        public string AccidentId { get; set; }
        public DateTime AccidentDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string ResolvingDetails { get; set; }
    }
}
