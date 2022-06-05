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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();

            cboNextStopInput.Enabled = false;
            cmdValidate.Enabled = false;
            pnlTime.Enabled = false;
            nudNewValue.Value = 1;

            List<string> fill = new List<string>();
            fill = BD.getNomArret();
            foreach (string s in fill)
            {
                cboFirstStopInput.Items.Add(s);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void cboFirstStopInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                lblFirstStop.Text = cboFirstStopInput.Text;
                cboNextStopInput.Enabled = true;
                cmdValidate.Enabled = false;

                List<string> fill2 = new List<string>();
                fill2 = BD.getNomArretLink(cboFirstStopInput.Text);
                foreach (string s in fill2)
                {
                    cboNextStopInput.Items.Add(s);
                }
            }
        }

        private void cboNextStopInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNextStop.Text = cboNextStopInput.Text;
            cmdValidate.Enabled = true;
        }

        private void cmdValidate_Click(object sender, EventArgs e)
        {
            pnlTime.Enabled = true;
        }

        private void nudNewValue_ValueChanged(object sender, EventArgs e)
        {
            if (nudNewValue.Value < 1)
            {
                nudNewValue.Value = 1;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //requete pour changer la bd
        }
    }
}
