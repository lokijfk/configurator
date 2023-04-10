namespace ConfiguratorSH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSkanuj = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.SelectLanguage = new System.Windows.Forms.ComboBox();
            this.labelDirGame = new System.Windows.Forms.Label();
            this.textBoxDirGame = new System.Windows.Forms.TextBox();
            this.buttonDirGame = new System.Windows.Forms.Button();
            this.buttonDirOutput = new System.Windows.Forms.Button();
            this.textBoxDirOutput = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonFileFLT = new System.Windows.Forms.Button();
            this.textBoxFileFLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDirScan = new System.Windows.Forms.Button();
            this.textBoxDirScan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonSET = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelProfil = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectRow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSkanuj
            // 
            this.buttonSkanuj.Enabled = false;
            this.buttonSkanuj.Location = new System.Drawing.Point(72, 265);
            this.buttonSkanuj.Name = "buttonSkanuj";
            this.buttonSkanuj.Size = new System.Drawing.Size(75, 23);
            this.buttonSkanuj.TabIndex = 0;
            this.buttonSkanuj.Text = "Skanuj";
            this.buttonSkanuj.UseVisualStyleBackColor = true;
            this.buttonSkanuj.Click += new System.EventHandler(this.ButtonSkanuj_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAnuluj.Location = new System.Drawing.Point(192, 535);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(69, 23);
            this.buttonAnuluj.TabIndex = 1;
            this.buttonAnuluj.Text = "Anuluj";
            this.toolTip1.SetToolTip(this.buttonAnuluj, "zamknij bez zapisywania");
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.ButtonAnuluj_Click);
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLanguage.Enabled = false;
            this.buttonLanguage.Location = new System.Drawing.Point(106, 17);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(75, 23);
            this.buttonLanguage.TabIndex = 2;
            this.buttonLanguage.Text = "Język";
            this.buttonLanguage.UseVisualStyleBackColor = true;
            this.buttonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
            // 
            // SelectLanguage
            // 
            this.SelectLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLanguage.Enabled = false;
            this.SelectLanguage.FormattingEnabled = true;
            this.SelectLanguage.Location = new System.Drawing.Point(201, 18);
            this.SelectLanguage.Name = "SelectLanguage";
            this.SelectLanguage.Size = new System.Drawing.Size(59, 23);
            this.SelectLanguage.TabIndex = 3;
            // 
            // labelDirGame
            // 
            this.labelDirGame.AutoSize = true;
            this.labelDirGame.Location = new System.Drawing.Point(15, 49);
            this.labelDirGame.Name = "labelDirGame";
            this.labelDirGame.Size = new System.Drawing.Size(68, 15);
            this.labelDirGame.TabIndex = 4;
            this.labelDirGame.Text = "Katalog Gry";
            // 
            // textBoxDirGame
            // 
            this.textBoxDirGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirGame.Location = new System.Drawing.Point(14, 71);
            this.textBoxDirGame.Name = "textBoxDirGame";
            this.textBoxDirGame.Size = new System.Drawing.Size(197, 23);
            this.textBoxDirGame.TabIndex = 5;
            // 
            // buttonDirGame
            // 
            this.buttonDirGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirGame.Location = new System.Drawing.Point(217, 71);
            this.buttonDirGame.Name = "buttonDirGame";
            this.buttonDirGame.Size = new System.Drawing.Size(43, 23);
            this.buttonDirGame.TabIndex = 6;
            this.buttonDirGame.Text = "Dir";
            this.buttonDirGame.UseVisualStyleBackColor = true;
            this.buttonDirGame.Click += new System.EventHandler(this.ButtonDirGame_Click);
            // 
            // buttonDirOutput
            // 
            this.buttonDirOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirOutput.Location = new System.Drawing.Point(218, 123);
            this.buttonDirOutput.Name = "buttonDirOutput";
            this.buttonDirOutput.Size = new System.Drawing.Size(43, 23);
            this.buttonDirOutput.TabIndex = 9;
            this.buttonDirOutput.Text = "Dir";
            this.buttonDirOutput.UseVisualStyleBackColor = true;
            this.buttonDirOutput.Click += new System.EventHandler(this.ButtonDirPayrusCompiler_Click);
            // 
            // textBoxDirOutput
            // 
            this.textBoxDirOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirOutput.Location = new System.Drawing.Point(15, 123);
            this.textBoxDirOutput.Name = "textBoxDirOutput";
            this.textBoxDirOutput.Size = new System.Drawing.Size(197, 23);
            this.textBoxDirOutput.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 15);
            this.label.TabIndex = 7;
            this.label.Text = "Katalog output";
            // 
            // buttonFileFLT
            // 
            this.buttonFileFLT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileFLT.Location = new System.Drawing.Point(219, 180);
            this.buttonFileFLT.Name = "buttonFileFLT";
            this.buttonFileFLT.Size = new System.Drawing.Size(43, 23);
            this.buttonFileFLT.TabIndex = 12;
            this.buttonFileFLT.Text = "Dir";
            this.buttonFileFLT.UseVisualStyleBackColor = true;
            this.buttonFileFLT.Click += new System.EventHandler(this.ButtonFileFLT_Click);
            // 
            // textBoxFileFLT
            // 
            this.textBoxFileFLT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileFLT.Location = new System.Drawing.Point(16, 180);
            this.textBoxFileFLT.Name = "textBoxFileFLT";
            this.textBoxFileFLT.Size = new System.Drawing.Size(197, 23);
            this.textBoxFileFLT.TabIndex = 11;
            this.textBoxFileFLT.Text = "TESV_Papyrus_Flags.flg";
            this.toolTip1.SetToolTip(this.textBoxFileFLT, "Domyślnie \'data\\scripts\\source\\\'");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Plik FLT";
            this.toolTip1.SetToolTip(this.label3, "Domyślnie \'data\\scripts\\source\\\'");
            // 
            // buttonDirScan
            // 
            this.buttonDirScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDirScan.Location = new System.Drawing.Point(220, 236);
            this.buttonDirScan.Name = "buttonDirScan";
            this.buttonDirScan.Size = new System.Drawing.Size(43, 23);
            this.buttonDirScan.TabIndex = 15;
            this.buttonDirScan.Text = "Dir";
            this.buttonDirScan.UseVisualStyleBackColor = true;
            this.buttonDirScan.Click += new System.EventHandler(this.ButtonDirScan_Click);
            // 
            // textBoxDirScan
            // 
            this.textBoxDirScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirScan.Location = new System.Drawing.Point(17, 236);
            this.textBoxDirScan.Name = "textBoxDirScan";
            this.textBoxDirScan.Size = new System.Drawing.Size(197, 23);
            this.textBoxDirScan.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBoxDirScan, "Katalog z modami w przypadki MO to mods");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Katalog do skanowania";
            this.toolTip1.SetToolTip(this.label4, "Katalog z modami w przypadki MO to mods");
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(26, 535);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 23;
            this.buttonOK.Text = "OK";
            this.toolTip1.SetToolTip(this.buttonOK, "zapisz i zamknij");
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonSET
            // 
            this.buttonSET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSET.Enabled = false;
            this.buttonSET.Location = new System.Drawing.Point(252, 507);
            this.buttonSET.Name = "buttonSET";
            this.buttonSET.Size = new System.Drawing.Size(35, 23);
            this.buttonSET.TabIndex = 24;
            this.buttonSET.Text = "set";
            this.toolTip1.SetToolTip(this.buttonSET, "ustaw jako domyślny profil");
            this.buttonSET.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(111, 535);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "zapisz";
            this.toolTip1.SetToolTip(this.buttonSave, "zapisz i nie zamykaj");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelProfil
            // 
            this.labelProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfil.AutoSize = true;
            this.labelProfil.Location = new System.Drawing.Point(20, 480);
            this.labelProfil.Name = "labelProfil";
            this.labelProfil.Size = new System.Drawing.Size(134, 15);
            this.labelProfil.TabIndex = 18;
            this.labelProfil.Text = "Nazwa profilu a pliku ini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectRow,
            this.Mod,
            this.PathDir});
            this.dataGridView1.Location = new System.Drawing.Point(16, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(247, 181);
            this.dataGridView1.TabIndex = 19;
            // 
            // SelectRow
            // 
            this.SelectRow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectRow.HeaderText = "Select";
            this.SelectRow.Name = "SelectRow";
            this.SelectRow.Width = 44;
            // 
            // Mod
            // 
            this.Mod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mod.HeaderText = "Mod";
            this.Mod.Name = "Mod";
            this.Mod.ReadOnly = true;
            this.Mod.Width = 57;
            // 
            // PathDir
            // 
            this.PathDir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PathDir.HeaderText = "Path";
            this.PathDir.Name = "PathDir";
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProfil.Enabled = false;
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Location = new System.Drawing.Point(9, 506);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(237, 23);
            this.comboBoxProfil.TabIndex = 20;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(158, 265);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Czyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 589);
            this.Controls.Add(this.buttonSET);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxProfil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelProfil);
            this.Controls.Add(this.buttonDirScan);
            this.Controls.Add(this.textBoxDirScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFileFLT);
            this.Controls.Add(this.textBoxFileFLT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDirOutput);
            this.Controls.Add(this.textBoxDirOutput);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonDirGame);
            this.Controls.Add(this.textBoxDirGame);
            this.Controls.Add(this.labelDirGame);
            this.Controls.Add(this.SelectLanguage);
            this.Controls.Add(this.buttonLanguage);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonSkanuj);
            this.MinimumSize = new System.Drawing.Size(308, 612);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSkanuj;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button buttonAnuluj;
        private Button buttonLanguage;
        private ComboBox SelectLanguage;
        private Label labelDirGame;
        private TextBox textBoxDirGame;
        private Button buttonDirGame;
        private Button buttonDirOutput;
        private TextBox textBoxDirOutput;
        private Label label;
        private Button buttonFileFLT;
        private TextBox textBoxFileFLT;
        private Label label3;
        private Button buttonDirScan;
        private TextBox textBoxDirScan;
        private Label label4;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private Label labelProfil;
        private DataGridView dataGridView1;
        private ComboBox comboBoxProfil;
        private Button buttonClear;
        private DataGridViewCheckBoxColumn SelectRow;
        private DataGridViewTextBoxColumn Mod;
        private DataGridViewTextBoxColumn PathDir;
        private Button buttonSave;
        private Button buttonOK;
        private Button buttonSET;
    }
}