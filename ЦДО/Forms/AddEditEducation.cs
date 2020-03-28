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
        public AddEditEducation()
        {
            InitializeComponent();
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

                    //Добавление типа обучения
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

                    //Добавление типа обучения
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
    }
 }
