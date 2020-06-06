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
    public partial class NewCourse : Form
    {
        public string ID;

        public NewCourse(string l)
        {
            ID = l;

            InitializeComponent();
        }

        private void NewCourse_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.cDODataSet4.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.TypePractik". При необходимости она может быть перемещена или удалена.
            this.typePractikTableAdapter4.Fill(this.cDODataSet4.TypePractik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.TypeObuch". При необходимости она может быть перемещена или удалена.
            this.typeObuchTableAdapter4.Fill(this.cDODataSet4.TypeObuch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.TypeProg". При необходимости она может быть перемещена или удалена.
            this.typeProgTableAdapter3.Fill(this.cDODataSet4.TypeProg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.Program". При необходимости она может быть перемещена или удалена.
            this.programTableAdapter3.Fill(this.cDODataSet4.Program);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter3.Fill(this.cDODataSet4.Course);
           

        }

        private void CbTypeProg_TextChanged(object sender, EventArgs e)
        { /*
            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
                SqlCommand cmd = connecting.CreateCommand();

                //Добавление курса
                cmd.CommandText = "SELECT KolChas FROM [TypeProg] WHERE NameType = '" + CbTypeProg.Text + "'";
                string chas = Convert.ToString(cmd.ExecuteScalar());
                MessageBox.Show(chas);
                TbChas.Text = chas;

                connecting.Close();



            }
            */
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand course = connecting.CreateCommand();
                    course.CommandText = "SELECT IDCourse FROM [Course] WHERE NameCourse='" + CbCourse.Text+"'";

                    SqlCommand prog = connecting.CreateCommand();
                    prog.CommandText = "SELECT ID FROM [Program] WHERE NameProg='" + CbProgram.Text+"'";

                    SqlCommand typeprog = connecting.CreateCommand();
                    typeprog.CommandText = "SELECT ID FROM [TypeProg] WHERE NameType='" + CbTypeProg.Text+"'";

                    SqlCommand typeobuch = connecting.CreateCommand();
                    typeobuch.CommandText = "SELECT ID FROM [TypeObuch] WHERE NameType='" + CbTypeObuch.Text+"'";

                    SqlCommand typepractik = connecting.CreateCommand();
                    typepractik.CommandText = "SELECT ID FROM [TypePractik] WHERE NamePractik='" + CbTypePractik.Text+"'";

                    SqlCommand cmd1 = connecting.CreateCommand();

                    //Добавление программы
                    cmd1.CommandText = "INSERT INTO [NewCourse] (Course, Program, Type, DateStart, DateEnd, KolChas, Smeta, TypeObuch, TypePractik, Kvalification, Profeciya, Group) VALUES ('" + Convert.ToInt32(course.ExecuteScalar()) + "', '"+ Convert.ToInt32(prog.ExecuteScalar())+"','"+ Convert.ToInt32(typeprog.ExecuteScalar())+"','"+ Convert.ToDateTime(dateStart.Value).ToShortDateString()+"', '"+ Convert.ToDateTime(dateEnd.Value).ToShortDateString()+"', '"+Convert.ToInt32(TbChas.Text)+"','" + Convert.ToInt32(TbSmeta.Text)+"', '" + Convert.ToInt32(typeobuch.ExecuteScalar())+"', '" + Convert.ToInt32(typepractik.ExecuteScalar())+"', '"+TbKvalif.Text+"', '"+TbProf.Text+"', '"+CbGroup.Text+"')";
                    cmd1.ExecuteScalar();
                    MessageBox.Show("Новый курс создан");

                    connecting.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Cources frm = new Cources();
            frm.Show();
            this.Hide();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand course = connecting.CreateCommand();
                    course.CommandText = "SELECT IDCourse FROM [Course] WHERE NameCourse='" + CbCourse.Text + "'";

                    SqlCommand prog = connecting.CreateCommand();
                    prog.CommandText = "SELECT ID FROM [Program] WHERE NameProg='" + CbProgram.Text + "'";

                    SqlCommand typeprog = connecting.CreateCommand();
                    typeprog.CommandText = "SELECT ID FROM [TypeProg] WHERE NameType='" + CbTypeProg.Text + "'";

                    SqlCommand typeobuch = connecting.CreateCommand();
                    typeobuch.CommandText = "SELECT ID FROM [TypeObuch] WHERE NameType='" + CbTypeObuch.Text + "'";

                    SqlCommand typepractik = connecting.CreateCommand();
                    typepractik.CommandText = "SELECT ID FROM [TypePractik] WHERE NamePractik='" + CbTypePractik.Text + "'";









                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о курсе
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [NewCourse] SET Course=@course, Program=@prog, Type=@typeprog, DateStart=@datestart, DateEnd=@dateend, KolChas=@kolchas, Smeta=@smeta, TypeObuch=@typeobuch, TypePractik=@typepractik, Kvalification=@kvalification, Profeciya=@profeciya, Group=@group  WHERE ID = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("course", Convert.ToInt32(course.ExecuteScalar()));
                    WriteCommand.Parameters.AddWithValue("prog", Convert.ToInt32(prog.ExecuteScalar()));
                    WriteCommand.Parameters.AddWithValue("typeprog", Convert.ToInt32(typeprog.ExecuteScalar()));
                    WriteCommand.Parameters.AddWithValue("datestart", Convert.ToDateTime(dateStart.Value).ToShortDateString());
                    WriteCommand.Parameters.AddWithValue("dateend", Convert.ToDateTime(dateEnd.Value).ToShortDateString());
                    WriteCommand.Parameters.AddWithValue("kolchas", Convert.ToInt32(TbChas.Text));
                    WriteCommand.Parameters.AddWithValue("smeta", Convert.ToInt32(TbSmeta.Text));
                    WriteCommand.Parameters.AddWithValue("typeobuch", Convert.ToInt32(typeobuch.ExecuteScalar()));
                    WriteCommand.Parameters.AddWithValue("typepractik", Convert.ToInt32(typepractik.ExecuteScalar()));
                    WriteCommand.Parameters.AddWithValue("kvalification", Convert.ToString(TbKvalif.Text));
                    WriteCommand.Parameters.AddWithValue("profeciya", Convert.ToString(TbProf.Text));
                    WriteCommand.Parameters.AddWithValue("group", Convert.ToString(CbGroup.Text));
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(ID));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Курс изменен");
                    connecting.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }


        }
    }
}

