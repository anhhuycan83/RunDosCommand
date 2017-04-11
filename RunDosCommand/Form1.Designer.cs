namespace RunDosCommand
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtGPSPFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGPSPFile = new System.Windows.Forms.Button();
            this.dtpBeginning = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnding = new System.Windows.Forms.Label();
            this.dtpEnding = new System.Windows.Forms.DateTimePicker();
            this.btnINIFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtINIFile = new System.Windows.Forms.TextBox();
            this.btnLogFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogFolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(116, 156);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 156);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtGPSPFile
            // 
            this.txtGPSPFile.Location = new System.Drawing.Point(70, 15);
            this.txtGPSPFile.Name = "txtGPSPFile";
            this.txtGPSPFile.Size = new System.Drawing.Size(149, 20);
            this.txtGPSPFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "GPSP file";
            // 
            // btnGPSPFile
            // 
            this.btnGPSPFile.Location = new System.Drawing.Point(225, 13);
            this.btnGPSPFile.Name = "btnGPSPFile";
            this.btnGPSPFile.Size = new System.Drawing.Size(34, 23);
            this.btnGPSPFile.TabIndex = 4;
            this.btnGPSPFile.Text = "...";
            this.btnGPSPFile.UseVisualStyleBackColor = true;
            this.btnGPSPFile.Click += new System.EventHandler(this.btnGPSPFile_Click);
            // 
            // dtpBeginning
            // 
            this.dtpBeginning.CustomFormat = "MM/dd/yyyy";
            this.dtpBeginning.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginning.Location = new System.Drawing.Point(70, 100);
            this.dtpBeginning.Name = "dtpBeginning";
            this.dtpBeginning.Size = new System.Drawing.Size(121, 20);
            this.dtpBeginning.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Begin";
            // 
            // lblEnding
            // 
            this.lblEnding.AutoSize = true;
            this.lblEnding.Location = new System.Drawing.Point(35, 129);
            this.lblEnding.Name = "lblEnding";
            this.lblEnding.Size = new System.Drawing.Size(26, 13);
            this.lblEnding.TabIndex = 7;
            this.lblEnding.Text = "End";
            // 
            // dtpEnding
            // 
            this.dtpEnding.CustomFormat = "MM/dd/yyyy";
            this.dtpEnding.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnding.Location = new System.Drawing.Point(70, 126);
            this.dtpEnding.Name = "dtpEnding";
            this.dtpEnding.Size = new System.Drawing.Size(121, 20);
            this.dtpEnding.TabIndex = 8;
            // 
            // btnINIFile
            // 
            this.btnINIFile.Location = new System.Drawing.Point(225, 42);
            this.btnINIFile.Name = "btnINIFile";
            this.btnINIFile.Size = new System.Drawing.Size(34, 23);
            this.btnINIFile.TabIndex = 11;
            this.btnINIFile.Text = "...";
            this.btnINIFile.UseVisualStyleBackColor = true;
            this.btnINIFile.Click += new System.EventHandler(this.btnINIFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ini file";
            // 
            // txtINIFile
            // 
            this.txtINIFile.Location = new System.Drawing.Point(70, 44);
            this.txtINIFile.Name = "txtINIFile";
            this.txtINIFile.Size = new System.Drawing.Size(149, 20);
            this.txtINIFile.TabIndex = 9;
            // 
            // btnLogFolder
            // 
            this.btnLogFolder.Location = new System.Drawing.Point(225, 71);
            this.btnLogFolder.Name = "btnLogFolder";
            this.btnLogFolder.Size = new System.Drawing.Size(34, 23);
            this.btnLogFolder.TabIndex = 14;
            this.btnLogFolder.Text = "...";
            this.btnLogFolder.UseVisualStyleBackColor = true;
            this.btnLogFolder.Click += new System.EventHandler(this.btnLogFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Log folder";
            // 
            // txtLogFolder
            // 
            this.txtLogFolder.Location = new System.Drawing.Point(70, 73);
            this.txtLogFolder.Name = "txtLogFolder";
            this.txtLogFolder.Size = new System.Drawing.Size(149, 20);
            this.txtLogFolder.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogFolder);
            this.Controls.Add(this.btnINIFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtINIFile);
            this.Controls.Add(this.dtpEnding);
            this.Controls.Add(this.lblEnding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBeginning);
            this.Controls.Add(this.btnGPSPFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGPSPFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGPSPFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGPSPFile;
        private System.Windows.Forms.DateTimePicker dtpBeginning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnding;
        private System.Windows.Forms.DateTimePicker dtpEnding;
        private System.Windows.Forms.Button btnINIFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtINIFile;
        private System.Windows.Forms.Button btnLogFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogFolder;
    }
}

