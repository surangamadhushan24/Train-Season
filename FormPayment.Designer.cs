namespace TrainSeason
{
    partial class FormPayment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTele = new System.Windows.Forms.Label();
            this.radioButtonVisa = new System.Windows.Forms.RadioButton();
            this.radioButtonAmex = new System.Windows.Forms.RadioButton();
            this.radioButtonMaster = new System.Windows.Forms.RadioButton();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelCvn = new System.Windows.Forms.Label();
            this.textBoxCvn = new System.Windows.Forms.TextBox();
            this.labelExDate = new System.Windows.Forms.Label();
            this.textBoxExYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelExMonth = new System.Windows.Forms.Label();
            this.comboBoxExMonth = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelViewAmount = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 67);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "PAYMENT";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Navy;
            this.buttonClose.Location = new System.Drawing.Point(816, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(67, 67);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTele.ForeColor = System.Drawing.Color.Navy;
            this.labelTele.Location = new System.Drawing.Point(33, 113);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(241, 25);
            this.labelTele.TabIndex = 5;
            this.labelTele.Text = "Select Payment Method";
            // 
            // radioButtonVisa
            // 
            this.radioButtonVisa.AutoSize = true;
            this.radioButtonVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVisa.ForeColor = System.Drawing.Color.Navy;
            this.radioButtonVisa.Location = new System.Drawing.Point(390, 109);
            this.radioButtonVisa.Name = "radioButtonVisa";
            this.radioButtonVisa.Size = new System.Drawing.Size(76, 29);
            this.radioButtonVisa.TabIndex = 6;
            this.radioButtonVisa.TabStop = true;
            this.radioButtonVisa.Text = "Visa";
            this.radioButtonVisa.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmex
            // 
            this.radioButtonAmex.AutoSize = true;
            this.radioButtonAmex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAmex.ForeColor = System.Drawing.Color.Navy;
            this.radioButtonAmex.Location = new System.Drawing.Point(763, 109);
            this.radioButtonAmex.Name = "radioButtonAmex";
            this.radioButtonAmex.Size = new System.Drawing.Size(88, 29);
            this.radioButtonAmex.TabIndex = 7;
            this.radioButtonAmex.TabStop = true;
            this.radioButtonAmex.Text = "Amex";
            this.radioButtonAmex.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster
            // 
            this.radioButtonMaster.AutoSize = true;
            this.radioButtonMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaster.ForeColor = System.Drawing.Color.Navy;
            this.radioButtonMaster.Location = new System.Drawing.Point(572, 109);
            this.radioButtonMaster.Name = "radioButtonMaster";
            this.radioButtonMaster.Size = new System.Drawing.Size(99, 29);
            this.radioButtonMaster.TabIndex = 8;
            this.radioButtonMaster.TabStop = true;
            this.radioButtonMaster.Text = "Master";
            this.radioButtonMaster.UseVisualStyleBackColor = true;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.ForeColor = System.Drawing.Color.Navy;
            this.labelCardNumber.Location = new System.Drawing.Point(33, 178);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(197, 25);
            this.labelCardNumber.TabIndex = 9;
            this.labelCardNumber.Text = "Enter Card Number";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNumber.ForeColor = System.Drawing.Color.Navy;
            this.textBoxCardNumber.Location = new System.Drawing.Point(330, 175);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(491, 30);
            this.textBoxCardNumber.TabIndex = 10;
            // 
            // labelCvn
            // 
            this.labelCvn.AutoSize = true;
            this.labelCvn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCvn.ForeColor = System.Drawing.Color.Navy;
            this.labelCvn.Location = new System.Drawing.Point(33, 249);
            this.labelCvn.Name = "labelCvn";
            this.labelCvn.Size = new System.Drawing.Size(58, 25);
            this.labelCvn.TabIndex = 11;
            this.labelCvn.Text = "CVN";
            // 
            // textBoxCvn
            // 
            this.textBoxCvn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCvn.ForeColor = System.Drawing.Color.Navy;
            this.textBoxCvn.Location = new System.Drawing.Point(330, 246);
            this.textBoxCvn.Name = "textBoxCvn";
            this.textBoxCvn.Size = new System.Drawing.Size(79, 30);
            this.textBoxCvn.TabIndex = 12;
            // 
            // labelExDate
            // 
            this.labelExDate.AutoSize = true;
            this.labelExDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExDate.ForeColor = System.Drawing.Color.Navy;
            this.labelExDate.Location = new System.Drawing.Point(33, 311);
            this.labelExDate.Name = "labelExDate";
            this.labelExDate.Size = new System.Drawing.Size(88, 25);
            this.labelExDate.TabIndex = 13;
            this.labelExDate.Text = "Ex Date";
            // 
            // textBoxExYear
            // 
            this.textBoxExYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExYear.ForeColor = System.Drawing.Color.Navy;
            this.textBoxExYear.Location = new System.Drawing.Point(412, 310);
            this.textBoxExYear.Name = "textBoxExYear";
            this.textBoxExYear.Size = new System.Drawing.Size(128, 30);
            this.textBoxExYear.TabIndex = 14;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Navy;
            this.labelYear.Location = new System.Drawing.Point(325, 313);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(57, 25);
            this.labelYear.TabIndex = 15;
            this.labelYear.Text = "Year";
            // 
            // labelExMonth
            // 
            this.labelExMonth.AutoSize = true;
            this.labelExMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExMonth.ForeColor = System.Drawing.Color.Navy;
            this.labelExMonth.Location = new System.Drawing.Point(580, 315);
            this.labelExMonth.Name = "labelExMonth";
            this.labelExMonth.Size = new System.Drawing.Size(72, 25);
            this.labelExMonth.TabIndex = 16;
            this.labelExMonth.Text = "Month";
            // 
            // comboBoxExMonth
            // 
            this.comboBoxExMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExMonth.ForeColor = System.Drawing.Color.Navy;
            this.comboBoxExMonth.FormattingEnabled = true;
            this.comboBoxExMonth.Items.AddRange(new object[] {
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
            this.comboBoxExMonth.Location = new System.Drawing.Point(671, 303);
            this.comboBoxExMonth.Name = "comboBoxExMonth";
            this.comboBoxExMonth.Size = new System.Drawing.Size(200, 33);
            this.comboBoxExMonth.TabIndex = 17;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.Navy;
            this.labelAmount.Location = new System.Drawing.Point(33, 379);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(86, 25);
            this.labelAmount.TabIndex = 18;
            this.labelAmount.Text = "Amount";
            // 
            // labelViewAmount
            // 
            this.labelViewAmount.AutoSize = true;
            this.labelViewAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAmount.ForeColor = System.Drawing.Color.Navy;
            this.labelViewAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelViewAmount.Location = new System.Drawing.Point(325, 379);
            this.labelViewAmount.Name = "labelViewAmount";
            this.labelViewAmount.Size = new System.Drawing.Size(84, 25);
            this.labelViewAmount.TabIndex = 19;
            this.labelViewAmount.Text = "$$$$$$";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Navy;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(330, 441);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(147, 54);
            this.buttonSubmit.TabIndex = 20;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TrainSeason.Properties.Resources.amex;
            this.pictureBox3.Location = new System.Drawing.Point(705, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrainSeason.Properties.Resources.master;
            this.pictureBox2.Location = new System.Drawing.Point(511, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainSeason.Properties.Resources.visa;
            this.pictureBox1.Location = new System.Drawing.Point(330, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 507);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelViewAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxExMonth);
            this.Controls.Add(this.labelExMonth);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxExYear);
            this.Controls.Add(this.labelExDate);
            this.Controls.Add(this.textBoxCvn);
            this.Controls.Add(this.labelCvn);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.radioButtonMaster);
            this.Controls.Add(this.radioButtonAmex);
            this.Controls.Add(this.radioButtonVisa);
            this.Controls.Add(this.labelTele);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.RadioButton radioButtonVisa;
        private System.Windows.Forms.RadioButton radioButtonAmex;
        private System.Windows.Forms.RadioButton radioButtonMaster;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelCvn;
        private System.Windows.Forms.TextBox textBoxCvn;
        private System.Windows.Forms.Label labelExDate;
        private System.Windows.Forms.TextBox textBoxExYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelExMonth;
        private System.Windows.Forms.ComboBox comboBoxExMonth;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelViewAmount;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}