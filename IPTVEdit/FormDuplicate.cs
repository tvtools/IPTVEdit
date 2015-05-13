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
    public partial class FormDuplicate : Form
    {
        public FormDuplicate(string lang, int ChannelCount, string[] Channelname)
        {
            InitializeComponent();
            if (lang == "ITA") languageITA();
            if (lang == "GER") languageGER();
            if (lang == "ENG") languageENG();
            for (int i = 0; i < ChannelCount; i++)
            {
                if (i > 0) comboTill.Items.Add(i + 1);
                if (i < ChannelCount - 1) comboFrom.Items.Add(i + 1);

                comboOneChannel.Items.Add(Convert.ToString(i + 1) + " , " + Channelname[i]);
            }
            comboFrom.SelectedIndex = 0;
            comboTill.SelectedIndex = ChannelCount - 2;
        }
        int[] DuplicateReturn = new int[20];
        string InfoMessage = "";
        private void checkOneChannel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOneChannel.Checked)
            {
                comboOneChannel.Enabled = true;
                comboOneChannel.SelectedIndex = 0;
            }
            else comboOneChannel.Enabled = false;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (checkName.Checked == false && checkEPGID.Checked == false && checkEPGName.Checked == false && checkFavourite.Checked == false && checkIP.Checked == false && checkLogo.Checked == false && checkTVRadio.Checked == false)
            {
                MessageBox.Show(InfoMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < DuplicateReturn.Length; i++)
                {
                    DuplicateReturn[i] = 0;
                }
                DuplicateReturn[0] = 1;
                if (checkName.Checked) DuplicateReturn[1] = 1;
                if (checkEPGID.Checked) DuplicateReturn[2] = 1;
                if (checkEPGName.Checked) DuplicateReturn[3] = 1;
                if (checkFavourite.Checked) DuplicateReturn[4] = 1;
                if (checkIP.Checked) DuplicateReturn[5] = 1;
                if (checkLogo.Checked) DuplicateReturn[6] = 1;
                if (checkTVRadio.Checked) DuplicateReturn[7] = 1;
                //
                if (checkWrite.Checked) DuplicateReturn[8] = 1; // Groß-Kleinschreibung
                if (checkSpace.Checked) DuplicateReturn[9] = 1; // Leerzeichen beachten
                if (checkOneChannel.Checked) DuplicateReturn[10] = comboOneChannel.SelectedIndex;
                DuplicateReturn[11] = comboFrom.SelectedIndex;
                DuplicateReturn[12] = comboTill.SelectedIndex;
                this.Close();
            }
        }
        public int[] setDuplicate()
        {
            return DuplicateReturn;
        }
        //Schließen ohne Duplikate löschen
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DuplicateReturn[0] = 0;
            this.Close();
        }

        private void comboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFrom.SelectedIndex >= comboTill.SelectedIndex)
            {
                comboTill.SelectedIndex = comboFrom.SelectedIndex;
            }
        }

        private void comboTill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTill.SelectedIndex <= comboFrom.SelectedIndex)
            {
                comboFrom.SelectedIndex = comboTill.SelectedIndex;
            }
        }
        // Sprachpaket
        private void languageGER()
        {
            grpDeleteby.Text = "Lösche Sender mit gleichen...";
            checkName.Text = "Sendername";
            checkEPGID.Text = "EPG-ID";
            checkEPGName.Text = "EPG-Name";
            checkFavourite.Text = "Favorit";
            checkIP.Text = "IP";
            checkLogo.Text = "Logo";
            checkTVRadio.Text = "TV/Radio";
            //
            checkWrite.Text = "Auf Groß - und Kleinschreibung achten";
            checkSpace.Text = "Auf Leerzeichen achten";
            checkOneChannel.Text = "Duplikate nur von einen Sender löschen :";
            //
            lblFromTill.Text = "Duplikate löschen von";
            lblFromTill2.Text = "bis";
            //
            btnApply.Text = "Anwenden";
            btnCancel.Text = "Abbrechen";

            InfoMessage = "Sie müssen mindestens ein Häkchen im oberen Abschnitt einsetzen";
        }
        private void languageITA()
        {
            grpDeleteby.Text = "Elimina canali con stesso...";
            checkName.Text = "Nome del canale";
            checkEPGID.Text = "EPG-ID";
            checkEPGName.Text = "Nome-EPG";
            checkFavourite.Text = "Favoriti";
            checkIP.Text = "IP";
            checkLogo.Text = "Logo";
            checkTVRadio.Text = "TV/Radio";
            //
            checkWrite.Text = "Presta attenzione a lettere maiuscole e minuscole";
            checkSpace.Text = "Presta attenzione allo spazio";
            checkOneChannel.Text = "Elimina duplicati di un solo canale";
            //
            lblFromTill.Text = "Elimina duplicati dal";
            lblFromTill2.Text = "al";
            //
            btnApply.Text = "Applica";
            btnCancel.Text = "Cancella";
            //
            InfoMessage = "Devi scegliere minima uno";
        }
        private void languageENG()
        {
            grpDeleteby.Text = "Delete channels with same...";
            checkName.Text = "Channel name";
            checkEPGID.Text = "EPG-ID";
            checkEPGName.Text = "EPG-Name";
            checkFavourite.Text = "Favourite";
            checkIP.Text = "IP";
            checkLogo.Text = "Logo";
            checkTVRadio.Text = "TV/Radio";
            //
            checkWrite.Text = "Pay attention to uppercase and lowercase letters";
            checkSpace.Text = "Pay attention to space";
            checkOneChannel.Text = "Delete duplicates by only one channel";
            //
            lblFromTill.Text = "Delete duplicates from";
            lblFromTill2.Text = "to";
            //
            btnApply.Text = "Apply";
            btnCancel.Text = "Cancel";
            //
            InfoMessage = "You need to choose minimum one";
        }
    }
}

