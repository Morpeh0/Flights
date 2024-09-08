using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights
{
    public partial class FreeSeats : Form
    {
        public FreeSeats(List<Fly> flights)
        {
            InitializeComponent();
            seatsView.ColumnCount = 2;
            seatsView.Columns[0].Name = "№ рейса";
            seatsView.Columns[1].Name = "Свободные места ";

            foreach (var flight in flights)
            {
                seatsView.Rows.Add(flight.GetNumberAndSeats());
            }

        }

        private void FreeSeats_Load(object sender, EventArgs e)
        {

        }

        private void SeatsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
