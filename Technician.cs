using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidents_by_Technician
{
    public class Technician
    {
        public string Name { get; set; }

        public int TechID { get; set; }

        public Technician()
        {

        }

        public Technician(string name, int techID)
        {
            Name = name;
            TechID = techID;
        }

    }
}
