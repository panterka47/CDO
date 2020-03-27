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
    public partial class Students : Form
    {
        public string p = "";

        public Students()
        {
            InitializeComponent();
        }

        private void GridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = Convert.ToString(this.GridStudent.CurrentRow.Cells[0].Value);
          //  MessageBox.Show(p);
        }


        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.cDODataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.Student". При необходимости она может быть перемещена или удалена.
         //   this.studentTableAdapter.Fill(this.cDODataSet1.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.cDODataSet.Student);

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Редактирование данных о студенте

            AddEditStudents frm = new AddEditStudents(p);

            //Передача данных о студенте на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
                MessageBox.Show(p);

                // Данные из таблицы Студент

                SqlCommand surname = connecting.CreateCommand();
                surname.CommandText = "SELECT Surname FROM [Student] WHERE IDStudent= " + p;
                surname.ExecuteScalar();

                SqlCommand name = connecting.CreateCommand();
                name.CommandText = "SELECT Name FROM [Student] WHERE IDStudent= " + p;
                name.ExecuteScalar();

                SqlCommand patronymic = connecting.CreateCommand();
                patronymic.CommandText = "SELECT Patronymic FROM [Student] WHERE IDStudent= " + p;
                patronymic.ExecuteScalar();

                SqlCommand dateofbirth = connecting.CreateCommand();
                dateofbirth.CommandText = "SELECT DateOfBirth FROM [Student] WHERE IDStudent= " + p;
                dateofbirth.ExecuteScalar();

                SqlCommand placeofbirth = connecting.CreateCommand();
                placeofbirth.CommandText = "SELECT PlaceOfBirth FROM [Student] WHERE IDStudent= " + p;
                placeofbirth.ExecuteScalar();

                SqlCommand nationality = connecting.CreateCommand();
                nationality.CommandText = "SELECT Nationality FROM [Student] WHERE IDStudent= " + p;
                nationality.ExecuteScalar();

                SqlCommand phone = connecting.CreateCommand();
                phone.CommandText = "SELECT Phone FROM [Student] WHERE IDStudent= " + p;
                phone.ExecuteScalar();

                SqlCommand email = connecting.CreateCommand();
                email.CommandText = "SELECT Email FROM [Student] WHERE IDStudent= " + p;
                email.ExecuteScalar();

                SqlCommand group = connecting.CreateCommand();
                group.CommandText = "SELECT Group FROM [Student] WHERE IDStudent= " + p;
                group.ExecuteScalar();

                SqlCommand dop = connecting.CreateCommand();
                dop.CommandText = "SELECT Dop FROM [Student] WHERE IDStudent= " + p;
                dop.ExecuteScalar();


                // Данные из таблицы Паспорт

                SqlCommand pasport = connecting.CreateCommand();
                pasport.CommandText = "SELECT Pasport FROM [Pasport] WHERE IDStudent= " + p;
                pasport.ExecuteScalar();

                SqlCommand series = connecting.CreateCommand();
                series.CommandText = "SELECT Series FROM [Pasport] WHERE IDStudent= " + p;
                series.ExecuteScalar();

                SqlCommand number = connecting.CreateCommand();
                number.CommandText = "SELECT Number FROM [Pasport] WHERE IDStudent= " + p;
                number.ExecuteScalar();

                SqlCommand issued = connecting.CreateCommand();
                issued.CommandText = "SELECT Issued FROM [Pasport] WHERE IDStudent= " + p;
                issued.ExecuteScalar();

                SqlCommand dateissued = connecting.CreateCommand();
                dateissued.CommandText = "SELECT DateIssued FROM [Pasport] WHERE IDStudent= " + p;
                dateissued.ExecuteScalar();

                SqlCommand lives = connecting.CreateCommand();
                lives.CommandText = "SELECT Lives FROM [Pasport] WHERE IDStudent= " + p;
                lives.ExecuteScalar();

                SqlCommand registered = connecting.CreateCommand();
                registered.CommandText = "SELECT  Registered FROM [Pasport] WHERE IDStudent= " + p;
                registered.ExecuteScalar();

                // Данные из таблицы Образование

                SqlCommand education = connecting.CreateCommand();
                education.CommandText = "SELECT Education FROM [Pasport] WHERE IDStudent= " + p;
                education.ExecuteScalar();

                SqlCommand dateeducation = connecting.CreateCommand();
                dateeducation.CommandText = "SELECT DateEducation FROM [Pasport] WHERE IDStudent= " + p;
                dateeducation.ExecuteScalar();

                SqlCommand doceducation = connecting.CreateCommand();
                doceducation.CommandText = "SELECT DocEducation FROM [Pasport] WHERE IDStudent= " + p;
                doceducation.ExecuteScalar();

                SqlCommand seriesdoc = connecting.CreateCommand();
                seriesdoc.CommandText = "SELECT SeriesDoc FROM [Pasport] WHERE IDStudent= " + p;
                seriesdoc.ExecuteScalar();

                SqlCommand numberdoc = connecting.CreateCommand();
                numberdoc.CommandText = "SELECT NumberDoc FROM [Pasport] WHERE IDStudent= " + p;
                numberdoc.ExecuteScalar();

                SqlCommand nameinstitute = connecting.CreateCommand();
                nameinstitute.CommandText = "SELECT NameInstitute FROM [Pasport] WHERE IDStudent= " + p;
                nameinstitute.ExecuteScalar();

                SqlCommand dateissueddoc = connecting.CreateCommand();
                dateissueddoc.CommandText = "SELECT DateIssuedDoc FROM [Pasport] WHERE IDStudent= " + p;
                dateissueddoc.ExecuteScalar();


                //Заполнение полей на форме редактирования данных о студенте
                frm.TbSurname.Text = Convert.ToString(surname.ExecuteScalar());
                frm.TbName.Text = Convert.ToString(name.ExecuteScalar());
                frm.TbPatronymic.Text = Convert.ToString(patronymic.ExecuteScalar());
                frm.DateOfBirth.Value = Convert.ToDateTime(dateofbirth.ExecuteScalar());
                frm.TbPlaceOfBirth.Text = Convert.ToString(placeofbirth.ExecuteScalar());
                frm.TbNationality.Text = Convert.ToString(nationality.ExecuteScalar());
                frm.TbPhone.Text = Convert.ToString(phone.ExecuteScalar());
                frm.TbEmail.Text = Convert.ToString(email.ExecuteScalar());
                frm.TbGroup.Text = Convert.ToString(group.ExecuteScalar());
                frm.TbDop.Text = Convert.ToString(dop.ExecuteScalar());


                frm.TbCertificate.Text = Convert.ToString(pasport.ExecuteScalar());
                frm.TbSeriesCertificate.Text = Convert.ToString(series.ExecuteScalar());
                frm.TbNumberCertificate.Text = Convert.ToString(number.ExecuteScalar());
                frm.TbIssued.Text = Convert.ToString(issued.ExecuteScalar());
                frm.PaspDateIssued.Value = Convert.ToDateTime(dateissued.ExecuteScalar());
                frm.TbAdressProg.Text = Convert.ToString(lives.ExecuteScalar());
                frm.TbAdressReg.Text = Convert.ToString(registered.ExecuteScalar());

                frm.CbTypeEducat.Text = Convert.ToString(education.ExecuteScalar());
                frm.DateEnd.Value = Convert.ToDateTime(dateeducation.ExecuteScalar());
                frm.CbDocEducat.Text = Convert.ToString(doceducation.ExecuteScalar());
                frm.TbSeriesDoc.Text = Convert.ToString(seriesdoc.ExecuteScalar());
                frm.TbNumberDoc.Text = Convert.ToString(numberdoc.ExecuteScalar());
                frm.TbNameInstitute.Text = Convert.ToString(nameinstitute.ExecuteScalar());
                frm.CalenDateIssued.Value = Convert.ToDateTime(dateissueddoc.ExecuteScalar());

                frm.BtnEdit.Enabled = true;
                frm.BtnAddStudent.Enabled = false;

                frm.Show();
                this.Hide();
                connecting.Close();


            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string p = "";
            AddEditStudents frm1 = new AddEditStudents(p);
            frm1.BtnEdit.Enabled = false;
            frm1.BtnAddStudent.Enabled = true;
            frm1.Show();
            this.Hide();

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();


                SqlCommand cmd = connecting.CreateCommand();
                //Удаление студента

                //Удаление данных о студенте
                cmd.CommandText = "DELETE*FROM [Student] WHERE IDStudent ='" + p + "'";
                cmd.ExecuteScalar();
                SqlCommand cmd1 = connecting.CreateCommand();
                cmd1.CommandText = "DELETE*FROM [Pasport] WHERE IDStudent ='" + p + "'";
                cmd1.ExecuteScalar();
                SqlCommand cmd2 = connecting.CreateCommand();
                cmd2.CommandText = "DELETE*FROM [Education] WHERE IDStudent ='" + p + "'";
                cmd2.ExecuteScalar();

                connecting.Close();

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();

        }
    }
}
