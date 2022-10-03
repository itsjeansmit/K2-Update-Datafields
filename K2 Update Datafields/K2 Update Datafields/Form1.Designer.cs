namespace K2_Update_Datafields
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.ddlProcesses = new System.Windows.Forms.ComboBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.lblDatafieldName = new System.Windows.Forms.Label();
            this.txtDatafieldName = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lstProcessInstances = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDatafieldValue = new System.Windows.Forms.TextBox();
            this.lblDatafieldValue = new System.Windows.Forms.Label();
            this.lblClientPort = new System.Windows.Forms.Label();
            this.txtCPort = new System.Windows.Forms.TextBox();
            this.lblManagementPort = new System.Windows.Forms.Label();
            this.txtMPort = new System.Windows.Forms.TextBox();
            this.lblSecLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.gbCredentials = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.chkUseConnectionString = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtOldDatafieldValue = new System.Windows.Forms.TextBox();
            this.lblOldDFValue = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.bgRetrieve = new System.ComponentModel.BackgroundWorker();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.txtNumOfRecords = new System.Windows.Forms.TextBox();
            this.procBar = new System.Windows.Forms.ProgressBar();
            this.lblStartProcInstID = new System.Windows.Forms.Label();
            this.txtProcInstID = new System.Windows.Forms.TextBox();
            this.lblEndNo = new System.Windows.Forms.Label();
            this.txtProcInstEnd = new System.Windows.Forms.TextBox();
            this.gbCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(13, 13);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(83, 13);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "K2 Servername:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(14, 92);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(106, 13);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "K2 Admin Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "K2 Admin Domain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "K2 Admin Password:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(151, 13);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(389, 20);
            this.txtServerName.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 89);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(152, 115);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(387, 20);
            this.txtDomain.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(387, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(471, 229);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ddlProcesses
            // 
            this.ddlProcesses.FormattingEnabled = true;
            this.ddlProcesses.Location = new System.Drawing.Point(152, 258);
            this.ddlProcesses.Name = "ddlProcesses";
            this.ddlProcesses.Size = new System.Drawing.Size(393, 21);
            this.ddlProcesses.TabIndex = 9;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(14, 261);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(90, 13);
            this.lblProcess.TabIndex = 10;
            this.lblProcess.Text = "Select a Process:";
            // 
            // lblDatafieldName
            // 
            this.lblDatafieldName.AutoSize = true;
            this.lblDatafieldName.Location = new System.Drawing.Point(14, 288);
            this.lblDatafieldName.Name = "lblDatafieldName";
            this.lblDatafieldName.Size = new System.Drawing.Size(128, 13);
            this.lblDatafieldName.TabIndex = 11;
            this.lblDatafieldName.Text = "Type the Datafield Name:";
            // 
            // txtDatafieldName
            // 
            this.txtDatafieldName.Location = new System.Drawing.Point(153, 285);
            this.txtDatafieldName.Name = "txtDatafieldName";
            this.txtDatafieldName.Size = new System.Drawing.Size(393, 20);
            this.txtDatafieldName.TabIndex = 10;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(471, 361);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 16;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lstProcessInstances
            // 
            this.lstProcessInstances.HideSelection = false;
            this.lstProcessInstances.Location = new System.Drawing.Point(19, 392);
            this.lstProcessInstances.Name = "lstProcessInstances";
            this.lstProcessInstances.Size = new System.Drawing.Size(527, 194);
            this.lstProcessInstances.TabIndex = 14;
            this.lstProcessInstances.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 592);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Datafields";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDatafieldValue
            // 
            this.txtDatafieldValue.Location = new System.Drawing.Point(153, 337);
            this.txtDatafieldValue.Name = "txtDatafieldValue";
            this.txtDatafieldValue.Size = new System.Drawing.Size(393, 20);
            this.txtDatafieldValue.TabIndex = 12;
            // 
            // lblDatafieldValue
            // 
            this.lblDatafieldValue.AutoSize = true;
            this.lblDatafieldValue.Location = new System.Drawing.Point(14, 340);
            this.lblDatafieldValue.Name = "lblDatafieldValue";
            this.lblDatafieldValue.Size = new System.Drawing.Size(107, 13);
            this.lblDatafieldValue.TabIndex = 17;
            this.lblDatafieldValue.Text = "New Datafield Value:";
            // 
            // lblClientPort
            // 
            this.lblClientPort.AutoSize = true;
            this.lblClientPort.Location = new System.Drawing.Point(17, 42);
            this.lblClientPort.Name = "lblClientPort";
            this.lblClientPort.Size = new System.Drawing.Size(58, 13);
            this.lblClientPort.TabIndex = 19;
            this.lblClientPort.Text = "Client Port:";
            // 
            // txtCPort
            // 
            this.txtCPort.Location = new System.Drawing.Point(94, 39);
            this.txtCPort.Name = "txtCPort";
            this.txtCPort.Size = new System.Drawing.Size(158, 20);
            this.txtCPort.TabIndex = 2;
            this.txtCPort.Text = "5252";
            // 
            // lblManagementPort
            // 
            this.lblManagementPort.AutoSize = true;
            this.lblManagementPort.Location = new System.Drawing.Point(265, 42);
            this.lblManagementPort.Name = "lblManagementPort";
            this.lblManagementPort.Size = new System.Drawing.Size(94, 13);
            this.lblManagementPort.TabIndex = 21;
            this.lblManagementPort.Text = "Management Port:";
            // 
            // txtMPort
            // 
            this.txtMPort.Location = new System.Drawing.Point(367, 39);
            this.txtMPort.Name = "txtMPort";
            this.txtMPort.Size = new System.Drawing.Size(172, 20);
            this.txtMPort.TabIndex = 3;
            this.txtMPort.Text = "5555";
            // 
            // lblSecLabel
            // 
            this.lblSecLabel.AutoSize = true;
            this.lblSecLabel.Location = new System.Drawing.Point(377, 92);
            this.lblSecLabel.Name = "lblSecLabel";
            this.lblSecLabel.Size = new System.Drawing.Size(36, 13);
            this.lblSecLabel.TabIndex = 23;
            this.lblSecLabel.Text = "Label:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(419, 89);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(120, 20);
            this.txtLabel.TabIndex = 5;
            this.txtLabel.Text = "K2";
            // 
            // gbCredentials
            // 
            this.gbCredentials.Controls.Add(this.label3);
            this.gbCredentials.Controls.Add(this.txtConnectionString);
            this.gbCredentials.Controls.Add(this.chkUseConnectionString);
            this.gbCredentials.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbCredentials.Location = new System.Drawing.Point(5, 65);
            this.gbCredentials.Name = "gbCredentials";
            this.gbCredentials.Size = new System.Drawing.Size(540, 158);
            this.gbCredentials.TabIndex = 25;
            this.gbCredentials.TabStop = false;
            this.gbCredentials.Text = "K2 Admin Credentials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "K2 Admin Password:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Enabled = false;
            this.txtConnectionString.Location = new System.Drawing.Point(146, 129);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(388, 20);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "Integrated=True;IsPrimaryLogin=True;Authenticate=True;EncryptedPassword=False;Hos" +
    "t=LOCALHOST;Port=5555;UserID=XXXXXXX;WindowsDomain=YYYYYYY;Password=ZZZZZZZ;Secu" +
    "rityLabelName=K2";
            // 
            // chkUseConnectionString
            // 
            this.chkUseConnectionString.AutoSize = true;
            this.chkUseConnectionString.ForeColor = System.Drawing.Color.Black;
            this.chkUseConnectionString.Location = new System.Drawing.Point(14, 105);
            this.chkUseConnectionString.Name = "chkUseConnectionString";
            this.chkUseConnectionString.Size = new System.Drawing.Size(132, 17);
            this.chkUseConnectionString.TabIndex = 0;
            this.chkUseConnectionString.Text = "Use Connection String";
            this.chkUseConnectionString.UseVisualStyleBackColor = true;
            this.chkUseConnectionString.CheckedChanged += new System.EventHandler(this.chkUseConnectionString_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(17, 597);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Welcome...";
            // 
            // txtOldDatafieldValue
            // 
            this.txtOldDatafieldValue.Location = new System.Drawing.Point(153, 311);
            this.txtOldDatafieldValue.Name = "txtOldDatafieldValue";
            this.txtOldDatafieldValue.Size = new System.Drawing.Size(393, 20);
            this.txtOldDatafieldValue.TabIndex = 11;
            // 
            // lblOldDFValue
            // 
            this.lblOldDFValue.AutoSize = true;
            this.lblOldDFValue.Location = new System.Drawing.Point(14, 314);
            this.lblOldDFValue.Name = "lblOldDFValue";
            this.lblOldDFValue.Size = new System.Drawing.Size(101, 13);
            this.lblOldDFValue.TabIndex = 27;
            this.lblOldDFValue.Text = "Old Datafield Value:";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(307, 592);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 19;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // bgRetrieve
            // 
            this.bgRetrieve.WorkerReportsProgress = true;
            this.bgRetrieve.WorkerSupportsCancellation = true;
            this.bgRetrieve.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgRetrieve_DoWork);
            this.bgRetrieve.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgRetrieve_ProgressChanged);
            this.bgRetrieve.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgRetrieve_RunWorkerCompleted);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(17, 366);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(90, 13);
            this.lblNumberOfRecords.TabIndex = 29;
            this.lblNumberOfRecords.Text = "Num. of Records:";
            // 
            // txtNumOfRecords
            // 
            this.txtNumOfRecords.Location = new System.Drawing.Point(153, 363);
            this.txtNumOfRecords.Name = "txtNumOfRecords";
            this.txtNumOfRecords.Size = new System.Drawing.Size(66, 20);
            this.txtNumOfRecords.TabIndex = 13;
            this.txtNumOfRecords.Text = "0";
            // 
            // procBar
            // 
            this.procBar.Location = new System.Drawing.Point(12, 229);
            this.procBar.Name = "procBar";
            this.procBar.Size = new System.Drawing.Size(453, 23);
            this.procBar.TabIndex = 31;
            this.procBar.Visible = false;
            // 
            // lblStartProcInstID
            // 
            this.lblStartProcInstID.AutoSize = true;
            this.lblStartProcInstID.Location = new System.Drawing.Point(225, 363);
            this.lblStartProcInstID.Name = "lblStartProcInstID";
            this.lblStartProcInstID.Size = new System.Drawing.Size(49, 13);
            this.lblStartProcInstID.TabIndex = 32;
            this.lblStartProcInstID.Text = "Start No:";
            // 
            // txtProcInstID
            // 
            this.txtProcInstID.Location = new System.Drawing.Point(280, 360);
            this.txtProcInstID.Name = "txtProcInstID";
            this.txtProcInstID.Size = new System.Drawing.Size(62, 20);
            this.txtProcInstID.TabIndex = 14;
            this.txtProcInstID.Text = "0";
            // 
            // lblEndNo
            // 
            this.lblEndNo.AutoSize = true;
            this.lblEndNo.Location = new System.Drawing.Point(348, 363);
            this.lblEndNo.Name = "lblEndNo";
            this.lblEndNo.Size = new System.Drawing.Size(46, 13);
            this.lblEndNo.TabIndex = 34;
            this.lblEndNo.Text = "End No:";
            // 
            // txtProcInstEnd
            // 
            this.txtProcInstEnd.Location = new System.Drawing.Point(400, 359);
            this.txtProcInstEnd.Name = "txtProcInstEnd";
            this.txtProcInstEnd.Size = new System.Drawing.Size(62, 20);
            this.txtProcInstEnd.TabIndex = 15;
            this.txtProcInstEnd.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 635);
            this.Controls.Add(this.txtProcInstEnd);
            this.Controls.Add(this.lblEndNo);
            this.Controls.Add(this.txtProcInstID);
            this.Controls.Add(this.lblStartProcInstID);
            this.Controls.Add(this.procBar);
            this.Controls.Add(this.txtNumOfRecords);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtOldDatafieldValue);
            this.Controls.Add(this.lblOldDFValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.lblSecLabel);
            this.Controls.Add(this.txtMPort);
            this.Controls.Add(this.lblManagementPort);
            this.Controls.Add(this.txtCPort);
            this.Controls.Add(this.lblClientPort);
            this.Controls.Add(this.txtDatafieldValue);
            this.Controls.Add(this.lblDatafieldValue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstProcessInstances);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.txtDatafieldName);
            this.Controls.Add(this.lblDatafieldName);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.ddlProcesses);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.gbCredentials);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Update Process Datafields";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCredentials.ResumeLayout(false);
            this.gbCredentials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox ddlProcesses;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label lblDatafieldName;
        private System.Windows.Forms.TextBox txtDatafieldName;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.ListView lstProcessInstances;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDatafieldValue;
        private System.Windows.Forms.Label lblDatafieldValue;
        private System.Windows.Forms.Label lblClientPort;
        private System.Windows.Forms.TextBox txtCPort;
        private System.Windows.Forms.Label lblManagementPort;
        private System.Windows.Forms.TextBox txtMPort;
        private System.Windows.Forms.Label lblSecLabel;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.GroupBox gbCredentials;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtOldDatafieldValue;
        private System.Windows.Forms.Label lblOldDFValue;
        private System.Windows.Forms.Button btnRestore;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker bgRetrieve;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.TextBox txtNumOfRecords;
        private System.Windows.Forms.ProgressBar procBar;
        private System.Windows.Forms.Label lblStartProcInstID;
        private System.Windows.Forms.TextBox txtProcInstID;
        private System.Windows.Forms.Label lblEndNo;
        private System.Windows.Forms.TextBox txtProcInstEnd;
        private System.Windows.Forms.CheckBox chkUseConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label3;
    }
}

