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
    public partial class AddLine : Form
    {
        public AddLine()
        {
            InitializeComponent();
            lblLine.Text = "Ligne " + ((Convert.ToInt32(BD.getNomLigne(BD.getNbLigne())))+1).ToString();
        }
    }
}
