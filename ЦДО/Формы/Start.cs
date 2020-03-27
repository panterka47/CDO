using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦДО
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            AddEditStudents ifrm = new AddEditStudents();
            ifrm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditStudent ifrm = new EditStudent();
            ifrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEditEducation ifrm = new AddEditEducation();
            ifrm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewTeacher frm = new NewTeacher();
            frm.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();

        }
        */

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TbLogin.Text != "" && TbPass.Text != "")

            {

                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd = connecting.CreateCommand();
                    cmd.CommandText = "SELECT Pass from [Users] Where Login ='" + TbLogin.Text + "'";
                    string password = Convert.ToString(cmd.ExecuteScalar());

                    if (TbPass.Text == password)
                    {
                        Menu frm = new Menu();
                        frm.Show();
                        this.Hide();

                    }

                    connecting.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            frm.Show();
            this.Hide();


        }
    }
}