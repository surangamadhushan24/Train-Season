using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSeason
{
    public partial class FormSeason : Form
    {
        public FormSeason()
        {
            InitializeComponent();
        }


        public string GetSid
        { get; set; }

        private void FormSeason_Load(object sender, EventArgs e)
        {
            labelGenarateCode.Text = GetSid;
        }

        private void buttonQr_Click(object sender, EventArgs e)
        {

            try
            {
                Zen.Barcode.CodeQrBarcodeDraw dr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox.Image = dr.Draw(labelGenarateCode.Text, 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.ShowDialog();
                pictureBox.Image.Save(dlg.FileName);
                MessageBox.Show("saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
           this.Hide();
        }
    }
}
