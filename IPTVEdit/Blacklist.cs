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

namespace IPTVEdit
{
    public partial class Blacklist : Form
    {
        public Blacklist(string lang)
        {
            InitializeComponent();
            btnAdd.Visible = false; btnChange.Visible = false; lblChannel.Visible = false; txtAdd.Enabled = false; txtAdd.Visible = false;
            panel1.Visible = false; lstBlacklist.Enabled = false; rimuoviCanaleToolStripMenuItem.Enabled = false;
            cambiaNomeDelCanaleToolStripMenuItem.Enabled = false; aggiungiCanaleToolStripMenuItem.Enabled = false;
            Form1 frm = new Form1();
            if (lang == "ITA") languageITA();
            if (lang == "GER") languageGER();
            if (lang == "ENG") languageENG();
        }
        // Toolstripmenue
        private void apriBlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lstBlacklist.Enabled = true; rimuoviCanaleToolStripMenuItem.Enabled = true;
                cambiaNomeDelCanaleToolStripMenuItem.Enabled = true; aggiungiCanaleToolStripMenuItem.Enabled = true;
                lstBlacklist.Items.Clear();
                using (StreamReader fileReader = new StreamReader(openFileDialog1.OpenFile()))
                {
                    while (fileReader.Peek() >= 0)
                    {
                        lstBlacklist.Items.Add(Convert.ToString(fileReader.ReadLine()));
                    }
                }
                lstBlacklist.SelectedIndex = 0;
            }

        }
        private void salvaBlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstBlacklist.SelectedIndex != -1)
            {
                save.FileName = "Blacklist.txt";
                save.Filter = "Blacklist File | *.txt";
                save.RestoreDirectory = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    for (int i = 0; i < lstBlacklist.Items.Count; i++)
                    {
                        writer.WriteLine(lstBlacklist.Items[i].ToString());
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
        }
        private void creaUnaNuovaBlacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBlacklist.Items.Clear();
            lstBlacklist.Enabled = true; rimuoviCanaleToolStripMenuItem.Enabled = true;
            cambiaNomeDelCanaleToolStripMenuItem.Enabled = true; aggiungiCanaleToolStripMenuItem.Enabled = true;
        }
        private void aggiungiCanaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAdd.Visible = true; btnChange.Visible = false;
            lblChannel.Visible = true;
            txtAdd.Enabled = true; txtAdd.Visible = true;
            txtAdd.Text = "";
            txtAdd.Select();

        }
        private void rimuoviCanaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int z = lstBlacklist.SelectedIndex;
            lstBlacklist.Items.Remove(lstBlacklist.SelectedItem);
            if (lstBlacklist.Items.Count != 0)
            {
                if (z != lstBlacklist.Items.Count)
                {
                    lstBlacklist.SelectedIndex = z;
                }
                else lstBlacklist.SelectedIndex = z - 1;
            }
        }
        private void cambiaNomeDelCanaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAdd.Visible = false; btnChange.Visible = true;
            lblChannel.Visible = true;
            txtAdd.Enabled = true; txtAdd.Visible = true;
            txtAdd.Select();
            try
            {
                txtAdd.Text = lstBlacklist.SelectedItem.ToString();
            }
            catch { }
        }
        // Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false; btnChange.Visible = false;
            lblChannel.Visible = false;
            txtAdd.Enabled = false; txtAdd.Visible = false;
            panel1.Visible = false;
            if (txtAdd.Text != "")
            {
                lstBlacklist.Items.Add(txtAdd.Text);
                lstBlacklist.SelectedIndex = lstBlacklist.Items.Count - 1;
            }

        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false; btnChange.Visible = false; lblChannel.Visible = false; txtAdd.Enabled = false; txtAdd.Visible = false; panel1.Visible = false;
            if (txtAdd.Text != "" && lstBlacklist.SelectedIndex != -1)
            {
                int z = lstBlacklist.SelectedIndex;
                lstBlacklist.Items.RemoveAt(z);
                lstBlacklist.Items.Insert(z, txtAdd.Text);
                lstBlacklist.SelectedIndex = z;
            }
        }

        private void lstBlacklist_DoubleClick(object sender, EventArgs e)
        {
            cambiaNomeDelCanaleToolStripMenuItem.PerformClick();
        }
        private void lstBlacklist_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) rimuoviCanaleToolStripMenuItem.PerformClick();
            if (e.KeyCode == Keys.C) cambiaNomeDelCanaleToolStripMenuItem.PerformClick();
            if (e.KeyCode == Keys.A) aggiungiCanaleToolStripMenuItem.PerformClick();
        }
        // Sprachpakete
        private void languageGER()
        {
            fileToolStripMenuItem.Text = "Datei";
            apriBlacklistToolStripMenuItem.Text = "Öffne Blacklist";
            creaUnaNuovaBlacklistToolStripMenuItem.Text = "Erstelle eine neue Blacklist";
            salvaBlacklistToolStripMenuItem.Text = "Speicher Blacklist";
            aggiungiCanaleToolStripMenuItem.Text = "Sender Hinzufügen (a)";
            rimuoviCanaleToolStripMenuItem.Text = "Sender entfernen (Entf)";
            cambiaNomeDelCanaleToolStripMenuItem.Text = "Sendername ändern (c)";
            btnChange.Text = "Ändern";
            lblChannel.Text = "Sender";
        }
        private void languageITA()
        {
            fileToolStripMenuItem.Text = "File";
            apriBlacklistToolStripMenuItem.Text = "Apri Blacklist";
            creaUnaNuovaBlacklistToolStripMenuItem.Text = "Crea una nuova Blacklist";
            salvaBlacklistToolStripMenuItem.Text = "Salva Blacklist";
            aggiungiCanaleToolStripMenuItem.Text = "Aggiungi canale (a)";
            rimuoviCanaleToolStripMenuItem.Text = "Rimuovi canale (Del)";
            cambiaNomeDelCanaleToolStripMenuItem.Text = "Cambia nome del canale (c)";
            btnChange.Text = "Cambia";
            lblChannel.Text = "Canale";

        }
        private void languageENG()
        {
            fileToolStripMenuItem.Text = "File";
            apriBlacklistToolStripMenuItem.Text = "Open Blacklist";
            creaUnaNuovaBlacklistToolStripMenuItem.Text = "Create new Blacklist";
            salvaBlacklistToolStripMenuItem.Text = "Save Blacklist";
            aggiungiCanaleToolStripMenuItem.Text = "Add channel (a)";
            rimuoviCanaleToolStripMenuItem.Text = "Delete channel (Del)";
            cambiaNomeDelCanaleToolStripMenuItem.Text = "Change channel name (c)";
            btnChange.Text = "Change";
            lblChannel.Text = "Channel";
        }
    }
}

