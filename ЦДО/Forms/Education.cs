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

namespace ЦДО.Forms
{
    
    public partial class Education : Form
    {
        string k, p = "";
        string course, prog, typeprog, typepractik = "";

        public Education()
        {
            InitializeComponent();
        }

        private void Education_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.TypePractik". При необходимости она может быть перемещена или удалена.
            this.typePractikTableAdapter.Fill(this.cDODataSet.TypePractik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.TypeProg". При необходимости она может быть перемещена или удалена.
            this.typeProgTableAdapter.Fill(this.cDODataSet.TypeProg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Program". При необходимости она может быть перемещена или удалена.
            this.programTableAdapter.Fill(this.cDODataSet.Program);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.cDODataSet.Course);

        }

        private void dataGridCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            course = Convert.ToString(this.dataGridCourse.CurrentRow.Cells[0].Value);
        }

        private void dataGridProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prog = Convert.ToString(this.dataGridProgram.CurrentRow.Cells[0].Value);
        }

        private void dataGridTypeProg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            typeprog = Convert.ToString(this.dataGridTypeProg.CurrentRow.Cells[0].Value);
        }

        private void dataGridTypePractik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            typepractik = Convert.ToString(this.dataGridTypePractik.CurrentRow.Cells[0].Value);
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            

            AddEditEducation ifrm = new AddEditEducation(k);
            ifrm.BtnCourseNew.Enabled = true;
            ifrm.BtnCourseEdit.Enabled = false;
            ifrm.BtnProgNew.Enabled = false;
            ifrm.BtnProgEdit.Enabled = false;
            ifrm.BtnTypeNew.Enabled = false;
            ifrm.BtnTypeEdit.Enabled = false;
            ifrm.BtnTypePractikNew.Enabled = false;
            ifrm.BtnTypePractikEdit.Enabled = false;



        }

        private void BtnEditProgam_Click(object sender, EventArgs e)
        {
            //Редактирование данных о программе

            AddEditEducation frm = new AddEditEducation(prog);
            p = prog;

            //Передача данных о программе на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();


                // Данные из таблицы Программы

                SqlCommand nameprog = connecting.CreateCommand();
                nameprog.CommandText = "SELECT NameProg FROM [Program] WHERE ID= " + p;
                nameprog.ExecuteScalar();

                //Заполнение полей на форме редактирования данных о программе
                frm.TbProg.Text = Convert.ToString(nameprog.ExecuteScalar());


                //Блокировка кнопок
                frm.BtnCourseNew.Enabled = false;
                frm.BtnCourseEdit.Enabled = false;
                frm.BtnProgNew.Enabled = false;
                frm.BtnProgEdit.Enabled = true;
                frm.BtnTypeNew.Enabled = false;
                frm.BtnTypeEdit.Enabled = false;
                frm.BtnTypePractikNew.Enabled = false;
                frm.BtnTypePractikEdit.Enabled = false;
                frm.Show();
                this.Hide();
                connecting.Close();


            }
        }

        private void BtnEditTypeProg_Click(object sender, EventArgs e)
        {
            //Редактирование данных о типе программы

            AddEditEducation frm = new AddEditEducation(typeprog);
            p = typeprog;

            //Передача данных о типе программы на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();


                // Данные из таблицы Тип программы

                SqlCommand nametype = connecting.CreateCommand();
                nametype.CommandText = "SELECT NameType FROM [TypeProg] WHERE ID= " + p;
                nametype.ExecuteScalar();

                SqlCommand kolchas = connecting.CreateCommand();
                kolchas.CommandText = "SELECT KolChas FROM [TypeProg] WHERE ID= " + p;
                kolchas.ExecuteScalar();

                SqlCommand typedoc = connecting.CreateCommand();
                typedoc.CommandText = "SELECT TypeDoc FROM [TypeProg] WHERE ID= " + p;
                typedoc.ExecuteScalar();

                //Заполнение полей на форме редактирования данных о типе программы
                frm.TbType.Text = Convert.ToString(nametype.ExecuteScalar());
                frm.TbKolChas.Text = Convert.ToString(kolchas.ExecuteScalar());
                frm.CbDocEducat.Text = Convert.ToString(typedoc.ExecuteScalar());


                //Блокировка кнопок
                frm.BtnCourseNew.Enabled = false;
                frm.BtnCourseEdit.Enabled = false;
                frm.BtnProgNew.Enabled = false;
                frm.BtnProgEdit.Enabled = false;
                frm.BtnTypeNew.Enabled = false;
                frm.BtnTypeEdit.Enabled = true;
                frm.BtnTypePractikNew.Enabled = false;
                frm.BtnTypePractikEdit.Enabled = false;
                frm.Show();
                this.Hide();
                connecting.Close();


            }
        }

        private void BtnEditTypePractik_Click(object sender, EventArgs e)
        {
            //Редактирование данных о типе практики

            AddEditEducation frm = new AddEditEducation(typepractik);
            p = typepractik;

            //Передача данных о типе практики на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();


                // Данные из таблицы Тип практики

                SqlCommand namepractik = connecting.CreateCommand();
                namepractik.CommandText = "SELECT NameType FROM [TypePractik] WHERE ID= " + p;
                namepractik.ExecuteScalar();

                

                //Заполнение полей на форме редактирования данных о типе программы
                frm.TbTypePractik.Text = Convert.ToString(namepractik.ExecuteScalar());
               


                //Блокировка кнопок
                frm.BtnCourseNew.Enabled = false;
                frm.BtnCourseEdit.Enabled = false;
                frm.BtnProgNew.Enabled = false;
                frm.BtnProgEdit.Enabled = false;
                frm.BtnTypeNew.Enabled = false;
                frm.BtnTypeEdit.Enabled = false;
                frm.BtnTypePractikNew.Enabled = false;
                frm.BtnTypePractikEdit.Enabled = true;
                frm.Show();
                this.Hide();
                connecting.Close();


            }
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

        private void BtnAddProgram_Click(object sender, EventArgs e)
        {
            AddEditEducation ifrm = new AddEditEducation(k);
            ifrm.BtnCourseNew.Enabled = false;
            ifrm.BtnCourseEdit.Enabled = false;
            ifrm.BtnProgNew.Enabled = true;
            ifrm.BtnProgEdit.Enabled = false;
            ifrm.BtnTypeNew.Enabled = false;
            ifrm.BtnTypeEdit.Enabled = false;
            ifrm.BtnTypePractikNew.Enabled = false;
            ifrm.BtnTypePractikEdit.Enabled = false;
        }

        private void BtnAddTypeProg_Click(object sender, EventArgs e)
        {
            AddEditEducation ifrm = new AddEditEducation(k);
            ifrm.BtnCourseNew.Enabled = false;
            ifrm.BtnCourseEdit.Enabled = false;
            ifrm.BtnProgNew.Enabled = false;
            ifrm.BtnProgEdit.Enabled = false;
            ifrm.BtnTypeNew.Enabled = true;
            ifrm.BtnTypeEdit.Enabled = false;
            ifrm.BtnTypePractikNew.Enabled = false;
            ifrm.BtnTypePractikEdit.Enabled = false;
        }

      
        private void BtnAddTypePractik_Click(object sender, EventArgs e)
        {
            AddEditEducation ifrm = new AddEditEducation(k);
            ifrm.BtnCourseNew.Enabled = false;
            ifrm.BtnCourseEdit.Enabled = false;
            ifrm.BtnProgNew.Enabled = false;
            ifrm.BtnProgEdit.Enabled = false;
            ifrm.BtnTypeNew.Enabled = false;
            ifrm.BtnTypeEdit.Enabled = false;
            ifrm.BtnTypePractikNew.Enabled = true;
            ifrm.BtnTypePractikEdit.Enabled = false;
        }

        private void BtnEditCourse_Click(object sender, EventArgs e)
        {
            //Редактирование данных о курсах

            AddEditEducation frm = new AddEditEducation(course);
            p = course;

            //Передача данных о курсе на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
              

                // Данные из таблицы Курсы

                SqlCommand namecourse = connecting.CreateCommand();
                namecourse.CommandText = "SELECT NameCourse FROM [Course] WHERE IDCourse= " + p;
                namecourse.ExecuteScalar();
                
                //Заполнение полей на форме редактирования данных о курсе
                frm.TbCourse.Text = Convert.ToString(namecourse.ExecuteScalar());


                //Блокировка кнопок
                frm.BtnCourseNew.Enabled = false;
                frm.BtnCourseEdit.Enabled = true;
                frm.BtnProgNew.Enabled = false;
                frm.BtnProgEdit.Enabled = false;
                frm.BtnTypeNew.Enabled = false;
                frm.BtnTypeEdit.Enabled = false;
                frm.BtnTypePractikNew.Enabled = false;
                frm.BtnTypePractikEdit.Enabled = false;
                frm.Show();
                this.Hide();
                connecting.Close();


            }
        }

       
    }
}
