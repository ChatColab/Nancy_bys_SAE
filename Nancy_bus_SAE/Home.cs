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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            BD.initConnexion();

            optAddLine.Checked = true;
            optAddStop.Checked = false;
            optDeleteLine.Checked = true;
            optDeleteStop.Checked = false;

            List<String> fill;
            fill = BD.getNomLigne();
            foreach (String s in fill)
            {
                lstLine.Items.Add("Ligne " + s);
            }

        }

        private void optAddStop_Click(object sender, EventArgs e)
        {
            optAddLine.Checked = false;
            optAddStop.Checked = true;
        }

        private void optAddLine_Click(object sender, EventArgs e)
        {
            optAddLine.Checked = true;
            optAddStop.Checked = false;
        }

        private void optDeleteLine_Click(object sender, EventArgs e)
        {
            optDeleteLine.Checked = true;
            optDeleteStop.Checked = false;
        }

        private void optDeleteStop_Click(object sender, EventArgs e)
        {
            optDeleteLine.Checked = false;
            optDeleteStop.Checked = true;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //hide active form
            this.Hide();
            //open new form
            if (optAddLine.Checked)
            {
                AddLine addLine = new AddLine();
                addLine.ShowDialog();
            }
            else if (optAddStop.Checked)
            {
                AddStop addStop = new AddStop();
                addStop.ShowDialog();
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //hide active form
            this.Hide();
            //open new form
            if (optDeleteLine.Checked)
            {
                DelLine deleteLine = new DelLine();
                deleteLine.ShowDialog();
            }
            else if (optDeleteStop.Checked)
            {
                DelStop deleteStop = new DelStop();
                deleteStop.ShowDialog();
            }
        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify modify = new Modify();
            modify.ShowDialog();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            //appeler le form avec le numéro de ligne correspondant (requête sql)
            this.Hide();
            string ligne = lstLine.SelectedItem.ToString();
            
            PrintLine print = new PrintLine(BD.getNumLigne(ligne.Substring(6)));
            print.ShowDialog();
        }

        private void Home_VisibleChanged(object sender, EventArgs e)
        {
            List<String> fill;
            fill = BD.getNomLigne();
            lstLine.Items.Clear();
            foreach (String s in fill)
            {
                lstLine.Items.Add("Ligne " + s);
            }
        }
    }
}
