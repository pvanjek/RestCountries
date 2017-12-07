namespace WindowsFormsAppCountries
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
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.inptCode = new System.Windows.Forms.TextBox();
            this.inptArea = new System.Windows.Forms.TextBox();
            this.inptCapitalCity = new System.Windows.Forms.TextBox();
            this.inptNumbPopulation = new System.Windows.Forms.TextBox();
            this.inptName = new System.Windows.Forms.TextBox();
            this.lblinptContinent = new System.Windows.Forms.Label();
            this.lblinptArea = new System.Windows.Forms.Label();
            this.lblinptCapitalCity = new System.Windows.Forms.Label();
            this.lblinptNumbPop = new System.Windows.Forms.Label();
            this.lblinptName = new System.Windows.Forms.Label();
            this.lblinptCode = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewCountries.Location = new System.Drawing.Point(228, 17);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(644, 306);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sCode";
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sName";
            this.Column2.HeaderText = "Naziv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sCapital";
            this.Column3.HeaderText = "Glavni grad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nPopulation";
            this.Column4.HeaderText = "Broj stanovnika";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sRegion";
            this.Column5.HeaderText = "Kontinent";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fArea";
            this.Column6.HeaderText = "Površina";
            this.Column6.Name = "Column6";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(18, 33);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(175, 21);
            this.comboBoxRegion.TabIndex = 1;
            this.comboBoxRegion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kontinent";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sortiraj po";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(21, 157);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(172, 20);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 203);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pretraži";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 412);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewCountries);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxRegion);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pregled";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxChoose);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.inptCode);
            this.tabPage2.Controls.Add(this.inptArea);
            this.tabPage2.Controls.Add(this.inptCapitalCity);
            this.tabPage2.Controls.Add(this.inptNumbPopulation);
            this.tabPage2.Controls.Add(this.inptName);
            this.tabPage2.Controls.Add(this.lblinptContinent);
            this.tabPage2.Controls.Add(this.lblinptArea);
            this.tabPage2.Controls.Add(this.lblinptCapitalCity);
            this.tabPage2.Controls.Add(this.lblinptNumbPop);
            this.tabPage2.Controls.Add(this.lblinptName);
            this.tabPage2.Controls.Add(this.lblinptCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(72, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inptCode
            // 
            this.inptCode.Location = new System.Drawing.Point(86, 18);
            this.inptCode.Name = "inptCode";
            this.inptCode.Size = new System.Drawing.Size(166, 20);
            this.inptCode.TabIndex = 11;
            // 
            // inptArea
            // 
            this.inptArea.Location = new System.Drawing.Point(101, 123);
            this.inptArea.Name = "inptArea";
            this.inptArea.Size = new System.Drawing.Size(151, 20);
            this.inptArea.TabIndex = 9;
            // 
            // inptCapitalCity
            // 
            this.inptCapitalCity.Location = new System.Drawing.Point(113, 97);
            this.inptCapitalCity.Name = "inptCapitalCity";
            this.inptCapitalCity.Size = new System.Drawing.Size(139, 20);
            this.inptCapitalCity.TabIndex = 8;
            // 
            // inptNumbPopulation
            // 
            this.inptNumbPopulation.Location = new System.Drawing.Point(130, 71);
            this.inptNumbPopulation.Name = "inptNumbPopulation";
            this.inptNumbPopulation.Size = new System.Drawing.Size(122, 20);
            this.inptNumbPopulation.TabIndex = 7;
            // 
            // inptName
            // 
            this.inptName.Location = new System.Drawing.Point(86, 44);
            this.inptName.Name = "inptName";
            this.inptName.Size = new System.Drawing.Size(166, 20);
            this.inptName.TabIndex = 6;
            // 
            // lblinptContinent
            // 
            this.lblinptContinent.AutoSize = true;
            this.lblinptContinent.Location = new System.Drawing.Point(6, 154);
            this.lblinptContinent.Name = "lblinptContinent";
            this.lblinptContinent.Size = new System.Drawing.Size(103, 13);
            this.lblinptContinent.TabIndex = 5;
            this.lblinptContinent.Text = "Odaberite kontinent:";
            // 
            // lblinptArea
            // 
            this.lblinptArea.AutoSize = true;
            this.lblinptArea.Location = new System.Drawing.Point(6, 126);
            this.lblinptArea.Name = "lblinptArea";
            this.lblinptArea.Size = new System.Drawing.Size(89, 13);
            this.lblinptArea.TabIndex = 4;
            this.lblinptArea.Text = "Unesite površinu:";
            // 
            // lblinptCapitalCity
            // 
            this.lblinptCapitalCity.AutoSize = true;
            this.lblinptCapitalCity.Location = new System.Drawing.Point(6, 102);
            this.lblinptCapitalCity.Name = "lblinptCapitalCity";
            this.lblinptCapitalCity.Size = new System.Drawing.Size(101, 13);
            this.lblinptCapitalCity.TabIndex = 3;
            this.lblinptCapitalCity.Text = "Unesite glavni grad:";
            // 
            // lblinptNumbPop
            // 
            this.lblinptNumbPop.AutoSize = true;
            this.lblinptNumbPop.Location = new System.Drawing.Point(6, 74);
            this.lblinptNumbPop.Name = "lblinptNumbPop";
            this.lblinptNumbPop.Size = new System.Drawing.Size(121, 13);
            this.lblinptNumbPop.TabIndex = 2;
            this.lblinptNumbPop.Text = "Unesite broj stanovnika:";
            // 
            // lblinptName
            // 
            this.lblinptName.AutoSize = true;
            this.lblinptName.Location = new System.Drawing.Point(6, 47);
            this.lblinptName.Name = "lblinptName";
            this.lblinptName.Size = new System.Drawing.Size(74, 13);
            this.lblinptName.TabIndex = 1;
            this.lblinptName.Text = "Unesite naziv:";
            // 
            // lblinptCode
            // 
            this.lblinptCode.AutoSize = true;
            this.lblinptCode.Location = new System.Drawing.Point(6, 21);
            this.lblinptCode.Name = "lblinptCode";
            this.lblinptCode.Size = new System.Drawing.Size(67, 13);
            this.lblinptCode.TabIndex = 0;
            this.lblinptCode.Text = "Unesite kod:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1013, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Karta svijeta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1013, 386);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.openstreetmap.org", System.UriKind.Absolute);
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(113, 151);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(139, 21);
            this.comboBoxChoose.TabIndex = 13;
            this.comboBoxChoose.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoose_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "REST Countries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox inptArea;
        private System.Windows.Forms.TextBox inptCapitalCity;
        private System.Windows.Forms.TextBox inptNumbPopulation;
        private System.Windows.Forms.TextBox inptName;
        private System.Windows.Forms.Label lblinptContinent;
        private System.Windows.Forms.Label lblinptArea;
        private System.Windows.Forms.Label lblinptCapitalCity;
        private System.Windows.Forms.Label lblinptNumbPop;
        private System.Windows.Forms.Label lblinptName;
        private System.Windows.Forms.Label lblinptCode;
        private System.Windows.Forms.TextBox inptCode;
        private System.Windows.Forms.ComboBox comboBoxChoose;
    }
}

