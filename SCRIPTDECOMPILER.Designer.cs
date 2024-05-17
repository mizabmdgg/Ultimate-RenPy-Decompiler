namespace Ultimate_RenPy_Decompiler
{
    partial class SCRIPTDECOMPILER
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OPN_OUT_DIR = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.DEC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CHS_OUT = new System.Windows.Forms.Button();
            this.TXT_OUTFOLDER = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CHS_FILE = new System.Windows.Forms.Button();
            this.TXT_FILE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.DEC);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.OPN_OUT_DIR);
            this.panel4.Controls.Add(this.log);
            this.panel4.Location = new System.Drawing.Point(3, 307);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 90);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // OPN_OUT_DIR
            // 
            this.OPN_OUT_DIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.OPN_OUT_DIR.FlatAppearance.BorderSize = 0;
            this.OPN_OUT_DIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OPN_OUT_DIR.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OPN_OUT_DIR.Location = new System.Drawing.Point(314, 16);
            this.OPN_OUT_DIR.Name = "OPN_OUT_DIR";
            this.OPN_OUT_DIR.Size = new System.Drawing.Size(142, 30);
            this.OPN_OUT_DIR.TabIndex = 1;
            this.OPN_OUT_DIR.Text = "Open Out Directory";
            this.OPN_OUT_DIR.UseVisualStyleBackColor = false;
            this.OPN_OUT_DIR.Click += new System.EventHandler(this.OPN_OUT_DIR_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(3, 56);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(764, 18);
            this.log.TabIndex = 0;
            this.log.Text = "blah blah blah";
            this.log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEC
            // 
            this.DEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.DEC.FlatAppearance.BorderSize = 0;
            this.DEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DEC.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DEC.Location = new System.Drawing.Point(332, 258);
            this.DEC.Name = "DEC";
            this.DEC.Size = new System.Drawing.Size(112, 32);
            this.DEC.TabIndex = 5;
            this.DEC.Tag = "false";
            this.DEC.Text = "DECOMPILE!";
            this.DEC.UseVisualStyleBackColor = false;
            this.DEC.Click += new System.EventHandler(this.DEC_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.CHS_OUT);
            this.panel3.Controls.Add(this.TXT_OUTFOLDER);
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 48);
            this.panel3.TabIndex = 4;
            // 
            // CHS_OUT
            // 
            this.CHS_OUT.FlatAppearance.BorderSize = 0;
            this.CHS_OUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHS_OUT.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHS_OUT.Location = new System.Drawing.Point(3, 9);
            this.CHS_OUT.Name = "CHS_OUT";
            this.CHS_OUT.Size = new System.Drawing.Size(75, 30);
            this.CHS_OUT.TabIndex = 2;
            this.CHS_OUT.Text = "Choose";
            this.CHS_OUT.UseVisualStyleBackColor = true;
            this.CHS_OUT.Click += new System.EventHandler(this.CHS_OUT_Click);
            // 
            // TXT_OUTFOLDER
            // 
            this.TXT_OUTFOLDER.AutoSize = true;
            this.TXT_OUTFOLDER.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT_OUTFOLDER.Location = new System.Drawing.Point(84, 13);
            this.TXT_OUTFOLDER.Name = "TXT_OUTFOLDER";
            this.TXT_OUTFOLDER.Size = new System.Drawing.Size(55, 22);
            this.TXT_OUTFOLDER.TabIndex = 1;
            this.TXT_OUTFOLDER.Text = "Empty";
            this.TXT_OUTFOLDER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.CHS_FILE);
            this.panel2.Controls.Add(this.TXT_FILE);
            this.panel2.Location = new System.Drawing.Point(0, 75);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(322, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Out Directory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(330, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rpa Archive";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SCRIPTDECOMPILER
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SCRIPTDECOMPILER";
            this.Size = new System.Drawing.Size(800, 448);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CHS_FILE;
        private System.Windows.Forms.Label TXT_FILE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DEC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CHS_OUT;
        private System.Windows.Forms.Label TXT_OUTFOLDER;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button OPN_OUT_DIR;
    }
}
