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
    public partial class PrintLine : Form
    {
        public PrintLine(int nLine) //on va appeler ce form avec le numéro de ligne
        {
            InitializeComponent();

            lblLine.Text = "Ligne " + BD.getNomLigne(nLine);

            
            
            List<String> fill;
            fill = BD.getHeureDepLigne(nLine);
            foreach (String s in fill)
            {
                lstHourly.Items.Add(s);
            }

            List<List<string>> fill2 = new List<List<string>>();
            fill2 = BD.getArretInterLigne(nLine);

            //permet de voir les colonnes
            lstStop.View = View.Details;

            //création des colonnes
            lstStop.Columns.Add("Arrêt 1");
            lstStop.Columns.Add("Arrêt 2");
            lstStop.Columns.Add("Durée (en min)");
            
            //remplissage des colonnes
            foreach (List<string> s in fill2)
            {
                var tmp = new ListViewItem(new[] { s[0], s[1], s[2] });

                lstStop.Items.Add(tmp);
            }
            //taille des colonnes
            lstStop.Columns[0].Width = -1;
            lstStop.Columns[1].Width = -1;
            lstStop.Columns[2].Width = -2;
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
