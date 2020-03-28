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
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void BtnTypeNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
                SqlCommand cmd2 = connecting.CreateCommand();

                //Добавление преподавателя
                cmd2.CommandText = "INSERT INTO [Teachers] (FIO, Discipline) VALUES ('" + TbFIO.Text + "','" +TbDiscipline.Text+"')";
                cmd2.ExecuteScalar();
                MessageBox.Show("Преподаватель добавлен");
            }
        }
    }
}
