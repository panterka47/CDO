using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦДО
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start frm = new Start();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            Cources ifrm = new Cources();
            ifrm.Show();
            this.Hide();

        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            Students ifrm = new Students();
            ifrm.Show();
            this.Hide();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Forms.Education frm = new Forms.Education();
            frm.Show();

           /* //открытие формы
            Формы.Reports frm = new Формы.Reports();
            frm.Show();
            this.Hide();
            */
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Forms.Documents frm = new Forms.Documents();
            frm.Show();
            this.Hide();

        }
    }
}
