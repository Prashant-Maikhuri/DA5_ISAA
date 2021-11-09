using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISAA_da
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form2.flag == 1)
            {
                SqlCommand cmd = new SqlCommand("Add_teacher_info", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                int i = int.Parse(textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", i);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                int j = int.Parse(textBox4.Text);
                cmd.Parameters.AddWithValue("@Ph", j);
                cmd.Parameters.AddWithValue("@UserName", textBox7.Text);
                cmd.Parameters.AddWithValue("@Password", textBox5.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    Form5 tt = new Form5();
                    this.Hide();
                    tt.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falied" + ex);
                }
                con.Close();

            }

            if(Form2.flag == 2)
            {
                SqlCommand cmd = new SqlCommand("Add_student_info", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                int i = int.Parse(textBox2.Text);
                cmd.Parameters.AddWithValue("@Age", i);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                int j = int.Parse(textBox4.Text);
                cmd.Parameters.AddWithValue("@Ph", j);
                cmd.Parameters.AddWithValue("@UserName", textBox7.Text);
                cmd.Parameters.AddWithValue("@Password", textBox5.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    Form5 tt = new Form5();
                    this.Hide();
                    tt.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falied" + ex);
                }
                con.Close();
            }
            

        }
    }
}
