namespace ЦДО
{
    partial class Cources
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GridCourse = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolChasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeObuchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePractikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDODataSet = new ЦДО.База_данных.CDODataSet();
            this.newCourseTableAdapter = new ЦДО.База_данных.CDODataSetTableAdapters.NewCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(560, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Курсы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ЦДО.Properties.Resources.значок1;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 95);
            this.panel1.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExit.Location = new System.Drawing.Point(1129, 561);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(252, 60);
            this.BtnExit.TabIndex = 62;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBack.Location = new System.Drawing.Point(1129, 460);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(252, 60);
            this.BtnBack.TabIndex = 61;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDel.Location = new System.Drawing.Point(1129, 361);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(252, 60);
            this.BtnDel.TabIndex = 60;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEdit.Location = new System.Drawing.Point(1129, 256);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(252, 60);
            this.BtnEdit.TabIndex = 59;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(1129, 149);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(252, 60);
            this.BtnAdd.TabIndex = 58;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GridCourse
            // 
            this.GridCourse.AutoGenerateColumns = false;
            this.GridCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.kolChasDataGridViewTextBoxColumn,
            this.smetaDataGridViewTextBoxColumn,
            this.typeObuchDataGridViewTextBoxColumn,
            this.typePractikDataGridViewTextBoxColumn});
            this.GridCourse.DataSource = this.newCourseBindingSource;
            this.GridCourse.Location = new System.Drawing.Point(23, 129);
            this.GridCourse.Name = "GridCourse";
            this.GridCourse.RowTemplate.Height = 24;
            this.GridCourse.Size = new System.Drawing.Size(1064, 532);
            this.GridCourse.TabIndex = 63;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            // 
            // kolChasDataGridViewTextBoxColumn
            // 
            this.kolChasDataGridViewTextBoxColumn.DataPropertyName = "KolChas";
            this.kolChasDataGridViewTextBoxColumn.HeaderText = "KolChas";
            this.kolChasDataGridViewTextBoxColumn.Name = "kolChasDataGridViewTextBoxColumn";
            // 
            // smetaDataGridViewTextBoxColumn
            // 
            this.smetaDataGridViewTextBoxColumn.DataPropertyName = "Smeta";
            this.smetaDataGridViewTextBoxColumn.HeaderText = "Smeta";
            this.smetaDataGridViewTextBoxColumn.Name = "smetaDataGridViewTextBoxColumn";
            // 
            // typeObuchDataGridViewTextBoxColumn
            // 
            this.typeObuchDataGridViewTextBoxColumn.DataPropertyName = "TypeObuch";
            this.typeObuchDataGridViewTextBoxColumn.HeaderText = "TypeObuch";
            this.typeObuchDataGridViewTextBoxColumn.Name = "typeObuchDataGridViewTextBoxColumn";
            // 
            // typePractikDataGridViewTextBoxColumn
            // 
            this.typePractikDataGridViewTextBoxColumn.DataPropertyName = "TypePractik";
            this.typePractikDataGridViewTextBoxColumn.HeaderText = "TypePractik";
            this.typePractikDataGridViewTextBoxColumn.Name = "typePractikDataGridViewTextBoxColumn";
            // 
            // newCourseBindingSource
            // 
            this.newCourseBindingSource.DataMember = "NewCourse";
            this.newCourseBindingSource.DataSource = this.cDODataSet;
            // 
            // cDODataSet
            // 
            this.cDODataSet.DataSetName = "CDODataSet";
            this.cDODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newCourseTableAdapter
            // 
            this.newCourseTableAdapter.ClearBeforeFill = true;
            // 
            // Cources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1393, 685);
            this.Controls.Add(this.GridCourse);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "Cources";
            this.Text = "Курсы";
            this.Load += new System.EventHandler(this.Cources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView GridCourse;
        private База_данных.CDODataSet cDODataSet;
        private System.Windows.Forms.BindingSource newCourseBindingSource;
        private База_данных.CDODataSetTableAdapters.NewCourseTableAdapter newCourseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolChasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeObuchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePractikDataGridViewTextBoxColumn;
    }
}