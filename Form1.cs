using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incidents_by_Technician
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Display the listView named lstView Column headers
            lstView.View = View.Details;

            //Defines list of data from the DB's TehcnicianDB and IncidentDB
            List<Technician> technicians = TechnicianDB.GetTechnicians();
            List<Incident> incidents = IncidentDB.GetIncidents();

            //get incidence using LINQ query of the incdents and technicians list loaded from DB Class
            var incidentList = from incident in incidents
                               join tech in technicians
                               on incident.TechID equals tech.TechID
                               where incident.DateClosed != null
                               orderby tech.Name, incident.DateClosed ascending
                               select new { tech.Name,
                                            incident.ProductCode,
                                            incident.DateOpened,
                                            incident.DateClosed,
                                            incident.Title };

            //Display Information into ListView named lstView
            string technicianName = "";
            int i = 0;
            foreach (var incident in incidentList)
            {
                if (incident.Name != technicianName)
                {
                    lstView.Items.Add(incident.Name);
                    technicianName = incident.Name;
                }
                else
                {
                    lstView.Items.Add("");
                }

                string[] row = { incident.ProductCode, (Convert.ToDateTime(incident.DateOpened).ToShortDateString()), (Convert.ToDateTime(incident.DateClosed).ToShortDateString()), incident.Title };
                lstView.Items[i].SubItems.AddRange(row);

                i += 1;
            }
        }
    }
}
