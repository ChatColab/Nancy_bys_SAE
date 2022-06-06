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
    public partial class DelStopX : Form
    {
        public DelStopX(int nLigne,int nArret)
        {
            InitializeComponent();

            this.Text = "Supprimer Arrêt " + BD.getNomArret(nArret);

            lblLine.Text = "Ligne " + BD.getNomLigne(nLigne);
        }
    }
}
