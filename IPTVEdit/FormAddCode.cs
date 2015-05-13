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
    public partial class FormAddCode : Form
    {
        public FormAddCode(string lang)
        {
            InitializeComponent();
            if (lang == "ITA") languageITA();
            if (lang == "GER") languageGER();
            if (lang == "ENG") languageENG();
        }
        string TextCode = "";
        private void btnAdd_Click(object sender, EventArgs e)
        {

            // alle Zeile in Schleife ausgeben und weiter auseinander nehmen
            TextCode = richTextBox1.Text;
            this.Close();
        }
        public string setText()
        {
            return TextCode;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void languageGER()
        {
            btnAdd.Text = "Hinzufügen";
            btnCancel.Text = "Abbrechen";
        }
        private void languageITA()
        {
            btnAdd.Text = "Aggiungi";
            btnCancel.Text = "Cancella";
        }
        private void languageENG()
        {
            btnAdd.Text = "Add";
            btnCancel.Text = "Cancel";
        }
    }
}