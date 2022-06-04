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

            //cboLine
            List<string> fill = new List<string>();
            fill = BD.getNomLigne();
            foreach (string s in fill)
            {
                cboLine.Items.Add("Ligne " + s);
            }

            
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            List<string> fill = new List<string>();
            fill = BD.getNomArret(cboLine.Text.Substring(6));

            cboStop.Items.Add("Nouvel Arrêt");
            foreach (string s in fill)
            {
                cboStop.Items.Add(s);
            }

            cboStop.Enabled = true;
            cboPrevStop.Enabled = true;
            cboNextStop.Enabled = true;
        }

        private void cboStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //le code ci-dessous est est copiloté (pas forcemment bon)
            /*
            if (cboStop.Text == "Nouvel Arrêt")
            {
                txtNewStop.Enabled = true;
                lblNewStop.Enabled = true;
                lblNextStop.Enabled = false;
                lblPrevStop.Enabled = false;
                cmdAdd.Enabled = true;
            }
            else
            {
                List<string> fill = new List<string>();
                fill = BD.getArret(cboLine.Text.Substring(6));
                int i = 0;
                foreach (string s in fill)
                {
                    if (s == cboStop.Text)
                    {
                        if (i == 0)
                        {
                            lblPrevStop.Enabled = false;
                            cboPrevStop.Enabled = false;
                        }
                        else
                        {
                            lblPrevStop.Enabled = true;
                            cboPrevStop.Enabled = true;
                            cboPrevStop.Text = fill[i - 1];
                        }
                        if (i == fill.Count - 1)
                        {
                            lblNextStop.Enabled = false;
                            cboNextStop.Enabled = false;
                        }
                        else
                        {
                            lblNextStop.Enabled = true;
                            cboNextStop.Enabled = true;
                            cboNextStop.Text = fill[i + 1];
                        }
                    }
                    i++;
                }
                cmdAdd.Enabled = true;
            }
            */
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
