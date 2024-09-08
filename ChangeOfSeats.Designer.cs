
namespace Flights
{
    partial class ChangeOfSeats
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
            this.label1 = new System.Windows.Forms.Label();
            this.flightNumberBox = new System.Windows.Forms.TextBox();
            this.seatsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ рейса ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flightNumberBox
            // 
            this.flightNumberBox.BackColor = System.Drawing.SystemColors.Info;
            this.flightNumberBox.Location = new System.Drawing.Point(12, 31);
            this.flightNumberBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flightNumberBox.Name = "flightNumberBox";
            this.flightNumberBox.Size = new System.Drawing.Size(86, 20);
            this.flightNumberBox.TabIndex = 1;
            // 
            // seatsBox
            // 
            this.seatsBox.BackColor = System.Drawing.SystemColors.Info;
            this.seatsBox.Location = new System.Drawing.Point(175, 31);
            this.seatsBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(86, 20);
            this.seatsBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество мест \r\n";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.LawnGreen;
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(108, 86);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(84, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // ChangeOfSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(294, 121);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.seatsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightNumberBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "ChangeOfSeats";
            this.ShowIcon = false;
            this.Text = "Изменение количества свободных мест";
            this.Load += new System.EventHandler(this.ChangeOfSeats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flightNumberBox;
        private System.Windows.Forms.TextBox seatsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyButton;
    }
}