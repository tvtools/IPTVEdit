using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTVEdit
{
    public partial class FormFavourite : Form
    {
        string MsgStringEmpty = "", MsgStringExists = "";
        public string[] Fav;
        public bool save = false;
        public FormFavourite(string lang, string[] Favourite)
        {
            Fav = Favourite;
            InitializeComponent();
            if (lang == "ITA") languageITA();
            if (lang == "GER") languageGER();
            if (lang == "ENG") languageENG();
            if (Favourite != null)
            {
                for (int i = 0; i < Fav.Length; i++)
                {
                    if (Favourite[i] != null)
                    {
                        lstFav.Items.Add(Fav[i]);
                    }
                }

            }

        }
        // Nur bestimmte zeichen in TXTFav zulassen
        private void txtFav_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\b";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        // Nur bestimmte Zeichen in TXTNewFav zulassen
        private void txtNewFav_KeyPress(object sender, KeyPressEventArgs e)
        {
            string OK = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789\b";
            if (OK.IndexOf(e.KeyChar.ToString()) < 0) e.Handled = true;
            else e.Handled = false;
        }
        private void lstFav_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtFav.Text = lstFav.SelectedItem.ToString();
            }
            catch { }
        }
        // Ändert den Namen
        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (lstFav.SelectedIndex != -1)
            {
                if (txtFav.Text != "")
                {
                    int check = 0;
                    for (int i = 0; i < Fav.Length; i++)
                    {
                        if (txtFav.Text == Fav[i]) check = 1;
                    }
                    if (check == 0)
                    {
                        int helper = lstFav.SelectedIndex;
                        lstFav.Items.RemoveAt(helper);
                        lstFav.Items.Insert(helper, txtFav.Text);
                        lstFav.SelectedIndex = helper;
                        ResetListbox();
                    }
                    else MessageBox.Show(MsgStringExists, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show(MsgStringEmpty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Löscht selektierten Favorit
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstFav.SelectedIndex != -1)
            {
                int helper = lstFav.SelectedIndex;
                lstFav.Items.RemoveAt(helper);
                lstFav.Items.Insert(helper, "---||| (Deleted) |||---");
                lstFav.SelectedIndex = helper;
                ResetListbox();
            }

        }
        //Aktualisiert die Einträge in der Fav-Listbox
        private void ResetListbox()
        {
            Fav = new string[20];
            for (int i = 0; i < lstFav.Items.Count; i++)
            {
                Fav[i] = lstFav.Items[i].ToString();
            }
            int end = lstFav.Items.Count;
            lstFav.Items.Clear();
            for (int j = 0; j < end; j++)
            {
                lstFav.Items.Add(Fav[j]);
            }
        }
        //Schliessen mit speichern
        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] FavHelp = Fav;
            int z = 0;
            for (int i = 0; i < Fav.Length; i++)
            {
                FavHelp[z] = Fav[i];
                z++;
            }
            Fav = new string[z];
            Fav = FavHelp;
            save = true;
            this.Close();
        }
        //Schliessen ohne speichern
        private void btnNotSave_Click(object sender, EventArgs e)
        {
            save = false;
            this.Close();
        }
        //Erstellt neuen Favorit
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtNewFav.Text != "")
            {
                int check = 0;
                if (Fav != null)
                {
                    for (int i = 0; i < Fav.Length; i++)
                    {
                        if (txtNewFav.Text == Fav[i]) check = 1;
                    }
                }

                if (check == 0)
                {
                    lstFav.Items.Add(txtNewFav.Text);
                    txtNewFav.Text = "";
                    ResetListbox();
                }
                else MessageBox.Show(MsgStringExists, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(MsgStringEmpty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //
        //Language-Pack
        //
        private void languageGER()
        {
            lblFav.Text = "Favoriten";
            btnChangeName.Text = "Ändere Name";
            btnDelete.Text = "Favorit löschen";
            btnNew.Text = "Erstelle neue Favorit-Gruppe";
            btnSave.Text = "Änderungen speichern";
            btnNotSave.Text = "Änderungen nicht speichern";
            lblNewGroup.Text = "Neue Favorit-Gruppe";
            MsgStringEmpty = "Bitte geben Sie einen Namen Sein.";
            MsgStringExists = "Dieser Name existiert bereits. Bitte wählen Sie ein anderen Namen aus";
        }
        private void languageITA()
        {
            lblFav.Text = "Favoriti";
            btnChangeName.Text = "Cambia nome";
            btnDelete.Text = "Cancella favorito";
            btnNew.Text = "Crea un nuovo gruppo";
            btnSave.Text = "Esci e salva cambiamenti";
            btnNotSave.Text = "Esci senza salvare";
            lblNewGroup.Text = "Nuovo Gruppo";
            MsgStringEmpty = "Devi inserire un nome.";
            MsgStringExists = "Questo nome esiste giá. Inserire un altro nome.";
        }
        private void languageENG()
        {
            lblFav.Text = "Favourites";
            btnChangeName.Text = "Change name";
            btnDelete.Text = "Delete Favourit";
            btnNew.Text = "Create a new Favourite-Group";
            btnSave.Text = "Exit and save changes";
            btnNotSave.Text = "Exit without saving changes";
            lblNewGroup.Text = "New Favourite-Group";
            MsgStringEmpty = "You have to type a name.";
            MsgStringExists = "This name already exists.Type another name.";
        }
    }
}
