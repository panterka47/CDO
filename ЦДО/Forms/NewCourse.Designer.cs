﻿namespace ЦДО
{
    partial class NewCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbChas = new System.Windows.Forms.TextBox();
            this.TbSmeta = new System.Windows.Forms.TextBox();
            this.CbTypeObuch = new System.Windows.Forms.ComboBox();
            this.typeObuchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cDODataSet3 = new ЦДО.BD.CDODataSet();
            this.typeObuchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbCourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbProgram = new System.Windows.Forms.ComboBox();
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbTypeProg = new System.Windows.Forms.ComboBox();
            this.typeProgBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.CbTypePractik = new System.Windows.Forms.ComboBox();
            this.typePractikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typePractikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.courseTableAdapter2 = new ЦДО.BD.CDODataSetTableAdapters.CourseTableAdapter();
            this.programTableAdapter2 = new ЦДО.BD.CDODataSetTableAdapters.ProgramTableAdapter();
            this.typeProgTableAdapter2 = new ЦДО.BD.CDODataSetTableAdapters.TypeProgTableAdapter();
            this.typeObuchTableAdapter3 = new ЦДО.BD.CDODataSetTableAdapters.TypeObuchTableAdapter();
            this.typePractikTableAdapter3 = new ЦДО.BD.CDODataSetTableAdapters.TypePractikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typeObuchBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeObuchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePractikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePractikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(141, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание/редактирование курса обучения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Программа";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 68);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип программы";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 62);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата начала курса";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 62);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата окончания курса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(541, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество часов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(541, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Смета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(541, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Тип обучения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(541, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Тип практики";
            // 
            // TbChas
            // 
            this.TbChas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbChas.Location = new System.Drawing.Point(797, 117);
            this.TbChas.Name = "TbChas";
            this.TbChas.Size = new System.Drawing.Size(208, 34);
            this.TbChas.TabIndex = 10;
            // 
            // TbSmeta
            // 
            this.TbSmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbSmeta.Location = new System.Drawing.Point(797, 181);
            this.TbSmeta.Name = "TbSmeta";
            this.TbSmeta.Size = new System.Drawing.Size(208, 34);
            this.TbSmeta.TabIndex = 11;
            // 
            // CbTypeObuch
            // 
            this.CbTypeObuch.DataSource = this.typeObuchBindingSource1;
            this.CbTypeObuch.DisplayMember = "NameType";
            this.CbTypeObuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbTypeObuch.FormattingEnabled = true;
            this.CbTypeObuch.Location = new System.Drawing.Point(797, 264);
            this.CbTypeObuch.Name = "CbTypeObuch";
            this.CbTypeObuch.Size = new System.Drawing.Size(208, 33);
            this.CbTypeObuch.TabIndex = 12;
            // 
            // typeObuchBindingSource1
            // 
            this.typeObuchBindingSource1.DataMember = "TypeObuch";
            this.typeObuchBindingSource1.DataSource = this.cDODataSet3;
            // 
            // cDODataSet3
            // 
            this.cDODataSet3.DataSetName = "CDODataSet";
            this.cDODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeObuchBindingSource
            // 
            this.typeObuchBindingSource.DataMember = "TypeObuch";
            // 
            // CbCourse
            // 
            this.CbCourse.DataSource = this.courseBindingSource1;
            this.CbCourse.DisplayMember = "NameCourse";
            this.CbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbCourse.FormattingEnabled = true;
            this.CbCourse.Location = new System.Drawing.Point(188, 120);
            this.CbCourse.Name = "CbCourse";
            this.CbCourse.Size = new System.Drawing.Size(233, 33);
            this.CbCourse.TabIndex = 13;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.cDODataSet3;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            // 
            // CbProgram
            // 
            this.CbProgram.DataSource = this.programBindingSource1;
            this.CbProgram.DisplayMember = "NameProg";
            this.CbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbProgram.FormattingEnabled = true;
            this.CbProgram.Location = new System.Drawing.Point(188, 212);
            this.CbProgram.Name = "CbProgram";
            this.CbProgram.Size = new System.Drawing.Size(233, 33);
            this.CbProgram.TabIndex = 14;
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataMember = "Program";
            this.programBindingSource1.DataSource = this.cDODataSet3;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            // 
            // CbTypeProg
            // 
            this.CbTypeProg.DataSource = this.typeProgBindingSource1;
            this.CbTypeProg.DisplayMember = "NameType";
            this.CbTypeProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbTypeProg.FormattingEnabled = true;
            this.CbTypeProg.Location = new System.Drawing.Point(188, 297);
            this.CbTypeProg.Name = "CbTypeProg";
            this.CbTypeProg.Size = new System.Drawing.Size(233, 33);
            this.CbTypeProg.TabIndex = 15;
            this.CbTypeProg.TextChanged += new System.EventHandler(this.CbTypeProg_TextChanged);
            // 
            // typeProgBindingSource1
            // 
            this.typeProgBindingSource1.DataMember = "TypeProg";
            this.typeProgBindingSource1.DataSource = this.cDODataSet3;
            // 
            // typeProgBindingSource
            // 
            this.typeProgBindingSource.DataMember = "TypeProg";
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateStart.Location = new System.Drawing.Point(188, 393);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(233, 30);
            this.dateStart.TabIndex = 16;
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEnd.Location = new System.Drawing.Point(188, 478);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(233, 30);
            this.dateEnd.TabIndex = 17;
            // 
            // CbTypePractik
            // 
            this.CbTypePractik.DataSource = this.typePractikBindingSource1;
            this.CbTypePractik.DisplayMember = "NamePractik";
            this.CbTypePractik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbTypePractik.FormattingEnabled = true;
            this.CbTypePractik.Location = new System.Drawing.Point(797, 336);
            this.CbTypePractik.Name = "CbTypePractik";
            this.CbTypePractik.Size = new System.Drawing.Size(208, 33);
            this.CbTypePractik.TabIndex = 18;
            // 
            // typePractikBindingSource1
            // 
            this.typePractikBindingSource1.DataMember = "TypePractik";
            this.typePractikBindingSource1.DataSource = this.cDODataSet3;
            // 
            // typePractikBindingSource
            // 
            this.typePractikBindingSource.DataMember = "TypePractik";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(39, 543);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(252, 60);
            this.BtnAdd.TabIndex = 50;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEdit.Location = new System.Drawing.Point(336, 543);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(252, 60);
            this.BtnEdit.TabIndex = 51;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBack.Location = new System.Drawing.Point(673, 543);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(174, 60);
            this.BtnBack.TabIndex = 52;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExit.Location = new System.Drawing.Point(886, 543);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(174, 60);
            this.BtnExit.TabIndex = 53;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // courseTableAdapter2
            // 
            this.courseTableAdapter2.ClearBeforeFill = true;
            // 
            // programTableAdapter2
            // 
            this.programTableAdapter2.ClearBeforeFill = true;
            // 
            // typeProgTableAdapter2
            // 
            this.typeProgTableAdapter2.ClearBeforeFill = true;
            // 
            // typeObuchTableAdapter3
            // 
            this.typeObuchTableAdapter3.ClearBeforeFill = true;
            // 
            // typePractikTableAdapter3
            // 
            this.typePractikTableAdapter3.ClearBeforeFill = true;
            // 
            // NewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1082, 632);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbTypePractik);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.CbTypeProg);
            this.Controls.Add(this.CbProgram);
            this.Controls.Add(this.CbCourse);
            this.Controls.Add(this.CbTypeObuch);
            this.Controls.Add(this.TbSmeta);
            this.Controls.Add(this.TbChas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewCourse";
            this.Text = "Создание/редактирование курса обучения";
            this.Load += new System.EventHandler(this.NewCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeObuchBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeObuchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePractikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePractikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private BD.CDODataSet cDODataSet;
        private BD.CDODataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private BD.CDODataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private BD.CDODataSetTableAdapters.TypeProgTableAdapter typeProgTableAdapter;
        private BD.CDODataSetTableAdapters.TypePractikTableAdapter typePractikTableAdapter;
        private BD.CDODataSetTableAdapters.TypeObuchTableAdapter typeObuchTableAdapter;
        public System.Windows.Forms.TextBox TbChas;
        public System.Windows.Forms.TextBox TbSmeta;
        public System.Windows.Forms.ComboBox CbTypeObuch;
        public System.Windows.Forms.ComboBox CbCourse;
        public System.Windows.Forms.ComboBox CbProgram;
        public System.Windows.Forms.ComboBox CbTypeProg;
        public System.Windows.Forms.DateTimePicker dateStart;
        public System.Windows.Forms.DateTimePicker dateEnd;
        public System.Windows.Forms.ComboBox CbTypePractik;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Button BtnAdd;
        private BD.CDODataSet cDODataSet1;
        private BD.CDODataSetTableAdapters.TypeObuchTableAdapter typeObuchTableAdapter1;
        private BD.CDODataSetTableAdapters.TypePractikTableAdapter typePractikTableAdapter1;
        private BD.CDODataSet cDODataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private BD.CDODataSetTableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private BD.CDODataSetTableAdapters.ProgramTableAdapter programTableAdapter1;
        private System.Windows.Forms.BindingSource typeProgBindingSource;
        private BD.CDODataSetTableAdapters.TypeProgTableAdapter typeProgTableAdapter1;
        private System.Windows.Forms.BindingSource typeObuchBindingSource;
        private BD.CDODataSetTableAdapters.TypeObuchTableAdapter typeObuchTableAdapter2;
        private System.Windows.Forms.BindingSource typePractikBindingSource;
        private BD.CDODataSetTableAdapters.TypePractikTableAdapter typePractikTableAdapter2;
        private BD.CDODataSet cDODataSet3;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private BD.CDODataSetTableAdapters.CourseTableAdapter courseTableAdapter2;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private BD.CDODataSetTableAdapters.ProgramTableAdapter programTableAdapter2;
        private System.Windows.Forms.BindingSource typeProgBindingSource1;
        private BD.CDODataSetTableAdapters.TypeProgTableAdapter typeProgTableAdapter2;
        private System.Windows.Forms.BindingSource typeObuchBindingSource1;
        private BD.CDODataSetTableAdapters.TypeObuchTableAdapter typeObuchTableAdapter3;
        private System.Windows.Forms.BindingSource typePractikBindingSource1;
        private BD.CDODataSetTableAdapters.TypePractikTableAdapter typePractikTableAdapter3;
    }
}