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
            List<string> fill2 = new List<string>();
            //fill2 = BD.getNomArretLink(cboFirstStopInput.Text)
        }
    }
}
