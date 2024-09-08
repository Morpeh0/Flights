
namespace Flights
{
    partial class FreeSeats
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
            this.seatsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.seatsView)).BeginInit();
            this.SuspendLayout();
            // 
            // seatsView
            // 
            this.seatsView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.seatsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seatsView.Location = new System.Drawing.Point(12, 12);
            this.seatsView.Name = "seatsView";
            this.seatsView.RowHeadersWidth = 51;
            this.seatsView.Size = new System.Drawing.Size(277, 157);
            this.seatsView.TabIndex = 0;
            this.seatsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeatsView_CellContentClick);
            // 
            // FreeSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(314, 198);
            this.Controls.Add(this.seatsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FreeSeats";
            this.ShowIcon = false;
            this.Text = "Свободные места";
            this.Load += new System.EventHandler(this.FreeSeats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seatsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seatsView;
    }
}