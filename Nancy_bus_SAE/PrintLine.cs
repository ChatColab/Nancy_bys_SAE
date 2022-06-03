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
            ListViewItem a1 = new ListViewItem("Arrêt 1");
            ListViewItem a2 = new ListViewItem("Arrêt 2");
            ListViewItem inter = new ListViewItem("Durée (en min)");
            for (int i = 0; i < fill2.Count; i++)
            {
                a1.SubItems.Add(fill2[i][0]);
                a2.SubItems.Add(fill2[i][1]);
                inter.SubItems.Add(fill2[i][2]);
            }
            lstStop.Items.AddRange(new ListViewItem[] { a1, a2, inter });
            //lstStop
        }
    }
}
