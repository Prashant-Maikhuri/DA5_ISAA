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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            Form3 tt = new Form3();
            this.Hide();
            tt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = 2;
            Form3 tt = new Form3();
            this.Hide();
            tt.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
