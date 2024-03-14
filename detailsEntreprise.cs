using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwiftInsightsV2.Class;

namespace SwiftInsightsV2
{
    public partial class detailsEntreprise : Form
    {
        private EntrepriseEtablissement selectedEtablissement;

        public detailsEntreprise(List<EntrepriseEtablissement> listeE)
        {
            InitializeComponent();




        }

        public detailsEntreprise(EntrepriseEtablissement selectedEtablissement)
        {
            InitializeComponent();
            EntrepriseEtablissement etabSelect = selectedEtablissement;
            tb_Name.Text = etabSelect.Deno;
            tb_CP.Text = etabSelect.CodePostal;
            tb_Adress.Text = etabSelect.VoieAdr;
            tb_Commune.Text = etabSelect.Ville;
            tb_DateDeb.Text = FormatDate(etabSelect.DateApparition);
            tb_DateFin.Text = FormatDate(etabSelect.DateFermeture);
            tb_SIRET.Text = etabSelect.Siret;
            tb_SecAct.Text = etabSelect.NafLib;
            tb_CodeAPE.Text = etabSelect.Naf;
            tb_NbEmploye.Text = etabSelect.TrancheEffInsee;
            this.Text = "Détail Entreprise - " + etabSelect.Deno + " - N° SIRET : " + etabSelect.Siret;
        }

        public static string FormatDate(string dateString)
        {
            if (string.IsNullOrEmpty(dateString) || dateString.Length != 8)
                return "";

            string formattedDate = dateString.Insert(4, "-").Insert(7, "-"); // Insérer les tirets pour obtenir le format "yyyy-MM-dd"
            DateTime date;
            if (DateTime.TryParseExact(formattedDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                return date.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("fr-FR")); // Formater la date en "dd MMMM yyyy"
            }
            else
            {
                return "";
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_CP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
