namespace ЦДО.Forms
{
    partial class AddEditDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditDocument));
            this.label1 = new System.Windows.Forms.Label();
            this.CbTypeDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbGroup = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cDODataSet1 = new ЦДО.BD.CDODataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAddDoc = new System.Windows.Forms.Button();
            this.CbStatusDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbUtrata = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbObmen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbUnichtog = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbSeriesDoc = new System.Windows.Forms.TextBox();
            this.TbNumberDoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbRegNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbStudent = new System.Windows.Forms.TextBox();
            this.studentTableAdapter1 = new ЦДО.BD.CDODataSetTableAdapters.StudentTableAdapter();
            this.BtnEditDoc = new System.Windows.Forms.Button();
            this.dateTimedateissued = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание/редактирование документа";
            // 
            // CbTypeDoc
            // 
            this.CbTypeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbTypeDoc.FormattingEnabled = true;
            this.CbTypeDoc.Items.AddRange(new object[] {
            "Удостоверение",
            "Диплом",
            "Свидетельство"});
            this.CbTypeDoc.Location = new System.Drawing.Point(269, 105);
            this.CbTypeDoc.Name = "CbTypeDoc";
            this.CbTypeDoc.Size = new System.Drawing.Size(233, 33);
            this.CbTypeDoc.TabIndex = 15;
            this.CbTypeDoc.Text = "Диплом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Тип документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Группа";
            // 
            // CbGroup
            // 
            this.CbGroup.DataSource = this.groupBindingSource;
            this.CbGroup.DisplayMember = "NameGroup";
            this.CbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbGroup.FormattingEnabled = true;
            this.CbGroup.Location = new System.Drawing.Point(269, 452);
            this.CbGroup.Name = "CbGroup";
            this.CbGroup.Size = new System.Drawing.Size(233, 33);
            this.CbGroup.TabIndex = 17;
            this.CbGroup.ValueMember = "NameGroup";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Слушатель";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 561);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 194);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDStudent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patronymic";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PlaceOfBirth";
            this.dataGridViewTextBoxColumn6.HeaderText = "PlaceOfBirth";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nationality";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nationality";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn8.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "Email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NameGroup";
            this.dataGridViewTextBoxColumn10.HeaderText = "NameGroup";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Dop";
            this.dataGridViewTextBoxColumn11.HeaderText = "Dop";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.cDODataSet1;
            // 
            // cDODataSet1
            // 
            this.cDODataSet1.DataSetName = "CDODataSet";
            this.cDODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            // 
            // BtnAddDoc
            // 
            this.BtnAddDoc.BackColor = System.Drawing.Color.Blue;
            this.BtnAddDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddDoc.Location = new System.Drawing.Point(167, 772);
            this.BtnAddDoc.Name = "BtnAddDoc";
            this.BtnAddDoc.Size = new System.Drawing.Size(192, 57);
            this.BtnAddDoc.TabIndex = 20;
            this.BtnAddDoc.Text = "Добавить";
            this.BtnAddDoc.UseVisualStyleBackColor = false;
            this.BtnAddDoc.Click += new System.EventHandler(this.BtnCourseNew_Click);
            // 
            // CbStatusDoc
            // 
            this.CbStatusDoc.DisplayMember = "NameCourse";
            this.CbStatusDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbStatusDoc.FormattingEnabled = true;
            this.CbStatusDoc.Items.AddRange(new object[] {
            "Оригинал",
            "Копия"});
            this.CbStatusDoc.Location = new System.Drawing.Point(814, 105);
            this.CbStatusDoc.Name = "CbStatusDoc";
            this.CbStatusDoc.Size = new System.Drawing.Size(233, 33);
            this.CbStatusDoc.TabIndex = 22;
            this.CbStatusDoc.Text = "Оригинал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(566, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Статус документа";
            // 
            // CbUtrata
            // 
            this.CbUtrata.DisplayMember = "NameCourse";
            this.CbUtrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbUtrata.FormattingEnabled = true;
            this.CbUtrata.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.CbUtrata.Location = new System.Drawing.Point(269, 193);
            this.CbUtrata.Name = "CbUtrata";
            this.CbUtrata.Size = new System.Drawing.Size(233, 33);
            this.CbUtrata.TabIndex = 24;
            this.CbUtrata.Text = "Нет";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(37, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 70);
            this.label6.TabIndex = 23;
            this.label6.Text = "Подтверждение утраты";
            // 
            // CbObmen
            // 
            this.CbObmen.DisplayMember = "NameCourse";
            this.CbObmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbObmen.FormattingEnabled = true;
            this.CbObmen.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.CbObmen.Location = new System.Drawing.Point(814, 193);
            this.CbObmen.Name = "CbObmen";
            this.CbObmen.Size = new System.Drawing.Size(233, 33);
            this.CbObmen.TabIndex = 26;
            this.CbObmen.Text = "Нет";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(566, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 70);
            this.label7.TabIndex = 25;
            this.label7.Text = "Подтверждение обмена";
            // 
            // CbUnichtog
            // 
            this.CbUnichtog.DisplayMember = "NameCourse";
            this.CbUnichtog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbUnichtog.FormattingEnabled = true;
            this.CbUnichtog.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.CbUnichtog.Location = new System.Drawing.Point(269, 288);
            this.CbUnichtog.Name = "CbUnichtog";
            this.CbUnichtog.Size = new System.Drawing.Size(233, 33);
            this.CbUnichtog.TabIndex = 28;
            this.CbUnichtog.Text = "Нет";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(37, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 70);
            this.label8.TabIndex = 27;
            this.label8.Text = "Подтверждение уничтожения";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(566, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 68);
            this.label9.TabIndex = 29;
            this.label9.Text = "Серия документа";
            // 
            // TbSeriesDoc
            // 
            this.TbSeriesDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbSeriesDoc.Location = new System.Drawing.Point(814, 285);
            this.TbSeriesDoc.Name = "TbSeriesDoc";
            this.TbSeriesDoc.Size = new System.Drawing.Size(233, 34);
            this.TbSeriesDoc.TabIndex = 30;
            this.TbSeriesDoc.Text = "0214";
            // 
            // TbNumberDoc
            // 
            this.TbNumberDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbNumberDoc.Location = new System.Drawing.Point(814, 352);
            this.TbNumberDoc.Name = "TbNumberDoc";
            this.TbNumberDoc.Size = new System.Drawing.Size(233, 34);
            this.TbNumberDoc.TabIndex = 32;
            this.TbNumberDoc.Text = "235749";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(566, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 60);
            this.label10.TabIndex = 31;
            this.label10.Text = "Номер документа";
            // 
            // TbRegNumber
            // 
            this.TbRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbRegNumber.Location = new System.Drawing.Point(269, 366);
            this.TbRegNumber.Name = "TbRegNumber";
            this.TbRegNumber.Size = new System.Drawing.Size(233, 34);
            this.TbRegNumber.TabIndex = 34;
            this.TbRegNumber.Text = "002";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(37, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 62);
            this.label11.TabIndex = 33;
            this.label11.Text = "Регистрационный номер";
            // 
            // TbStudent
            // 
            this.TbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbStudent.Location = new System.Drawing.Point(269, 511);
            this.TbStudent.Name = "TbStudent";
            this.TbStudent.Size = new System.Drawing.Size(233, 34);
            this.TbStudent.TabIndex = 35;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnEditDoc
            // 
            this.BtnEditDoc.BackColor = System.Drawing.Color.Blue;
            this.BtnEditDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditDoc.Location = new System.Drawing.Point(437, 772);
            this.BtnEditDoc.Name = "BtnEditDoc";
            this.BtnEditDoc.Size = new System.Drawing.Size(192, 57);
            this.BtnEditDoc.TabIndex = 36;
            this.BtnEditDoc.Text = "Изменить";
            this.BtnEditDoc.UseVisualStyleBackColor = false;
            this.BtnEditDoc.Click += new System.EventHandler(this.BtnEditDoc_Click);
            // 
            // dateTimedateissued
            // 
            this.dateTimedateissued.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimedateissued.Location = new System.Drawing.Point(814, 429);
            this.dateTimedateissued.Name = "dateTimedateissued";
            this.dateTimedateissued.Size = new System.Drawing.Size(233, 34);
            this.dateTimedateissued.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(566, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 60);
            this.label12.TabIndex = 38;
            this.label12.Text = "Дата выдачи документа";
            // 
            // AddEditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1082, 854);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimedateissued);
            this.Controls.Add(this.BtnEditDoc);
            this.Controls.Add(this.TbStudent);
            this.Controls.Add(this.TbRegNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TbNumberDoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbSeriesDoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbUnichtog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbObmen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbUtrata);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbStatusDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAddDoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbTypeDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditDocument";
            this.Text = "Добавить/изменить документ";
            this.Load += new System.EventHandler(this.AddEditDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox CbTypeDoc;
        public System.Windows.Forms.ComboBox CbGroup;
        private BD.CDODataSet cDODataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private BD.CDODataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private BD.CDODataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopDataGridViewTextBoxColumn;
        public System.Windows.Forms.ComboBox CbStatusDoc;
        public System.Windows.Forms.ComboBox CbUtrata;
        public System.Windows.Forms.ComboBox CbObmen;
        public System.Windows.Forms.ComboBox CbUnichtog;
        public System.Windows.Forms.TextBox TbSeriesDoc;
        public System.Windows.Forms.TextBox TbNumberDoc;
        public System.Windows.Forms.TextBox TbRegNumber;
        public System.Windows.Forms.TextBox TbStudent;
        private BD.CDODataSet cDODataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private BD.CDODataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        public System.Windows.Forms.Button BtnEditDoc;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BtnAddDoc;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimedateissued;
        public System.Windows.Forms.Label label12;
    }
}