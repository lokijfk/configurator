namespace ConfiguratorSH
{
    public partial class Form1 : Form
    {
        private IniFile? Settings = null;
        private string path = @"settings.ini";

        public Form1()
        {
            InitializeComponent();
        }

        private string GetPath()
        {
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog1.Description =
                "Select the directory that you want to use as the default.";

            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog1.ShowNewFolderButton = false;

            // Default to the My Documents folder.
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {
                return "";
            }
        }

        private void ButtonDirGame_Click(object sender, EventArgs e)
        {
            textBoxDirGame.Text = GetPath();
        }

        private void ButtonAnuluj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSkanuj_Click(object sender, EventArgs e)
        {
            Skanuj(textBoxDirScan.Text);
        }

        private void Skanuj(string path)
        {
            DirectoryInfo rootDir = new(path);
            //DirectoryInfo[]? subDir= null;
            DirectoryInfo[]? tabDirRoot = rootDir.GetDirectories();

            AddRow(true, rootDir.FullName, rootDir.FullName);

            //przeszukaj g³ówny podany katalog (subDir to wykaz katalogów z modami -mody)
            foreach (DirectoryInfo dir in tabDirRoot)
            {   //dir to katalog modu
                //czy w œrodku s¹ jakieœ katalogi?
                DirectoryInfo[] subDir = dir.GetDirectories();
                if (subDir.Length > 0)
                {
                    ///tu myœla³em nad przepisaniem ifów do funkcji 
                    ///ale chyba nie bêdê tego robi³ bo to zbytnio komplikuje
                    ///mo¿na dodaæ w addrow blokowanie wiersza,¿eby go nie w³¹czaæ i dodaæ wyjaœnienie czemu jak siê da

                    var xxxPath = Path.Combine(dir.FullName, "scripts", "source");
                    if (Directory.Exists(xxxPath))
                    {
                        AddRow(true, dir.Name, xxxPath);
                    }
                    xxxPath = Path.Combine(dir.FullName, "source", "scripts");
                    if (Directory.Exists(xxxPath))
                    {
                        AddRow(true, dir.Name, xxxPath);
                    }
                }
                /*
                 * else
                 * {
                 * tu sprawdzanie czy jest w katalogu  jakiœ BSA i dodanie go do grida z komentarzem
                 * }
                 */
            }
        }

        /// <summary>
        /// dodaje wiersz do grida 
        /// </summary>
        /// <param name="Box"></param> zaznaczenie domyœlne true/false
        /// <param name="ModName"></param> nazwa moda
        /// <param name="pathSource"></param> œcieszka do katalogu ze Ÿród³ami
        /// <param name="toolTips"></param> podpowiedŸ o ile wymagana
        /// <param name="Block"></param> blokowanie zmian wiersza o ile wymagane true/false
        private void AddRow(bool Box, string ModName, string pathSource, string toolTips = "", bool Block = false)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = Box;
            row.Cells[1].Value = ModName;
            row.Cells[2].Value = pathSource;
            if (!toolTips.Equals(""))
                row.Cells[2].ToolTipText = toolTips;
            //dwa poni¿sze wiersza s¹ do blokowania wiersza
            row.ReadOnly = Block;
            if (Block)
                row.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows.Add(row);
        }


        private void ButtonLanguage_Click(object sender, EventArgs e)
        {
            //textBoxDirGame.Text = SelectLanguagr.Text;
        }

        private void ButtonDirPayrusCompiler_Click(object sender, EventArgs e)
        {
            textBoxDirOutput.Text = GetPath();
        }

        private void ButtonDirScan_Click(object sender, EventArgs e)
        {
            textBoxDirScan.Text = GetPath();
            if (!textBoxDirScan.Text.Equals(""))
                buttonSkanuj.Enabled = true;
        }

        private void ButtonFileFLT_Click(object sender, EventArgs e)
        {

            this.openFileDialog1.DefaultExt = "flg";
            this.openFileDialog1.Filter = "flg files (*.flg)|*.flg";

            //openFileDialog1.InitialDirectory = Environment.SpecialFolder.Personal;
            // Display the openFile dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                //do wyko¿ystania
                textBoxFileFLT.Text = openFileDialog1.FileName;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Save();

        }

        private void Save()
        {
            // to na przysz³oœæ jak bêdêrobi³ modyfikacjêpod Advanced-Papyrus-master
           // string path = @"settings.ini";

            Settings ??= new IniFile(); 
            Settings.LoadIni(path);
            //if(Settings == null)Settings = new iniFile(path);

            //tu bêdzie z parametrami
            //Settings.Write("GUI", "Lang", SelectLanguage.SelectedText.Trim());
            // moi¿e tu by siê przyda³a jakaœ pêtla wyszukuj¹ca i wywo³uj¹ca pola ??
            /*
            Settings.Write("Skyrim", "DirGame", textBoxDirGame.Text.Trim());
            Settings.Write("Skyrim", "DirPapyrusCompiler", textBoxDirPapyrusCompiler.Text.Trim());
            Settings.Write("Skyrim", "BoxFileFLT", textBoxFileFLT.Text.Trim());
            */
            Dictionary<string, string> dir = new Dictionary<string, string>();
            List<Control> c = Controls.OfType<TextBox>().Cast<Control>().ToList();
            foreach (Control t in c)
            {
                string x = t.Name.Substring(7);                
                dir[x] = t.Text.Trim();
            }
            Settings.Write("Skyrim", dir);
            /*
            Settings.Write("Skyrim", new Dictionary<string, string> 
            { 
                { "DirGame", textBoxDirGame.Text.Trim() },
                {"DirPapyrusCompiler", textBoxDirPapyrusCompiler.Text.Trim() },
                { "FileFLT", textBoxFileFLT.Text.Trim()},
                {"DirScan", textBoxDirScan.Text.Trim()}
            });
            */
            //Settings.DeleteKey("Skyrim", "BoxFileFLT");
            //dalej powinno byæ odczytywanie z dataGridView1 kolejnych wierszy
            int licznik = 0;
            string r;
            bool s;
            Settings.OpenTransaction();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //zawsze jest jeden wiersz ale mo¿e byæ pusty
                if (row.Cells[2].Value != null)
                {
                    r = (string)row.Cells[2].Value;
                    s = (bool)row.Cells[0].Value;
                    if (s == true)
                    {
                        Settings.Write("Import", "Path" + licznik, r);
                    }
                    licznik++;
                }
            }
            Settings.Savetransaction();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tu by siê przyda³o zapisywaæ likalnie œcieszkê, czyli lokala i nazwa pliku
            // i dalej ju¿ tylko j¹ wywo³ywaæ
            //dodaæ parametr do wywo³ania jak ma braæ inny plik ini, albo dodatkow¹ opcjê
            Settings = new IniFile();
            string temp = "";
            if (File.Exists(path))
            { 
                Settings.LoadIni(path);
                //Settings = new IniFile(@"settings.ini");
                //MessageBox.Show("jest plik: "+ Settings.Read("Skyrim", "DirGame"));
                //tu powinno byæ za³adowanie danych

                //tu na razie rêcznie wpisywanie ale bêdzie trzeba zrobiæ jakiœ schemat i wpisywanie w pêtli
                //mo¿e jakieœ mapowanie danych
               /* textBoxDirGame.Text = Settings.Read("Skyrim", "DirGame");
                textBoxDirPapyrusCompiler.Text = Settings.Read("Skyrim", "DirPapyrusCompiler");
                textBoxFileFLT.Text = Settings.Read("Skyrim", "FileFLT");
                textBoxDirScan.Text = Settings.Read("Skyrim", "DirScan");
                */
                //var Set = Settings.GetSection("Skyrim");
                //if (Set != null)
                //{
                    List<Control>c = Controls.OfType<TextBox>().Cast<Control>().ToList();
                    foreach (Control t in c)
                    {
                        string x = t.Name.Substring(7);
                        temp = Settings.Read("skyrim", x,true);//Set[x];
                        if(temp != "")
                        {
                            t.Text = temp;
                        }
                    }
                //}
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Save();
            Application.Exit();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}