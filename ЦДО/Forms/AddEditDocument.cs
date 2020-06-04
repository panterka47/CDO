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
    public partial class AddEditDocument : Form
    {
        public string p, id;

        public AddEditDocument(string l)
        {
            InitializeComponent();
            id = l;

        }

        private void AddEditDocument_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.cDODataSet1.Student);
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            TbStudent.Text = p;

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
                SqlCommand cmd = connecting.CreateCommand();

                //Добавление документа
                cmd.CommandText = " SELECT NameGroup FROM [Student] WHERE IDStudent ='" + p + "'";
                cmd.ExecuteScalar();
                CbGroup.Text = Convert.ToString(cmd.ExecuteScalar());
            }

        }

        private void BtnCourseNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();
                    SqlCommand cmd = connecting.CreateCommand();

                    //Добавление документа
                    cmd.CommandText = "INSERT INTO [Documents] (TypeDoc, [Group], IdStudent, StatusDoc, Utrata, Obmen, Unichtog, SeriesDoc, NumberDoc, RegNumber, DateIssued) VALUES ('" + Convert.ToString(CbTypeDoc.Text) + "', '" + Convert.ToString(CbGroup.Text) + "','" + Convert.ToInt32(TbStudent.Text) + "','" + CbStatusDoc.Text + "', '" + CbUtrata.Text + "','" + CbObmen.Text + "', '" + CbUnichtog.Text + "', '" + TbSeriesDoc.Text + "', '" + Convert.ToInt32(TbNumberDoc.Text) + "', '" + Convert.ToInt32(TbRegNumber.Text) + "', '"+Convert.ToDateTime(dateTimedateissued.Value).ToShortDateString()+"')";
                    cmd.ExecuteScalar();

                    MessageBox.Show("Документ добавлен");

                    Documents ifrm = new Documents();
                    ifrm.Show();
                    this.Hide();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка: " + ex);
            }
        }

        private void BtnEditDoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();


                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о слушателе
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [Documents] SET TypeDoc = @typedoc, Group = @group, IdSutent=@idstudent, StatusDoc=@statusdoc, Utrata = @utrata, Obmen = @obmen, Unichtog = @unichtog, SeriesDoc= @seriesdoc, NumberDoc = @numberdoc, RegNumber = @regnumber  WHERE ID = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("typedoc", CbTypeDoc.Text);
                    WriteCommand.Parameters.AddWithValue("group", CbGroup.Text);
                    WriteCommand.Parameters.AddWithValue("idsutent", TbStudent.Text);
                    WriteCommand.Parameters.AddWithValue("statusdoc", CbStatusDoc.Text);
                    WriteCommand.Parameters.AddWithValue("utrata", CbUtrata.Text);
                    WriteCommand.Parameters.AddWithValue("obmen", CbObmen.Text);
                    WriteCommand.Parameters.AddWithValue("unichtog", CbUnichtog.Text);
                    WriteCommand.Parameters.AddWithValue("seriesdoc", TbSeriesDoc.Text);
                    WriteCommand.Parameters.AddWithValue("numberdoc", Convert.ToInt32(TbNumberDoc.Text));
                    WriteCommand.Parameters.AddWithValue("regnumber", Convert.ToInt32(TbRegNumber.Text));
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(id));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Данные о документе изменены");
                    connecting.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }

        }
    }
}
 
