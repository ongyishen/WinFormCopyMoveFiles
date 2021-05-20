namespace WinCopyFiles
{
    partial class FormMain
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkOutputFileName = new System.Windows.Forms.CheckBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseFrom = new System.Windows.Forms.Button();
            this.btnOpenFrom = new System.Windows.Forms.Button();
            this.btnOpenTo = new System.Windows.Forms.Button();
            this.btnBrowseTo = new System.Windows.Forms.Button();
            this.chkApplyOp = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOp = new System.Windows.Forms.ComboBox();
            this.dtpLastWriteTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(644, 189);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(143, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "-";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(644, 163);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(143, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy File(s)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(12, 217);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(775, 186);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 191);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(626, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From Path";
            // 
            // chkOutputFileName
            // 
            this.chkOutputFileName.AutoSize = true;
            this.chkOutputFileName.Location = new System.Drawing.Point(15, 163);
            this.chkOutputFileName.Name = "chkOutputFileName";
            this.chkOutputFileName.Size = new System.Drawing.Size(108, 17);
            this.chkOutputFileName.TabIndex = 5;
            this.chkOutputFileName.Text = "Output File Name";
            this.chkOutputFileName.UseVisualStyleBackColor = true;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(108, 6);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(447, 20);
            this.txtFrom.TabIndex = 6;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(108, 32);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(447, 20);
            this.txtTo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Path";
            // 
            // btnBrowseFrom
            // 
            this.btnBrowseFrom.Location = new System.Drawing.Point(561, 4);
            this.btnBrowseFrom.Name = "btnBrowseFrom";
            this.btnBrowseFrom.Size = new System.Drawing.Size(77, 23);
            this.btnBrowseFrom.TabIndex = 9;
            this.btnBrowseFrom.Text = "Browse";
            this.btnBrowseFrom.UseVisualStyleBackColor = true;
            this.btnBrowseFrom.Click += new System.EventHandler(this.btnBrowseFrom_Click);
            // 
            // btnOpenFrom
            // 
            this.btnOpenFrom.Location = new System.Drawing.Point(647, 4);
            this.btnOpenFrom.Name = "btnOpenFrom";
            this.btnOpenFrom.Size = new System.Drawing.Size(57, 23);
            this.btnOpenFrom.TabIndex = 10;
            this.btnOpenFrom.Text = "Open";
            this.btnOpenFrom.UseVisualStyleBackColor = true;
            this.btnOpenFrom.Click += new System.EventHandler(this.btnOpenFrom_Click);
            // 
            // btnOpenTo
            // 
            this.btnOpenTo.Location = new System.Drawing.Point(647, 30);
            this.btnOpenTo.Name = "btnOpenTo";
            this.btnOpenTo.Size = new System.Drawing.Size(57, 23);
            this.btnOpenTo.TabIndex = 12;
            this.btnOpenTo.Text = "Open";
            this.btnOpenTo.UseVisualStyleBackColor = true;
            this.btnOpenTo.Click += new System.EventHandler(this.btnOpenTo_Click);
            // 
            // btnBrowseTo
            // 
            this.btnBrowseTo.Location = new System.Drawing.Point(561, 30);
            this.btnBrowseTo.Name = "btnBrowseTo";
            this.btnBrowseTo.Size = new System.Drawing.Size(77, 23);
            this.btnBrowseTo.TabIndex = 11;
            this.btnBrowseTo.Text = "Browse";
            this.btnBrowseTo.UseVisualStyleBackColor = true;
            this.btnBrowseTo.Click += new System.EventHandler(this.btnBrowseTo_Click);
            // 
            // chkApplyOp
            // 
            this.chkApplyOp.AutoSize = true;
            this.chkApplyOp.Location = new System.Drawing.Point(108, 58);
            this.chkApplyOp.Name = "chkApplyOp";
            this.chkApplyOp.Size = new System.Drawing.Size(141, 17);
            this.chkApplyOp.TabIndex = 13;
            this.chkApplyOp.Text = "Apply Compare Operator";
            this.chkApplyOp.UseVisualStyleBackColor = true;
            this.chkApplyOp.CheckedChanged += new System.EventHandler(this.chkApplyOp_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Operator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOp);
            this.groupBox1.Controls.Add(this.dtpLastWriteTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(108, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 72);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cboOp
            // 
            this.cboOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOp.FormattingEnabled = true;
            this.cboOp.Items.AddRange(new object[] {
            "=",
            "<",
            "<=",
            ">",
            ">="});
            this.cboOp.Location = new System.Drawing.Point(136, 13);
            this.cboOp.Name = "cboOp";
            this.cboOp.Size = new System.Drawing.Size(200, 21);
            this.cboOp.TabIndex = 17;
            // 
            // dtpLastWriteTime
            // 
            this.dtpLastWriteTime.CustomFormat = "dd/MM/yyyy";
            this.dtpLastWriteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastWriteTime.Location = new System.Drawing.Point(136, 40);
            this.dtpLastWriteTime.Name = "dtpLastWriteTime";
            this.dtpLastWriteTime.Size = new System.Drawing.Size(200, 20);
            this.dtpLastWriteTime.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "LastWriteTime";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(644, 134);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(143, 23);
            this.btnMove.TabIndex = 16;
            this.btnMove.Text = "Move File(s)";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(710, 4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(77, 49);
            this.btnSwap.TabIndex = 17;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(644, 105);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(143, 23);
            this.btnSaveSetting.TabIndex = 18;
            this.btnSaveSetting.Text = "Save Setting";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Location = new System.Drawing.Point(151, 163);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(71, 17);
            this.chkOverwrite.TabIndex = 19;
            this.chkOverwrite.Text = "Overwrite";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 415);
            this.Controls.Add(this.chkOverwrite);
            this.Controls.Add(this.btnSaveSetting);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkApplyOp);
            this.Controls.Add(this.btnOpenTo);
            this.Controls.Add(this.btnBrowseTo);
            this.Controls.Add(this.btnOpenFrom);
            this.Controls.Add(this.btnBrowseFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.chkOutputFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files Copy / Move";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkOutputFileName;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseFrom;
        private System.Windows.Forms.Button btnOpenFrom;
        private System.Windows.Forms.Button btnOpenTo;
        private System.Windows.Forms.Button btnBrowseTo;
        private System.Windows.Forms.CheckBox chkApplyOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOp;
        private System.Windows.Forms.DateTimePicker dtpLastWriteTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.CheckBox chkOverwrite;
    }
}

