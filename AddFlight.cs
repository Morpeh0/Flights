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
    public partial class AddFlight : Form
    {
        private Schedule _form;
        private int MAX_SEATS = 96;
        public AddFlight(Schedule form)
        {
            _form = form;
            InitializeComponent();
            destinationBox.KeyPress += new KeyPressEventHandler(KeyPres);
        }

        private void KeyPres(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
                return;
            e.Handled = true;

        }
        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightNumberBox.Text) ||
                string.IsNullOrEmpty(destinationBox.Text) ||
                string.IsNullOrEmpty(depTimeBox.Text) ||
                string.IsNullOrEmpty(arrTimeBox.Text) ||
                string.IsNullOrEmpty(freeSeatsBox.Text))
            {
                MessageBox.Show("Заполните все значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(flightNumberBox.Text, out int flightNumber))
            {
                if (int.TryParse(freeSeatsBox.Text, out int seats))
                {
                    string departureTime = depTimeBox.Text;
                    string arrivalTime = arrTimeBox.Text;

                    if (DateTime.TryParse(departureTime, out DateTime res))
                    {
                        departureTime = string.Format("{0:HH:mm}", res);
                    }
                    else
                    {
                        MessageBox.Show("Введите время в формате ЧЧ:ММ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (DateTime.TryParse(arrivalTime, out DateTime res2))
                    {
                        arrivalTime = string.Format("{0:HH:mm}", res2);
                    }
                    else
                    {
                        MessageBox.Show("Введите время в формате ЧЧ:ММ (00 <= ЧЧ <= 23, 0 <= ММ <= 59)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (flightNumber > 0 && seats > 0)
                    {
                        if (seats > MAX_SEATS)
                        {
                            MessageBox.Show("Количество мест не может превышать 96!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            bool result = _form.AddFlight(flightNumberBox.Text, destinationBox.Text, departureTime, arrivalTime, freeSeatsBox.Text);
                            if (result)
                            {
                                Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество мест и номер рейса должны быть натуральными числами!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Количество должно быть натуральным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Номер рейса должен быть натуральным числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
    }
}
