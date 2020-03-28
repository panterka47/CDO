using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ЦДО.Формы;

namespace ЦДО
{
    public partial class Start : Form
    {
        Hach hach = new Hach(); 
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
            try
            {
                if (TbLogin.Text.Length > 0 && TbPass.Text.Length > 0)//.Length > 0 лучше так проверять 
                {
                    using (SqlConnection connecting = new SqlConnection(Program.connection))
                    {
                        connecting.Open();
                        SqlCommand cmd = connecting.CreateCommand();
                        cmd.CommandText = "SELECT Pass from [Users] Where Login ='" + TbLogin.Text + "'";
                        string password = Convert.ToString(cmd.ExecuteScalar());
                        connecting.Close();
                        if (hach.GetHash(TbPass.Text) == password)
                        {
                            Menu frm = new Menu();
                            frm.Show();
                            Hide(); //this писать не нужно 
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            frm.Show();
            Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}