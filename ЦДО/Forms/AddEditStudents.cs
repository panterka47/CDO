﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;



namespace ЦДО
{
    public partial class AddEditStudents : Form
    {
        public string Id;
        public AddEditStudents(string l)
        {
            InitializeComponent();
            Id = l;

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.Program". При необходимости она может быть перемещена или удалена.
            this.programTableAdapter1.Fill(this.cDODataSet1.Program);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.TypeObuch". При необходимости она может быть перемещена или удалена.
            this.typeObuchTableAdapter1.Fill(this.cDODataSet1.TypeObuch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.TypeProg". При необходимости она может быть перемещена или удалена.
            this.typeProgTableAdapter1.Fill(this.cDODataSet1.TypeProg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cDODataSet1.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.cDODataSet1.Group);

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbSurname.Text != "" && TbName.Text != "" && TbPatronymic.Text != "" && DateOfBirth.Text != ""
                   && TbPhone.Text != "" && TbEmail.Text != "" && TbCertificate.Text != ""
                   && TbSeriesCertificate.Text != "" && TbNumberCertificate.Text != ""
                   && TbIssued.Text != "" && CalenDateIssued.Text != "")
                {
                    var email = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
                    bool isValid = email.IsMatch(TbEmail.Text);

                    if (isValid == true)
                    {
                        using (SqlConnection connecting = new SqlConnection(Program.connection))
                        {
                            connecting.Open();

                             
                           SqlCommand cmd = connecting.CreateCommand();



                            //Добавление студента
                            
                                                        //Запись в таблицу Студент
                                                        cmd.CommandText = "INSERT INTO [Student] (Surname, Name, Patronymic, DateOfBirth, PlaceOfBirth, Nationality, Phone, Email, NameGroup, Dop) VALUES('"
                                                      + TbSurname.Text + "','" + TbName.Text + "','" + TbPatronymic.Text + "','" + Convert.ToDateTime(DateOfBirth.Text).ToShortDateString() + "','"+TbPlaceOfBirth.Text+"', '"
                                                      + TbNationality.Text + "','" + Convert.ToString(TbPhone.Text) + "', '" + TbEmail.Text + "','"+ TbGroup.Text + "', '"+TbDop.Text+"') ";

                                                  cmd.ExecuteScalar();



                                                        SqlCommand cmd1 = connecting.CreateCommand();


                                                        //Запись в таблицу Паспорт
                                                     cmd1.CommandText = "INSERT INTO [Pasport] (Pasport, Series, Number, Issued, DateIssued, Lives, Registered) VALUES ('"
                                                         + TbCertificate.Text + "', '" + Convert.ToInt32(TbSeriesCertificate.Text) + "', '" + Convert.ToInt32(TbNumberCertificate.Text)
                                                         + "','" + TbIssued.Text + "','" + Convert.ToDateTime(PaspDateIssued.Text).ToShortDateString() + "','" + TbAdressProg.Text + "','" + TbAdressReg.Text + "')";
                                                     cmd1.ExecuteScalar();








                                                       //Запись в таблицу Образование
                                                        SqlCommand cmd2 = connecting.CreateCommand();
                                                   cmd2.CommandText = "INSERT INTO [Education] (Education, DateEducation, DocEducation, SeriesDoc, NumberDoc," +
                                                       " NameInstitute, DateIssuedDoc) VALUES ( '" + CbTypeEducat.Text + "','" + Convert.ToDateTime(DateEnd.Text).ToShortDateString() + "','" + CbDocEducat.Text + "'," +
                                                       "'" + Convert.ToInt32(TbSeriesDoc.Text) + "','" + Convert.ToInt32(TbNumberDoc.Text) + "','" + TbNameInstitute.Text + "','" + Convert.ToDateTime(CalenDateIssued.Text).ToShortDateString() + "')";
                                                   cmd2.ExecuteScalar();
                                                   MessageBox.Show("Слушатель успешно добавлен");

                                                    
                            connecting.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("E-mail не соответсвует стандарту" +
                            "Образец E-mail: nastya-maa@ngs.ru");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( Convert.ToString(ex.Message));
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
           

        }



        private void BtnDog_Click(object sender, EventArgs e)
        {
            // Создаём объект документа
            Word.Document doc = null;
            try
            {
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа должен быть целиком на английском !!!
                string source = @"D:\shablon.docx";
                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();
                doc.Bookmarks["Name"].Range.Text = TbName.Text;
                ////////дописать свое
                // Закрываем документ
                doc.Close();
                doc = null;
                MessageBox.Show("Документ сформирован");
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то закрываем документ и выводим информацию
                doc.Close();
                doc = null;
               MessageBox.Show("Во время выполнения произошла ошибка" + ex);
                
            }

            /*
                        string TemplateFileName = @"D:\Настя\учеба\4 курс\Диплом\ЦДО\шаблон.doc";
                        var wordApp = new Word.Application();
                        wordApp.Visible = false;

                        var wordDocument = wordApp.Documents.Add(TemplateFileName);

                        ReplaceWordStub("{surname}", TbSurname.Text, wordDocument);
                        ReplaceWordStub("{name}", TbName.Text, wordDocument);
                        ReplaceWordStub("{patronymic}", TbPatronymic.Text, wordDocument);
                        ReplaceWordStub("{dateOfBirth}", DateOfBirth.Text, wordDocument);
                        ReplaceWordStub("{placeOfBirth}", TbPlaceOfBirth.Text, wordDocument);
                        ReplaceWordStub("{adressLives}", TbAdressProg.Text, wordDocument);
                        ReplaceWordStub("{adressReg}", TbAdressReg.Text, wordDocument);
                        ReplaceWordStub("{nationality}", TbNationality.Text, wordDocument);
                        ReplaceWordStub("{pasport}", TbCertificate.Text, wordDocument);
                        ReplaceWordStub("{series}", TbSeriesCertificate.Text, wordDocument);
                        ReplaceWordStub("{number}", TbNumberCertificate.Text, wordDocument);
                        ReplaceWordStub("{issued}", TbIssued.Text, wordDocument);
                        ReplaceWordStub("{dateIssued}",CalenDateIssued.Text, wordDocument);


                        MessageBox.Show("Файл сформирован");


                        SaveFileDialog sfd = new SaveFileDialog();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {

                            wordDocument.SaveAs(@"D:\Настя\учеба\4 курс\Диплом\ЦДО\Договор.docx");

                        }
                        wordDocument.Close();

                    }
                    */
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connecting = new SqlConnection(Program.connection))
                {
                    connecting.Open();


                    SqlCommand cmd = connecting.CreateCommand();

                    //Изменение данных о слушателе
                    SqlCommand WriteCommand;
                    WriteCommand = new SqlCommand("UPDATE [Student] SET Surname = @Surname, Name = @Name, Patronymic=@Patronymic, DateOfBirth=@DateOfBirth, PlaceOfBirth=@PlaceOfBirth, Nationality=@Nationality, Phone=@Phone, Email=@Email, Group=@Group, Dop=@Dop  WHERE IDStudent = @ID", connecting);

                    WriteCommand.Parameters.AddWithValue("Surname", TbSurname.Text);
                    WriteCommand.Parameters.AddWithValue("Name", TbName.Text);
                    WriteCommand.Parameters.AddWithValue("Patronymic", TbPatronymic.Text);
                    WriteCommand.Parameters.AddWithValue("DateOfBirth", Convert.ToDateTime(DateOfBirth.Text).ToShortDateString());
                    WriteCommand.Parameters.AddWithValue("PlaceOfBirth", TbPlaceOfBirth.Text);
                    WriteCommand.Parameters.AddWithValue("Nationality", TbNationality.Text);
                    WriteCommand.Parameters.AddWithValue("Phone", Convert.ToString(TbPhone.Text));
                    WriteCommand.Parameters.AddWithValue("Email", TbEmail.Text);
                    WriteCommand.Parameters.AddWithValue("Group", TbGroup.Text);
                    WriteCommand.Parameters.AddWithValue("Dop", TbDop.Text);
                    WriteCommand.Parameters.AddWithValue("ID", Convert.ToInt32(Id));
                    WriteCommand.ExecuteNonQuery();

                    MessageBox.Show("Данные о слушателе изменена");
                    connecting.Close();


                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students frm = new Students();
            frm.Show();
            this.Hide();

        }

        private void BtnDog_Click_1(object sender, EventArgs e)
        {

            // Создаём объект документа
            Word.Document doc = null;
            try
            {
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа должен быть целиком на английском !!!
                string source = @"D:\zayavlenie.docx";

                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();
                doc.Bookmarks["surname"].Range.Text = TbSurname.Text;
                doc.Bookmarks["name"].Range.Text = TbName.Text;
                doc.Bookmarks["patronymic"].Range.Text = TbPatronymic.Text;
                doc.Bookmarks["dateOfBirth"].Range.Text = Convert.ToDateTime(DateOfBirth.Value).ToShortDateString();
                doc.Bookmarks["placeOfBirth"].Range.Text = TbPlaceOfBirth.Text;
                doc.Bookmarks["adressLives"].Range.Text = TbAdressProg.Text;
                doc.Bookmarks["adressReg"].Range.Text = TbAdressReg.Text;
                doc.Bookmarks["nationality"].Range.Text = TbNationality.Text;
                doc.Bookmarks["pasport"].Range.Text = TbCertificate.Text;
                doc.Bookmarks["series"].Range.Text = TbSeriesCertificate.Text;
                doc.Bookmarks["number"].Range.Text = TbNumberCertificate.Text;
                doc.Bookmarks["issued"].Range.Text = TbIssued.Text;
                doc.Bookmarks["dateIssued"].Range.Text = Convert.ToDateTime(CalenDateIssued.Value).ToShortDateString();
                doc.Bookmarks["phone"].Range.Text = TbPhone.Text;
                int year = Convert.ToDateTime(DateEnd.Text).Year;
                doc.Bookmarks["yearendeducat"].Range.Text = Convert.ToString(year);
                doc.Bookmarks["docoeducat"].Range.Text = CbDocEducat.Text;
                doc.Bookmarks["seriesdoc"].Range.Text = TbSeriesDoc.Text;
                doc.Bookmarks["numberdoc"].Range.Text = TbNumberDoc.Text;
                doc.Bookmarks["nameinstitute"].Range.Text = TbNameInstitute.Text;
                doc.Bookmarks["dateissueddoc"].Range.Text = Convert.ToDateTime(CalenDateIssued.Value).ToShortDateString();
                doc.Bookmarks["datenow"].Range.Text = Convert.ToDateTime(DateTime.Now).ToShortDateString();
                doc.Bookmarks["datenow1"].Range.Text = Convert.ToDateTime(DateTime.Now).ToShortDateString();
                doc.Bookmarks["typeprog"].Range.Text = CbTypeCourse.Text;
                doc.Bookmarks["nameprof"].Range.Text = CbNameProg.Text;
                doc.Bookmarks["typeobuch"].Range.Text = CbTypeObuch.Text;

              
                // Закрываем документ
                doc.SaveAs2(@"D:\dogovor.docx");

                doc.Close();
               
                app.Quit();

                

              
                doc = null;
                MessageBox.Show("Документ сформирован");
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то закрываем документ и выводим информацию
                
                MessageBox.Show("Во время выполнения произошла ошибка" + ex);

            }

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSogl_Click(object sender, EventArgs e)
        {
            // Создаём объект документа
            Word.Document doc = null;
            try
            {
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа должен быть целиком на английском !!!
                string source = @"D:\soglshab.docx";

                // Открываем
                doc = app.Documents.Open(source);
                doc.Activate();
                doc.Bookmarks["FIO"].Range.Text = TbSurname.Text + "  " + TbName.Text + "  " + TbPatronymic.Text;
                doc.Bookmarks["pasportseries"].Range.Text = TbSeriesCertificate.Text;
                doc.Bookmarks["pasportnumber"].Range.Text = TbNumberCertificate.Text;
                doc.Bookmarks["dateissuedpasport"].Range.Text = Convert.ToDateTime(PaspDateIssued.Text).ToShortDateString();
                doc.Bookmarks["issued"].Range.Text = TbIssued.Text;
                doc.Bookmarks["adressreg"].Range.Text = TbAdressReg.Text;
                doc.Bookmarks["date"].Range.Text = Convert.ToDateTime(DateTime.Now).ToShortDateString();


                MessageBox.Show("Файл сформирован");
                
                SaveFileDialog sfd = new SaveFileDialog();

                //выбираем путь для сохранения
                sfd.InitialDirectory = @"D:\";
                
                string path = "";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    doc.SaveAs2(path);
                    MessageBox.Show("Файл сохранен");


                }
                doc.Close();



            }

            catch (Exception ex)
            {
                // Если произошла ошибка, то закрываем документ и выводим информацию

                MessageBox.Show("Во время выполнения произошла ошибка" + ex);

            }


        }
    }
}
