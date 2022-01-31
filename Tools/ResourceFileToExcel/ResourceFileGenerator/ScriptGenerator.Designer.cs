namespace ResourceToExcel
{
    partial class ScriptGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbLanguageCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDBName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.cbOrgID = new System.Windows.Forms.ComboBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpAppPath = new System.Windows.Forms.GroupBox();
            this.grpExtractOption = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpGenerateOption = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.grpDBValues = new System.Windows.Forms.GroupBox();
            this.grpExcel = new System.Windows.Forms.GroupBox();
            this.grpXML = new System.Windows.Forms.GroupBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.gpProgress = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grpAppPath.SuspendLayout();
            this.grpExtractOption.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpGenerateOption.SuspendLayout();
            this.grpDBValues.SuspendLayout();
            this.grpExcel.SuspendLayout();
            this.grpXML.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.gpProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(258, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 35);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLanguageCode
            // 
            this.cbLanguageCode.FormattingEnabled = true;
            this.cbLanguageCode.Items.AddRange(new object[] {
            "vi-VN",
            "ar-SA",
            "ta-IN",
            "id-ID","zh-CN","ru-RU"});
            this.cbLanguageCode.Location = new System.Drawing.Point(190, 56);
            this.cbLanguageCode.Name = "cbLanguageCode";
            this.cbLanguageCode.Size = new System.Drawing.Size(192, 21);
            this.cbLanguageCode.TabIndex = 1;
            this.cbLanguageCode.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a language ";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(188, 17);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(192, 20);
            this.txtServer.TabIndex = 3;
            this.txtServer.Text = "ATT-116";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(188, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "A$$une";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Database Name";
            // 
            // cbDBName
            // 
            this.cbDBName.FormattingEnabled = true;
            this.cbDBName.Location = new System.Drawing.Point(188, 132);
            this.cbDBName.Name = "cbDBName";
            this.cbDBName.Size = new System.Drawing.Size(192, 21);
            this.cbDBName.TabIndex = 11;
            this.cbDBName.SelectedIndexChanged += new System.EventHandler(this.cbDBName_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "retrive DB list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(79, 11);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(159, 35);
            this.btnExtract.TabIndex = 13;
            this.btnExtract.Text = "Extract to XLSX";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Visible = false;
            this.btnExtract.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(185, 14);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.ReadOnly = true;
            this.txtXMLPath.Size = new System.Drawing.Size(192, 20);
            this.txtXMLPath.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select source XML file";
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(185, 16);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.ReadOnly = true;
            this.txtExcelPath.Size = new System.Drawing.Size(192, 20);
            this.txtExcelPath.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Select source excel file";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(396, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(395, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "browse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML|*.xml";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "XLS|*.xls|XLSX|*.xlsx";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "SQL|.sql";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Organization Name";
            // 
            // cbOrgID
            // 
            this.cbOrgID.FormattingEnabled = true;
            this.cbOrgID.Location = new System.Drawing.Point(188, 167);
            this.cbOrgID.Name = "cbOrgID";
            this.cbOrgID.Size = new System.Drawing.Size(192, 21);
            this.cbOrgID.TabIndex = 22;
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "XLSX|*.xlsx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select application folder";
            // 
            // txtAppPath
            // 
            this.txtAppPath.Location = new System.Drawing.Point(180, 17);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(192, 20);
            this.txtAppPath.TabIndex = 25;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(390, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "browse";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.Text = "Extract DB Only";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "Extract Resx";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(258, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 17);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.Text = "Extract Resx and DB";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // grpAppPath
            // 
            this.grpAppPath.Controls.Add(this.txtAppPath);
            this.grpAppPath.Controls.Add(this.label9);
            this.grpAppPath.Controls.Add(this.button7);
            this.grpAppPath.Location = new System.Drawing.Point(13, 504);
            this.grpAppPath.Name = "grpAppPath";
            this.grpAppPath.Size = new System.Drawing.Size(485, 46);
            this.grpAppPath.TabIndex = 30;
            this.grpAppPath.TabStop = false;
            this.grpAppPath.Visible = false;
            // 
            // grpExtractOption
            // 
            this.grpExtractOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpExtractOption.Controls.Add(this.radioButton2);
            this.grpExtractOption.Controls.Add(this.radioButton1);
            this.grpExtractOption.Controls.Add(this.radioButton3);
            this.grpExtractOption.Location = new System.Drawing.Point(13, 51);
            this.grpExtractOption.Name = "grpExtractOption";
            this.grpExtractOption.Size = new System.Drawing.Size(485, 42);
            this.grpExtractOption.TabIndex = 31;
            this.grpExtractOption.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(13, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 42);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(147, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Generate Data";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Extract Data";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.grpExtractOption);
            this.flowLayoutPanel1.Controls.Add(this.grpGenerateOption);
            this.flowLayoutPanel1.Controls.Add(this.grpDBValues);
            this.flowLayoutPanel1.Controls.Add(this.grpExcel);
            this.flowLayoutPanel1.Controls.Add(this.grpXML);
            this.flowLayoutPanel1.Controls.Add(this.grpAppPath);
            this.flowLayoutPanel1.Controls.Add(this.grpButtons);
            this.flowLayoutPanel1.Controls.Add(this.gpProgress);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 670);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // grpGenerateOption
            // 
            this.grpGenerateOption.Controls.Add(this.cbLanguageCode);
            this.grpGenerateOption.Controls.Add(this.label1);
            this.grpGenerateOption.Controls.Add(this.radioButton8);
            this.grpGenerateOption.Controls.Add(this.radioButton7);
            this.grpGenerateOption.Controls.Add(this.radioButton6);
            this.grpGenerateOption.Location = new System.Drawing.Point(13, 99);
            this.grpGenerateOption.Name = "grpGenerateOption";
            this.grpGenerateOption.Size = new System.Drawing.Size(485, 92);
            this.grpGenerateOption.TabIndex = 33;
            this.grpGenerateOption.TabStop = false;
            this.grpGenerateOption.Visible = false;
            this.grpGenerateOption.Enter += new System.EventHandler(this.grpGenerateOption_Enter);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(258, 17);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(147, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Generate Script and Resx";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(147, 17);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(91, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Generate resx";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(27, 17);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(97, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Generate script";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // grpDBValues
            // 
            this.grpDBValues.Controls.Add(this.cbOrgID);
            this.grpDBValues.Controls.Add(this.txtServer);
            this.grpDBValues.Controls.Add(this.label8);
            this.grpDBValues.Controls.Add(this.txtUserName);
            this.grpDBValues.Controls.Add(this.label2);
            this.grpDBValues.Controls.Add(this.label3);
            this.grpDBValues.Controls.Add(this.txtPassword);
            this.grpDBValues.Controls.Add(this.label4);
            this.grpDBValues.Controls.Add(this.label5);
            this.grpDBValues.Controls.Add(this.cbDBName);
            this.grpDBValues.Controls.Add(this.button2);
            this.grpDBValues.Location = new System.Drawing.Point(13, 197);
            this.grpDBValues.Name = "grpDBValues";
            this.grpDBValues.Size = new System.Drawing.Size(485, 198);
            this.grpDBValues.TabIndex = 34;
            this.grpDBValues.TabStop = false;
            this.grpDBValues.Text = "Data source(s)";
            this.grpDBValues.Visible = false;
            // 
            // grpExcel
            // 
            this.grpExcel.Controls.Add(this.label7);
            this.grpExcel.Controls.Add(this.txtExcelPath);
            this.grpExcel.Controls.Add(this.button5);
            this.grpExcel.Location = new System.Drawing.Point(13, 401);
            this.grpExcel.Name = "grpExcel";
            this.grpExcel.Size = new System.Drawing.Size(485, 48);
            this.grpExcel.TabIndex = 34;
            this.grpExcel.TabStop = false;
            this.grpExcel.Visible = false;
            // 
            // grpXML
            // 
            this.grpXML.Controls.Add(this.txtXMLPath);
            this.grpXML.Controls.Add(this.label6);
            this.grpXML.Controls.Add(this.button4);
            this.grpXML.Location = new System.Drawing.Point(13, 455);
            this.grpXML.Name = "grpXML";
            this.grpXML.Size = new System.Drawing.Size(485, 43);
            this.grpXML.TabIndex = 35;
            this.grpXML.TabStop = false;
            this.grpXML.Visible = false;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnGenerate);
            this.grpButtons.Controls.Add(this.btnExtract);
            this.grpButtons.Location = new System.Drawing.Point(13, 556);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(485, 56);
            this.grpButtons.TabIndex = 34;
            this.grpButtons.TabStop = false;
            // 
            // gpProgress
            // 
            this.gpProgress.Controls.Add(this.progressBar1);
            this.gpProgress.Location = new System.Drawing.Point(13, 618);
            this.gpProgress.Name = "gpProgress";
            this.gpProgress.Size = new System.Drawing.Size(486, 49);
            this.gpProgress.TabIndex = 34;
            this.gpProgress.TabStop = false;
            this.gpProgress.Visible = false;
            this.gpProgress.Enter += new System.EventHandler(this.gpProgress_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // ScriptGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(511, 745);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScriptGenerator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriptGenerator";
            this.grpAppPath.ResumeLayout(false);
            this.grpAppPath.PerformLayout();
            this.grpExtractOption.ResumeLayout(false);
            this.grpExtractOption.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grpGenerateOption.ResumeLayout(false);
            this.grpGenerateOption.PerformLayout();
            this.grpDBValues.ResumeLayout(false);
            this.grpDBValues.PerformLayout();
            this.grpExcel.ResumeLayout(false);
            this.grpExcel.PerformLayout();
            this.grpXML.ResumeLayout(false);
            this.grpXML.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.gpProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbLanguageCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDBName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOrgID;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox grpAppPath;
        private System.Windows.Forms.GroupBox grpExtractOption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grpDBValues;
        private System.Windows.Forms.GroupBox grpXML;
        private System.Windows.Forms.GroupBox grpGenerateOption;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpExcel;
        private System.Windows.Forms.GroupBox gpProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}