using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwiftInsightsV2.Entities;
using BC = BCrypt.Net.BCrypt;

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
            List<User> listeU = Modele.getAdmin();

            Dictionary<string, string> DictioAdmin = new Dictionary<string, string>();

            foreach (User us in listeU)
            {
                
                string username = us.LoginUser;

                DictioAdmin.Add(username, us.PasswordUser);
            }


            /*   string login_verif = admin.LoginAdmin;
               string password_verif = admin.MdpAdmin;*/
            string login_Input = tb_login.Text;
            string password_Input = tb_Password.Text;


            bool correspondanceTrouvee = false;

            foreach (var admins in DictioAdmin)
            {
                if ((login_Input == admins.Key) && BC.Verify(password_Input, admins.Value))
                {
                    mainForm FM = new mainForm();
                    FM.Show();
                    this.Hide();
                    correspondanceTrouvee = true;
                    break; // Sortir de la boucle une fois une correspondance trouvée
                }
            }

            // Vérifier si aucune correspondance n'a été trouvée
            if (!correspondanceTrouvee)
            {
                MessageBox.Show("Mot de passe ou identifiant incorrect");
            }
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
