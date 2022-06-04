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

            lstStop.View = View.Details;

            lstStop.Columns.Add("Arrêt 1");
            lstStop.Columns.Add("Arrêt 2");
            lstStop.Columns.Add("Durée (en min)");
            foreach (List<string> s in fill2)
            {
                var tmp = new ListViewItem(new[] { s[0], s[1], s[2] });

                lstStop.Items.Add(tmp);
            }
            
            //lstStop.Items.AddRange(new ListViewItem[] { a1, a2, inter });
        }
    }
}
