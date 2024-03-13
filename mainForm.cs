using SwiftInsightsV2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwiftInsightsV2.Controller;


namespace SwiftInsightsV2
{
    public partial class mainForm : Form
    {
        private SousFormulaire SF;
        public mainForm()
        {
            InitializeComponent();
            SF = new SousFormulaire(main_PNL);
            menuForm FM = new menuForm();
            SF.openChildForm(FM);
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            searchForm SFM = new searchForm();
            SF.openChildForm(SFM);
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            createForm CFM = new createForm();
            SF.openChildForm(CFM);
        }

        private void mainPic_ToMenu_Click(object sender, EventArgs e)
        {
            menuForm MFM = new menuForm();
            SF.openChildForm(MFM);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Ferme la forme actuelle
            this.Close();

            // Redémarre l'application pour afficher la forme de connexion
            Application.Restart();



        }
    }
}
