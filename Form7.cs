using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAA_da
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        List<string> pdfFiles = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = ofd.FileName;

                    pdfFiles = new List<string>();
                    foreach (string fileName in ofd.FileNames)
                        pdfFiles.Add(fileName);
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
