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
    public partial class DelStop : Form
    {
        public DelStop()
        {
            
            InitializeComponent();
            List<string> fill = new List<string>();
            fill = BD.getNomLigne();
            foreach (string s in fill)
            {
                cboLine.Items.Add("Ligne " + s);
            }
            cboStop.Enabled = false;
            cmdDel.Enabled = false;
        }

        //retorurne à l'accueil sans sauvegarder
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Home);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Close();
        }

        //modifie les arrêts pouvant être supprimé en fonction de la ligne choisie
        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomLine = cboLine.Text.Substring(6); 
            List<string> fill2 = new List<string>();
            fill2 = BD.getNomArret(nomLine);
            foreach (string s in fill2)
            {
                cboStop.Items.Add(s);
             
            }
            cboStop.Enabled = true;
        }
     
        private void cmdDel_Click(object sender, EventArgs e)
        {
            DelStopX form = new DelStopX(BD.getNumLigne(cboLine.Text), BD.getNumArret(cboStop.Text));
            form.ShowDialog();
            this.Close();
        }

        private void cboStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdDel.Enabled = true;
        }
    }
}
