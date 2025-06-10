using System;

namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnConnecttoServer = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPortnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtsendtoServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsendtoserver = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnecttoServer
            // 
            this.btnConnecttoServer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.btnConnecttoServer.Location = new System.Drawing.Point(88, 192);
            this.btnConnecttoServer.Name = "btnConnecttoServer";
            this.btnConnecttoServer.Size = new System.Drawing.Size(207, 30);
            this.btnConnecttoServer.TabIndex = 7;
            this.btnConnecttoServer.Text = "Connect to Server";
            this.btnConnecttoServer.UseVisualStyleBackColor = true;
            this.btnConnecttoServer.Click += new System.EventHandler(this.btnConnecttoServer_Click);
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtIp.Location = new System.Drawing.Point(89, 109);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(207, 22);
            this.txtIp.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPortnum
            // 
            this.txtPortnum.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtPortnum.Location = new System.Drawing.Point(89, 153);
            this.txtPortnum.Name = "txtPortnum";
            this.txtPortnum.Size = new System.Drawing.Size(207, 22);
            this.txtPortnum.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port Num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtLog.Location = new System.Drawing.Point(8, 243);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(289, 132);
            this.txtLog.TabIndex = 11;
            this.txtLog.Text = "";
            // 
            // txtsendtoServer
            // 
            this.txtsendtoServer.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.txtsendtoServer.Location = new System.Drawing.Point(8, 409);
            this.txtsendtoServer.Name = "txtsendtoServer";
            this.txtsendtoServer.Size = new System.Drawing.Size(288, 22);
            this.txtsendtoServer.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label4.Location = new System.Drawing.Point(5, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Message";
            // 
            // btnsendtoserver
            // 
            this.btnsendtoserver.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.btnsendtoserver.Location = new System.Drawing.Point(8, 449);
            this.btnsendtoserver.Name = "btnsendtoserver";
            this.btnsendtoserver.Size = new System.Drawing.Size(288, 42);
            this.btnsendtoserver.TabIndex = 15;
            this.btnsendtoserver.Text = "Send to Server";
            this.btnsendtoserver.UseVisualStyleBackColor = true;
            this.btnsendtoserver.Click += new System.EventHandler(this.btnsendtoserver_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(110, 71);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(76, 13);
            this.lblstatus.TabIndex = 16;
            this.lblstatus.Text = "Discoonected ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 514);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnsendtoserver);
            this.Controls.Add(this.txtsendtoServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPortnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnecttoServer);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form2";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnecttoServer;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPortnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtsendtoServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsendtoserver;
        private System.Windows.Forms.Label lblstatus;
    }
}