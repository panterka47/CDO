namespace ЦДО.Forms
{
    partial class Documents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridDocuments = new System.Windows.Forms.DataGridView();
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
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDODataSet1 = new ЦДО.BD.CDODataSet();
            this.BtnEditDoc = new System.Windows.Forms.Button();
            this.BtnAddDoc = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.documentsTableAdapter1 = new ЦДО.BD.CDODataSetTableAdapters.DocumentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.CbTypeDoc = new System.Windows.Forms.ComboBox();
            this.typeProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeProgTableAdapter = new ЦДО.BD.CDODataSetTableAdapters.TypeProgTableAdapter();
            this.dateTimeOt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 120);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(218, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Документы об окончании обучения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ЦДО.Properties.Resources.значок1;
            this.pictureBox1.Location = new System.Drawing.Point(983, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridDocuments
            // 
            this.dataGridDocuments.AutoGenerateColumns = false;
            this.dataGridDocuments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridDocuments.DataSource = this.documentsBindingSource;
            this.dataGridDocuments.Location = new System.Drawing.Point(60, 169);
            this.dataGridDocuments.Name = "dataGridDocuments";
            this.dataGridDocuments.RowTemplate.Height = 24;
            this.dataGridDocuments.Size = new System.Drawing.Size(740, 265);
            this.dataGridDocuments.TabIndex = 3;
            this.dataGridDocuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDocuments_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Group";
            this.dataGridViewTextBoxColumn3.HeaderText = "Group";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdStudent";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StatusDoc";
            this.dataGridViewTextBoxColumn5.HeaderText = "StatusDoc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Utrata";
            this.dataGridViewTextBoxColumn6.HeaderText = "Utrata";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Obmen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Obmen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Unichtog";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unichtog";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SeriesDoc";
            this.dataGridViewTextBoxColumn9.HeaderText = "SeriesDoc";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NumberDoc";
            this.dataGridViewTextBoxColumn10.HeaderText = "NumberDoc";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RegNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "RegNumber";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.cDODataSet1;
            // 
            // cDODataSet1
            // 
            this.cDODataSet1.DataSetName = "CDODataSet";
            this.cDODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnEditDoc
            // 
            this.BtnEditDoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditDoc.Location = new System.Drawing.Point(831, 261);
            this.BtnEditDoc.Name = "BtnEditDoc";
            this.BtnEditDoc.Size = new System.Drawing.Size(252, 60);
            this.BtnEditDoc.TabIndex = 58;
            this.BtnEditDoc.Text = "Изменить";
            this.BtnEditDoc.UseVisualStyleBackColor = false;
            // 
            // BtnAddDoc
            // 
            this.BtnAddDoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddDoc.Location = new System.Drawing.Point(831, 169);
            this.BtnAddDoc.Name = "BtnAddDoc";
            this.BtnAddDoc.Size = new System.Drawing.Size(252, 60);
            this.BtnAddDoc.TabIndex = 57;
            this.BtnAddDoc.Text = "Добавить";
            this.BtnAddDoc.UseVisualStyleBackColor = false;
            this.BtnAddDoc.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExit.Location = new System.Drawing.Point(831, 460);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(252, 60);
            this.BtnExit.TabIndex = 60;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBack.Location = new System.Drawing.Point(831, 359);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(252, 60);
            this.BtnBack.TabIndex = 59;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // documentsTableAdapter1
            // 
            this.documentsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(131, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 60);
            this.button1.TabIndex = 61;
            this.button1.Text = "Сформировать отчет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbTypeDoc
            // 
            this.CbTypeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbTypeDoc.FormattingEnabled = true;
            this.CbTypeDoc.Items.AddRange(new object[] {
            "Диплом",
            "Удостоверение",
            "Сертификат"});
            this.CbTypeDoc.Location = new System.Drawing.Point(237, 546);
            this.CbTypeDoc.Name = "CbTypeDoc";
            this.CbTypeDoc.Size = new System.Drawing.Size(281, 33);
            this.CbTypeDoc.TabIndex = 62;
            // 
            // typeProgBindingSource
            // 
            this.typeProgBindingSource.DataMember = "TypeProg";
            this.typeProgBindingSource.DataSource = this.cDODataSet1;
            // 
            // typeProgTableAdapter
            // 
            this.typeProgTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimeOt
            // 
            this.dateTimeOt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeOt.Location = new System.Drawing.Point(98, 488);
            this.dateTimeOt.Name = "dateTimeOt";
            this.dateTimeOt.Size = new System.Drawing.Size(200, 30);
            this.dateTimeOt.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Период";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(320, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "До";
            // 
            // dateTimeDo
            // 
            this.dateTimeDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeDo.Location = new System.Drawing.Point(380, 488);
            this.dateTimeDo.Name = "dateTimeDo";
            this.dateTimeDo.Size = new System.Drawing.Size(200, 30);
            this.dateTimeDo.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Тип документа";
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1104, 684);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeOt);
            this.Controls.Add(this.CbTypeDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnEditDoc);
            this.Controls.Add(this.BtnAddDoc);
            this.Controls.Add(this.dataGridDocuments);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Documents";
            this.Text = "Документы об окончании";
            this.Load += new System.EventHandler(this.Documents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeProgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridDocuments;
        private BD.CDODataSet cDODataSet;
        private BD.CDODataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unichtogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEditDoc;
        private System.Windows.Forms.Button BtnAddDoc;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBack;
        private BD.CDODataSet cDODataSet1;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private BD.CDODataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CbTypeDoc;
        private System.Windows.Forms.BindingSource typeProgBindingSource;
        private BD.CDODataSetTableAdapters.TypeProgTableAdapter typeProgTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeOt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeDo;
        private System.Windows.Forms.Label label5;
    }
}