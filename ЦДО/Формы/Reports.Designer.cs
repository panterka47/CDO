namespace ЦДО.Формы
{
    partial class Reports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 95);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(464, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ЦДО.Properties.Resources.значок1;
            this.pictureBox1.Location = new System.Drawing.Point(1242, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.newCourseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 453);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 125;
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            this.programDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolChasDataGridViewTextBoxColumn
            // 
            this.kolChasDataGridViewTextBoxColumn.DataPropertyName = "KolChas";
            this.kolChasDataGridViewTextBoxColumn.HeaderText = "KolChas";
            this.kolChasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolChasDataGridViewTextBoxColumn.Name = "kolChasDataGridViewTextBoxColumn";
            this.kolChasDataGridViewTextBoxColumn.Width = 125;
            // 
            // smetaDataGridViewTextBoxColumn
            // 
            this.smetaDataGridViewTextBoxColumn.DataPropertyName = "Smeta";
            this.smetaDataGridViewTextBoxColumn.HeaderText = "Smeta";
            this.smetaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.smetaDataGridViewTextBoxColumn.Name = "smetaDataGridViewTextBoxColumn";
            this.smetaDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeObuchDataGridViewTextBoxColumn
            // 
            this.typeObuchDataGridViewTextBoxColumn.DataPropertyName = "TypeObuch";
            this.typeObuchDataGridViewTextBoxColumn.HeaderText = "TypeObuch";
            this.typeObuchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeObuchDataGridViewTextBoxColumn.Name = "typeObuchDataGridViewTextBoxColumn";
            this.typeObuchDataGridViewTextBoxColumn.Width = 125;
            // 
            // typePractikDataGridViewTextBoxColumn
            // 
            this.typePractikDataGridViewTextBoxColumn.DataPropertyName = "TypePractik";
            this.typePractikDataGridViewTextBoxColumn.HeaderText = "TypePractik";
            this.typePractikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typePractikDataGridViewTextBoxColumn.Name = "typePractikDataGridViewTextBoxColumn";
            this.typePractikDataGridViewTextBoxColumn.Width = 125;
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
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(1092, 208);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(252, 60);
            this.BtnAdd.TabIndex = 51;
            this.BtnAdd.Text = "Сформировать";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1353, 645);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        public System.Windows.Forms.Button BtnAdd;
    }
}