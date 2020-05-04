namespace ЦДО.Forms
{
    partial class Education
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Education));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            this.cDODataSet = new ЦДО.BD.CDODataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new ЦДО.BD.CDODataSetTableAdapters.CourseTableAdapter();
            this.iDCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditCourse = new System.Windows.Forms.Button();
            this.BtnAddCourse = new System.Windows.Forms.Button();
            this.dataGridProgram = new System.Windows.Forms.DataGridView();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new ЦДО.BD.CDODataSetTableAdapters.ProgramTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditProgam = new System.Windows.Forms.Button();
            this.BtnAddProgram = new System.Windows.Forms.Button();
            this.dataGridTypeProg = new System.Windows.Forms.DataGridView();
            this.typeProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeProgTableAdapter = new ЦДО.BD.CDODataSetTableAdapters.TypeProgTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolChasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditTypeProg = new System.Windows.Forms.Button();
            this.BtnAddTypeProg = new System.Windows.Forms.Button();
            this.dataGridTypePractik = new System.Windows.Forms.DataGridView();
            this.typePractikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typePractikTableAdapter = new ЦДО.BD.CDODataSetTableAdapters.TypePractikTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePractikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditTypePractik = new System.Windows.Forms.Button();
            this.BtnAddTypePractik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypePractik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePractikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 120);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(433, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обучение";
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.AutoGenerateColumns = false;
            this.dataGridCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCourseDataGridViewTextBoxColumn,
            this.nameCourseDataGridViewTextBoxColumn});
            this.dataGridCourse.DataSource = this.courseBindingSource;
            this.dataGridCourse.Location = new System.Drawing.Point(39, 153);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.RowTemplate.Height = 24;
            this.dataGridCourse.Size = new System.Drawing.Size(695, 150);
            this.dataGridCourse.TabIndex = 2;
            this.dataGridCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCourse_CellClick);
            // 
            // cDODataSet
            // 
            this.cDODataSet.DataSetName = "CDODataSet";
            this.cDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.cDODataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // iDCourseDataGridViewTextBoxColumn
            // 
            this.iDCourseDataGridViewTextBoxColumn.DataPropertyName = "IDCourse";
            this.iDCourseDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.iDCourseDataGridViewTextBoxColumn.Name = "iDCourseDataGridViewTextBoxColumn";
            this.iDCourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameCourseDataGridViewTextBoxColumn
            // 
            this.nameCourseDataGridViewTextBoxColumn.DataPropertyName = "NameCourse";
            this.nameCourseDataGridViewTextBoxColumn.HeaderText = "Название курса";
            this.nameCourseDataGridViewTextBoxColumn.Name = "nameCourseDataGridViewTextBoxColumn";
            this.nameCourseDataGridViewTextBoxColumn.Width = 400;
            // 
            // BtnEditCourse
            // 
            this.BtnEditCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditCourse.Location = new System.Drawing.Point(844, 245);
            this.BtnEditCourse.Name = "BtnEditCourse";
            this.BtnEditCourse.Size = new System.Drawing.Size(252, 60);
            this.BtnEditCourse.TabIndex = 56;
            this.BtnEditCourse.Text = "Изменить";
            this.BtnEditCourse.UseVisualStyleBackColor = false;
            this.BtnEditCourse.Click += new System.EventHandler(this.BtnEditCourse_Click);
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddCourse.Location = new System.Drawing.Point(844, 153);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(252, 60);
            this.BtnAddCourse.TabIndex = 55;
            this.BtnAddCourse.Text = "Добавить";
            this.BtnAddCourse.UseVisualStyleBackColor = false;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // dataGridProgram
            // 
            this.dataGridProgram.AutoGenerateColumns = false;
            this.dataGridProgram.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameProgDataGridViewTextBoxColumn});
            this.dataGridProgram.DataSource = this.programBindingSource;
            this.dataGridProgram.Location = new System.Drawing.Point(39, 353);
            this.dataGridProgram.Name = "dataGridProgram";
            this.dataGridProgram.RowTemplate.Height = 24;
            this.dataGridProgram.Size = new System.Drawing.Size(695, 150);
            this.dataGridProgram.TabIndex = 57;
            this.dataGridProgram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProgram_CellClick);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.cDODataSet;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "№ п/п";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameProgDataGridViewTextBoxColumn
            // 
            this.nameProgDataGridViewTextBoxColumn.DataPropertyName = "NameProg";
            this.nameProgDataGridViewTextBoxColumn.HeaderText = "Наименование программы";
            this.nameProgDataGridViewTextBoxColumn.Name = "nameProgDataGridViewTextBoxColumn";
            this.nameProgDataGridViewTextBoxColumn.Width = 400;
            // 
            // BtnEditProgam
            // 
            this.BtnEditProgam.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditProgam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditProgam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditProgam.Location = new System.Drawing.Point(844, 445);
            this.BtnEditProgam.Name = "BtnEditProgam";
            this.BtnEditProgam.Size = new System.Drawing.Size(252, 60);
            this.BtnEditProgam.TabIndex = 59;
            this.BtnEditProgam.Text = "Изменить";
            this.BtnEditProgam.UseVisualStyleBackColor = false;
            this.BtnEditProgam.Click += new System.EventHandler(this.BtnEditProgam_Click);
            // 
            // BtnAddProgram
            // 
            this.BtnAddProgram.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddProgram.Location = new System.Drawing.Point(844, 353);
            this.BtnAddProgram.Name = "BtnAddProgram";
            this.BtnAddProgram.Size = new System.Drawing.Size(252, 60);
            this.BtnAddProgram.TabIndex = 58;
            this.BtnAddProgram.Text = "Добавить";
            this.BtnAddProgram.UseVisualStyleBackColor = false;
            this.BtnAddProgram.Click += new System.EventHandler(this.BtnAddProgram_Click);
            // 
            // dataGridTypeProg
            // 
            this.dataGridTypeProg.AutoGenerateColumns = false;
            this.dataGridTypeProg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridTypeProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypeProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameTypeDataGridViewTextBoxColumn,
            this.kolChasDataGridViewTextBoxColumn,
            this.typeDocDataGridViewTextBoxColumn});
            this.dataGridTypeProg.DataSource = this.typeProgBindingSource;
            this.dataGridTypeProg.Location = new System.Drawing.Point(39, 561);
            this.dataGridTypeProg.Name = "dataGridTypeProg";
            this.dataGridTypeProg.RowTemplate.Height = 24;
            this.dataGridTypeProg.Size = new System.Drawing.Size(695, 150);
            this.dataGridTypeProg.TabIndex = 60;
            this.dataGridTypeProg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTypeProg_CellClick);
            // 
            // typeProgBindingSource
            // 
            this.typeProgBindingSource.DataMember = "TypeProg";
            this.typeProgBindingSource.DataSource = this.cDODataSet;
            // 
            // typeProgTableAdapter
            // 
            this.typeProgTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "№ п/п";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameTypeDataGridViewTextBoxColumn
            // 
            this.nameTypeDataGridViewTextBoxColumn.DataPropertyName = "NameType";
            this.nameTypeDataGridViewTextBoxColumn.HeaderText = "Наименование типа";
            this.nameTypeDataGridViewTextBoxColumn.Name = "nameTypeDataGridViewTextBoxColumn";
            this.nameTypeDataGridViewTextBoxColumn.Width = 300;
            // 
            // kolChasDataGridViewTextBoxColumn
            // 
            this.kolChasDataGridViewTextBoxColumn.DataPropertyName = "KolChas";
            this.kolChasDataGridViewTextBoxColumn.HeaderText = "Количество часов";
            this.kolChasDataGridViewTextBoxColumn.Name = "kolChasDataGridViewTextBoxColumn";
            // 
            // typeDocDataGridViewTextBoxColumn
            // 
            this.typeDocDataGridViewTextBoxColumn.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.HeaderText = "Тип докуента об окончании";
            this.typeDocDataGridViewTextBoxColumn.Name = "typeDocDataGridViewTextBoxColumn";
            this.typeDocDataGridViewTextBoxColumn.Width = 300;
            // 
            // BtnEditTypeProg
            // 
            this.BtnEditTypeProg.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditTypeProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditTypeProg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditTypeProg.Location = new System.Drawing.Point(844, 651);
            this.BtnEditTypeProg.Name = "BtnEditTypeProg";
            this.BtnEditTypeProg.Size = new System.Drawing.Size(252, 60);
            this.BtnEditTypeProg.TabIndex = 62;
            this.BtnEditTypeProg.Text = "Изменить";
            this.BtnEditTypeProg.UseVisualStyleBackColor = false;
            this.BtnEditTypeProg.Click += new System.EventHandler(this.BtnEditTypeProg_Click);
            // 
            // BtnAddTypeProg
            // 
            this.BtnAddTypeProg.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddTypeProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddTypeProg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddTypeProg.Location = new System.Drawing.Point(844, 559);
            this.BtnAddTypeProg.Name = "BtnAddTypeProg";
            this.BtnAddTypeProg.Size = new System.Drawing.Size(252, 60);
            this.BtnAddTypeProg.TabIndex = 61;
            this.BtnAddTypeProg.Text = "Добавить";
            this.BtnAddTypeProg.UseVisualStyleBackColor = false;
            this.BtnAddTypeProg.Click += new System.EventHandler(this.BtnAddTypeProg_Click);
            // 
            // dataGridTypePractik
            // 
            this.dataGridTypePractik.AutoGenerateColumns = false;
            this.dataGridTypePractik.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridTypePractik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypePractik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.namePractikDataGridViewTextBoxColumn});
            this.dataGridTypePractik.DataSource = this.typePractikBindingSource;
            this.dataGridTypePractik.Location = new System.Drawing.Point(39, 756);
            this.dataGridTypePractik.Name = "dataGridTypePractik";
            this.dataGridTypePractik.RowTemplate.Height = 24;
            this.dataGridTypePractik.Size = new System.Drawing.Size(695, 150);
            this.dataGridTypePractik.TabIndex = 63;
            this.dataGridTypePractik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTypePractik_CellClick);
            // 
            // typePractikBindingSource
            // 
            this.typePractikBindingSource.DataMember = "TypePractik";
            this.typePractikBindingSource.DataSource = this.cDODataSet;
            // 
            // typePractikTableAdapter
            // 
            this.typePractikTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "№ п/п";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // namePractikDataGridViewTextBoxColumn
            // 
            this.namePractikDataGridViewTextBoxColumn.DataPropertyName = "NamePractik";
            this.namePractikDataGridViewTextBoxColumn.HeaderText = "Наименование практики";
            this.namePractikDataGridViewTextBoxColumn.Name = "namePractikDataGridViewTextBoxColumn";
            this.namePractikDataGridViewTextBoxColumn.Width = 200;
            // 
            // BtnEditTypePractik
            // 
            this.BtnEditTypePractik.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditTypePractik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditTypePractik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditTypePractik.Location = new System.Drawing.Point(844, 846);
            this.BtnEditTypePractik.Name = "BtnEditTypePractik";
            this.BtnEditTypePractik.Size = new System.Drawing.Size(252, 60);
            this.BtnEditTypePractik.TabIndex = 65;
            this.BtnEditTypePractik.Text = "Изменить";
            this.BtnEditTypePractik.UseVisualStyleBackColor = false;
            this.BtnEditTypePractik.Click += new System.EventHandler(this.BtnEditTypePractik_Click);
            // 
            // BtnAddTypePractik
            // 
            this.BtnAddTypePractik.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddTypePractik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddTypePractik.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddTypePractik.Location = new System.Drawing.Point(844, 754);
            this.BtnAddTypePractik.Name = "BtnAddTypePractik";
            this.BtnAddTypePractik.Size = new System.Drawing.Size(252, 60);
            this.BtnAddTypePractik.TabIndex = 64;
            this.BtnAddTypePractik.Text = "Добавить";
            this.BtnAddTypePractik.UseVisualStyleBackColor = false;
            this.BtnAddTypePractik.Click += new System.EventHandler(this.BtnAddTypePractik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ЦДО.Properties.Resources.значок1;
            this.pictureBox1.Location = new System.Drawing.Point(1050, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBack.Location = new System.Drawing.Point(826, 923);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(130, 43);
            this.BtnBack.TabIndex = 67;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExit.Location = new System.Drawing.Point(994, 923);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(130, 43);
            this.BtnExit.TabIndex = 66;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1182, 978);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnEditTypePractik);
            this.Controls.Add(this.BtnAddTypePractik);
            this.Controls.Add(this.dataGridTypePractik);
            this.Controls.Add(this.BtnEditTypeProg);
            this.Controls.Add(this.BtnAddTypeProg);
            this.Controls.Add(this.dataGridTypeProg);
            this.Controls.Add(this.BtnEditProgam);
            this.Controls.Add(this.BtnAddProgram);
            this.Controls.Add(this.dataGridProgram);
            this.Controls.Add(this.BtnEditCourse);
            this.Controls.Add(this.BtnAddCourse);
            this.Controls.Add(this.dataGridCourse);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Education";
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.Education_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypePractik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePractikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridCourse;
        private BD.CDODataSet cDODataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private BD.CDODataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditCourse;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.DataGridView dataGridProgram;
        private System.Windows.Forms.BindingSource programBindingSource;
        private BD.CDODataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditProgam;
        private System.Windows.Forms.Button BtnAddProgram;
        private System.Windows.Forms.DataGridView dataGridTypeProg;
        private System.Windows.Forms.BindingSource typeProgBindingSource;
        private BD.CDODataSetTableAdapters.TypeProgTableAdapter typeProgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolChasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditTypeProg;
        private System.Windows.Forms.Button BtnAddTypeProg;
        private System.Windows.Forms.DataGridView dataGridTypePractik;
        private System.Windows.Forms.BindingSource typePractikBindingSource;
        private BD.CDODataSetTableAdapters.TypePractikTableAdapter typePractikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePractikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditTypePractik;
        private System.Windows.Forms.Button BtnAddTypePractik;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
    }
}