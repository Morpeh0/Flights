using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights
{
    public partial class ChangeOfSeats : Form
    {
        private Schedule _form;

        public ChangeOfSeats(Schedule form1)
        {
            _form = form1;
            InitializeComponent();
        }

        private List<Fly> LoadFlightsFromFile()
        {
            List<Fly> flights = new List<Fly>();
            List<string> text = File.ReadAllText("Files/flights.csv").Split('\n').ToList();
            string[] headers = text[0].Split(';');
            text.RemoveAt(0);

            foreach (string row in text)
            {
                if (!string.IsNullOrEmpty(row))
                {
                    Fly flight = new Fly(row);
                    flights.Add(flight);
                }
            }

            return flights;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(flightNumberBox.Text, out int number)
                && int.TryParse(seatsBox.Text, out int seats))
            {
                if (seats <= 0)
                {
                    MessageBox.Show("Количество мест должно быть положительным целым числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Fly> flights = LoadFlightsFromFile();

                bool found = false;

                foreach (Fly f in flights)
                {
                    if (f.GetNumber() == number)
                    {
                        if (f.GetFreeSeats() == seats)
                        {
                            MessageBox.Show("Указанное количество мест на этот рейс уже забронировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        f.SetSeats(seats);
                        found = true;
                    }
                }

                if (found)
                {
                    string flightsInfo = "Номер рейса; Пункт назначения; Время вылета; Время прибытия; Свободные места\n";

                    foreach (Fly f in flights)
                    {
                        flightsInfo += f.GetNumber() + ";" + f.GetDestinationPoint() + ";" + f.GetDepartureTime() + ";" +
                        f.GetArrivalTime() + ";" + f.GetFreeSeats() + "\n";
                    }

                    SaveFlightsToFile(flightsInfo);

                    MessageBox.Show("Количество мест обновлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _form.EntryTable();
                    Close();
                }
                else
                {
                    MessageBox.Show("Рейса с указанным номером не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Номер рейса и количество посадочных мест должны быть целыми положительными числами!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveFlightsToFile(string flightsInfo)
        {
            File.WriteAllText("Files/flights.csv", flightsInfo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeOfSeats_Load(object sender, EventArgs e)
        {

        }
    }
        
}
