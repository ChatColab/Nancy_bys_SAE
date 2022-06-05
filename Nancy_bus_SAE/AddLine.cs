using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDB;

namespace Nancy_bus_SAE
{
    public partial class AddLine : Form
    {
        public AddLine()
        {
            InitializeComponent();
            
            lblLine.Text = "Ligne " + ((Convert.ToInt32(BD.getNomLigne(BD.getNbLigne())))+1).ToString();

            foreach (String s in BD.getNomArret())
            {
                cboStop.Items.Add(s);
            }
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            //unhide Home (pas copiloté, stackoverflow)
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Home);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Close();
        }

        private void txtStartHourly_TextChanged(object sender, EventArgs e)
        {
          if (txtStartHourly.Text != "Format Invalide")
            {
                //set default forecolor
                txtStartHourly.ForeColor = Color.Grey;
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            /*
            string txt = txtStartHourly.Text;
            string pattern = @"\d\d:\d\d:\d\d";
            Match m = Regex.Match(txt, pattern);
            if (m.Success && Convert.ToInt32(txt.Substring())<24 && )
            {

                //requête sql
            }
            else
            {
                txtStartHourly.ForeColor = Color.Red;
                txtStartHourly.Text = "Format Invalide";
            }
            */

            //ok gaetour oublie le truc du haut on va remplacer la text box par deux numeric up down un pour les heures un pour les minutes et on fait en sorte que le premier dépasse pas 24 et l autre 60 comme ça on est tranquile et nique bien mais alors EXTREMEMENT fort l'entrée utilisateur c des gros chiens les utilisateurs
        }
    }
}
