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
    public partial class AddEditEducation : Form
    {
        public string Id;
        public AddEditEducation(string l)
        {
            InitializeComponent();
            Id = l;
        }
        private void BtnCourseNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd = connecting.CreateCommand();

                    //Добавление курса
                    cmd.CommandText = "INSERT INTO [Course] (NameCourse) VALUES ('" + TbCourse.Text + "')";
                    cmd.ExecuteScalar();

                    MessageBox.Show("Курс добавлен");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }
        }

        private void BtnProgNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd1 = connecting.CreateCommand();

                    //Добавление программы
                    cmd1.CommandText = "INSERT INTO [Program] (NameProg) VALUES ('" + TbProg.Text + "')";
                    cmd1.ExecuteScalar();
                    MessageBox.Show("Программа добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }

        }

        private void BtnTypeNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd2 = connecting.CreateCommand();

                    //Добавление типа подготовки
                    cmd2.CommandText = "INSERT INTO [TypeProg] (NameType, KolChas, TypeDoc) VALUES ('" + TbType.Text + "','" + Convert.ToInt32(TbKolChas.Text) + "','" + CbDocEducat.Text + "')";
                    cmd2.ExecuteScalar();
                    MessageBox.Show("Тип программы добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }
        }

        private void BtnTypePractik_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd2 = connecting.CreateCommand();

                    //Добавление типа практики
                    cmd2.CommandText = "INSERT INTO [TypePractik] (NamePractik) VALUES ('" + TbTypePractik.Text + "')";
                    cmd2.ExecuteScalar();
                    MessageBox.Show("Тип практики добавлен");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }
        }

        private void BtnCourseEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();


                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о курсе
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [Course] SET NameCourse=@namecourse  WHERE IDCourse = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("namecourse", TbCourse.Text);
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(Id));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Курс изменен");
                    connecting.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }

        }

        private void BtnProgEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();


                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о программе
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [Program] SET NameProg=@nameprog  WHERE ID = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("nameprog", TbProg.Text);
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(Id));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Программа изменена");
                    connecting.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }
        }

        private void BtnTypeEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();


                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о типе подготовки
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [TypeProg] SET NameType=@nametype, KolChas=@kolchas, TypeDoc=@typedoc  WHERE ID = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("nametype", TbType.Text);
                    WriteCommand.Parameters.AddWithValue("kolchas", Convert.ToInt32(TbKolChas.Text));
                    WriteCommand.Parameters.AddWithValue("typedoc", CbDocEducat.Text);
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(Id));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Тип подготовки изменен");
                    connecting.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }
        }

        private void BtnTypePractikEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();


                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о типе практики
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [TypePractik] SET NamePractik=@namepractik  WHERE ID = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("namepractik", TbTypePractik.Text);
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(Id));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Тип практики изменен");
                    connecting.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd2 = connecting.CreateCommand();

                    //Добавление типа подготовки
                    cmd2.CommandText = "INSERT INTO [Group] (NameGroup) VALUES ('" +TbGroup.Text + "')";
                    cmd2.ExecuteScalar();
                    MessageBox.Show("Группа добавлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }
        }

        
    }
    }
    
 
