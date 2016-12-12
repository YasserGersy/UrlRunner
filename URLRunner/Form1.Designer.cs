namespace URLRunner
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox_urls = new System.Windows.Forms.ListBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonHTTP = new System.Windows.Forms.RadioButton();
            this.radioButtonHTTPS = new System.Windows.Forms.RadioButton();
            this.radioButtonContains = new System.Windows.Forms.RadioButton();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxSingle = new System.Windows.Forms.TextBox();
            this.buttonAddsIngle = new System.Windows.Forms.Button();
            this.radioButtonEmbededBrowser = new System.Windows.Forms.RadioButton();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonDefault = new System.Windows.Forms.RadioButton();
            this.buttonRun = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxBEmbededURl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTimeUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelExport = new System.Windows.Forms.LinkLabel();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Location = new System.Drawing.Point(2, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(855, 495);
            this.panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.linkLabelExport);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonAddsIngle);
            this.panel1.Controls.Add(this.textBoxSingle);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonLoadFromFile);
            this.panel1.Controls.Add(this.listBox_urls);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 342);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(4, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 134);
            this.panel2.TabIndex = 1;
            // 
            // listBox_urls
            // 
            this.listBox_urls.FormattingEnabled = true;
            this.listBox_urls.Location = new System.Drawing.Point(7, 5);
            this.listBox_urls.Name = "listBox_urls";
            this.listBox_urls.Size = new System.Drawing.Size(678, 316);
            this.listBox_urls.TabIndex = 0;
            this.listBox_urls.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(691, 51);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(152, 23);
            this.buttonLoadFromFile.TabIndex = 1;
            this.buttonLoadFromFile.Text = "Load From file";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(691, 75);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Location = new System.Drawing.Point(691, 101);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(152, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear all";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonFilter);
            this.panel3.Controls.Add(this.textBoxFilter);
            this.panel3.Controls.Add(this.radioButtonContains);
            this.panel3.Controls.Add(this.radioButtonHTTPS);
            this.panel3.Controls.Add(this.radioButtonHTTP);
            this.panel3.Location = new System.Drawing.Point(691, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 87);
            this.panel3.TabIndex = 3;
            // 
            // radioButtonHTTP
            // 
            this.radioButtonHTTP.AutoSize = true;
            this.radioButtonHTTP.Location = new System.Drawing.Point(4, 2);
            this.radioButtonHTTP.Name = "radioButtonHTTP";
            this.radioButtonHTTP.Size = new System.Drawing.Size(54, 17);
            this.radioButtonHTTP.TabIndex = 0;
            this.radioButtonHTTP.TabStop = true;
            this.radioButtonHTTP.Text = "HTTP";
            this.radioButtonHTTP.UseVisualStyleBackColor = true;
            this.radioButtonHTTP.CheckedChanged += new System.EventHandler(this.radioButtonHTTP_CheckedChanged);
            // 
            // radioButtonHTTPS
            // 
            this.radioButtonHTTPS.AutoSize = true;
            this.radioButtonHTTPS.Location = new System.Drawing.Point(64, 1);
            this.radioButtonHTTPS.Name = "radioButtonHTTPS";
            this.radioButtonHTTPS.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHTTPS.TabIndex = 1;
            this.radioButtonHTTPS.TabStop = true;
            this.radioButtonHTTPS.Text = "HTTPS";
            this.radioButtonHTTPS.UseVisualStyleBackColor = true;
            this.radioButtonHTTPS.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonContains
            // 
            this.radioButtonContains.AutoSize = true;
            this.radioButtonContains.Location = new System.Drawing.Point(4, 25);
            this.radioButtonContains.Name = "radioButtonContains";
            this.radioButtonContains.Size = new System.Drawing.Size(66, 17);
            this.radioButtonContains.TabIndex = 2;
            this.radioButtonContains.TabStop = true;
            this.radioButtonContains.Text = "Contains";
            this.radioButtonContains.UseVisualStyleBackColor = true;
            this.radioButtonContains.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(73, 25);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(72, 20);
            this.textBoxFilter.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(4, 50);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(141, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxSingle
            // 
            this.textBoxSingle.Location = new System.Drawing.Point(691, 5);
            this.textBoxSingle.Name = "textBoxSingle";
            this.textBoxSingle.Size = new System.Drawing.Size(152, 20);
            this.textBoxSingle.TabIndex = 4;
            this.textBoxSingle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonAddsIngle
            // 
            this.buttonAddsIngle.Enabled = false;
            this.buttonAddsIngle.Location = new System.Drawing.Point(691, 27);
            this.buttonAddsIngle.Name = "buttonAddsIngle";
            this.buttonAddsIngle.Size = new System.Drawing.Size(152, 23);
            this.buttonAddsIngle.TabIndex = 5;
            this.buttonAddsIngle.Text = "Add";
            this.buttonAddsIngle.UseVisualStyleBackColor = true;
            this.buttonAddsIngle.Click += new System.EventHandler(this.buttonAddsIngle_Click);
            // 
            // radioButtonEmbededBrowser
            // 
            this.radioButtonEmbededBrowser.AutoSize = true;
            this.radioButtonEmbededBrowser.Location = new System.Drawing.Point(85, 19);
            this.radioButtonEmbededBrowser.Name = "radioButtonEmbededBrowser";
            this.radioButtonEmbededBrowser.Size = new System.Drawing.Size(60, 17);
            this.radioButtonEmbededBrowser.TabIndex = 0;
            this.radioButtonEmbededBrowser.Text = "Internal";
            this.radioButtonEmbededBrowser.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(9, 39);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCustom.TabIndex = 0;
            this.radioButtonCustom.Text = "Custome";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefault
            // 
            this.radioButtonDefault.AutoSize = true;
            this.radioButtonDefault.Checked = true;
            this.radioButtonDefault.Location = new System.Drawing.Point(9, 19);
            this.radioButtonDefault.Name = "radioButtonDefault";
            this.radioButtonDefault.Size = new System.Drawing.Size(62, 17);
            this.radioButtonDefault.TabIndex = 0;
            this.radioButtonDefault.TabStop = true;
            this.radioButtonDefault.Text = "Default ";
            this.radioButtonDefault.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(9, 87);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(137, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(103, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Define";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxTimeUnit);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.radioButtonDefault);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.radioButtonEmbededBrowser);
            this.groupBox1.Controls.Add(this.buttonRun);
            this.groupBox1.Controls.Add(this.radioButtonCustom);
            this.groupBox1.Location = new System.Drawing.Point(696, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browser";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 134);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxBEmbededURl);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(835, 102);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.webBrowser1);
            this.panel5.Location = new System.Drawing.Point(4, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(826, 72);
            this.panel5.TabIndex = 0;
            // 
            // textBoxBEmbededURl
            // 
            this.textBoxBEmbededURl.Location = new System.Drawing.Point(4, 1);
            this.textBoxBEmbededURl.Name = "textBoxBEmbededURl";
            this.textBoxBEmbededURl.Size = new System.Drawing.Size(826, 20);
            this.textBoxBEmbededURl.TabIndex = 1;
            this.textBoxBEmbededURl.TextChanged += new System.EventHandler(this.textBoxBEmbededURl_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(826, 72);
            this.webBrowser1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(54, 64);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxTimeUnit
            // 
            this.comboBoxTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeUnit.FormattingEnabled = true;
            this.comboBoxTimeUnit.Items.AddRange(new object[] {
            "Mil",
            "Sec",
            "Min",
            "Hour"});
            this.comboBoxTimeUnit.Location = new System.Drawing.Point(99, 63);
            this.comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            this.comboBoxTimeUnit.Size = new System.Drawing.Size(47, 21);
            this.comboBoxTimeUnit.TabIndex = 4;
            this.comboBoxTimeUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeUnit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval";
            // 
            // linkLabelExport
            // 
            this.linkLabelExport.AutoSize = true;
            this.linkLabelExport.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelExport.Location = new System.Drawing.Point(7, 324);
            this.linkLabelExport.Name = "linkLabelExport";
            this.linkLabelExport.Size = new System.Drawing.Size(37, 13);
            this.linkLabelExport.TabIndex = 6;
            this.linkLabelExport.TabStop = true;
            this.linkLabelExport.Text = "Export";
            this.linkLabelExport.Visible = false;
            this.linkLabelExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExport_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 503);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "URl Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.ListBox listBox_urls;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.RadioButton radioButtonContains;
        private System.Windows.Forms.RadioButton radioButtonHTTPS;
        private System.Windows.Forms.RadioButton radioButtonHTTP;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAddsIngle;
        private System.Windows.Forms.TextBox textBoxSingle;
        private System.Windows.Forms.RadioButton radioButtonDefault;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonEmbededBrowser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxBEmbededURl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBoxTimeUnit;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelExport;
    }
}

