using Microsoft.Graph;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;


namespace Flights
{
   
    public partial class Schedule : Form
    {
        private bool _isFormed = false;
        private string _savePath;
        private List<Fly> _flights = new List<Fly>();
        public Schedule()
        {
            InitializeComponent();
        }

        public void EntryTable()
        {
            flightsDataGrid.Rows.Clear();
            List<string> text = File.ReadAllText("Files/flights.csv").Split('\n').ToList();
            string[] headers = text[0].Split(';');
            flightsDataGrid.ColumnCount = headers.Length;

            for (int i = 0; i < headers.Length; i++)
            {
                flightsDataGrid.Columns[i].ReadOnly = true;
                flightsDataGrid.Columns[i].Name = headers[i];
                flightsDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            text.RemoveAt(0);
            _flights.Clear();
            dPointsComboBox.Items.Clear();
            foreach (string row in text)
            {
                if (!string.IsNullOrEmpty(row))
                {
                    Fly flight = new Fly(row);
                    _flights.Add(flight);
                    flightsDataGrid.Rows.Add(flight.GetArray());
                    if (!dPointsComboBox.Items.Contains(flight.GetDestinationPoint()))
                    {
                        dPointsComboBox.Items.Add(flight.GetDestinationPoint());
                    }
                }
            }
            if (dPointsComboBox.Items.Count != 0)
                dPointsComboBox.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flights = File.ReadAllText("Files/flights.csv");
            List<string> flightsList = flights.Split('\n').ToList();
            bool removed = false;
            for (int i = 1; i < flightsList.Count - 1; i++)
            {
                if (flightsList[i].Split(';')[0] == flightRemoveBox.Text)
                {
                    flightsList.RemoveAt(i);
                    removed = true;
                    break;
                }
            }
            if (removed)
            {
                // удаление рейса из списка рейсов
                if (MessageBox.Show($"Вы точно хотите удалить рейс № {flightRemoveBox.Text}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _flights.RemoveAt(_flights.FindIndex(x => x.GetNumber() == int.Parse(flightRemoveBox.Text)));
                    flights = string.Join("\n", flightsList.ToArray());
                    File.WriteAllText("Files/flights.csv", flights);

                    MessageBox.Show($"Рейс {flightRemoveBox.Text}  удалён!");
                }
            }
            else
            {
                MessageBox.Show("Такого рейса нет в списке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            flightRemoveBox.Text = "";
            EntryTable();
        }

        public bool AddFlight(string number, string dest, string depTime, string arrTime, string freeSeats)
        {
            for (int i = 0; i < flightsDataGrid.RowCount - 1; i++)
            {
                if (flightsDataGrid.Rows[i].Cells[0].Value.ToString() == number)
                {
                    MessageBox.Show("Рейс с таким номером уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string flights = File.ReadAllText("Files/flights.csv");
            flights += number + ";" + dest + ";" + depTime + ";" +
                arrTime + ";" + freeSeats + "\n";
            File.WriteAllText("Files/flights.csv", flights);
            MessageBox.Show("Рейс добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EntryTable();
            return true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EntryTable();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FreeSeats freeSeatsForm = new FreeSeats(_flights.Where(flight => flight.GetDestinationPoint() == dPointsComboBox.SelectedItem.ToString()).ToList());
            if (dPointsComboBox.SelectedIndex != -1)
                freeSeatsForm.Show();
            else
            {
                MessageBox.Show("Список рейсов пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            _isFormed = true;
            StringBuilder text = new StringBuilder("№ рейса;Пункт назначения;Время вылета\n");
            foreach (DataGridViewRow row in flightsDataGrid.Rows)
            {
                text.Append($"{row.Cells[0].Value};{row.Cells[1].Value};{row.Cells[2].Value}\n");
            }
            File.WriteAllText("flight_point_time.csv", text.ToString());
        



        // открытие файла
        //System.Diagnostics.Process.Start("notepad.exe", "flight_point_time.csv");
        object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();

            Word.Paragraph para = doc.Paragraphs.Add(ref oMissing);
            para.Range.Text = $"Выдано: {DateTime.Now}";

            int k = 0;
            int j = 0;

            int columns = 3;
            int rows = _flights.Count + 1;

            Word.Table objTable;
            Word.Range wrdRng = doc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            objTable = doc.Tables.Add(wrdRng, rows, columns, ref oMissing, ref oMissing);
            objTable.Range.ParagraphFormat.SpaceAfter = 7;


            objTable.Cell(1, 1).Range.Text = "№ рейса";
            objTable.Cell(1, 2).Range.Text = "Пункт назначения";
            objTable.Cell(1, 3).Range.Text = "Время вылета";


            for (k = 2; k <= rows; k++)
            {
                objTable.Cell(k, 1).Range.Text = _flights[k - 2].GetNumber().ToString();
                objTable.Cell(k, 2).Range.Text = _flights[k - 2].GetDestinationPoint();
                objTable.Cell(k, 3).Range.Text = _flights[k - 2].GetDepartureTime();
            }
            objTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            objTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            string savePath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\flight_point_time.docx";
            doc.SaveAs2(savePath);
            doc.Close();
            Process.Start(savePath);
            _savePath = savePath;
            MessageBox.Show("Файл успешно сформирован!");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddFlight addForm = new AddFlight(this);
            addForm.Show();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeOfSeats changeSeats = new ChangeOfSeats(this);
            changeSeats.Show();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (_isFormed)
            {
                ProcessStartInfo info = new ProcessStartInfo(_savePath);
                info.Verb = "print";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
            else
            {
                MessageBox.Show("Изначально необходимо сформировать файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flightsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flightRemoveBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
