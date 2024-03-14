using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwiftInsightsV2.Class;
using SwiftInsightsV2.Controller;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SwiftInsightsV2
{
    public partial class searchForm : Form
    {
        private List<Entreprise> allEnterprises; // Variable pour stocker toutes les entreprises
        private List<EntrepriseEtablissement> allEnterprisesEtab;
        private int currentPage = 1; // Page actuelle
        private int pageSize = 20; // Nombre d'entreprises par page
        private int totalResults; // Nombre total de résultats
        private int totalPages; // Nombre total de pages

        public searchForm()
        {
            InitializeComponent();
        }

        private async void pb_Search_Click(object sender, EventArgs e)
        {
            if (tb_Search.Text != "")
            {
                Api api = new Api();

                //Condition si texte ou numéro particulier

                if ((tb_Search.Text.Length == 14 || tb_Search.Text.Length == 9) && tb_Search.Text.All(char.IsDigit))
                {
                    try
                    {
                        JArray results = await api.SearchEnterpriseBySiren(tb_Search.Text);



                        allEnterprisesEtab = JsonConvert.DeserializeObject<List<EntrepriseEtablissement>>(results.ToString());

                        // Afficher une boîte de dialogue modale avec une liste déroulante pour sélectionner l'établissement
                        using (var dialog = new SelectEtablissementDialog(allEnterprisesEtab))
                        {
                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                // L'utilisateur a sélectionné un établissement, afficher les détails de l'entreprise
                                detailsEntreprise DE = new detailsEntreprise(dialog.SelectedEtablissement);
                                DE.Show();
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la requête à l'API : " + ex.Message);
                    }

                }
                else
                {

                    try
                    {
                        JArray results = await api.SearchEnterprise(RemoveAccents(tb_Search.Text));
                        allEnterprises = JsonConvert.DeserializeObject<List<Entreprise>>(results.ToString());


                        totalResults = allEnterprises.Count;
                        CalculatePages();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la requête à l'API : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Entrez un nom d'entreprise");
            }
        }

        
        private void resultNumber_PerPage_ValueChanged(object sender, EventArgs e)
        {
            pageSize = (int)resultNumber_PerPage.Value;
            CalculatePages();
            LoadData();
        }

        private void pb_PreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void pb_NextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }
        //Fonction calcul les paginations et charge les données en fonction du nombre de résultats, le nombre d'affichage souhaité
        private void LoadData()
        {
            // Calculer l'index de début et de fin pour la page actuelle
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, allEnterprises.Count);

            // Extraire les entreprises pour la page actuelle
            var pageEnterprises = allEnterprises.Skip(startIndex).Take(endIndex - startIndex).ToList();

            // Afficher les entreprises dans la DataGridView
            advDGV_Search.DataSource = pageEnterprises;
            advDGV_Search.Columns.RemoveAt(7); // Remove Latitude column
            advDGV_Search.Columns.RemoveAt(6); // Remove Longitude column
            advDGV_Search.Columns[0].HeaderText = "Nom Commercial";
            advDGV_Search.Columns[1].HeaderText = "N° Siren";
            advDGV_Search.Columns[2].HeaderText = "Code APE";
            advDGV_Search.Columns[3].HeaderText = "Activité Principale";
            advDGV_Search.Columns[4].HeaderText = "Code Postal";


            // Mettre à jour le numéro de page affiché
            tb_PageNumber.Text = currentPage.ToString();
        }

        private async void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Fonction calcul pages
        private void CalculatePages()
        {
            totalPages = (int)Math.Ceiling((double)totalResults / pageSize);
            tb_Max.Text = (totalPages == 200) ? "+200" : totalPages.ToString();
            tb_NumberOfResult.Text = totalResults.ToString();
            currentPage = 1; // Réinitialiser la page courante à la première page
            tb_PageNumber.Text = currentPage.ToString();
        }

        private async void tb_Search_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pb_Search_Click(sender, e);
            }
        }

        private async void advDGV_Search_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Api api = new Api();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string siren = advDGV_Search.Rows[e.RowIndex].Cells["Siren"].Value.ToString();

                // Récupérer tous les établissements de l'entreprise correspondant au numéro de Siren
                JArray results = await api.SearchEnterpriseBySiren(siren);
                List<EntrepriseEtablissement> allEnterprisesEtab = JsonConvert.DeserializeObject<List<EntrepriseEtablissement>>(results.ToString());

                // Afficher une boîte de dialogue modale avec une liste déroulante pour sélectionner l'établissement
                using (var dialog = new SelectEtablissementDialog(allEnterprisesEtab))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // L'utilisateur a sélectionné un établissement, afficher les détails de l'entreprise
                        detailsEntreprise DE = new detailsEntreprise(dialog.SelectedEtablissement);
                             DE.Show();
                    }
                }
            }
        }

        public static string RemoveAccents(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            string normalizedString = input.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
