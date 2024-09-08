
namespace Flights
{
    partial class Schedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.flightsDataGrid = new System.Windows.Forms.DataGridView();
            this.dPointsComboBox = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonGetFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flightRemoveBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flightsDataGrid
            // 
            this.flightsDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.flightsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flightsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flightsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGrid.Location = new System.Drawing.Point(12, 175);
            this.flightsDataGrid.Name = "flightsDataGrid";
            this.flightsDataGrid.RowHeadersWidth = 51;
            this.flightsDataGrid.Size = new System.Drawing.Size(632, 217);
            this.flightsDataGrid.TabIndex = 0;
            this.flightsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightsDataGrid_CellContentClick);
            // 
            // dPointsComboBox
            // 
            this.dPointsComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.dPointsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dPointsComboBox.FormattingEnabled = true;
            this.dPointsComboBox.Location = new System.Drawing.Point(4, 31);
            this.dPointsComboBox.Name = "dPointsComboBox";
            this.dPointsComboBox.Size = new System.Drawing.Size(115, 21);
            this.dPointsComboBox.TabIndex = 2;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShow.Location = new System.Drawing.Point(4, 63);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(117, 34);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Показать свободные места";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonGetFile
            // 
            this.buttonGetFile.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonGetFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetFile.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGetFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGetFile.Location = new System.Drawing.Point(188, 46);
            this.buttonGetFile.Name = "buttonGetFile";
            this.buttonGetFile.Size = new System.Drawing.Size(114, 29);
            this.buttonGetFile.TabIndex = 4;
            this.buttonGetFile.Text = "Сформировать";
            this.buttonGetFile.UseVisualStyleBackColor = false;
            this.buttonGetFile.Click += new System.EventHandler(this.buttonGetFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сформировать файл :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LawnGreen;
            this.addButton.Location = new System.Drawing.Point(483, 108);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 40);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Добавить рейс";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(478, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Удаление рейса : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flightRemoveBox
            // 
            this.flightRemoveBox.BackColor = System.Drawing.SystemColors.Info;
            this.flightRemoveBox.Location = new System.Drawing.Point(539, 32);
            this.flightRemoveBox.Name = "flightRemoveBox";
            this.flightRemoveBox.Size = new System.Drawing.Size(49, 20);
            this.flightRemoveBox.TabIndex = 8;
            this.flightRemoveBox.TextChanged += new System.EventHandler(this.flightRemoveBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(479, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = " № рейса";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(486, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(8, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Изменить кол-во свободных мест";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Bisque;
            this.printButton.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printButton.Location = new System.Drawing.Point(332, 46);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(114, 31);
            this.printButton.TabIndex = 12;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(213, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Расписание самолетов";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите город : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Schedule
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flightRemoveBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetFile);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dPointsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Schedule";
            this.Text = "Расписание рейсов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flightsDataGrid;
        private System.Windows.Forms.ComboBox dPointsComboBox;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonGetFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox flightRemoveBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

