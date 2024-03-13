using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInsightsV2
{
    public partial class connectingForm : Form
    {
        public connectingForm()
        {
            InitializeComponent();
            pb_SeePassword.Image = Properties.Resources.oeil_cache;
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {

        }

        private void pb_SeePassword_Click(object sender, EventArgs e)
        {

            if (tb_Password.UseSystemPasswordChar == true)
            {
                // Afficher l'oeil fermé
                pb_SeePassword.Image = Properties.Resources.oeil_visible;

                // Activer le masquage des caractères
                tb_Password.UseSystemPasswordChar = false;
            }
            else
            {
                // Afficher l'oeil ouvert
                pb_SeePassword.Image = Properties.Resources.oeil_cache;

                // Désactiver le masquage des caractères
                tb_Password.UseSystemPasswordChar = true;
            }

        }
    }
}
