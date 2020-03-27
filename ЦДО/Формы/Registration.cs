using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦДО
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbLogin.Text != "" && TbPass.Text != "" && TbMail.Text != "")
                {
                    var email = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
                    bool isValid = email.IsMatch(TbMail.Text);

                    if (isValid == true)
                    {
                        using (SqlConnection connecting = new SqlConnection(Program.connection))
                        {
                            connecting.Open();
                            SqlCommand cmd = connecting.CreateCommand();

                            //Запись в таблицу Студент
                            cmd.CommandText = "INSERT INTO [Users] (login, pass, email) VALUES ('" + TbLogin.Text + "','" + TbPass.Text + "','" + TbMail.Text + "')";

                        }
                    }
                    else
                    {
                        MessageBox.Show("E-mail не соответсвует стандарту" +
                            "Образец E-mail: nastya-maa@ngs.ru");

                    }
                }
                MessageBox.Show("Регистрация успешно завершена!");
                this.Close();
                Start frm = new Start();

                frm.Show();
                this.Hide();


            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }
        }
    }
}

    