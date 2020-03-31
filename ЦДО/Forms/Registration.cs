using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ЦДО.Формы;

namespace ЦДО
{
    public partial class Registration : Form
    {
        Hach hach = new Hach();

        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbPassRep.Text.Length > 0 && TbPass.Text.Length > 0 && TbPassRep.Text == TbPass.Text)
                {
                    if (TbLogin.Text.Length > 0 && TbMail.Text.Length > 0)
                    {
                        var email = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
                        bool isValid = email.IsMatch(TbMail.Text);

                        if (isValid == true)
                        {
                            using (SqlConnection connecting = new SqlConnection(Program.connection))
                            {
                                connecting.Open();
                                SqlCommand cmd = connecting.CreateCommand();

                                //Запись в таблицу Пользователи

                                //hach.GetHash(TbPass.Text)
                                cmd.CommandText = "INSERT INTO [Users] (login, pass, email) VALUES ('" + TbLogin.Text + "','" + hach.GetHash(TbPass.Text) + "','" + TbMail.Text + "')";
                                cmd.ExecuteScalar();
                                
                                connecting.Close();
                                 
                                MessageBox.Show("Регистрация успешно завершена!");
                                Start frm = new Start();
                                frm.Show();
                                Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail не соответсвует стандарту" +
                                "Образец E-mail: nastya-maa@ngs.ru");
                        }
                    }
                    else MessageBox.Show("Пароли не совпадают !!! ");
                }
                else MessageBox.Show("Одно или несколько полей не заполнены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex); //Convert.ToString(ex.Message) ???
            }
        }
    }
}

    