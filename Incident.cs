using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incidents_by_Technician
{
    public class Incident
    {
        public int CustomerID { get; set; }

        public Nullable<DateTime> DateClosed { get; set; }

        public DateTime DateOpened { get; set; }

        public string Description { get; set; }

        public int IncidentID { get; set; }

        public string ProductCode { get; set; }

        public Nullable<int> TechID { get; set; }

        public string Title { get; set; }

        public Incident()
        {

        }

        public Incident(int customerID, DateTime dateClosed, DateTime dateOpened, string description, int incidentID, string productCode, int techID, string title)
        {
            CustomerID = customerID;
            DateClosed = dateClosed;
            DateOpened = dateOpened;
            Description = description;
            IncidentID = incidentID;
            ProductCode = productCode;
            TechID = techID;
            Title = title;
        }
    }
}
