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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public static int User_ID;

        // getting the username of teacher
        private string getPt_id()
        {
            // fetch the data from the database
            con.Open();
            String syntax = "SELECT UserName FROM Teacher_Info where Id=@user_id";
            cmd = new SqlCommand(syntax, con);
            int i;
            i = int.Parse(textBox1.Text);
            User_ID = i;
            cmd.Parameters.AddWithValue("@user_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr.GetValue(0).ToString();
            dr.Close();
            con.Close();
            return temp;
        }


        //getting the password of teacher
        private string getPassword()
        {
            //fetch the data from the database
            con.Open();
            string syntax = "SELECT Password from Teacher_Info where Id = @user_id";
            cmd = new SqlCommand(syntax, con);
            int i;
            i = int.Parse(textBox1.Text);
            cmd.Parameters.AddWithValue("@user_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr.GetValue(0).ToString();
            dr.Close();
            con.Close();
            return temp;

        }

        // getting the username of student
        private string getPt_id_s()
        {
            // fetch the data from the database
            con.Open();
            String syntax = "SELECT UserName FROM Student_Info where Id=@user_id";
            cmd = new SqlCommand(syntax, con);
            int i;
            i = int.Parse(textBox1.Text);
            User_ID = i;
            cmd.Parameters.AddWithValue("@user_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr.GetValue(0).ToString();
            dr.Close();
            con.Close();
            return temp;
        }

        //getting the password of student
        private string getPassword_s()
        {
            //fetch the data from the database
            con.Open();
            string syntax = "SELECT Password from Student_Info where Id = @user_id";
            cmd = new SqlCommand(syntax, con);
            int i;
            i = int.Parse(textBox1.Text);
            cmd.Parameters.AddWithValue("@user_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr.GetValue(0).ToString();
            dr.Close();
            con.Close();
            return temp;

        }


        public static string dr_user_id;
        public static string dr_Password;
        private void button1_Click(object sender, EventArgs e)
        {
            string user_id;
            string Password;

            if(Form2.flag == 1)
            {
                dr_user_id = getPt_id();
                dr_Password = getPassword();
            }

            if(Form2.flag == 2)
            {
                dr_user_id = getPt_id_s();
                dr_Password = getPassword_s();
            }

            user_id = textBox7.Text;
            Password = textBox5.Text;
            if ((dr_user_id == user_id) && (dr_Password == Password))
            {
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Login Successful");
                    if(Form2.flag == 1)
                    {
                        Form6 obj = new Form6();
                        this.Hide();
                        obj.Show();
                    }

                    else if(Form2.flag == 2)
                    {
                        Form7 obj = new Form7();
                        this.Hide();
                        obj.Show();
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falied" + ex);
                }
                con.Close();

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
