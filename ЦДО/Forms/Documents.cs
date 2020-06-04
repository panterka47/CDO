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
        int[] nomera;
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
            List<int> id_select = new List<int>();

           
            SqlConnection connecting = new SqlConnection(Program.connection);
            connecting.Open();
            string contact = "SELECT ID  FROM [Documents] WHERE TypeDoc='" + CbTypeDoc.Text + "' AND DateIssued>='"+dateTimeOt.Value+"' AND DateIssued<='"+dateTimeDo.Value+"'";

           
            SqlCommand cmd = new SqlCommand(contact, connecting);
                      

            SqlDataReader dataReader = cmd.ExecuteReader();
            
            try
            {
                if (dataReader.HasRows) // если есть данные
                {
                    while (dataReader.Read())
                    {

                        id_select.Add(Convert.ToInt32(dataReader["ID"]));                      
                       
                    }
                }

                 

                nomera = new int[id_select.Count];
                int k = 0;
                foreach (int i in id_select)
                {
                    nomera[k] = i;
                    

                    k++;
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connecting.Close();


            










     
           try
           {
               
                //Объявляем приложение
                Microsoft.Office.Interop.Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                   //Отобразить Excel

                   //Количество листов в рабочей книге
                   ex.SheetsInNewWorkbook = 1;
                   //Добавить рабочую книгу
                   Microsoft.Office.Interop.Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
                   //Получаем первый лист документа (счет начинается с 1)
                   Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)ex.Worksheets.get_Item(1);

                   string rootFolder = @"D:\"; //Путь       
                   string fileName = $"ExportUsers{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";// название файла чтобы не повторялось

                   FileInfo file = new FileInfo(rootFolder + fileName);//создаем файл
                                                                       // Microsoft.Office.Interop.Excel.Application package  = new Microsoft.Office.Interop.Excel.Application();
                                                                       //  package.Visible = true;

                //      string rootFolder = @"D:\"; //Путь        

                //            string fileName = "shab";
                //
                //            FileInfo file = new FileInfo(rootFolder + fileName);


              
                var excelcells = worksheet.get_Range("A1", "Q1");
                excelcells.Merge(Type.Missing);
                excelcells.Value = "Выписка о выданных документах типа'" + CbTypeDoc.Text + "'";
                excelcells.get_Range("A1", "Q1").HorizontalAlignment= Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;


                var excelcells1 = worksheet.get_Range("A2", "Q2");
                excelcells1.Merge(Type.Missing);
                excelcells1.Value= "Период: от '" + dateTimeOt.Value.ToShortDateString() + "' до '" + dateTimeDo.Value.ToShortDateString() + "'";
                excelcells1.get_Range("A2", "Q2").HorizontalAlignment=Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;



                //  ExcelWorksheet worksheet = package.Worksheets.Add("Дипломы"); //Необязательно
                worksheet.Cells[3, 1].Value = "Вид документа";
                    worksheet.Cells[3, 2].Value = "Статус документа";
                    worksheet.Cells[3, 3].Value = "Подтверждение утраты";
                    worksheet.Cells[3, 4].Value = "Подтверждение обмена";
                    worksheet.Cells[3, 5].Value = "Подтверждение уничтожения";
                    worksheet.Cells[3, 6].Value = "Серия документа";
                    worksheet.Cells[3, 7].Value = "Номер документа";
                    worksheet.Cells[3, 8].Value = "Дата выдачи документа";
                    worksheet.Cells[3, 9].Value = "Регистрационный номер";
                    worksheet.Cells[3, 10].Value = "Дополнительная профессиональная программа";
                    worksheet.Cells[3, 11].Value = "Наименование дополнительной профессиональной программы";
                    worksheet.Cells[3, 12].Value = "Дата начала обучения";
                    worksheet.Cells[3, 13].Value = "Дата окончания обучения";
                    worksheet.Cells[3, 14].Value = "Фамилия слушателя";
                    worksheet.Cells[3, 15].Value = "Имя слушателя";
                    worksheet.Cells[3, 16].Value = "Отчество слушателя";
                    worksheet.Cells[3, 17].Value = "Дата рождения";


                SqlConnection connect = new SqlConnection(Program.connection);
                connect.Open();

                //выбираем статус документа
            //    SqlCommand statusdoc = new SqlCommand("SELECT StatusDoc FROM [Documents] WHERE ID =" + nomera[1], connect);
            //    statusdoc.ExecuteScalar();
           //     MessageBox.Show(Convert.ToString(statusdoc.ExecuteScalar()));

                for (int u = 0; u < nomera.Length; u++)
                    {

                        //выбираем статус документа
                        SqlCommand statusdoc = new SqlCommand("SELECT StatusDoc FROM [Documents] WHERE ID =" + nomera[u], connect);
                       statusdoc.ExecuteScalar();
                      


                        //выбираем утрату документа
                        SqlCommand utrata = new SqlCommand("SELECT Utrata FROM [Documents] WHERE ID =" + nomera[u], connect);
                        utrata.ExecuteScalar();

                        //выбираем обмен документа
                        SqlCommand obmen = new SqlCommand("SELECT Obmen FROM [Documents] WHERE ID =" + nomera[u], connect);
                        obmen.ExecuteScalar();

                        //выбираем уничтожение документа
                        SqlCommand unichtog = new SqlCommand("SELECT Unichtog FROM [Documents] WHERE ID =" + nomera[u], connect);
                        unichtog.ExecuteScalar();

                        //выбираем серию документа
                        SqlCommand seriesdoc = new SqlCommand("SELECT SeriesDoc FROM [Documents] WHERE ID =" + nomera[u], connect);
                        seriesdoc.ExecuteScalar();

                        //выбираем номер документа
                        SqlCommand numberdoc = new SqlCommand("SELECT NumberDoc FROM [Documents] WHERE ID =" + nomera[u], connect);
                        numberdoc.ExecuteScalar();

                        //выбираем регистрационный номер документа
                        SqlCommand regnumber = new SqlCommand("SELECT RegNumber FROM [Documents] WHERE ID =" + nomera[u], connect);
                        regnumber.ExecuteScalar();

                        //выбираем дату выдачи документа
                        SqlCommand dateissued = new SqlCommand("SELECT DateIssued FROM [Documents] WHERE ID =" + nomera[u], connect);
                        dateissued.ExecuteScalar();

                        //Выбираем группу к которой привязан курс
                        SqlCommand gr = new SqlCommand("SELECT [Group] FROM [Documents] WHERE ID=" + nomera[u], connect);
                        gr.ExecuteScalar();

                        //выбираем ID курса по названию группы
                        SqlCommand course = new SqlCommand("SELECT IDCourse FROM [Group] WHERE NameGroup ='" + gr.ExecuteScalar()+"'", connect);
                        course.ExecuteScalar();

                        //выбираем тип программы( повышение квалификации..)
                        SqlCommand nametype = new SqlCommand("SELECT NameType FROM [TypeProg] WHERE ID=(SELECT Type FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "')", connect);
                        nametype.ExecuteScalar();

                        //выбираем количество часов в курсе
                        SqlCommand kolchas = new SqlCommand("SELECT KolChas FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "'", connect);
                        kolchas.ExecuteScalar();

                        //выбираем наименование программы (медицинская оптика...)
                        SqlCommand nameprog = new SqlCommand("SELECT NameProg FROM [Program] WHERE ID=(SELECT Program FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "')", connect);
                        nameprog.ExecuteScalar();

                    //выбираем ID курса
                    SqlCommand idcourse = new SqlCommand("SELECT Course FROM [NewCourse] WHERE ID='" + course.ExecuteScalar() + "'", connect);
                    idcourse.ExecuteScalar();

                    //выбираем наименование курса
                    SqlCommand namecourse = new SqlCommand("SELECT NameCourse FROM [Course] WHERE IDCourse='" + idcourse.ExecuteScalar() + "'", connect);
                        namecourse.ExecuteScalar();

                        //выбираем дату начала курса
                        SqlCommand datestart = new SqlCommand("SELECT DateStart FROM [NewCourse] WHERE ID=" + course.ExecuteScalar(), connect);
                        datestart.ExecuteScalar();

                        //выбираем дату окончания курса
                        SqlCommand dateend = new SqlCommand("SELECT DateEnd FROM [NewCourse] WHERE ID=" + course.ExecuteScalar(), connect);
                        dateend.ExecuteScalar();

                        //выбираем id студента
                        SqlCommand student = new SqlCommand("SELECT IdStudent FROM [Documents] WHERE ID=" + nomera[u], connect);
                        student.ExecuteScalar();

                        //выбираем фамилию студента
                        SqlCommand surname = new SqlCommand("SELECT Surname FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connect);
                        surname.ExecuteScalar();

                        //выбираем имя студента
                        SqlCommand name = new SqlCommand("SELECT Name FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connect);
                        name.ExecuteScalar();

                        //выбираем отчество студента
                        SqlCommand patronimyc = new SqlCommand("SELECT Patronymic FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connect);
                        patronimyc.ExecuteScalar();

                        //выбираем дату рождения студента
                        SqlCommand dateofbirth = new SqlCommand("SELECT DateOfBirth FROM [Student] WHERE IDStudent=" + student.ExecuteScalar(), connect);
                        dateofbirth.ExecuteScalar();


                        worksheet.Cells[u + 4, 1].Value = CbTypeDoc.Text;
                        worksheet.Cells[u + 4, 2].Value = statusdoc.ExecuteScalar();
                        worksheet.Cells[u + 4, 3].Value = utrata.ExecuteScalar();
                        worksheet.Cells[u + 4, 4].Value = obmen.ExecuteScalar();
                        worksheet.Cells[u + 4, 5].Value = unichtog.ExecuteScalar();
                        worksheet.Cells[u + 4, 6].Value = seriesdoc.ExecuteScalar();
                        worksheet.Cells[u + 4, 7].Value = numberdoc.ExecuteScalar();
                        worksheet.Cells[u + 4, 8].Value = dateissued.ExecuteScalar();
                        worksheet.Cells[u + 4, 9].Value = regnumber.ExecuteScalar();
                        worksheet.Cells[u + 4, 10].Value = nametype.ExecuteScalar();
                        worksheet.Cells[u + 4, 11].Value = nameprog.ExecuteScalar();
                        worksheet.Cells[u + 4, 12].Value = datestart.ExecuteScalar();
                        worksheet.Cells[u + 4, 13].Value = dateend.ExecuteScalar();
                        worksheet.Cells[u + 4, 14].Value = surname.ExecuteScalar();
                        worksheet.Cells[u + 4, 15].Value = name.ExecuteScalar();
                        worksheet.Cells[u + 4, 16].Value = patronimyc.ExecuteScalar();
                        worksheet.Cells[u + 4, 17].Value = dateofbirth.ExecuteScalar();

                   

                }


             var   oRng = worksheet.get_Range("A1", "Q1");
                oRng.EntireColumn.AutoFit();



                // закрываем соединение с БД




                ex.Visible = true;
                // worksheet.SaveAs("otchet");
                connect.Close();
                MessageBox.Show("Файл сформирован");
            }




            catch (Exception ex)
            {
                MessageBox.Show("ошибка" + ex);


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
