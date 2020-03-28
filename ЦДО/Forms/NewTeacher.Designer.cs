namespace ЦДО
{
    partial class NewTeacher
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
            this.label7 = new System.Windows.Forms.Label();
            this.BtnTypeNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbFIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbDiscipline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(40, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "Преподаваемые дисциплины";
            // 
            // BtnTypeNew
            // 
            this.BtnTypeNew.BackColor = System.Drawing.Color.Blue;
            this.BtnTypeNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTypeNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTypeNew.Location = new System.Drawing.Point(418, 338);
            this.BtnTypeNew.Name = "BtnTypeNew";
            this.BtnTypeNew.Size = new System.Drawing.Size(192, 57);
            this.BtnTypeNew.TabIndex = 51;
            this.BtnTypeNew.Text = "Добавить";
            this.BtnTypeNew.UseVisualStyleBackColor = false;
            this.BtnTypeNew.Click += new System.EventHandler(this.BtnTypeNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(40, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 29);
            this.label6.TabIndex = 50;
            this.label6.Text = "ФИО преподавателя";
            // 
            // TbFIO
            // 
            this.TbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbFIO.Location = new System.Drawing.Point(418, 86);
            this.TbFIO.Multiline = true;
            this.TbFIO.Name = "TbFIO";
            this.TbFIO.Size = new System.Drawing.Size(555, 120);
            this.TbFIO.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(333, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 32);
            this.label3.TabIndex = 48;
            this.label3.Text = "Добавление преподавателя";
            // 
            // TbDiscipline
            // 
            this.TbDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbDiscipline.Location = new System.Drawing.Point(418, 232);
            this.TbDiscipline.Multiline = true;
            this.TbDiscipline.Name = "TbDiscipline";
            this.TbDiscipline.Size = new System.Drawing.Size(555, 82);
            this.TbDiscipline.TabIndex = 54;
            // 
            // NewTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1002, 407);
            this.Controls.Add(this.TbDiscipline);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnTypeNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbFIO);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1020, 714);
            this.Name = "NewTeacher";
            this.Text = "Добавление преподавателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnTypeNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbFIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbDiscipline;
    }
}