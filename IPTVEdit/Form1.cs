using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;
using WinSCP;

namespace IPTVEdit
{
    public partial class Form1 : Form
    {
        string VersionNr = "1.15.9";
        bool changed = false, m3uorepg = true;// Für die Nachfrage beim Programm Schließen oder neu laden
        string pth = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        string lang = "", Info = "", DGNumber = "", DGName = "", DGEPGName = "", DGEPGShift = "", DGGroup = "", SaveError = "", SaveError2 = "", SaveSuccess = "", SafeWarning = "", SafeQuestion = "", SafeQuestionLogo = "", MessageDuplicates = "", MessageVersionOK = "", MessageVersionOld = "";
        // Variablen fuer Logo
        string LogoDownload = "";
        string LogoLoadOK = "", LogoLoadError = "";
        string[] Favourite, LogoNames = new string[0], EPGID = new string[0], EPG = new string[0], EpgNames = new string[0], EpgNamesSimple = new string[0], EpgDir2, LogoDir2, m3uURL2, FTPUser2, FTPPw2, FTPIP2, FTPDir2, FTPorSFTP2, FTPFilename2;
        string EpgDir = "", LogoDir = "", m3uURL = "", FTPUser = "", FTPPw = "", FTPIP = "", FTPDir = "", FTPFilename="list.m3u";
        int FTPorSFTP = 0;
        //
        string[] DefaultConfig;
        public Form1()
        {
            InitializeComponent();
            DGChannel.ReadOnly = true;
            btnAddClose.Visible = false; btnAddClose.Enabled = false;
            DGChannel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Einstellungen von Datei Default.Config laden
            System.IO.StreamReader fileConfig = new System.IO.StreamReader(@"default.config");
            string[] lang2 = new string[2];
            DefaultConfig = fileConfig.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i].Contains("lang:<"))
                {
                    lang2 = DefaultConfig[i].Split('<', '>');
                    lang = lang2[1];
                }
                if (DefaultConfig[i].Contains("EpgDir:<"))
                {
                    EpgDir2 = DefaultConfig[i].Split('<', '>');
                    EpgDir = EpgDir2[1];
                }
                if (DefaultConfig[i].Contains("LogoDir:<"))
                {
                    LogoDir2 = DefaultConfig[i].Split('<', '>');
                    LogoDir = LogoDir2[1];
                }
                if (DefaultConfig[i].Contains("m3uURL:<"))
                {
                    m3uURL2 = DefaultConfig[i].Split('<', '>');
                    m3uURL = m3uURL2[1];
                }
                if (DefaultConfig[i].Contains("FTP:<"))
                {
                    FTPorSFTP2 = DefaultConfig[i].Split('<', '>');
                    FTPorSFTP = Convert.ToInt32(FTPorSFTP2[1]);
                }
                if (DefaultConfig[i].Contains("FTPUser:<"))
                {
                    FTPUser2 = DefaultConfig[i].Split('<', '>');
                    FTPUser = FTPUser2[1];
                }
                if (DefaultConfig[i].Contains("FTPPw:<"))
                {
                    FTPPw2 = DefaultConfig[i].Split('<', '>');
                    FTPPw = FTPPw2[1];
                }
                if (DefaultConfig[i].Contains("FTPIP:<"))
                {
                    FTPIP2 = DefaultConfig[i].Split('<', '>');
                    FTPIP = FTPIP2[1];
                }
                if (DefaultConfig[i].Contains("FTPDir:<"))
                {
                    FTPDir2 = DefaultConfig[i].Split('<', '>');
                    FTPDir = FTPDir2[1];
                }
                if (DefaultConfig[i].Contains("FTPFilename:<"))
                {
                    FTPFilename2 = DefaultConfig[i].Split('<', '>');
                    FTPFilename = FTPFilename2[1];
                }
                if (DefaultConfig[i].Contains("SimpleIPTV = 1") && TSMEpgCheckSimpleIPTV.Checked == false)
                {
                    TSMEpgCheckSimpleIPTV.Checked = true;
                }
            }
            fileConfig.Close();
            /*  Falls das Tool zum ersten Mal geöffnet wurde...bzw. Falls in default.config datei keine Sprache angegeben ist
                Soll das Tool vom System die Sprache erkennen und die für's nächste Öffnen ins default.config speichern.  
             */
            if (lang == "")
            {
                string myDefaultLanguage = System.Globalization.CultureInfo.CurrentUICulture.ThreeLetterWindowsLanguageName;
                switch (myDefaultLanguage)
                {
                    case "DEU": lang = "GER"; languageGER(); break;
                    case "ITA": lang = "ITA"; languageITA(); break;
                    case "ENU": lang = "ENG"; languageENG(); break;
                    default: lang = "ENG"; break;
                }
                for (int i = 0; i < DefaultConfig.Length; i++)
                {
                    if (DefaultConfig[i].Contains("lang:<"))
                    {
                        DefaultConfig[i] = "lang:<" + lang + ">";
                    }
                }
                WriteInDefaultConfig();
            }
            else
            {
                switch (lang)
                {
                    case "GER": lang = "GER"; languageGER(); break;
                    case "ITA": lang = "ITA"; languageITA(); break;
                    case "ENG": lang = "ENG"; languageENG(); break;
                    default: lang = "ENG"; break;
                }
            }
            try { LogoCheck(); LoadEPG(EpgDir); EPGCheck(); }
            catch { }
        }
        //
        //Tastatureingabe
        private void DGChannel_SelectionChanged(object sender, EventArgs e)
        {
            if (DGChannel.SelectedRows.Count >= 2)
            {
                //      txtChangeEPGShift.Text = "";
                txtChangeEPGShift.Enabled = false;
                //    txtChangeIDEPG.Text = "";
                txtChangeIDEPG.Enabled = false;
                //  txtChangeIP.Text = "";
                txtChangeIP.Enabled = false;
                //   txtChangeLogo.Text = "";
                txtChangeLogo.Enabled = false;
                //  txtChangeName.Text = "";
                txtChangeName.Enabled = false;
                //  txtChangeNameEPG.Text = "";
                txtChangeNameEPG.Enabled = false;
                //  txtSort.Text = "";
                txtSort.Enabled = false;
                btnAddChannel.Enabled = false;
            }
            else
            {
                txtChangeEPGShift.Enabled = true;
                txtChangeIDEPG.Enabled = true;
                txtChangeIP.Enabled = true;
                txtChangeLogo.Enabled = true;
                txtChangeName.Enabled = true;
                txtChangeNameEPG.Enabled = true;
                txtSort.Enabled = true;
                btnAddChannel.Enabled = true;
            }
        }
        //Selektiert die ganze Zeile
        private void DGChannel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DGChannel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (DGChannel.Rows.Count != 0)
            {
                ChangeChannel();
            }
        }
        //Tasten belegen zum Ausfuehren der TSM-Buttons
        private void DGChannel_KeyUp(object sender, KeyEventArgs e)
        {
            if (DGChannel.Rows.Count != 0 && e.KeyCode == Keys.Delete) btnDelete.PerformClick();
            ChangeChannel();
        }
        //Eingabehilfe bei Logo-Eingabe
        private void txtChangeLogo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtChangeLogo.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtChangeLogo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                for (int i = 0; i < LogoNames.Length; i++)
                {
                    col.Add(LogoNames[i]);
                }
                txtChangeLogo.AutoCompleteCustomSource = col;
            }
            catch { }
        }
        //Eingabehilfe bei EPG-Name-Eingabe
        private void txtChangeNameEPG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtChangeNameEPG.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtChangeNameEPG.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                for (int i = 0; i < EPG.Length; i++)
                {
                    col.Add(EPG[i]);
                }
                txtChangeNameEPG.AutoCompleteCustomSource = col;
            }
            catch { }
        }
        //Eingabehilfe bei EPG-ID-Eingabe
        private void txtChangeIDEPG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtChangeIDEPG.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtChangeIDEPG.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                for (int i = 0; i < EPGID.Length; i++)
                {
                    col.Add(EPGID[i]);
                }
                txtChangeIDEPG.AutoCompleteCustomSource = col;
            }
            catch { }
        }
        //Nur Zahlen eingeben
        private void txtSort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // Zahl darf nicht groesser sein als die Anzahl der Sender
        private void txtSort_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSort.Text != "")
            {
                if (Convert.ToInt32(txtSort.Text) >= DGChannel.RowCount && btnAdd.Enabled == false) txtSort.Text = (DGChannel.RowCount).ToString();
                if (Convert.ToInt32(txtSort.Text) > DGChannel.RowCount && btnAdd.Enabled == true) txtSort.Text = (DGChannel.RowCount + 1).ToString();

                if (Convert.ToInt32(txtSort.Text) == 0) txtSort.Text = "1";
                if (Convert.ToInt32(txtSort.Text) == -1) txtSort.Text = "1";
            }

        }
        //Nur bestimmte Zeichen zulassen
        private void txtChangeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = " ._-ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\bÜüÖöÄä";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        //Nur bestimmte Zeichen zulassen
        private void txtChangeIDEPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = " ._-ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\bÜüÖöÄä";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        //Nur bestimmte Zeichen zulassen
        private void txtChangeNameEPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = " ._-ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\bÜüÖöÄä";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        //Nur bestimmte Zeichen zulassen
        private void txtChangeLogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = " ._-ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\bÜüÖöÄä";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        //Nur bestimmte Zeichen zulassen
        private void txtChangeIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = " .:_-ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\bÜüÖöÄä?//\\ß!§$%&()=";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        //Nur Zahlen eingeben
        private void txtChangeEPGShift_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Mauseingabe
        //Passt die Form an, wenn man an der Breite oder Höhe der Form zieht.
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width >= 600)
            {
                grpChange.Left = this.Width - 350;
                DGChannel.Width = grpChange.Left;
            }
        }
        //Verweigert dem User nach Column zu sortieren
        private void DGChannel_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            DGChannel.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        //Groupbox
        //Button - Ueberschreibt die alten Werte des Senders von den in den Textbox eingebebenen Werte
        private void btnChangeOK_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = this.DGChannel.SelectedRows[0].Index;// Selektierten Index merken
                int pos = Convert.ToInt32(txtSort.Text);
                if (DGChannel.Rows.Count != 0 && this.DGChannel.SelectedRows.Count == 1)
                {
                    btnDelete.Enabled = true; btnAddClose.Enabled = true; btnAddClose.Visible = true; btnAddChannel.Enabled = true;
                    DGChannel.Rows[selectedIndex].SetValues(selectedIndex + 1, txtChangeName.Text, txtChangeIDEPG.Text, txtChangeNameEPG.Text, txtChangeEPGShift.Text, CBChangeGroup.SelectedItem, txtChangeIP.Text, txtChangeLogo.Text, CBTVRadio.SelectedItem.ToString());
                    if (txtSort.Text != DGChannel[0, selectedIndex].Value.ToString())// Es darf nur eine Zeile selektiert sein
                    {
                        SortbyUser();
                    }
                    grpChange.Visible = false; grpChange.Enabled = false;
                    DGChannel.Enabled = true; changed = true;
                }
                else if (DGChannel.RowCount == 0) { btnAddClose.Enabled = false; }
                // Falls mehrere auswählt wurden
                else if (this.DGChannel.SelectedRows.Count >= 2)
                {
                    int currentIndex = 0;
                    for (int i = DGChannel.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        currentIndex = DGChannel.SelectedRows[i].Index;
                        DGChannel.Rows[currentIndex].SetValues(currentIndex, DGChannel.Rows[currentIndex].Cells[1].Value, DGChannel.Rows[currentIndex].Cells[2].Value, DGChannel.Rows[currentIndex].Cells[3].Value, DGChannel.Rows[currentIndex].Cells[4].Value, CBChangeGroup.SelectedItem, DGChannel.Rows[currentIndex].Cells[6].Value, DGChannel.Rows[currentIndex].Cells[7].Value, CBTVRadio.SelectedItem.ToString());

                    }
                    BackgroundChange(); SortbyNewIndex(); ChangeChannel(); FavouriteHelp();
                }
                DGChannel.ClearSelection();// Selektion löschen
                DGChannel.Rows[pos - 1].Selected = true;// Das verschobene Objekt an der neuen Stelle selektieren
                if (pos >= 5)
                {
                    DGChannel.FirstDisplayedScrollingRowIndex = pos - 5;
                }
                FavouriteHelp();
                BackgroundChange(); SortbyNewIndex(); ChangeChannel(); LogoCheck(); EPGCheck();
            }
            catch
            {
                grpChange.Visible = true; grpChange.Enabled = true; btnAdd.Enabled = false; btnAdd.Visible = false;
            }

        }
        //Button - schließt hinzufügen
        private void btnAddClose_Click(object sender, EventArgs e)
        {
            if (DGChannel.RowCount != 0)
            {
                txtSort.Clear();
                btnDelete.Enabled = true; btnDelete.Visible = true; btnChangeOK.Enabled = true; btnChangeOK.Visible = true;
                btnAdd.Enabled = false; btnAdd.Visible = false; btnAddChannel.Enabled = true; btnAddChannel.Visible = true;
                DGChannel.Enabled = true; DGChannel.Select(); ChangeChannel(); btnAddClose.Visible = false;
            }
        }
        //Button - Fuegt einen neuen Sender mit den eingegeben Werte der Textbox
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = Convert.ToInt32(txtSort.Text);
                if (DGChannel.Rows.Count != 0)
                {
                    // Favorit in Variable favgroup abspeichern
                    string favgroup = "";
                    if (CBChangeGroup.SelectedItem == null) favgroup = "";
                    else favgroup = CBChangeGroup.SelectedItem.ToString();
                    //
                    //Neuen Sender hinzufügen mit eingegebenen Werte übernehmen
                    DGChannel.Rows.Add(DGChannel.Rows.Count + 1, txtChangeName.Text, txtChangeIDEPG.Text, txtChangeNameEPG.Text, txtChangeEPGShift.Text, favgroup, txtChangeIP.Text, txtChangeLogo.Text, CBTVRadio.SelectedItem.ToString());
                    DGChannel.Rows[DGChannel.Rows.Count - 1].Selected = true;// Das verschobene Objekt an der neuen Stelle selektieren
                    if (txtSort.Text != Convert.ToString(DGChannel.Rows.Count + 1))
                    {
                        SortbyUser();
                    }
                    grpChange.Visible = false; grpChange.Enabled = false; btnAdd.Visible = false; btnAdd.Enabled = false; btnChangeOK.Visible = false; btnChangeOK.Enabled = false;
                    btnAddChannel.Enabled = true; btnDelete.Enabled = true;
                    btnDelete.Enabled = true; btnAddChannel.Enabled = true;
                    SortbyNewIndex(); BackgroundChange();
                    DGChannel.ClearSelection();// Selektion löschen
                    DGChannel.Rows[pos - 1].Selected = true;// Das verschobene Objekt an der neuen Stelle selektieren
                    ChangeChannel();
                    btnAddClose.Visible = false;
                    if (pos >= 5)
                    {
                        DGChannel.FirstDisplayedScrollingRowIndex = pos - 5;
                    }
                    LogoCheck(); EPGCheck(); FavouriteHelp();
                }
                else
                {
                    DGChannel.Rows.Add(DGChannel.Rows.Count + 1, txtChangeName.Text, txtChangeIDEPG.Text, txtChangeNameEPG.Text, txtChangeEPGShift.Text, CBChangeGroup.SelectedItem, txtChangeIP.Text, txtChangeLogo.Text, CBTVRadio.SelectedItem.ToString());
                    grpChange.Visible = false; grpChange.Enabled = false; btnAdd.Visible = false; btnAdd.Enabled = false; btnChangeOK.Visible = false; btnChangeOK.Enabled = false;
                    btnAddChannel.Enabled = true; btnDelete.Enabled = true;
                    btnDelete.Enabled = true; btnAddChannel.Enabled = true;
                    SortbyNewIndex(); BackgroundChange();
                    DGChannel.ClearSelection();// Selektion löschen
                    DGChannel.Rows[pos - 1].Selected = true;// Das verschobene Objekt an der neuen Stelle selektieren
                    ChangeChannel();
                    btnAddClose.Visible = false;
                }
                changed = true;
            }
            catch { }
        }
        //Button - Löscht den selektierten Sender
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = this.DGChannel.SelectedRows[0].Index;// Selektierten Index merken
                int currentIndex = 0;
                if (DGChannel.SelectedRows.Count >= 1)
                {
                    for (int i = DGChannel.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        currentIndex = DGChannel.SelectedRows[i].Index;
                        DGChannel.Rows.Remove(DGChannel.Rows[currentIndex]);
                    }
                    BackgroundChange(); SortbyNewIndex(); ChangeChannel(); FavouriteHelp();
                }
                else if (DGChannel.SelectedRows.Count == 1)
                {
                    if (selectedIndex != DGChannel.Rows.Count - 1)
                    {
                        DGChannel.Rows.Remove(DGChannel.CurrentRow);
                        BackgroundChange(); SortbyNewIndex(); ChangeChannel();
                        DGChannel.Rows[selectedIndex].Selected = true;// Das verschobene Objekt an der neuen Stelle selektieren
                    }
                    else
                    {
                        DGChannel.Rows.Remove(DGChannel.CurrentRow);
                        BackgroundChange(); SortbyNewIndex();
                        ChangeChannel();
                        DGChannel.Rows[selectedIndex - 1].Selected = true;
                    }
                }
                changed = false;
            }
            catch { }
        }
        //Bereitet die Groupbox vor um Sender hinzuzufügen
        private void btnAddChannel_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false; btnAddChannel.Enabled = false;
            if (DGChannel.RowCount != 0)
            {
                btnAddClose.Enabled = true; btnAddClose.Visible = true;
            }
            grpChange.Visible = true; grpChange.Enabled = true; btnAdd.Visible = true; btnAdd.Enabled = true; btnChangeOK.Visible = false; btnChangeOK.Enabled = false;
            try { CBChangeGroup.SelectedIndex = 0; } catch { }
            txtChangeIP.Clear(); txtChangeLogo.Clear(); txtChangeName.Clear(); txtChangeNameEPG.Clear(); txtChangeIDEPG.Clear(); txtChangeEPGShift.Clear();
            txtSort.Text = Convert.ToString(DGChannel.Rows.Count + 1); txtChangeName.Select(); btnAddClose.Visible = true; CBTVRadio.SelectedIndex = 0;
        }
        // Favoritenlist bearbeiten
        private void btnFavourite_Click(object sender, EventArgs e)
        {
            FormFavourite frmFav = new FormFavourite(lang, Favourite);
            frmFav.ShowDialog();
            if (frmFav.save == true)
            {
                string[] Favourite2 = frmFav.Fav;
                // Falls Favoriten hinzugefügt wurden
                if (Favourite != null)
                {
                    if (Favourite2.Length > Favourite.Length)
                    {
                        string[] FavHelp = new string[Favourite2.Length - Favourite.Length];
                        for (int f = 0; f < Favourite2.Length - Favourite.Length; f++)
                        {
                            FavHelp[f] = Favourite2[Favourite.Length + f];
                        }
                        string[] Fav = Favourite;
                        Favourite = new string[Fav.Length + FavHelp.Length];
                        Array.Copy(Fav, Favourite, Fav.Length);
                        Array.Copy(FavHelp, 0, Favourite, Fav.Length, FavHelp.Length);
                    }
                    //
                    for (int i = 0; i < Favourite.Length; i++)
                    {
                        if (Favourite[i] != Favourite2[i])
                        {
                            //löscht Favorit aus den Datagrid-Sendern raus
                            if (Favourite2[i] == "---||| (Deleted) |||---")
                            {
                                for (int j = 0; j < DGChannel.Rows.Count; j++)
                                {
                                    if (DGChannel[5, j].Value.ToString() == Favourite[i])
                                    {
                                        DGChannel[5, j].Value = "";
                                    }
                                }
                                Favourite[i] = "";
                            }
                            // Für Namenänderungen
                            else
                            {
                                for (int k = 0; k < DGChannel.Rows.Count; k++)
                                {
                                    if (DGChannel[5, k].Value.ToString() == Favourite[i])
                                    {
                                        DGChannel[5, k].Value = Favourite2[i];
                                    }
                                }
                                Favourite[i] = Favourite2[i];
                            }
                        }
                    }
                }
                FavouriteHelp();
            }
        }
        //
        // File (Toolstripmenu)
        private void TSMNew_Click(object sender, EventArgs e)
        {
            if (changed == true)//Falls sich etwas verändert hat, erst nachfragen ob Einträge gelöscht werden sollten
            {
                DialogResult dr = MessageBox.Show(SafeWarning, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    grpChange.Enabled = true;
                    // initialisiert Datagrid
                    DGChannel.Rows.Clear(); DGChannel.Columns.Clear(); DGChannel.ColumnCount = 9; DGChannelTitel();
                    btnAddChannel.PerformClick();
                    changed = false;
                }
            }
            if (changed == false)
            {
                grpChange.Enabled = true;
                // initialisiert Datagrid
                DGChannel.Rows.Clear(); DGChannel.Columns.Clear(); DGChannel.ColumnCount = 9; DGChannelTitel();
                btnAddChannel.PerformClick();
            }

            Favourite = null; FavouriteHelp(); Favourite = null;
        }
        // File -> TSMOpenM3U
        // Öffnet M3U - Datei vom Ordner
        private void TSMM3UfromFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "M3U-file (*.m3u)|*.m3u";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if (DGChannel.RowCount == 0)
                {
                    DGChannel.Rows.Clear(); DGChannel.Columns.Clear(); DGChannel.ColumnCount = 9; DGChannelTitel();
                }
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);//StreamReader für Datei initialisieren
                                                                                                   // alle Zeile in Schleife ausgeben und weiter auseinander nehmen
                string Unsplitted = file.ReadToEnd();
                file.Close();
                OpenM3U(Unsplitted);

                DGChannel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                SortbyNewIndex(); BackgroundChange();
                if (DGChannel.RowCount != 0) this.DGChannel.Rows[0].Selected = true;
                LogoCheck(); EPGCheck(); Favourite = null; FavouriteHelp(); ChangeChannel();
            }
        }
        // Öffnet M3U - Datei vom URL
        private void TSMM3UfromURL_Click(object sender, EventArgs e)
        {
            grpURL.Visible = true;
            DGChannel.Enabled = false; TSMSortby.Enabled = false; TSMTools.Enabled = false; TSMFile.Enabled = false; TSMOthers.Enabled = false;
            if (m3uURL == "") txtURL.Text = "http://";
            else txtURL.Text = m3uURL;
        }
        // Öffnet M3U - Datei mit eingefügtem Code
        private void TSMM3UfromCode_Click(object sender, EventArgs e)
        {
            string M3UCode = "";
            FormAddCode frmAC = new FormAddCode(lang);
            frmAC.ShowDialog();
            try
            {
                M3UCode = frmAC.setText();
                if (DGChannel.RowCount == 0)
                {
                    DGChannel.Rows.Clear(); DGChannel.Columns.Clear(); DGChannel.ColumnCount = 9; DGChannelTitel();
                }
                OpenM3U(M3UCode);
                DGChannel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                SortbyNewIndex(); BackgroundChange();
                if (DGChannel.RowCount != 0) this.DGChannel.Rows[0].Selected = true;
                ChangeChannel(); LogoCheck(); EPGCheck(); Favourite = null; FavouriteHelp();
            }
            catch { }
        }
        //
        //TSMFTP
        //
        //
        // Server Einstellungen
        private void TSMFTPConfig_Click(object sender, EventArgs e)
        {
            txtFTPUser.Text = FTPUser;
            txtFTPPw.Text = FTPPw;
            txtFTPIP.Text = FTPIP;
            txtFTPDir.Text = FTPDir;
            if (FTPFilename == "") FTPFilename = "List.m3u";
            txtFTPFilename.Text = FTPFilename;
            if (FTPorSFTP == 0)
            {
                rbFTP.Checked = false; rbSFTP.Checked = true;
            }
            else
            {
                rbSFTP.Checked = false; rbFTP.Checked = true;
            }
            grpFTP.Left = (this.Width - grpFTP.Width) / 2;
            grpFTP.Top = (this.Height - grpFTP.Height) / 2;
            grpFTP.Visible = true;
            DGChannel.Enabled = false; TSMSortby.Enabled = false; TSMTools.Enabled = false; TSMFile.Enabled = false; TSMOthers.Enabled = false;

        }
        private void TSMFTPUpload_Click(object sender, EventArgs e)
        {
            string ftpurl = FTPIP + FTPDir;
            string source = pth + "\\temp\\" + FTPFilename;
            //M3U - Datei schreiben
            string Testo = CreateM3UFromList();
            File.WriteAllText(source, Testo, Encoding.UTF8);
            if (FTPDir != "" && FTPFilename != "" && ftpurl != "" && FTPPw != "" && FTPUser != "")
            {
                if (FTPDir.StartsWith("/") == false) FTPDir = "/" + FTPDir;
                if (FTPDir.EndsWith("/") == false) FTPDir = FTPDir + "/";
                string upload = UploadFileToServer(FTPorSFTP, source, FTPIP, FTPDir, FTPUser, FTPPw, pth);
                MessageBox.Show(upload, "", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Please check FTP - Config");            
        }
        //FTP - Einstellung schließen mit Änderung speichern
        private void btnFTPSave_Click(object sender, EventArgs e)
        {
            //in default.config speichern
            if (rbFTP.Checked) FTPorSFTP = 1;
            else FTPorSFTP = 0;
            FTPUser = txtFTPUser.Text;
            FTPPw = txtFTPPw.Text;
            FTPIP = txtFTPIP.Text;
            FTPDir = txtFTPDir.Text;
            FTPFilename = txtFTPFilename.Text;
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i].Contains("FTP:<"))
                {
                    DefaultConfig[i] = "FTP:<" + FTPorSFTP + ">";
                }
                if (DefaultConfig[i].Contains("FTPUser:<"))
                {
                    DefaultConfig[i] = "FTPUser:<" + FTPUser + ">";
                }
                if (DefaultConfig[i].Contains("FTPPw:<"))
                {
                    DefaultConfig[i] = "FTPPw:<" + FTPPw + ">";
                }
                if (DefaultConfig[i].Contains("FTPIP:<"))
                {
                    DefaultConfig[i] = "FTPIP:<" + FTPIP + ">";
                }
                if (DefaultConfig[i].Contains("FTPDir:<"))
                {
                    DefaultConfig[i] = "FTPDir:<" + FTPDir + ">";
                }
                if (DefaultConfig[i].Contains("FTPFilename:<"))
                {
                    DefaultConfig[i] = "FTPFilename:<" + FTPFilename + ">";
                }
            }
            WriteInDefaultConfig();

            grpFTP.Visible = false;
            DGChannel.Enabled = true; TSMSortby.Enabled = true; TSMTools.Enabled = true; TSMFile.Enabled = true; TSMOthers.Enabled = true;
        }
        //FTP - Einstellung schließen ohne Änderung speichern
        private void btnFTPCancel_Click(object sender, EventArgs e)
        {
            grpFTP.Visible = false;
            DGChannel.Enabled = true; TSMSortby.Enabled = true; TSMTools.Enabled = true; TSMFile.Enabled = true; TSMOthers.Enabled = true;
        }
        // Speichert die Tabelle als M3U-Datei
        private void TSMSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGChannel.Rows.Count != 0)
                {
                    saveFileDialog1.Filter = "M3U-file (*.m3u)|*.m3u";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.RestoreDirectory = true;
                    saveFileDialog1.ShowDialog();
                    string Testo = CreateM3UFromList();
                    File.WriteAllText(saveFileDialog1.FileName, Testo, Encoding.UTF8);
                    changed = false;
                    MessageBox.Show(SaveSuccess, "", MessageBoxButtons.OK);
                }
                else MessageBox.Show(SaveError2, "", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show(SaveError, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //
        //
        //Tools
        //Tools -> Blacklist
        private void TSMOpenBlacklistEditor_Click(object sender, EventArgs e)
        {
            Blacklist BList = new Blacklist(lang);
            BList.Show();
        }
        private void TSMLoadBlacklist_Click(object sender, EventArgs e)
        {
            OFDBlacklist.Title = "Open Text File";
            OFDBlacklist.Filter = "TXT files|*.txt";
            OFDBlacklist.RestoreDirectory = true;
            if (OFDBlacklist.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader fileReader = new StreamReader(OFDBlacklist.OpenFile()))
                {
                    try
                    {
                        //     int ende = File.ReadAllLines(fileReader.ReadLine()).Length;
                        //  while (fileReader.ReadLine() != null) ende++;
                        string[] NeuSender = fileReader.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        fileReader.Close();
                        DataGridViewRow[] rows = new DataGridViewRow[this.DGChannel.Rows.Count];// Gleichgroßes Array erstellen
                        for (int j = 0; j < DGChannel.Rows.Count; j++)
                        {
                            string Tester = Convert.ToString(DGChannel.Rows[j].Cells[1].Value);
                            //   for (int z = ende; z != 0; z--)
                            for (int z = 1; z <= NeuSender.Count(); z++)
                            {
                                if (Tester == NeuSender[z - 1].ToString())
                                {
                                    DGChannel.Rows.Remove(DGChannel.Rows[j]);
                                    j = z - 1;
                                    changed = false;
                                }
                            }
                        }
                        BackgroundChange(); SortbyNewIndex(); FavouriteHelp();
                    }
                    catch { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        //Tools -> Duplicate
        private void TSMDuplicate_Click(object sender, EventArgs e)
        {
            int ChannelCount = DGChannel.RowCount;
            string[] Channelname = new string[ChannelCount];
            for (int i = 0; i < ChannelCount; i++)
            {
                Channelname[i] = DGChannel.Rows[i].Cells[1].Value.ToString();
            }
            if (ChannelCount > 1)
            {
                int zaehler = 0;
                FormDuplicate frmDup = new FormDuplicate(lang, ChannelCount, Channelname);
                frmDup.ShowDialog();
                int[] Dupli = frmDup.setDuplicate();
                //Auf Leerzeichen achten oder nicht
                string Leerzeichen = "";
                if (Dupli[9] == 1) Leerzeichen = " ";
                else Leerzeichen = "";
                //Groß und Kleinschreibung
                bool grossklein = true;
                if (Dupli[8] == 1) grossklein = false;
                //Nach Duplikate suchen von ... bis...
                int from = Dupli[11], from2 = Dupli[11];
                int till = Dupli[12] + 2, till2 = Dupli[12] + 2;
                // Nur von einen bestimmten Sender Duplikate suchen
                if (Dupli[10] >= 1)
                {
                    from = Dupli[10];
                    till = Dupli[10] + 1;
                }
                if (Dupli[0] == 1)
                {
                    for (int i = from; i < till; i++)
                    {
                        //
                        string DupName = DGChannel.Rows[i].Cells[1].Value.ToString().Replace(" ", Leerzeichen);
                        string DupEPGID = DGChannel.Rows[i].Cells[2].Value.ToString().Replace(" ", Leerzeichen);
                        string DupEPGName = DGChannel.Rows[i].Cells[3].Value.ToString().Replace(" ", Leerzeichen);
                        string DupFav = DGChannel.Rows[i].Cells[5].Value.ToString().Replace(" ", Leerzeichen);
                        string DupIP = DGChannel.Rows[i].Cells[6].Value.ToString().Replace(" ", Leerzeichen);
                        string DupLogo = DGChannel.Rows[i].Cells[7].Value.ToString().Replace(" ", Leerzeichen);
                        string DupRadioTV = DGChannel.Rows[i].Cells[8].Value.ToString().Replace(" ", Leerzeichen);
                        //
                        for (int j = from2; j < till2; j++)
                        {
                            //
                            int resultName = string.Compare(DupName, DGChannel.Rows[j].Cells[1].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            int resultEPGID = string.Compare(DupEPGID, DGChannel.Rows[j].Cells[2].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            int resultEPGName = string.Compare(DupEPGName, DGChannel.Rows[j].Cells[3].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            int resultFav = string.Compare(DupFav, DGChannel.Rows[j].Cells[5].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            int resultIP = string.Compare(DupIP, DGChannel.Rows[j].Cells[6].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            int resultLogo = string.Compare(DupLogo, DGChannel.Rows[j].Cells[7].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            int resultRadioTV = string.Compare(DupRadioTV, DGChannel.Rows[j].Cells[8].Value.ToString().Replace(" ", Leerzeichen), grossklein);
                            //
                            if (Dupli[1] != 1) resultName = 0;
                            if (Dupli[2] != 1) resultEPGID = 0;
                            if (Dupli[3] != 1) resultEPGName = 0;
                            if (Dupli[4] != 1) resultFav = 0;
                            if (Dupli[5] != 1) resultIP = 0;
                            if (Dupli[6] != 1) resultLogo = 0;
                            if (Dupli[7] != 1) resultRadioTV = 0;
                            //
                            if ((resultName == 0) && (resultEPGID == 0) && (resultEPGName == 0) && (resultFav == 0) && (resultIP == 0) && (resultLogo == 0) && (resultRadioTV == 0))
                            {
                                if (i != j && DGChannel.Rows[j].Cells[0].Value.ToString() != "Y")
                                {
                                    DGChannel.Rows[i].Cells[0].Value = "Y";
                                    DGChannel.Rows[j].Cells[0].Value = "X";
                                }
                            }
                        }
                    }
                    for (int m = DGChannel.Rows.Count - 1; m > 0; m--) // löscht die Duplikate
                    {
                        if (DGChannel.Rows[m].Cells[0].Value.ToString() == "X")
                        {
                            DGChannel.Rows.Remove(DGChannel.Rows[m]);
                            zaehler++;
                        }
                    }
                }
                SortbyNewIndex(); BackgroundChange(); changed = false;
                MessageBox.Show(MessageDuplicates + " " + zaehler, "", MessageBoxButtons.OK);
            }
        }
        //Tools -> Logo
        private void TSMChangeLogoPath_Click(object sender, EventArgs e)
        {
            try
            {
                if (FBDLogo.ShowDialog() == DialogResult.OK)
                {
                    LogoDir = FBDLogo.SelectedPath;
                    LogoCheck();
                    MessageBox.Show(LogoLoadOK, "", MessageBoxButtons.OK);
                }
                if (FBDLogo.SelectedPath != "")
                {
                    DialogResult dr = MessageBox.Show(SafeQuestionLogo, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < DefaultConfig.Length; i++)
                        {
                            if (DefaultConfig[i].Contains("LogoDir:<"))
                            {
                                DefaultConfig[i] = "LogoDir:<" + LogoDir + ">";
                            }
                        }
                        WriteInDefaultConfig();
                    }
                }
            }
            catch { MessageBox.Show(LogoLoadError, "", MessageBoxButtons.OK); }
        }
        private void TSMLogoUpdate_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("http://raspy.bplaced.net/download/logos.zip"), @"logos.zip");
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PbLoad.Value = e.ProgressPercentage;
            PbLoad.Visible = true;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            string pth = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
            string zipping = pth + "\\logos.zip";
            string destPath = pth + "\\logos";
            UnZip(zipping, destPath);
            try
            {
                LogoCheck();
            }
            catch { }
            MessageBox.Show(LogoDownload, "", MessageBoxButtons.OK);
            PbLoad.Visible = false;
        }
        //Tools -> EPG
        //Öffnet und lädt EPG vom Internet
        private void TSMOpenEPGFromInternet_Click(object sender, EventArgs e)
        {
            m3uorepg = false;
            grpURL.Visible = true;
            DGChannel.Enabled = false; TSMSortby.Enabled = false; TSMTools.Enabled = false; TSMFile.Enabled = false; TSMOthers.Enabled = false;
            txtURL.Text = "http://";
        }
        //Öffnet und lädt EPG-Datei vom Computer
        private void TSMOpenEPGFromFile_Click(object sender, EventArgs e)
        {
            m3uorepg = false;
            OFDEpg.Filter = "EPG-file (*.xml , *.gz)|*.xml; *.gz|All files|*.*";
            OFDEpg.FilterIndex = 1;
            OFDEpg.RestoreDirectory = true;
            if (OFDEpg.ShowDialog() == DialogResult.OK)
            {
                string url = OFDEpg.FileName;
                LoadEPG(url);
            }
            EPGCheck();
        }
        //ersetzt die Leerzeichen in "_" um
        private void TSMEpgCheckSimpleIPTV_Click(object sender, EventArgs e)
        {
            EPGCheck();
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i].Contains("SimpleIPTV = 1"))
                {
                    DefaultConfig[i] = "SimpleIPTV = 0";
                }
                else if (DefaultConfig[i].Contains("SimpleIPTV = 0"))
                {
                    DefaultConfig[i] = "SimpleIPTV = 1";
                }
            }
            WriteInDefaultConfig();
        }
        //Benennt die IP-Endung .ts in m3u8 um
        private void TSMRenameIPEndToM3U8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGChannel.RowCount; i++)
            {
                string IPOrig = DGChannel.Rows[i].Cells[6].Value.ToString();
                string IPNew = "";
                if (IPOrig.EndsWith(".ts"))
                {
                    IPNew = IPOrig.Replace(".ts", ".m3u8");
                    DGChannel.Rows[i].Cells[6].Value = IPNew;
                }
            }
        }
        private void btnURLCANCEL_Click(object sender, EventArgs e)
        {
            grpURL.Visible = false;
            DGChannel.Enabled = true; TSMSortby.Enabled = true; TSMTools.Enabled = true; TSMFile.Enabled = true; TSMOthers.Enabled = true;
        }
        // wird für epg und m3u - Dateien beutzt
        private void btnURL_Click(object sender, EventArgs e)
        {
            if (m3uorepg == true)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    string urldownload = pth + "\\temp\\downloadedM3U";
                    webClient.DownloadFile(txtURL.Text, urldownload);

                    System.IO.StreamReader ReadM3U = new System.IO.StreamReader(urldownload);
                    string Unsplitted = ReadM3U.ReadToEnd();
                    ReadM3U.Close();

                    if (DGChannel.RowCount == 0)
                    {
                        DGChannel.Rows.Clear(); DGChannel.Columns.Clear(); DGChannel.ColumnCount = 9; DGChannelTitel();
                    }

                    OpenM3U(Unsplitted);

                    DGChannel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    SortbyNewIndex(); BackgroundChange();
                    if (DGChannel.RowCount != 0) this.DGChannel.Rows[0].Selected = true;
                    LogoCheck(); EPGCheck(); Favourite = null; FavouriteHelp(); ChangeChannel();

                    if (m3uURL != txtURL.Text)
                    {
                        DialogResult dr = MessageBox.Show(SafeQuestion, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            m3uURL = txtURL.Text;
                            for (int i = 0; i < DefaultConfig.Length; i++)
                            {
                                if (DefaultConfig[i].Contains("m3uURL:<"))
                                {
                                    DefaultConfig[i] = "m3uURL:<" + txtURL.Text + ">";
                                }
                            }
                            WriteInDefaultConfig();
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Invalid URL", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                LoadEPG(txtURL.Text);
                EPGCheck();
            }
            grpURL.Visible = false;
            DGChannel.Enabled = true; TSMSortby.Enabled = true; TSMTools.Enabled = true; TSMFile.Enabled = true; TSMOthers.Enabled = true;
        }

        //
        //Sort (Toolstripmenu)
        // Sortiert Sender nach Name von a-z und umgekehrt
        private void TSMSortbyName_Click(object sender, EventArgs e)
        {
            if (DGChannel.RowCount != 0)
            {
                string[] NewText;
                if (TSMSortbyName.Text == "Sortiere Sender nach Name (A-Z)" || TSMSortbyName.Text == "Sort channels by name (A-Z)" || TSMSortbyName.Text == "Ordina canali dal nome (A-Z)")
                {
                    DGChannel.Sort(DGChannel.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
                    NewText = TSMSortbyName.Text.Split('(');
                    TSMSortbyName.Text = NewText[0] + "(Z-A)";
                    BackgroundChange(); SortbyNewIndex(); changed = true;
                }
                else
                {
                    DGChannel.Sort(DGChannel.Columns[1], System.ComponentModel.ListSortDirection.Descending);
                    NewText = TSMSortbyName.Text.Split('(');
                    TSMSortbyName.Text = NewText[0] + "(A-Z)";
                    BackgroundChange(); SortbyNewIndex(); changed = true;
                }
                changed = false;
            }
        }
        //Sortiert Sender nach Favoriten von a-z und umgekehrt
        private void TSMSortbyFavourite_Click(object sender, EventArgs e)
        {
            if (DGChannel.RowCount != 0)
            {
                string[] NewText;
                if (TSMSortbyFavourite.Text == "Sort channels by favourite (A-Z)" || TSMSortbyFavourite.Text == "Sortiere Sender nach Favorit (A-Z)" || TSMSortbyFavourite.Text == "Ordina canali da favoriti (A-Z)")
                {
                    DGChannel.Sort(DGChannel.Columns[5], System.ComponentModel.ListSortDirection.Ascending);
                    NewText = TSMSortbyFavourite.Text.Split('(');
                    TSMSortbyFavourite.Text = NewText[0] + "(Z-A)";
                    BackgroundChange(); SortbyNewIndex(); changed = true;
                }
                else
                {
                    DGChannel.Sort(DGChannel.Columns[5], System.ComponentModel.ListSortDirection.Descending);
                    NewText = TSMSortbyFavourite.Text.Split('(');
                    TSMSortbyFavourite.Text = NewText[0] + "(A-Z)";
                    BackgroundChange(); SortbyNewIndex(); changed = true;
                }
                changed = false;
            }
        }
        //Versucht die Sender von einer M3U-Datei zu sortieren
        private void TSMSortbyFile_Click(object sender, EventArgs e)
        {
            OFDSort.Filter = "M3U-file (*.m3u)|*.m3u"; // Öffne nur  M3U - Datei
            OFDSort.FilterIndex = 2;
            OFDSort.RestoreDirectory = true;
            if (OFDSort.ShowDialog() == DialogResult.OK && DGChannel.Rows.Count != 0)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(OFDSort.FileName);//StreamReader für Datei initialisieren
                string Unsplitted = file.ReadToEnd();
                file.Close();
                string[] Kanal = Unsplitted.Split(new string[] { "#EXTINF" }, StringSplitOptions.None); //Die ganze Liste splitten
                string[] NeuSender = new string[Kanal.Length];
                string[] NeuGruppe = new string[Kanal.Length];
                string[] NeuEPGID = new string[Kanal.Length];
                string[] NeuEPG = new string[Kanal.Length];
                string[] NeuEPGShift = new string[Kanal.Length];
                string[] NeuLogo = new string[Kanal.Length];
                string[] NeuRadio = new string[Kanal.Length];
                for (int i = 1; i < Kanal.Length; i++)
                {
                    string[] IP = Kanal[i].Split(new string[] { "\n" }, StringSplitOptions.None);
                    string[] Channel = Kanal[i].Split(',', '\n');
                    string[] Group1, Group2, Logo1, Logo2, TVGName1, TVGName2, TVGID1, TVGID2, TVGShift1, TVGShift2, Radio2, Radio1;
                    string Group = "", Logo = "", TVGName = "", TVGID = "", TVGShift = "", Radio = "TV";
                    if (Kanal[i].Contains("group-title="))
                    {
                        Group1 = Kanal[i].Split(new string[] { "group-title=" }, StringSplitOptions.None);
                        Group2 = Group1[1].Split('"', '"');
                        Group = Group2[1];
                    }
                    if (Kanal[i].Contains("tvg-logo="))
                    {
                        Logo1 = Kanal[i].Split(new string[] { "tvg-logo=" }, StringSplitOptions.None);
                        Logo2 = Logo1[1].Split('"', '"');
                        Logo = Logo2[1];
                    }
                    if (Kanal[i].Contains("radio="))
                    {
                        Radio2 = Kanal[i].Split(new string[] { "radio=" }, StringSplitOptions.None);
                        Radio1 = Radio2[1].Split('"', '"');
                        Radio = Radio1[1];
                        if (Radio == "true") Radio = "Radio";
                        else Radio = "TV";
                    }
                    if (Kanal[i].Contains("tvg-name="))
                    {
                        TVGName1 = Kanal[i].Split(new string[] { "tvg-name=" }, StringSplitOptions.None);
                        TVGName2 = TVGName1[1].Split('"', '"');
                        TVGName = TVGName2[1];
                    }
                    if (Kanal[i].Contains("tvg-id="))
                    {
                        TVGID1 = Kanal[i].Split(new string[] { "tvg-id=" }, StringSplitOptions.None);
                        TVGID2 = TVGID1[1].Split('"', '"');
                        TVGID = TVGID2[1];
                    }
                    if (Kanal[i].Contains("tvg-shift="))
                    {
                        TVGShift1 = Kanal[i].Split(new string[] { "tvg-shift=" }, StringSplitOptions.None);
                        TVGShift2 = TVGShift1[1].Split('"', '"');
                        TVGShift = TVGShift2[1];
                    }
                    // Sortieren.Rows.Add(i, Channel[1], TVGName, Group, "http://" + IP[1], Logo);
                    NeuSender[i] = Channel[1].Replace('\r'.ToString(), string.Empty);
                    NeuEPGID[i] = TVGID;
                    NeuEPG[i] = TVGName;
                    NeuGruppe[i] = Group;
                    NeuLogo[i] = Logo;
                    NeuEPGShift[i] = TVGShift;
                    NeuRadio[i] = Radio;
                }
                int ende = Kanal.Length;
                int waage = DGChannel.Rows.Count - Kanal.Length;
                if (waage < 0) //Damit die Senderliste in der Tabelle nicht kleiner als die geladene Senderliste ist
                {
                    waage = -waage;
                    for (int i = 1; i < waage; i++)
                    {
                        DGChannel.Rows.Add("X", "", "", "", "", "", "", "", "");
                    }
                }
                int tcnt = 0;
                DataGridView TestView = new DataGridView();
                TestView.Rows.Clear(); TestView.Columns.Clear();
                TestView.ColumnCount = 9;
                for (int z = 0; z < ende - 1; z++)
                {
                    string TesterNew = Convert.ToString(NeuSender[z]);
                    for (int j = 0; j < DGChannel.Rows.Count; j++)
                    {
                        string TesterDG = Convert.ToString(DGChannel.Rows[j].Cells[1].Value);
                        if (TesterDG == TesterNew)
                        {
                            TestView.Rows.Add(tcnt, TesterDG, NeuEPGID[z], NeuEPG[z], NeuEPGShift[z], NeuGruppe[z], DGChannel.Rows[j].Cells[6].Value, NeuLogo[z], NeuRadio[z]);
                            DGChannel.Rows.RemoveAt(j);
                            j = 0;
                            tcnt++;
                        }
                    }
                }
                for (int m = DGChannel.Rows.Count - 1; m > 0; m--) // löscht die leeren Einträge
                {
                    if (DGChannel.Rows[m].Cells[0].Value.ToString() == "X")
                    {
                        DGChannel.Rows.Remove(DGChannel.Rows[m]);
                    }
                }
                for (int ai = 0; ai < DGChannel.Rows.Count; ai++) //fügt die restlichen in der Tabelle an der hinteren Stelle
                {
                    TestView.Rows.Add(DGChannel.Rows[ai].Cells[0].Value, DGChannel.Rows[ai].Cells[1].Value, DGChannel.Rows[ai].Cells[2].Value, DGChannel.Rows[ai].Cells[3].Value, DGChannel.Rows[ai].Cells[4].Value, DGChannel.Rows[ai].Cells[5].Value, DGChannel.Rows[ai].Cells[6].Value, DGChannel.Rows[ai].Cells[7].Value, DGChannel.Rows[ai].Cells[8].Value);
                }
                DGChannel.Rows.Clear(); DGChannel.Columns.Clear(); DGChannel.ColumnCount = 9; DGChannelTitel(); // Starte neu DGChannel
                for (int di = 0; di < TestView.Rows.Count - 1; di++) // DGChannel wird mit neue Tabelle beschrieben
                {
                    DGChannel.Rows.Add(TestView.Rows[di].Cells[0].Value, TestView.Rows[di].Cells[1].Value, TestView.Rows[di].Cells[2].Value, TestView.Rows[di].Cells[3].Value, TestView.Rows[di].Cells[4].Value, TestView.Rows[di].Cells[5].Value, TestView.Rows[di].Cells[6].Value, TestView.Rows[di].Cells[7].Value, TestView.Rows[di].Cells[8].Value);
                }
                BackgroundChange(); SortbyNewIndex();
                DGChannel.Rows[0].Selected = true; changed = true;
                LogoCheck(); EPGCheck(); Favourite = null; FavouriteHelp(); ChangeChannel();
            }
        }
        //
        //Others
        private void TSMInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Info, "Info", MessageBoxButtons.OK);
        }
        private void TSMCheckUpdate_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string strUpdate = webClient.DownloadString("http://tvtools.tk/download/IPTVEdit.ver");
            if (strUpdate == VersionNr)
            {
                MessageBox.Show(MessageVersionOK, "Update", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show(MessageVersionOld, "Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"http://tvtools.tk/download/IPTVEdit.zip");
                }
            }
        }
        //Others -> Language
        private void TSMEng_Click(object sender, EventArgs e) { languageENG(); }
        private void TSMIta_Click(object sender, EventArgs e) { languageITA(); }
        private void TSMGer_Click(object sender, EventArgs e) { languageGER(); }
        //
        //UNTERPROGRAMME
        //
        // importiert M3U- Dateien in dem Datagridview
        private string CreateM3UFromList()
        {
            string Testo = "";
            Testo = "#EXTM3U" + Environment.NewLine;
            for (int i = 0; i < DGChannel.Rows.Count; i++)
            {
                string tvgname = DGChannel[3, i].Value.ToString().Replace("\r", "");
                string tvgshift = DGChannel[4, i].Value.ToString().Replace("\r", "");
                string tvglogo = DGChannel[7, i].Value.ToString().Replace("\r", "");

                string grouptitle = "";
                if (DGChannel[5, i].Value != null) grouptitle = DGChannel[5, i].Value.ToString().Replace("\r", "");

                string sendername = DGChannel[1, i].Value.ToString().Replace("\r", "");
                string tvgid = DGChannel[2, i].Value.ToString().Replace("\r", "");
                string senderip = DGChannel[6, i].Value.ToString().Replace("\r", "");

                string tvradio = DGChannel[8, i].Value.ToString().Replace("\r", "");
                if (tvradio == "TV") tvradio = "";
                else tvradio = "true";

                Testo = Testo + "#EXTINF:-1 tvg-id=" + '\u0022' + tvgid + '\u0022' + " tvg-name=" + '\u0022' + tvgname + '\u0022' + " tvg-shift=" + '\u0022' + tvgshift + '\u0022' + " radio=" + '\u0022' + tvradio + '\u0022' + " tvg-logo=" + '\u0022' + tvglogo + '\u0022' + " group-title=" + '\u0022' + grouptitle + '\u0022' + "," + sendername + Environment.NewLine + senderip + Environment.NewLine;
            }
            return Testo;
        }
        // Setzt M3U-Liste in Datagrid ein
        private void OpenM3U(string UnsplittedText)
        {
            string[] Kanal = UnsplittedText.Split(new string[] { "#EXTINF" }, StringSplitOptions.None);
            for (int i = 1; i < Kanal.Length; i++)
            {
                string[] IP = Kanal[i].Split(new string[] { "\n" }, StringSplitOptions.None);
                if (IP.Length <= 1) // Falls der Letzte Sender keine IP hat, bricht das Programm nicht zusammen
                {
                    IP = new string[2];
                    IP[1] = "";
                }
                string[] Channel = Kanal[i].Split(',', '\n');
                string[] Group1, Group2, Logo1, Logo2, TVGName1, TVGName2, TVGID1, TVGID2, TVGShift1, TVGShift2, Radio2, Radio1;
                string Programm = "", URL = "", Group = "", Logo = "", TVGName = "", TVGID = "", TVGShift = "", Radio = "TV";
                Programm = Channel[1].Replace('\r'.ToString(), string.Empty);
                URL = IP[1].Replace('\r'.ToString(), string.Empty);
                if (Kanal[i].Contains("group-title="))
                {
                    Group1 = Kanal[i].Split(new string[] { "group-title=" }, StringSplitOptions.None);
                    Group2 = Group1[1].Split('"', '"');
                    Group = Group2[1];
                }
                if (Kanal[i].Contains("tvg-logo="))
                {
                    Logo1 = Kanal[i].Split(new string[] { "tvg-logo=" }, StringSplitOptions.None);
                    Logo2 = Logo1[1].Split('"', '"');
                    Logo = Logo2[1];
                }
                if (Kanal[i].Contains("radio="))
                {
                    Radio2 = Kanal[i].Split(new string[] { "radio=" }, StringSplitOptions.None);
                    Radio1 = Radio2[1].Split('"', '"');
                    Radio = Radio1[1];
                    if (Radio == "true") Radio = "Radio";
                    else Radio = "TV";
                }
                if (Kanal[i].Contains("tvg-name="))
                {
                    TVGName1 = Kanal[i].Split(new string[] { "tvg-name=" }, StringSplitOptions.None);
                    TVGName2 = TVGName1[1].Split('"', '"');
                    TVGName = TVGName2[1];
                }
                if (Kanal[i].Contains("tvg-id="))
                {
                    TVGID1 = Kanal[i].Split(new string[] { "tvg-id=" }, StringSplitOptions.None);
                    TVGID2 = TVGID1[1].Split('"', '"');
                    TVGID = TVGID2[1];
                }
                if (Kanal[i].Contains("tvg-shift="))
                {
                    TVGShift1 = Kanal[i].Split(new string[] { "tvg-shift=" }, StringSplitOptions.None);
                    TVGShift2 = TVGShift1[1].Split('"', '"');
                    TVGShift = TVGShift2[1];
                }
                DGChannel.Rows.Add(i, Programm, TVGID, TVGName, TVGShift, Group, URL, Logo, Radio);
            }
        }
        // entpackt die runtergeladene Logo-Datei
        public static void UnZip(string zipFile, string folderPath)
        {
            if (!File.Exists(zipFile))
                throw new FileNotFoundException();

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            Shell32.Shell objShell = new Shell32.Shell();
            Shell32.Folder destinationFolder = objShell.NameSpace(folderPath);
            Shell32.Folder sourceFile = objShell.NameSpace(zipFile);

            foreach (var file in sourceFile.Items())
            {
                destinationFolder.CopyHere(file, 4 | 16);
            }
        }
        // entpackt die EPG-Datei aus der GZip - Datei
        public static void Decompress(FileInfo fileToDecompress, string newFilePath)
        {
            try
            {
                using (FileStream originalFileStream = fileToDecompress.OpenRead())
                {
                    string currentFileName = fileToDecompress.FullName;
                    //    string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);
                    if (File.Exists(newFilePath))
                    {
                        File.Delete(newFilePath);
                    }
                    using (FileStream decompressedFileStream = File.Create(newFilePath))
                    {
                        using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(decompressedFileStream);
                            Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                        }
                    }
                }
            }
            catch { }
        }
        // filtert von der XML-Datei die Werte für EPG-ID und EPG-Name
        private void LoadEPG(string url)
        {
            bool ok = true;
            string EPGDirNew = "";
            if (url.StartsWith("http") || url.StartsWith("www."))
            {
                try
                {
                    EPGDirNew = url;
                    WebClient webClient = new WebClient();
                    string urldownload = pth + "\\temp\\downloadedEPG";
                    webClient.DownloadFile(url, urldownload);
                    if (url.EndsWith(".gz"))
                    {
                        // UnZip(OFDEpg.FileName, url);
                        FileInfo filetodecompress = new FileInfo(urldownload);

                        url = pth + "\\temp\\xmlfile.xml";
                        Decompress(filetodecompress, url);
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid URL", "Error", MessageBoxButtons.OK);
                    ok = false;
                }
            }
            else
            {
                if (url.EndsWith(".gz"))
                {
                    // UnZip(OFDEpg.FileName, url);
                    FileInfo filetodecompress = new FileInfo(url);

                    url = pth + "\\temp\\xmlfile.xml";
                    Decompress(filetodecompress, url);
                }
                EPGDirNew = OFDEpg.FileName;
            }
            if (ok)
            {
                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(url);//StreamReader für Datei initialisieren
                                                                                  // alle Zeile in Schleife ausgeben und weiter auseinander nehmen
                    string Unsplitted = file.ReadToEnd();
                    string[] Kanal = Unsplitted.Split(new string[] { "<display-name", "</display-name>" }, StringSplitOptions.None);
                    string[] SenderName = new string[Kanal.Length];
                    string[] SenderID = new string[Kanal.Length];
                    string[] SenderID2 = new string[Kanal.Length];
                    EpgNames = new string[Convert.ToInt32(Kanal.Length / 2)];
                    EpgNamesSimple = new string[EpgNames.Length];
                    EPGID = new string[EpgNames.Length];
                    int j = 0, j2 = 0;
                    for (int i = 0; i < Kanal.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            SenderName = Kanal[i].Split(new string[] { ">" }, StringSplitOptions.None);
                            EpgNames[j] = SenderName[1];
                            j++;
                        }
                        try
                        {
                            if (i % 2 == 0)
                            {
                                SenderID = Kanal[i].Split(new string[] { "channel id=\"" }, StringSplitOptions.None);
                                // SenderID2 = SenderID.
                                SenderID2 = SenderID[1].Split(new string[] { "\"" }, StringSplitOptions.None);
                                EPGID[j2] = SenderID2[0];
                                //  EPGID[j2].Replace
                                j2++;
                            }
                        }
                        catch { }
                    }
                    for (int k = 0; k < EpgNames.Length; k++)//Für simpleIPTV konvertieren
                    {
                        EpgNamesSimple[k] = EpgNames[k].Replace(' ', '_');
                    }
                    if (EPGDirNew != EpgDir && EPGDirNew != "")
                    {
                        DialogResult dr = MessageBox.Show(SafeQuestion, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            EpgDir = EPGDirNew;
                            for (int i = 0; i < DefaultConfig.Length; i++)
                            {
                                if (DefaultConfig[i].Contains("EpgDir:<"))
                                {
                                    DefaultConfig[i] = "EpgDir:<" + EpgDir + ">";
                                }
                            }
                            WriteInDefaultConfig();

                        }
                    }
                    file.Close();
                }
                catch { }
            }
        }
        //
        private void ChangeChannel()
        {
            if (DGChannel.Rows.Count != 0 && DGChannel.SelectedRows.Count == 1)
            {
                //eliminaCanaleToolStripMenuItem1.Enabled = false; ChangeToolStripMenuItem.Enabled = false; AddToolStripMenuItem.Enabled = false;
                grpChange.Visible = true; grpChange.Enabled = true; btnAdd.Enabled = false; btnAdd.Visible = false; btnChangeOK.Enabled = true; btnChangeOK.Visible = true; btnAddClose.Enabled = false; btnAddClose.Visible = false;
                btnDelete.Enabled = true; btnDelete.Visible = true; btnAddChannel.Visible = true; btnAddChannel.Enabled = true;
                int selectedIndex = this.DGChannel.SelectedRows[0].Index;// Selektierten Index merken
                txtSort.Text = DGChannel[0, selectedIndex].Value.ToString();
                txtChangeName.Text = DGChannel[1, selectedIndex].Value.ToString();
                txtChangeIDEPG.Text = DGChannel[2, selectedIndex].Value.ToString();
                txtChangeNameEPG.Text = DGChannel[3, selectedIndex].Value.ToString();
                txtChangeEPGShift.Text = DGChannel[4, selectedIndex].Value.ToString();
                if (DGChannel[5, selectedIndex].Value != null) CBChangeGroup.SelectedItem = DGChannel[5, selectedIndex].Value.ToString();
                txtChangeIP.Text = DGChannel[6, selectedIndex].Value.ToString();
                txtChangeLogo.Text = DGChannel[7, selectedIndex].Value.ToString();
                CBTVRadio.SelectedItem = DGChannel[8, selectedIndex].Value.ToString();
                txtChangeName.Select();
                DGChannel.Select();
            }
            else
            {
                btnChangeOK.Enabled = false;
                txtChangeName.Text = "";
                txtChangeNameEPG.Text = "";
                txtChangeEPGShift.Text = "";
                CBChangeGroup.SelectedIndex = 0;
                txtChangeIP.Text = "";
                txtSort.Text = "";
                txtChangeLogo.Text = "";
                txtChangeName.Select();
                DGChannel.Select();
            }
        }
        // Ändert Abwechselnd den Hintergrund
        private void BackgroundChange()
        {
            for (int x = 0; x < DGChannel.Rows.Count; x++)
            {
                if (x % 2 == 0)
                {
                    DGChannel.Rows[x].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else DGChannel.Rows[x].DefaultCellStyle.BackColor = Color.Snow;
            }
        }
        //Nummeriert die Sender von 1 bis n
        private void SortbyNewIndex()
        {
            for (int x = 0; x < DGChannel.Rows.Count; x++)
            {
                DGChannel.Rows[x].Cells[0].Value = x + 1;
            }
        }
        // Sortiert den Sender in der angegebenen Nummer
        private void SortbyUser()
        {
            int NeueNummer = Convert.ToInt32(txtSort.Text);
            int selectedIndex = this.DGChannel.SelectedRows[0].Index;// Selektierten Index merken     
            DataGridViewRow[] rows = new DataGridViewRow[this.DGChannel.Rows.Count];// Gleichgroßes Array erstellen
            if (NeueNummer - 1 < selectedIndex) // falls kleiner
            {
                for (int i = 0; i < this.DGChannel.Rows.Count; i++)// Jede Zeile des Grids durchlaufen
                {
                    if (i >= NeueNummer && i <= selectedIndex)
                    {
                        rows[i] = this.DGChannel.Rows[i - 1];
                    }
                    else if (i == NeueNummer - 1)
                    {
                        rows[NeueNummer - 1] = this.DGChannel.Rows[selectedIndex];
                    }
                    else rows[i] = this.DGChannel.Rows[i];
                }
            }
            else if (NeueNummer - 1 > selectedIndex) //falls größer
            {
                for (int i = 0; i < this.DGChannel.Rows.Count; i++)// Jede Zeile des Grids durchlaufen
                {
                    if (i >= selectedIndex && i < NeueNummer - 1)
                    {
                        rows[i] = this.DGChannel.Rows[i + 1];
                    }
                    else if (i == NeueNummer - 1)
                    {
                        rows[NeueNummer - 1] = this.DGChannel.Rows[selectedIndex];
                    }
                    else rows[i] = this.DGChannel.Rows[i];
                }
            }
            else // falls gleich
            {
                for (int i = 0; i < this.DGChannel.Rows.Count; i++)// Jede Zeile des Grids durchlaufen
                {
                    rows[i] = this.DGChannel.Rows[i];
                }
            }
            this.DGChannel.Rows.Clear();// Das Grid leeren               
            for (int i = 0; i < rows.Length; i++)// Das sortierte Array in das Grid schreiben
            {
                DGChannel.Rows.Add(rows[i]);
            }

        }
        //Prueft ob die EPGs in der Tabelle mit denen von der XML-Datei uebereinstimmen
        private void EPGCheck()
        {
            try
            {
                DataGridViewCellStyle MakeItRed = new DataGridViewCellStyle();
                MakeItRed.ForeColor = Color.Red;
                DataGridViewCellStyle MakeItGreen = new DataGridViewCellStyle();
                MakeItGreen.ForeColor = Color.Green;
                EPG = EpgNames;
                if (TSMEpgCheckSimpleIPTV.Checked == true)
                {
                    EPG = EpgNamesSimple;
                }
                else EPG = EpgNames;
                int x = 0, x2 = 0;
                for (int k = 0; k < DGChannel.Rows.Count; k++)
                {
                    string checkName = DGChannel.Rows[k].Cells[3].Value.ToString();
                    string checkID = DGChannel.Rows[k].Cells[2].Value.ToString();
                    for (int l = 0; l < EPG.Length; l++)
                    {
                        if (checkName == EPG[l])
                        {
                            DGChannel.Rows[k].Cells[3].Style = MakeItGreen;
                            x = 1;
                        }
                        if (checkID == EPGID[l])
                        {
                            DGChannel.Rows[k].Cells[2].Style = MakeItGreen;
                            x2 = 1;
                        }
                    }
                    if (x != 1)
                    {
                        DGChannel.Rows[k].Cells[3].Style = MakeItRed;
                    }
                    if (x2 != 1)
                    {
                        DGChannel.Rows[k].Cells[2].Style = MakeItRed;
                    }
                    x = 0;
                    x2 = 0;
                }
            }
            catch { }
        }
        //Prueft ob die Logos in der Tabelle mit denen vom Ordner uebereinstimmen
        private void LogoCheck()
        {
            try
            {
                DataGridViewCellStyle MakeItRed = new DataGridViewCellStyle();
                MakeItRed.ForeColor = Color.Red;
                DataGridViewCellStyle MakeItGreen = new DataGridViewCellStyle();
                MakeItGreen.ForeColor = Color.Green;
                // Pfad zum Ordner "logos"
                System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(LogoDir);
                int i = 0, j = 0;
                foreach (System.IO.FileInfo f in ParentDirectory.GetFiles()) { i++; } // Anzahl der Ordnerdateien abzaehlen
                LogoNames = new string[i];
                foreach (System.IO.FileInfo g in ParentDirectory.GetFiles()) // Die Logos in der Variable LogoNames reinschreiben
                {
                    LogoNames[j] = g.Name.ToString();
                    j++;
                }
                //
                int x = 0;
                for (int k = 0; k < DGChannel.Rows.Count; k++)
                {
                    string check = DGChannel.Rows[k].Cells[7].Value.ToString();
                    for (int l = 0; l < i; l++)
                    {
                        if (check == LogoNames[l])
                        {
                            DGChannel.Rows[k].Cells[7].Style = MakeItGreen;
                            x = 1;
                        }
                    }
                    if (x != 1)
                    {
                        DGChannel.Rows[k].Cells[7].Style = MakeItRed;
                    }
                    x = 0;
                }
            }
            catch { }
        }
        // Schreibt in die Default.Config-Datei
        private void WriteInDefaultConfig()
        {
            string Text = "";
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i] != "")
                {
                    Text += DefaultConfig[i] + Environment.NewLine;
                }
            }
            //   StreamWriter sw = new StreamWriter(@"default.config");
            File.WriteAllText(@"default.config", Text, Encoding.UTF8);
            // sw.WriteLine(Text);
            //  sw.Close();
        }
        // Eingabehilfe für Favoriten
        private void FavouriteHelp()
        {
            CBChangeGroup.Items.Clear();
            // Beim Start soll er die Favoriten aus dem Datagrid entnehmen und in der Variable Favourite speichern
            if (Favourite == null)
            {
                string[] Fav = new string[DGChannel.RowCount];
                for (int i = 0; i < DGChannel.RowCount; i++)
                {
                    Fav[i] = DGChannel.Rows[i].Cells[5].Value.ToString();
                }

                string[] Fav2 = Fav;
                for (int j = 0; j < Fav.Length; j++)
                {
                    for (int k = 0; k < Fav.Length; k++)
                    {
                        if (Fav2[j] == Fav[k] && j != k)
                        {
                            Fav2[j] = "";
                        }
                    }
                }
                int z = 0;
                for (int l = 0; l < Fav2.Length; l++)
                {
                    if (Fav2[l] != "")
                    {
                        z++;
                    }
                }
                Favourite = new string[z];
                z = 0;
                CBChangeGroup.Items.Add("");
                for (int m = 0; m < Fav.Length; m++)
                {
                    if (Fav2[m] != "")
                    {
                        Favourite[z] = Fav2[m];
                        CBChangeGroup.Items.Add(Favourite[z]);
                        z++;
                    }
                }
            }
            else
            {
                string[] Favourite2 = Favourite;
                int z = 0;                 // z = Anzahl der Favoriten
                CBChangeGroup.Items.Add("");
                for (int n = 0; n < Favourite2.Length; n++)
                {
                    if (Favourite2[n] != null)
                    {
                        z++;
                    }
                }
                Favourite = new string[z];
                z = 0;
                for (int o = 0; o < Favourite.Length; o++)
                {
                    if (Favourite2[o] != "")
                    {
                        Favourite[z] = Favourite2[o];
                        CBChangeGroup.Items.Add(Favourite[z]);
                        z++;
                    }
                }
            }
        }
        // FTP- und SFTP-Upload
        private string UploadFileToServer(int FTPorSFTP, string source, string ftphost, string ftpdir, string ftpusername, string ftppassword, string pth)
        {
            //SFTP
            if (FTPorSFTP == 0)
            {
                try
                {
                    // Setup session options
                    SessionOptions sessionOptions = new SessionOptions
                    {
                        Protocol = Protocol.Sftp,
                        HostName = ftphost,
                        UserName = ftpusername,
                        Password = ftppassword,
                        PortNumber = 22,
                        GiveUpSecurityAndAcceptAnySshHostKey = true,
                        SshHostKeyFingerprint = "9e:1a:5e:27:16:4d:2a:13:90:2c:64:41:bd:25:fd:35"
                    };

                    using (Session session = new Session())
                    {
                        // Connect
                        session.ExecutablePath = pth + @"\res\WinSCP.exe";
                        session.Open(sessionOptions);

                        // Upload files
                        TransferOptions transferOptions = new TransferOptions();
                        transferOptions.TransferMode = TransferMode.Binary;

                        TransferOperationResult transferResult;
                        transferResult = session.PutFiles(source, ftpdir, false, transferOptions);

                        // Throw on any error
                        transferResult.Check();

                        // Print results
                        foreach (TransferEventArgs transfer in transferResult.Transfers)
                        {
                            Console.WriteLine("Upload of {0} succeeded", transfer.FileName);
                        }
                    }

                    return SaveSuccess;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e);
                    return e.ToString();
                }
            }
            // FTP
            else if (FTPorSFTP == 1)
            {
                try
                {
                    // Setup session options
                    SessionOptions sessionOptions = new SessionOptions
                    {
                        Protocol = Protocol.Ftp,                        
                        HostName = ftphost,
                        UserName = ftpusername,
                        Password = ftppassword
                    };

                    using (Session session = new Session())
                    {
                        // Connect
                        session.ExecutablePath = pth + @"\res\WinSCP.exe";
                        session.Open(sessionOptions);

                        // Upload files
                        TransferOptions transferOptions = new TransferOptions();
                        transferOptions.TransferMode = TransferMode.Binary;

                        TransferOperationResult transferResult;
                        transferResult = session.PutFiles(source, ftpdir, false, transferOptions);

                        // Throw on any error
                        transferResult.Check();

                        // Print results
                        foreach (TransferEventArgs transfer in transferResult.Transfers)
                        {
                            Console.WriteLine("Upload of {0} succeeded", transfer.FileName);
                        }
                    }

                    return SaveSuccess;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e);
                    return e.ToString();
                }
            }
            else return "Error";
        }

        
        //
        //Sprachpakete
        //
        private void languageGER()
        {
            SafeWarning = "Sind sie sicher, dass sie ohne speichern fortsetzen möchten ?";
            SafeQuestion = "Wollen Sie diese Datei als Standarddatei festlegen?";
            SafeQuestionLogo = "Wollen Sie diesen Ordner als Standardordner für Logos festlegen?";
            //FIle (ToolStripMenu)
            TSMFile.Text = "Datei";
            TSMNew.Text = "Neue Datei erstellen";
            TSMOpenM3U.Text = "M3U-Datei hinzufügen";
            TSMM3UfromFile.Text = "M3U - Datei öffnen";
            TSMM3UfromURL.Text = "M3U - Datei herunterladen";
            TSMM3UfromCode.Text = "M3U - Code einfügen";
            TSMFTPConfig.Text = "FTP-Einstellungen";
            TSMFTPUpload.Text = "M3U-Liste auf FTP-Server hochladen";
            TSMSave.Text = "Speichern unter...";
            //
            btnAddChannel.Text = "Sender hinzufügen";
            btnDelete.Text = "Sender entfernen (Entf)";
            btnFTPSave.Text = "Speichern";
            btnFTPCancel.Text = "Abbrechen";
            //Tools
            TSMTools.Text = "Tools";
            TSMOpenBlacklistEditor.Text = "Öffne BlacklistEditor";
            TSMLoadBlacklist.Text = "Entferne die Sender von der Blacklist";
            TSMOthers.Text = "Sonstiges";
            // TSMIP
            // TSMRenameIPENDTOM3u8
            TSMRenameIPEndToM3U8.Text = "IP von .ts zu .m3u8 umbenennen";
            //TSMDuplicate
            TSMDuplicate.Text = "Entferne Duplikate";
            MessageDuplicates = "Duplikate entfernt:";
            //  aiutoToolStripMenuItem.Text = "Hilfe";
            TSMLanguage.Text = "Sprache ändern";
            TSMEng.Enabled = true; TSMGer.Enabled = false; TSMIta.Enabled = true;
            //TSMSortby
            TSMSortby.Text = "Sortiere Sender";
            TSMSortbyFile.Text = "Sortiere Sender von einer anderen M3U-Datei";
            TSMSortbyName.Text = "Sortiere Sender nach Name (A-Z)";
            TSMSortbyFavourite.Text = "Sortiere Sender nach Favorit (A-Z)";
            //TSMLogo
            LogoDownload = "Logos wurden erfolgreich aktualisiert";
            TSMLogoUpdate.Text = "Logos aktualisieren";
            TSMChangeLogoPath.Text = "Logo Verzeichnis ändern";
            LogoLoadOK = "Das Verzeichnis wurde geändert"; LogoLoadError = "Fehler";
            //TSMEPG
            TSMEpgCheckSimpleIPTV.Text = "Sender für Simple IPTV umbenennen";
            TSMOpenEPG.Text = "Öffne EPG-Datei";
            TSMOpenEPGFromFile.Text = "Öffne EPG vom Computer";
            TSMOpenEPGFromInternet.Text = "Öffne EPG vom Internet";
            //TSMUPDATE
            TSMCheckUpdate.Text = "Nach Updates prüfen";
            //
            btnAddClose.Text = "Abbrechen";
            btnAdd.Text = "Hinzufügen";
            btnChangeOK.Text = "Ändern";
            btnFavourite.Text = "Favoriten bearbeiten";
            lblSort.Text = "Geben Sie die neue Nummer ein";
            lblChangeName.Text = "Name des Senders";
            lblChangeNameEPG.Text = "Name des Senders (für EPG)";
            lblChangeGroup.Text = "Favorit";
            lang = "GER";
            Info = "M3U Editor Version " + VersionNr + Environment.NewLine + "weitere Infos auf www.tvtools.tk";
            DGNumber = "Nr"; DGName = "Sendername"; DGEPGName = "Name (für EPG)"; DGEPGShift = "EPGShift"; DGGroup = "Favorit";
            if (DGChannel.Rows.Count != 0) DGChannelTitel();
            SaveError = "Datei konnte nicht gespeichert werden";
            SaveError2 = "Die Senderliste ist leer";
            SaveSuccess = "Die Datei wurde erfolgreich gespeichert";
            MessageVersionOK = "Sie haben die neuste Version";
            MessageVersionOld = "Sie haben eine veraltete Version. Möchten Sie die aktuelle Version runterladen?";
            // Für den nächsten Start merken
            lang = "GER";
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i].Contains("lang:<"))
                {
                    DefaultConfig[i] = "lang:<" + lang + ">";
                }
            }
            WriteInDefaultConfig();
        }
        private void languageITA()
        {
            SafeWarning = "Siete sicuri di volere proseguire senza salvare ?";
            SafeQuestion = "Vuoi memorizzarti questa scelta per ogni riavvio del programma?";
            SafeQuestionLogo = "Vuoi memorizzarti questa scelta per ogni riavvio del programma?";
            // File (ToolStripMenu)
            TSMFile.Text = "File";
            TSMNew.Text = "Crea nuova file";
            TSMOpenM3U.Text = "Aggiungi file (.m3u)";
            TSMM3UfromFile.Text = "Apri un file .M3U";
            TSMM3UfromURL.Text = "Scarica un file .M3U";
            TSMM3UfromCode.Text = "Aggiungi canali via M3U-Code";
            TSMFTPConfig.Text = "Configurazione FTP";
            TSMFTPUpload.Text = "Carica e salva lista M3U su FTP-Server";
            TSMSave.Text = "Salva file...";
            //
            btnAddChannel.Text = "Aggiungi canale";
            btnDelete.Text = "Cancella canale (Del)";
            btnFTPSave.Text = "Salva";
            btnFTPCancel.Text = "Chiudi";
            //Tools
            TSMTools.Text = "Tools";
            TSMOpenBlacklistEditor.Text = "Apri BlacklistEditor";
            TSMLoadBlacklist.Text = "Cancella i canali dalla Blacklist";
            TSMOthers.Text = "Altro";
            // TSMIP
            // TSMRenameIPENDTOM3u8
            TSMRenameIPEndToM3U8.Text = "Rinomina l'IP da .ts in .m3u8";
            //File - TSMDuplicate
            TSMDuplicate.Text = "Elimina duplicati";
            MessageDuplicates = "Duplicati eliminati:";
            //    aiutoToolStripMenuItem.Text = "Aiuto";
            TSMLanguage.Text = "Cambia lingua";
            //TSMSort
            TSMSortby.Text = "Ordina canali...";
            TSMSortbyFile.Text = "Ordina elenco da un altro file .m3u";
            TSMSortbyName.Text = "Ordina canali dal nome (A-Z)";
            TSMSortbyFavourite.Text = "Ordina canali da favoriti (A-Z)";
            //TSMLogo
            LogoDownload = "Logo sono stati attualizzati";
            TSMLogoUpdate.Text = "Aggiorna i loghi";
            TSMChangeLogoPath.Text = "Cambia elenco Logo";
            LogoLoadOK = "L'elenco é stato cambiato"; LogoLoadError = "Errore";
            //TSMEPG
            TSMEpgCheckSimpleIPTV.Text = "Rinomina EPG per Simple IPTV";
            TSMOpenEPG.Text = "Apri un EPG-File";
            TSMOpenEPGFromFile.Text = "Apri EPG dal Computer";
            TSMOpenEPGFromInternet.Text = "Apri EPG dall'Internet";
            //TSMUPDATE
            TSMCheckUpdate.Text = "Cerca aggiornamenti";
            //
            TSMEng.Enabled = true; TSMGer.Enabled = true; TSMIta.Enabled = false;
            btnAddClose.Text = "Cancella";
            btnAdd.Text = "Aggiungi";
            btnChangeOK.Text = "Modifica";
            btnFavourite.Text = "Modifica favoriti";
            lblSort.Text = "Inserire il nuovo numero del canale";
            lblChangeName.Text = "Nome del canale";
            lblChangeNameEPG.Text = "Nome del canale (per l'EPG)";
            lblChangeGroup.Text = "Nome del gruppo";
            lang = "ITA";
            Info = "M3U Editor Version 1.15.04 " + VersionNr + Environment.NewLine + "altri informazioni su www.tvtools.tk";
            DGNumber = "N°"; DGName = "Programma"; DGEPGName = "Nome (per l'EPG)"; DGEPGShift = "EPGShift"; DGGroup = "Favoriti";
            if (DGChannel.Rows.Count != 0) DGChannelTitel();
            SaveError = "Il file non é stato salvato";
            SaveError2 = "La lista é vuota";
            SaveSuccess = "Il file é stato salvato";
            MessageVersionOK = "Hai la versione attuale.";
            MessageVersionOld = "Non hai la versione attuale. Vuoi scaricarla?";
            // Für den nächsten Start merken
            lang = "ITA";
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i].Contains("lang:<"))
                {
                    DefaultConfig[i] = "lang:<" + lang + ">";
                }
            }
            WriteInDefaultConfig();
        }
        private void languageENG()
        {
            SafeWarning = "Are you sure to proceed without saving ?";
            SafeQuestion = "Do you want to save this decision for the next startups?";
            SafeQuestionLogo = "Do you want to save this decision for the next startups?";

            // File (ToolStripMenu)
            TSMFile.Text = "File";
            TSMNew.Text = "Create new File";
            TSMOpenM3U.Text = "Open M3U-file";
            TSMM3UfromFile.Text = "Open from file";
            TSMM3UfromURL.Text = "Download from URL";
            TSMM3UfromCode.Text = "Add channels with M3U-Code";
            TSMFTPConfig.Text = "FTP-Settings";
            TSMFTPUpload.Text = "Upload and save M3U-List on FTP-Server";
            TSMSave.Text = "Save file...";
            //
            btnAddChannel.Text = "Add channel";
            btnDelete.Text = "Delete channel (Del)";
            btnFTPSave.Text = "Save";
            btnFTPCancel.Text = "Cancel";
            //Tools
            TSMTools.Text = "Tools";
            TSMOpenBlacklistEditor.Text = "Open BlacklistEditor";
            TSMLoadBlacklist.Text = "Delete channels from Blacklist";
            TSMOthers.Text = "Others";
            // TSMIP
            // TSMRenameIPENDTOM3u8
            TSMRenameIPEndToM3U8.Text = "Rename IP from .ts to .m3u8";
            //TSMDuplicates
            TSMDuplicate.Text = "Delete duplicates";
            MessageDuplicates = "Duplicates deleted:";
            //   aiutoToolStripMenuItem.Text = "Help";
            TSMLanguage.Text = "Change language";
            // TSMSortby
            TSMSortbyFile.Text = "Sort channel by another M3U-file";
            TSMSortby.Text = "Sort channels";
            TSMSortbyName.Text = "Sort channels by name (A-Z)";
            TSMSortbyFavourite.Text = "Sort channels by favourite (A-Z)";
            //TSMLogo
            LogoDownload = "Logos have been successfully updated";
            TSMLogoUpdate.Text = "Update Logos";
            TSMChangeLogoPath.Text = "Change Logo-Directory";
            LogoLoadOK = "Directory changed"; LogoLoadError = "Error";
            //TSMEPG
            TSMEpgCheckSimpleIPTV.Text = "Change Epg-Names for Simple IPTV";
            TSMOpenEPG.Text = "Open EPG-File";
            TSMOpenEPGFromFile.Text = "Open EPG from Computer";
            TSMOpenEPGFromInternet.Text = "Open EPG from the Internet";
            //TSMUPDATE
            TSMCheckUpdate.Text = "Check for Update";
            //
            TSMEng.Enabled = false; TSMGer.Enabled = true; TSMIta.Enabled = true;
            btnAddClose.Text = "Cancel";
            btnAdd.Text = "Add";
            btnChangeOK.Text = "Change";
            btnFavourite.Text = "Edit favourites";
            lblSort.Text = "Enter the new channel number";
            lblChangeName.Text = "Channel name";
            lblChangeNameEPG.Text = "Channel name (for EPG)";
            lblChangeGroup.Text = "Favourite";
            lang = "ENG";
            Info = "M3U Editor version " + VersionNr + Environment.NewLine + "more informations on www.tvtools.tk";
            DGNumber = "N°"; DGName = "Channel name"; DGEPGName = "Name (for EPG)"; DGEPGShift = "EPGShift"; DGGroup = "Favourite";
            if (DGChannel.Rows.Count != 0) DGChannelTitel();
            SaveError = "File could not be saved";
            SaveError2 = "The channel list is empty";
            SaveSuccess = "File has been successfully saved";
            MessageVersionOK = "You have the newest version.";
            MessageVersionOld = "You have an old version. Do you want to download the new one?";
            // Für den nächsten Start merken
            lang = "ENG";
            for (int i = 0; i < DefaultConfig.Length; i++)
            {
                if (DefaultConfig[i].Contains("lang:<"))
                {
                    DefaultConfig[i] = "lang:<" + lang + ">";
                }
            }
            WriteInDefaultConfig();
        }
        private void DGChannelTitel()
        {
            DGChannel.Columns[0].Name = DGNumber;
            DGChannel.Columns[1].Name = DGName;
            DGChannel.Columns[2].Name = "EPG-ID";
            DGChannel.Columns[3].Name = DGEPGName;
            DGChannel.Columns[4].Name = DGEPGShift;
            DGChannel.Columns[5].Name = DGGroup;
            DGChannel.Columns[6].Name = "IP";
            DGChannel.Columns[7].Name = "Logo";
            DGChannel.Columns[8].Name = "TV/Radio";
        }
        public string setlang() { return lang; }
        //
        //Programm Schließen
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed == true)
            {
                DialogResult dr = MessageBox.Show(SafeWarning, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    changed = false;
                    Application.Exit();
                }
            }

        }
    }
}
