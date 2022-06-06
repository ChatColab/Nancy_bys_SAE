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
    public partial class AddStop : Form
    {
        public AddStop()
        {
            InitializeComponent();

            //greyer tous les champs initialement innaccessibles
            //greyer cboStop cboPrevStop cboNextStop 
            cboStop.Enabled = false;
            cboPrevStop.Enabled = false;
            cboNextStop.Enabled = false;
            txtNewStop.Enabled = false;
            lblNewStop.Enabled = false;
            lblNextStop.Enabled = false;
            lblPrevStop.Enabled = false;
            cmdAdd.Enabled = false;
            nudNextStop.Enabled = false;
            nudPrevStop.Enabled = false;

            //cboLine
            List<string> fill = new List<string>();
            fill = BD.getNomLigne();
            foreach (string s in fill)
            {
                cboLine.Items.Add("Ligne " + s);
            }

            
            List<string> fill2 = new List<string>();
            fill2 = BD.getNomArret();

            cboStop.Items.Add("Nouvel Arrêt");
            foreach (string s in fill2)
            {
                cboStop.Items.Add(s);
            }

        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStop.Enabled = true;

            //fill prev and next Stop comboboxes
            List<string> fill = new List<string>();
            fill = BD.getNomArret(cboLine.Text.Substring(6));

            cboPrevStop.Items.Clear();
            cboNextStop.Items.Clear();

            cboPrevStop.Items.Add("Aucun (début de ligne)");
            foreach (string s in fill)
            {
                cboPrevStop.Items.Add(s);
                cboNextStop.Items.Add(s);
            }
            cboNextStop.Items.Add("Aucun (fin de ligne)");
        }

        private void cboStop_SelectedIndexChanged(object sender, EventArgs e)
        {

            cboPrevStop.Enabled = true;
            cboNextStop.Enabled = true;
            nudPrevStop.Enabled = true;
            nudNextStop.Enabled = true;
            lblNextStop.Enabled = true;
            lblPrevStop.Enabled = true;


            if (cboStop.Text == "Nouvel Arrêt")
            {
                txtNewStop.Enabled = true;
                lblNewStop.Enabled = true;
            }
            else
            {
                txtNewStop.Enabled = false;
                lblNewStop.Enabled = false;
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
    }
}
