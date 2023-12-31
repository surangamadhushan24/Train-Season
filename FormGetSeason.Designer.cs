namespace TrainSeason
{
    partial class FormGetSeason
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
            this.labelTele = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelViewPrice = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTele.ForeColor = System.Drawing.Color.Navy;
            this.labelTele.Location = new System.Drawing.Point(58, 56);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(139, 25);
            this.labelTele.TabIndex = 4;
            this.labelTele.Text = "Select Month";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Navy;
            this.labelYear.Location = new System.Drawing.Point(58, 124);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(114, 25);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Enter Year";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.ForeColor = System.Drawing.Color.Navy;
            this.labelDestination.Location = new System.Drawing.Point(58, 199);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(120, 25);
            this.labelDestination.TabIndex = 6;
            this.labelDestination.Text = "Destination";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.BackColor = System.Drawing.Color.White;
            this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.ForeColor = System.Drawing.Color.Navy;
            this.labelprice.Location = new System.Drawing.Point(58, 265);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(200, 25);
            this.labelprice.TabIndex = 7;
            this.labelprice.Text = "Click To View Price";
            this.labelprice.Click += new System.EventHandler(this.labelprice_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.ForeColor = System.Drawing.Color.Navy;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Octomber",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(336, 48);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(200, 33);
            this.comboBoxMonth.TabIndex = 8;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.ForeColor = System.Drawing.Color.Navy;
            this.textBoxYear.Location = new System.Drawing.Point(336, 124);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 30);
            this.textBoxYear.TabIndex = 9;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestination.ForeColor = System.Drawing.Color.Navy;
            this.textBoxDestination.Location = new System.Drawing.Point(336, 194);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(200, 30);
            this.textBoxDestination.TabIndex = 10;
            // 
            // labelViewPrice
            // 
            this.labelViewPrice.AutoSize = true;
            this.labelViewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewPrice.ForeColor = System.Drawing.Color.Navy;
            this.labelViewPrice.Location = new System.Drawing.Point(331, 265);
            this.labelViewPrice.Name = "labelViewPrice";
            this.labelViewPrice.Size = new System.Drawing.Size(84, 25);
            this.labelViewPrice.TabIndex = 11;
            this.labelViewPrice.Text = "$$$$$$";
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Navy;
            this.buttonPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayment.ForeColor = System.Drawing.Color.White;
            this.buttonPayment.Location = new System.Drawing.Point(76, 375);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(135, 39);
            this.buttonPayment.TabIndex = 13;
            this.buttonPayment.Text = "PAYMENT";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Navy;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(336, 375);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 39);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormGetSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 462);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.labelViewPrice);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelTele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGetSeason";
            this.Text = "FormGetSeason";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelViewPrice;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonClear;
    }
}