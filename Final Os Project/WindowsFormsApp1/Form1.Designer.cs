namespace WindowsFormsApp1
{
    partial class frmform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmform));
            this.btncreate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnmove = new System.Windows.Forms.Button();
            this.btnrename = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.browser = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.npath = new System.Windows.Forms.TextBox();
            this.newpath = new System.Windows.Forms.Label();
            this.Nname = new System.Windows.Forms.Label();
            this.NN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btncreate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(38, 27);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(301, 88);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Create Folder";
            this.btncreate.UseVisualStyleBackColor = false;
            this.btncreate.Click += new System.EventHandler(this.CreFol_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btndelete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(38, 132);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(301, 84);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete Folder";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnmove
            // 
            this.btnmove.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnmove.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmove.Location = new System.Drawing.Point(38, 237);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(301, 84);
            this.btnmove.TabIndex = 2;
            this.btnmove.Text = "Move Folder";
            this.btnmove.UseVisualStyleBackColor = false;
            this.btnmove.Click += new System.EventHandler(this.btnmove_Click);
            // 
            // btnrename
            // 
            this.btnrename.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnrename.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrename.Location = new System.Drawing.Point(38, 351);
            this.btnrename.Name = "btnrename";
            this.btnrename.Size = new System.Drawing.Size(301, 84);
            this.btnrename.TabIndex = 3;
            this.btnrename.Text = "Rename Folder";
            this.btnrename.UseVisualStyleBackColor = false;
            this.btnrename.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(362, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(362, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete File";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(362, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "Move File";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(362, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(320, 84);
            this.button4.TabIndex = 7;
            this.button4.Text = "Rename File";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.SystemColors.MenuBar;
            this.path.Location = new System.Drawing.Point(846, 70);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(273, 22);
            this.path.TabIndex = 8;
            // 
            // browser
            // 
            this.browser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.browser.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browser.Location = new System.Drawing.Point(1125, 59);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(118, 37);
            this.browser.TabIndex = 9;
            this.browser.Text = "Select Folder";
            this.browser.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.name.Location = new System.Drawing.Point(846, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(273, 22);
            this.name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(692, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(692, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // npath
            // 
            this.npath.BackColor = System.Drawing.SystemColors.MenuBar;
            this.npath.Location = new System.Drawing.Point(850, 193);
            this.npath.Name = "npath";
            this.npath.Size = new System.Drawing.Size(273, 22);
            this.npath.TabIndex = 13;
            // 
            // newpath
            // 
            this.newpath.AutoSize = true;
            this.newpath.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newpath.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpath.ForeColor = System.Drawing.SystemColors.Info;
            this.newpath.Location = new System.Drawing.Point(692, 179);
            this.newpath.Name = "newpath";
            this.newpath.Size = new System.Drawing.Size(134, 37);
            this.newpath.TabIndex = 14;
            this.newpath.Text = "New Path";
            // 
            // Nname
            // 
            this.Nname.AutoSize = true;
            this.Nname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nname.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nname.ForeColor = System.Drawing.SystemColors.Info;
            this.Nname.Location = new System.Drawing.Point(688, 247);
            this.Nname.Name = "Nname";
            this.Nname.Size = new System.Drawing.Size(152, 37);
            this.Nname.TabIndex = 15;
            this.Nname.Text = "New Name";
            // 
            // NN
            // 
            this.NN.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NN.Location = new System.Drawing.Point(850, 262);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(273, 22);
            this.NN.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(698, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Path";
            // 
            // frmform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.Nname);
            this.Controls.Add(this.newpath);
            this.Controls.Add(this.npath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrename);
            this.Controls.Add(this.btnmove);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btncreate);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmform";
            this.Text = "File Manager";
  
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.Button btnrename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button browser;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox npath;
        private System.Windows.Forms.Label newpath;
        private System.Windows.Forms.Label Nname;
        private System.Windows.Forms.TextBox NN;
        private System.Windows.Forms.Label label3;
    }
}

