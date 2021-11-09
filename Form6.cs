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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        List<string> pdfFiles = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog() { ValidateNames= true,Multiselect=false,Filter="PDF|*.pdf"})
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PDF file|*.pdf";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;

                // Here you can save the file with the chosen file name
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
