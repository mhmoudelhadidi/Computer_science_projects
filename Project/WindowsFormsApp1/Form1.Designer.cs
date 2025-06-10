namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.RichTextBox();
            this.txtserverport = new System.Windows.Forms.TextBox();
            this.btnstartserver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendtoAllClients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnewclient = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.Client_List = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Port";
            // 
            // txtlog
            // 
            this.txtlog.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtlog.Location = new System.Drawing.Point(10, 192);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(287, 89);
            this.txtlog.TabIndex = 2;
            this.txtlog.Text = "";
            this.txtlog.TextChanged += new System.EventHandler(this.txtlog_TextChanged);
            // 
            // txtserverport
            // 
            this.txtserverport.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtserverport.Location = new System.Drawing.Point(91, 105);
            this.txtserverport.Name = "txtserverport";
            this.txtserverport.Size = new System.Drawing.Size(206, 22);
            this.txtserverport.TabIndex = 3;
            // 
            // btnstartserver
            // 
            this.btnstartserver.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.btnstartserver.Location = new System.Drawing.Point(91, 133);
            this.btnstartserver.Name = "btnstartserver";
            this.btnstartserver.Size = new System.Drawing.Size(93, 32);
            this.btnstartserver.TabIndex = 4;
            this.btnstartserver.Text = "Start Server";
            this.btnstartserver.UseVisualStyleBackColor = true;
            this.btnstartserver.Click += new System.EventHandler(this.btnstartserver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label2.Location = new System.Drawing.Point(9, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log";
            // 
            // txtSendtoAllClients
            // 
            this.txtSendtoAllClients.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtSendtoAllClients.Location = new System.Drawing.Point(10, 436);
            this.txtSendtoAllClients.Name = "txtSendtoAllClients";
            this.txtSendtoAllClients.Size = new System.Drawing.Size(287, 22);
            this.txtSendtoAllClients.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label3.Location = new System.Drawing.Point(7, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send to all Clients";
            // 
            // btnnewclient
            // 
            this.btnnewclient.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.btnnewclient.Location = new System.Drawing.Point(204, 133);
            this.btnnewclient.Name = "btnnewclient";
            this.btnnewclient.Size = new System.Drawing.Size(93, 32);
            this.btnnewclient.TabIndex = 8;
            this.btnnewclient.Text = "New Client";
            this.btnnewclient.UseVisualStyleBackColor = true;
            this.btnnewclient.Click += new System.EventHandler(this.btnnewclient_Click);
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.btnsend.Location = new System.Drawing.Point(10, 477);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(121, 43);
            this.btnsend.TabIndex = 9;
            this.btnsend.Text = "Send To All Clients";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(108, 68);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(76, 13);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Discoonected ";
            // 
            // Client_List
            // 
            this.Client_List.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_List.FormattingEnabled = true;
            this.Client_List.Location = new System.Drawing.Point(10, 302);
            this.Client_List.Name = "Client_List";
            this.Client_List.Size = new System.Drawing.Size(287, 94);
            this.Client_List.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.button2.Location = new System.Drawing.Point(176, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Send To Selected Clients";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Client_List);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnnewclient);
            this.Controls.Add(this.txtSendtoAllClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstartserver);
            this.Controls.Add(this.txtserverport);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtlog;
        private System.Windows.Forms.TextBox txtserverport;
        private System.Windows.Forms.Button btnstartserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendtoAllClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnewclient;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.CheckedListBox Client_List;
        private System.Windows.Forms.Button button2;
    }
}

