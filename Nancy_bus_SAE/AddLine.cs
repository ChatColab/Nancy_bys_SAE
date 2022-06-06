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

            nudHours.Enabled = false;
            nudMinutes.Enabled = false;
            nudSeconds.Enabled = false;
            cmdAdd.Enabled = false;
            cmdValidate.Enabled = false;
            lblLine.Text = "Ligne " + ((Convert.ToInt32(BD.getNomLigne(BD.getNbLigne())))+1).ToString();

            foreach (String s in BD.getNomArret())
            {
                cboStop.Items.Add(s);
            }
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


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int heure = (int)nudHours.Value;
            int minute = (int)nudMinutes.Value;
            int seconde = (int)nudSeconds.Value;
            string time = $"{heure}:{minute}:{seconde}";
            bool exist = false;
            foreach (string s in lstHourly.Items)
            {
                if (s == time)
                    exist = true;
            }

            if (!exist) {
                lstHourly.Items.Add(time);
            }
            cmdValidate.Enabled = true;
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            if (nudHours.Value > 23)
            {
                nudHours.Value = 23;
            }
            if (nudHours.Value < 0)
            {
                nudHours.Value = 0;
            }
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinutes.Value > 59)
            {
                nudMinutes.Value = 59;
            }
            if (nudMinutes.Value < 0)
            {
                nudMinutes.Value = 0;
            }
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (nudSeconds.Value > 59)
            {
                nudSeconds.Value = 59;
            }
            if (nudSeconds.Value < 0)
            {
                nudSeconds.Value = 0;
            }
        }

        private void cboStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudHours.Enabled = true;
            nudMinutes.Enabled = true;
            nudSeconds.Enabled = true;
            cmdAdd.Enabled = true;
        }
    }
}
