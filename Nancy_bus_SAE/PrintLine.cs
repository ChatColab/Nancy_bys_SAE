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
            List<String> fill;
            fill = BD.getHeureDepLigne(nLine);
            foreach (String s in fill)
            {
                lstHourly.Items.Add(s);
            }
        }
    }
}
