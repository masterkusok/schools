namespace WindowsFormsApp1
{
    partial class studentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bprofile = new System.Windows.Forms.Button();
            this.bdiary = new System.Windows.Forms.Button();
            this.bmyschool = new System.Windows.Forms.Button();
            this.btimetable = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ученик";
            // 
            // bprofile
            // 
            this.bprofile.Location = new System.Drawing.Point(149, 84);
            this.bprofile.Name = "bprofile";
            this.bprofile.Size = new System.Drawing.Size(75, 32);
            this.bprofile.TabIndex = 1;
            this.bprofile.Text = "профиль";
            this.bprofile.UseVisualStyleBackColor = true;
            this.bprofile.Click += new System.EventHandler(this.bprofile_Click);
            // 
            // bdiary
            // 
            this.bdiary.Location = new System.Drawing.Point(276, 84);
            this.bdiary.Name = "bdiary";
            this.bdiary.Size = new System.Drawing.Size(75, 32);
            this.bdiary.TabIndex = 2;
            this.bdiary.Text = "дневник";
            this.bdiary.UseVisualStyleBackColor = true;
            this.bdiary.Click += new System.EventHandler(this.bdiary_Click);
            // 
            // bmyschool
            // 
            this.bmyschool.Location = new System.Drawing.Point(389, 84);
            this.bmyschool.Name = "bmyschool";
            this.bmyschool.Size = new System.Drawing.Size(130, 33);
            this.bmyschool.TabIndex = 3;
            this.bmyschool.Text = "моя школа";
            this.bmyschool.UseVisualStyleBackColor = true;
            // 
            // btimetable
            // 
            this.btimetable.Location = new System.Drawing.Point(559, 84);
            this.btimetable.Name = "btimetable";
            this.btimetable.Size = new System.Drawing.Size(130, 32);
            this.btimetable.TabIndex = 4;
            this.btimetable.Text = "Рассписание";
            this.btimetable.UseVisualStyleBackColor = true;
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(695, 326);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(82, 32);
            this.bexit.TabIndex = 5;
            this.bexit.Text = "Выход";
            this.bexit.UseVisualStyleBackColor = true;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.btimetable);
            this.Controls.Add(this.bmyschool);
            this.Controls.Add(this.bdiary);
            this.Controls.Add(this.bprofile);
            this.Controls.Add(this.label1);
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bprofile;
        private System.Windows.Forms.Button bdiary;
        private System.Windows.Forms.Button bmyschool;
        private System.Windows.Forms.Button btimetable;
        private System.Windows.Forms.Button bexit;
    }
}