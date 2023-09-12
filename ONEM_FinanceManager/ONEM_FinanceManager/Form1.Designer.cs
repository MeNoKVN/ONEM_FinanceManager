namespace ONEM_FinanceManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl22 = new ONEM_FinanceManager.UserControl2();
            this.userControl32 = new ONEM_FinanceManager.UserControl3();
            this.userControl12 = new ONEM_FinanceManager.UserControl1();
            this.userControl31 = new ONEM_FinanceManager.UserControl3();
            this.userControl21 = new ONEM_FinanceManager.UserControl2();
            this.userControl11 = new ONEM_FinanceManager.UserControl1();
            this.userControl33 = new ONEM_FinanceManager.UserControl3();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Income";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Spendings";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Overview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControl33);
            this.groupBox1.Controls.Add(this.userControl22);
            this.groupBox1.Controls.Add(this.userControl32);
            this.groupBox1.Controls.Add(this.userControl12);
            this.groupBox1.Controls.Add(this.userControl31);
            this.groupBox1.Controls.Add(this.userControl21);
            this.groupBox1.Controls.Add(this.userControl11);
            this.groupBox1.Location = new System.Drawing.Point(211, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 541);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "FinanceManager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userControl22
            // 
            this.userControl22.Location = new System.Drawing.Point(98, 57);
            this.userControl22.Name = "userControl22";
            this.userControl22.Size = new System.Drawing.Size(591, 353);
            this.userControl22.TabIndex = 5;
            // 
            // userControl32
            // 
            this.userControl32.Location = new System.Drawing.Point(56, 27);
            this.userControl32.Name = "userControl32";
            this.userControl32.Size = new System.Drawing.Size(510, 401);
            this.userControl32.TabIndex = 4;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(48, 19);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(726, 455);
            this.userControl12.TabIndex = 3;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(242, 38);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(510, 401);
            this.userControl31.TabIndex = 2;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(161, 83);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(591, 353);
            this.userControl21.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(48, 38);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(726, 455);
            this.userControl11.TabIndex = 0;
            // 
            // userControl33
            // 
            this.userControl33.Location = new System.Drawing.Point(106, 65);
            this.userControl33.Name = "userControl33";
            this.userControl33.Size = new System.Drawing.Size(510, 401);
            this.userControl33.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ONEM_FinanceManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private UserControl1 userControl11;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl2 userControl22;
        private UserControl3 userControl32;
        private UserControl1 userControl12;
        private UserControl3 userControl33;
    }
}

