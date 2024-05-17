namespace Ultimate_RenPy_Decompiler
{
    partial class RPADECOMPILER
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DEC = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CHS_FILE = new System.Windows.Forms.Button();
            this.TXT_FILE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.DEC);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 400);
            this.panel1.TabIndex = 1;
            // 
            // DEC
            // 
            this.DEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DEC.FlatAppearance.BorderSize = 0;
            this.DEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DEC.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DEC.Location = new System.Drawing.Point(332, 158);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(112, 32);
            this.DEC.TabIndex = 5;
            this.DEC.Tag = "false";
            this.DEC.Text = "DECOMPILE!";
            this.DEC.UseVisualStyleBackColor = false;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.CHS_FILE);
            this.panel2.Controls.Add(this.TXT_FILE);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 48);
            this.panel2.TabIndex = 3;
            // 
            // CHS_FILE
            // 
            this.CHS_FILE.FlatAppearance.BorderSize = 0;
            this.CHS_FILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHS_FILE.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHS_FILE.Location = new System.Drawing.Point(3, 9);
            this.CHS_FILE.Name = "CHS_FILE";
            this.CHS_FILE.Size = new System.Drawing.Size(75, 30);
            this.CHS_FILE.TabIndex = 2;
            this.CHS_FILE.Text = "Choose";
            this.CHS_FILE.UseVisualStyleBackColor = true;
            this.CHS_FILE.Click += new System.EventHandler(this.CHS_FILE_Click);
            // 
            // TXT_FILE
            // 
            this.TXT_FILE.AutoSize = true;
            this.TXT_FILE.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT_FILE.Location = new System.Drawing.Point(84, 13);
            this.TXT_FILE.Name = "TXT_FILE";
            this.TXT_FILE.Size = new System.Drawing.Size(55, 22);
            this.TXT_FILE.TabIndex = 1;
            this.TXT_FILE.Text = "Empty";
            this.TXT_FILE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Where is \'game\' folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 159);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose where is \'game\' folder it`s like C://Games/visualnovel/game/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "After You Hit The \'Decompile\' Button You Need To Start Game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "After This You Can See In \'game\' Folder file .rpy, This Is Decompiled Files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(262, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thank You 4 Using, Good Luck!";
            // 
            // RPADECOMPILER
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RPADECOMPILER";
            this.Size = new System.Drawing.Size(800, 448);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CHS_FILE;
        private System.Windows.Forms.Label TXT_FILE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
