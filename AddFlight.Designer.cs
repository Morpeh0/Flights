
namespace Flights
{
    partial class AddFlight
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
            this.destinationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depTimeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.arrTimeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.freeSeatsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ рейса";
            // 
            // flightNumberBox
            // 
            this.flightNumberBox.BackColor = System.Drawing.SystemColors.Info;
            this.flightNumberBox.Location = new System.Drawing.Point(218, 40);
            this.flightNumberBox.Name = "flightNumberBox";
            this.flightNumberBox.Size = new System.Drawing.Size(100, 20);
            this.flightNumberBox.TabIndex = 1;
            // 
            // destinationBox
            // 
            this.destinationBox.BackColor = System.Drawing.SystemColors.Info;
            this.destinationBox.Location = new System.Drawing.Point(218, 66);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(100, 20);
            this.destinationBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пункт назначения :";
            // 
            // depTimeBox
            // 
            this.depTimeBox.BackColor = System.Drawing.SystemColors.Info;
            this.depTimeBox.Location = new System.Drawing.Point(218, 92);
            this.depTimeBox.Name = "depTimeBox";
            this.depTimeBox.Size = new System.Drawing.Size(100, 20);
            this.depTimeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время вылета :";
            // 
            // arrTimeBox
            // 
            this.arrTimeBox.BackColor = System.Drawing.SystemColors.Info;
            this.arrTimeBox.Location = new System.Drawing.Point(218, 118);
            this.arrTimeBox.Name = "arrTimeBox";
            this.arrTimeBox.Size = new System.Drawing.Size(100, 20);
            this.arrTimeBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время прибытия : ";
            // 
            // freeSeatsBox
            // 
            this.freeSeatsBox.BackColor = System.Drawing.SystemColors.Info;
            this.freeSeatsBox.Location = new System.Drawing.Point(218, 144);
            this.freeSeatsBox.Name = "freeSeatsBox";
            this.freeSeatsBox.Size = new System.Drawing.Size(100, 20);
            this.freeSeatsBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во свободных мест в салоне :";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LawnGreen;
            this.AddButton.Location = new System.Drawing.Point(121, 196);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(340, 231);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.freeSeatsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arrTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depTimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightNumberBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Text = "Добавление рейса";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flightNumberBox;
        private System.Windows.Forms.TextBox destinationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depTimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arrTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox freeSeatsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
    }
}