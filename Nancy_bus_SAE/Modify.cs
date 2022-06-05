using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nancy_bus_SAE
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
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
    }
}
