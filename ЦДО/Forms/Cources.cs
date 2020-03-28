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
    public partial class Cources : Form
    {
        public string p = "";

        public Cources()
        {
            InitializeComponent();
        }

        private void Cources_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet4.NewCourse". При необходимости она может быть перемещена или удалена.
            this.newCourseTableAdapter2.Fill(this.cDODataSet4.NewCourse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet3.NewCourse". При необходимости она может быть перемещена или удалена.
       //     this.newCourseTableAdapter1.Fill(this.cDODataSet3.NewCourse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet2.NewCourse". При необходимости она может быть перемещена или удалена.
        //    this.newCourseTableAdapter.Fill(this.cDODataSet2.NewCourse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.NewCourse". При необходимости она может быть перемещена или удалена.
        //    this.newCourseTableAdapter.Fill(this.cDODataSet1.NewCourse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.NewCourse". При необходимости она может быть перемещена или удалена.
        //    this.newCourseTableAdapter.Fill(this.cDODataSet.NewCourse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Course". При необходимости она может быть перемещена или удалена.
          //  this.courseTableAdapter.Fill(this.cDODataSet.Course);

        }
        private void GridCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = Convert.ToString(this.GridCourse.CurrentRow.Cells[0].Value);
           MessageBox.Show(p);
        }



        private void BtnBack_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string p = "";

            NewCourse frm = new NewCourse(p);
            frm.BtnAdd.Enabled = true;
            frm.BtnEdit.Enabled = false;

            frm.Show();
            this.Hide();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            NewCourse frm = new NewCourse(p);

            //Передача данных о студенте на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
                MessageBox.Show(p);

                // Данные из таблицы Курсы

                SqlCommand course = connecting.CreateCommand();
                course.CommandText = "SELECT Course FROM [NewCourse] WHERE ID= " + p;
                course.ExecuteScalar();

                SqlCommand program = connecting.CreateCommand();
                program.CommandText = "SELECT Program FROM [NewCourse] WHERE ID= " + p;
                program.ExecuteScalar();

                SqlCommand type = connecting.CreateCommand();
                type.CommandText = "SELECT Type FROM [NewCourse] WHERE ID= " + p;
                type.ExecuteScalar();

                SqlCommand datestart = connecting.CreateCommand();
                datestart.CommandText = "SELECT DateStart FROM [NewCourse] WHERE ID= " + p;
                datestart.ExecuteScalar();

                SqlCommand dateend = connecting.CreateCommand();
                dateend.CommandText = "SELECT DateEnd FROM [NewCourse] WHERE ID= " + p;
                dateend.ExecuteScalar();

                SqlCommand kolchas = connecting.CreateCommand();
                kolchas.CommandText = "SELECT KolChas FROM [NewCourse] WHERE ID= " + p;
                kolchas.ExecuteScalar();

                SqlCommand smeta = connecting.CreateCommand();
                smeta.CommandText = "SELECT Smeta FROM [NewCourse] WHERE ID= " + p;
                smeta.ExecuteScalar();

                SqlCommand typeobuch = connecting.CreateCommand();
                typeobuch.CommandText = "SELECT TypeObuch FROM [NewCourse] WHERE ID= " + p;
                typeobuch.ExecuteScalar();

                SqlCommand typepractik = connecting.CreateCommand();
                typepractik.CommandText = "SELECT TypePractik FROM [NewCourse] WHERE ID= " + p;
                typepractik.ExecuteScalar();


                //Заполнение полей на форме редактирования данных о курсе
                frm.CbCourse.Text = Convert.ToString(course.ExecuteScalar());
                frm.CbProgram.Text = Convert.ToString(program.ExecuteScalar());
                frm.CbTypeProg.Text = Convert.ToString(type.ExecuteScalar());
                frm.dateStart.Value = Convert.ToDateTime(datestart.ExecuteScalar());
                frm.dateEnd.Value = Convert.ToDateTime(dateend.ExecuteScalar());
                frm.TbChas.Text = Convert.ToString(kolchas.ExecuteScalar());
                frm.TbSmeta.Text = Convert.ToString(smeta.ExecuteScalar());
                frm.CbTypeObuch.Text = Convert.ToString(typeobuch.ExecuteScalar());
                frm.CbTypePractik.Text = Convert.ToString(typepractik.ExecuteScalar());

                frm.BtnAdd.Enabled = false;
                frm.BtnEdit.Enabled = true;


                frm.Show();
                this.Hide();
                connecting.Close();

            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();


                SqlCommand cmd = connecting.CreateCommand();
                //Удаление студента

                //Удаление данных о студенте
                cmd.CommandText = "DELETE*FROM [NewCourse] WHERE ID ='" + p + "'";
                cmd.ExecuteScalar();

                connecting.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
