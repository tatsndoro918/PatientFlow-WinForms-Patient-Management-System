using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPatientTracker.Models
{
    public class Patient
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Condition { get; set; }

        public string Priority { get; set; }

        public string Status { get; set; }

        public DateTime ArrivalTime { get; set; }
    }
}
