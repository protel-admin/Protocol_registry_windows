using System;

namespace ProtocolRegiryWindows
{
    partial class frmProtoColRegister
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGetInstalledPrinter = new System.Windows.Forms.Button();
            this.CboInstalledPrinter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReadRegistry = new System.Windows.Forms.Button();
            this.BtnRegiter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.txtprotocolUrl = new System.Windows.Forms.TextBox();
            this.txtProtocol = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGetInstalledPrinter);
            this.groupBox1.Controls.Add(this.CboInstalledPrinter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnReadRegistry);
            this.groupBox1.Controls.Add(this.BtnRegiter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtExePath);
            this.groupBox1.Controls.Add(this.txtprotocolUrl);
            this.groupBox1.Controls.Add(this.txtProtocol);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // BtnGetInstalledPrinter
            // 
            this.BtnGetInstalledPrinter.Location = new System.Drawing.Point(426, 134);
            this.BtnGetInstalledPrinter.Name = "BtnGetInstalledPrinter";
            this.BtnGetInstalledPrinter.Size = new System.Drawing.Size(132, 23);
            this.BtnGetInstalledPrinter.TabIndex = 12;
            this.BtnGetInstalledPrinter.Text = "GetInstalledPrinters";
            this.BtnGetInstalledPrinter.UseVisualStyleBackColor = true;
            this.BtnGetInstalledPrinter.Click += new System.EventHandler(this.BtnGetInstalledPrinter_Click);
            // 
            // CboInstalledPrinter
            // 
            this.CboInstalledPrinter.FormattingEnabled = true;
            this.CboInstalledPrinter.Location = new System.Drawing.Point(143, 133);
            this.CboInstalledPrinter.Name = "CboInstalledPrinter";
            this.CboInstalledPrinter.Size = new System.Drawing.Size(272, 21);
            this.CboInstalledPrinter.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Printer Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnReadRegistry
            // 
            this.BtnReadRegistry.Location = new System.Drawing.Point(426, 20);
            this.BtnReadRegistry.Name = "BtnReadRegistry";
            this.BtnReadRegistry.Size = new System.Drawing.Size(132, 23);
            this.BtnReadRegistry.TabIndex = 8;
            this.BtnReadRegistry.Text = "Read Registry";
            this.BtnReadRegistry.UseVisualStyleBackColor = true;
            this.BtnReadRegistry.Click += new System.EventHandler(this.BtnReadRegistry_Click);
            // 
            // BtnRegiter
            // 
            this.BtnRegiter.Location = new System.Drawing.Point(192, 180);
            this.BtnRegiter.Name = "BtnRegiter";
            this.BtnRegiter.Size = new System.Drawing.Size(138, 42);
            this.BtnRegiter.TabIndex = 7;
            this.BtnRegiter.Text = "Write Registry";
            this.BtnRegiter.UseVisualStyleBackColor = true;
            this.BtnRegiter.Click += new System.EventHandler(this.BtnRegiter_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Handler EXE Path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL Protocol";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Protocol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(426, 99);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(132, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtExePath
            // 
            this.txtExePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExePath.Location = new System.Drawing.Point(143, 99);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.Size = new System.Drawing.Size(277, 20);
            this.txtExePath.TabIndex = 3;
            // 
            // txtprotocolUrl
            // 
            this.txtprotocolUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprotocolUrl.Location = new System.Drawing.Point(143, 59);
            this.txtprotocolUrl.Name = "txtprotocolUrl";
            this.txtprotocolUrl.Size = new System.Drawing.Size(277, 20);
            this.txtprotocolUrl.TabIndex = 2;
            // 
            // txtProtocol
            // 
            this.txtProtocol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProtocol.Location = new System.Drawing.Point(143, 20);
            this.txtProtocol.Name = "txtProtocol";
            this.txtProtocol.Size = new System.Drawing.Size(277, 20);
            this.txtProtocol.TabIndex = 0;
            this.txtProtocol.Text = "plplprint";
            this.txtProtocol.TextChanged += new System.EventHandler(this.txtProtocol_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProtoColRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 287);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProtoColRegister";
            this.Text = "PLPL -Printer- Protocol Register";
            this.Load += new System.EventHandler(this.FrmProtoColRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.TextBox txtprotocolUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProtocol;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Button BtnRegiter;
        private System.Windows.Forms.Button BtnReadRegistry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboInstalledPrinter;
        private System.Windows.Forms.Button BtnGetInstalledPrinter;
    }
}

