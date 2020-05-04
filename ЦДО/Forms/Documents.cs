using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦДО.Forms
{
    public partial class Documents : Form
    {
        public string k, p = "";
        string[] nomera;
        private Microsoft.Office.Interop.Excel.Application excelapp;
        public Documents()
        {
            InitializeComponent();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.TypeProg". При необходимости она может быть перемещена или удалена.
            this.typeProgTableAdapter.Fill(this.cDODataSet1.TypeProg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter1.Fill(this.cDODataSet1.Documents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet.Documents". При необходимости она может быть перемещена или удалена.
            //this.documentsTableAdapter.Fill(this.cDODataSet.Documents);

        }

        private void dataGridDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = Convert.ToString(this.dataGridDocuments.CurrentRow.Cells[0].Value);
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

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            AddEditDocument frm = new AddEditDocument(k);
            frm.BtnEditDoc.Enabled = false;
            frm.Show();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                /*
                connecting.Open();

                MessageBox.Show("1");


                SqlCommand id = connecting.CreateCommand();
                // id.CommandText = "SELECT ID  FROM [Documents] WHERE TypeDoc=Диплом";

/*
                // объект для выполнения SQL-запроса
                SqlCommand command = new SqlCommand("SELECT ID  FROM [Documents] WHERE TypeDoc= 'Диплом'", connecting);
                // объект для чтения ответа сервера
                SqlDataReader reader = command.ExecuteReader();
                // читаем результат
                int i = 1;

                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    nomera[i] = reader[0].ToString();
                    i++;

                }
                reader.Close(); // закрываем reader
                */
                try
                {
                
                    string rootFolder = @"D:\"; //Путь        
                    
                    string fileName = "отчет";

                    FileInfo file = new FileInfo(rootFolder + fileName);
                   
                    using (ExcelPackage package = new ExcelPackage(file))
                    {

                        package.Workbook.Properties.Author = "Meneger"; //Автор
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Дипломы"); //Необязательно
                        worksheet.Cells[1, 1].Value = "Вид документа";
                        


                        worksheet.Cells[1, 2].Value = "Статус документа";
                        worksheet.Cells[1, 3].Value = "Подтверждение утраты";
                        worksheet.Cells[1, 4].Value = "Подтверждение обмена";
                        worksheet.Cells[1, 5].Value = "Подтверждение уничтожения";
                        worksheet.Cells[1, 6].Value = "Серия документа";
                        worksheet.Cells[1, 7].Value = "Номер документа";
                        worksheet.Cells[1, 8].Value = "Дата выдачи документа";
                        worksheet.Cells[1, 9].Value = "Регистрационный номер";
                        worksheet.Cells[1, 10].Value = "Дополнительная профессиональная программа";
                        worksheet.Cells[1, 11].Value = "Наименование дополнительной профессиональной программы";
                        worksheet.Cells[1, 12].Value = "Дата начала обучения";
                        worksheet.Cells[1, 13].Value = "Дата окончания обучения";
                        worksheet.Cells[1, 14].Value = "Фамилия слушателя";
                        worksheet.Cells[1, 15].Value = "Имя слушателя";
                        worksheet.Cells[1, 16].Value = "Отчество слушателя";
                        worksheet.Cells[1, 17].Value = "Дата рождения";


                        /*



                                                for (int u = 1; u < nomera.Length; u++)
                                                {
                                                    //выбираем статус документа
                                                    SqlCommand statusdoc = new SqlCommand("SELECT StatusDoc FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    statusdoc.ExecuteScalar();

                                                    //выбираем утрату документа
                                                    SqlCommand utrata = new SqlCommand("SELECT Utrata FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    utrata.ExecuteScalar();

                                                    //выбираем обмен документа
                                                    SqlCommand obmen = new SqlCommand("SELECT Obmen FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    obmen.ExecuteScalar();

                                                    //выбираем уничтожение документа
                                                    SqlCommand unichtog = new SqlCommand("SELECT Unichtog FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    unichtog.ExecuteScalar();

                                                    //выбираем серию документа
                                                    SqlCommand seriesdoc = new SqlCommand("SELECT SeriesDoc FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    seriesdoc.ExecuteScalar();

                                                    //выбираем номер документа
                                                    SqlCommand numberdoc = new SqlCommand("SELECT NumberDoc FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    numberdoc.ExecuteScalar();

                                                    //выбираем регистрационный номер документа
                                                    SqlCommand regnumber = new SqlCommand("SELECT RegNumber FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    regnumber.ExecuteScalar();

                                                    //выбираем дату выдачи документа
                                                    SqlCommand dateissued = new SqlCommand("SELECT DateIssued FROM [Documents] WHERE ID =" + nomera[u], connecting);
                                                    dateissued.ExecuteScalar();

                                                    //Выбираем группу к которой привязан курс
                                                    SqlCommand gr = new SqlCommand("SELECT Group FROM [Documents] WHERE ID=" + nomera[u], connecting);
                                                    gr.ExecuteScalar();

                                                    //выбираем ID курса по названию группы
                                                    SqlCommand course = new SqlCommand("SELECT IDCourse FROM [Group] WHERE NameGroup =" + gr.ExecuteScalar(), connecting);
                                                    course.ExecuteScalar();

                                                    //выбираем тип программы( повышение квалификации..)
                                                    SqlCommand nametype = new SqlCommand("SELECT NameType FROM [TypeProg] WHERE ID=(SELECT Type FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "')", connecting);
                                                    nametype.ExecuteScalar();

                                                    //выбираем количество часов в курсе
                                                    SqlCommand kolchas = new SqlCommand("SELECT KolChas FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "')", connecting);
                                                    kolchas.ExecuteScalar();

                                                    //выбираем наименование программы (медицинская оптика...)
                                                    SqlCommand nameprog = new SqlCommand("SELECT NameProg FROM [Program] WHERE ID=(SELECT Program FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "')", connecting);
                                                    nameprog.ExecuteScalar();

                                                    //выбираем наименование курса
                                                    SqlCommand namecourse = new SqlCommand("SELECT NameCourse FROM [Course] WHERE ID=(SELECT Course FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "')", connecting);
                                                    namecourse.ExecuteScalar();

                                                    //выбираем дату начала курса
                                                    SqlCommand datestart = new SqlCommand("SELECT DateStart FROM [NewCourse] WHERE ID=" + course.ExecuteScalar(), connecting);
                                                    datestart.ExecuteScalar();

                                                    //выбираем дату окончания курса
                                                    SqlCommand dateend = new SqlCommand("SELECT DateEnd FROM [NewCourse] WHERE ID=" + course.ExecuteScalar(), connecting);
                                                    dateend.ExecuteScalar();

                                                    //выбираем id студента
                                                    SqlCommand student = new SqlCommand("SELECT IdStudent FROM [NewCourse] WHERE ID=" + course.ExecuteScalar(), connecting);
                                                    student.ExecuteScalar();

                                                    //выбираем фамилию студента
                                                    SqlCommand surname = new SqlCommand("SELECT Surname FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connecting);
                                                    surname.ExecuteScalar();

                                                    //выбираем имя студента
                                                    SqlCommand name = new SqlCommand("SELECT Name FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connecting);
                                                    name.ExecuteScalar();

                                                    //выбираем отчество студента
                                                    SqlCommand patronimyc = new SqlCommand("SELECT Patronimyc FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connecting);
                                                    patronimyc.ExecuteScalar();

                                                    //выбираем дату рождения студента
                                                    SqlCommand dateofbirth = new SqlCommand("SELECT DateOfBirth FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connecting);
                                                    dateofbirth.ExecuteScalar();


                                                } */
                        // закрываем соединение с БД

                        connecting.Close();

                       
                        package.Save("отчет");
                    }
                    MessageBox.Show("Файл сформирован");

                    

                }
                catch
                {

                }

                

            }
        }
        private void BtnEditDoc_Click(object sender, EventArgs e)
        {
            //Редактирование данных о документе

            AddEditDocument frm = new AddEditDocument(p);

            //Передача данных о документе на форму редактирования

            using (SqlConnection connecting = new SqlConnection(Program.connection))
            {
                connecting.Open();
                
                // Данные из таблицы Документы


                SqlCommand typedoc = connecting.CreateCommand();
                typedoc.CommandText = "SELECT TypeDoc FROM [Documents] WHERE ID= " + p;
                typedoc.ExecuteScalar();

                SqlCommand group = connecting.CreateCommand();
                group.CommandText = "SELECT Group FROM [Documents] WHERE ID= " + p;
                group.ExecuteScalar();

                SqlCommand idstudent = connecting.CreateCommand();
                idstudent.CommandText = "SELECT IdStudent FROM [Documents] WHERE ID= " + p;
                idstudent.ExecuteScalar();

                SqlCommand statusdoc = connecting.CreateCommand();
                statusdoc.CommandText = "SELECT StatusDoc  FROM [Documents] WHERE ID= " + p;
                statusdoc.ExecuteScalar();

                SqlCommand utrata = connecting.CreateCommand();
                utrata.CommandText = "SELECT Utrata  FROM [Documents] WHERE ID= " + p;
                utrata.ExecuteScalar();

                SqlCommand obmen = connecting.CreateCommand();
                obmen.CommandText = "SELECT Obmen FROM [Documents] WHERE ID= " + p;
                obmen.ExecuteScalar();

                SqlCommand unichtog = connecting.CreateCommand();
                unichtog.CommandText = "SELECT Unichtog FROM [Documents] WHERE ID= " + p;
                unichtog.ExecuteScalar();

                SqlCommand seriesdoc = connecting.CreateCommand();
                seriesdoc.CommandText = "SELECT SeriesDoc FROM [Documents] WHERE ID= " + p;
                seriesdoc.ExecuteScalar();

                SqlCommand numberdoc = connecting.CreateCommand();
                numberdoc.CommandText = "SELECT NumberDoc  FROM [Documents] WHERE ID= " + p;
                numberdoc.ExecuteScalar();

                SqlCommand regnumber = connecting.CreateCommand();
                regnumber.CommandText = "SELECT RegNumber  FROM [Documents] WHERE ID= " + p;
                regnumber.ExecuteScalar();

                //Заполнение полей на форме редактирования данных о студенте
                frm.CbTypeDoc.Text = Convert.ToString(typedoc.ExecuteScalar());
                frm.CbUtrata.Text = Convert.ToString(utrata.ExecuteScalar());
                frm.CbUnichtog.Text = Convert.ToString(unichtog.ExecuteScalar());
                frm.TbRegNumber.Text = Convert.ToString(regnumber.ExecuteScalar());
                frm.CbGroup.Text = Convert.ToString(group.ExecuteScalar());
                frm.TbStudent.Text = Convert.ToString(idstudent.ExecuteScalar());
                frm.CbStatusDoc.Text = Convert.ToString(statusdoc.ExecuteScalar());
                frm.CbObmen.Text = Convert.ToString(obmen.ExecuteScalar());
                frm.TbSeriesDoc.Text = Convert.ToString(seriesdoc.ExecuteScalar());
                frm.TbNumberDoc.Text = Convert.ToString(numberdoc.ExecuteScalar());

                
                frm.BtnEditDoc.Enabled = true;
                frm.BtnAddDoc.Enabled = false;

                frm.Show();
                this.Hide();
                connecting.Close();


            }

        }

        
    }
}
