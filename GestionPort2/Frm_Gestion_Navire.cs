using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPort2
{
    public partial class Frm_Gestion_Navire : Form
    {
        public Frm_Gestion_Navire()
        {
            InitializeComponent();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreerPort_Click(object sender, EventArgs e) {
            Port port = new Port();
            port.NomPort = txtBoxNomPort.Text;
            port.NbNavireFret() = txtBoxFretPresent.
        }

    }
}
