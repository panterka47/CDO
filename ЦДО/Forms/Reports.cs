using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ЦДО.Forms;

namespace ЦДО.Формы
{
    public partial class Reports : Form
    {
        GenerateDox generateDox = new GenerateDox();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.NewCourse". При необходимости она может быть перемещена или удалена.
            this.newCourseTableAdapter.Fill(this.cDODataSet.NewCourse);

        }

        private void BtnAdd_Click(object sender, EventArgs e)  
        {

        }
        private void GenerateDocOne() 
        {
            string fileName = $"ExportUsers{DateTime.Now:yyyyMMddHHmmss}.xlsx"; //Название документа
            string[] mass = new string[3]; // Этому массиву нужно присвоить значения из датагрид 

            generateDox.GenerateDoxOnes(fileName,mass);
        }

    }
}
