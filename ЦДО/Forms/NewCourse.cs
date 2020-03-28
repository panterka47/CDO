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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet2.TypePractik". При необходимости она может быть перемещена или удалена.
            this.typePractikTableAdapter2.Fill(this.cDODataSet2.TypePractik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet2.TypeObuch". При необходимости она может быть перемещена или удалена.
            this.typeObuchTableAdapter2.Fill(this.cDODataSet2.TypeObuch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet2.TypeProg". При необходимости она может быть перемещена или удалена.
            this.typeProgTableAdapter1.Fill(this.cDODataSet2.TypeProg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet2.Program". При необходимости она может быть перемещена или удалена.
            this.programTableAdapter1.Fill(this.cDODataSet2.Program);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet2.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter1.Fill(this.cDODataSet2.Course);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.TypePractik". При необходимости она может быть перемещена или удалена.
          //  this.typePractikTableAdapter1.Fill(this.cDODataSet1.TypePractik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.TypeObuch". При необходимости она может быть перемещена или удалена.
       //     this.typeObuchTableAdapter1.Fill(this.cDODataSet1.TypeObuch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.TypeObuch". При необходимости она может быть перемещена или удалена.
        //    this.typeObuchTableAdapter.Fill(this.cDODataSet.TypeObuch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.TypePractik". При необходимости она может быть перемещена или удалена.
       //     this.typePractikTableAdapter.Fill(this.cDODataSet.TypePractik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.TypeProg". При необходимости она может быть перемещена или удалена.
        //    this.typeProgTableAdapter.Fill(this.cDODataSet.TypeProg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.TypeEducation". При необходимости она может быть перемещена или удалена.
         //   this.typeEducationTableAdapter.Fill(this.cDODataSet.TypeEducation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Program". При необходимости она может быть перемещена или удалена.
      //      this.programTableAdapter.Fill(this.cDODataSet.Program);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Course". При необходимости она может быть перемещена или удалена.
       //     this.courseTableAdapter.Fill(this.cDODataSet.Course);

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
    }
}

