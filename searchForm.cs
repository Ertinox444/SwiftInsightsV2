using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwiftInsightsV2.Class;
using SwiftInsightsV2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInsightsV2
{
    public partial class searchForm : Form
    {
        private List<Entreprise> allEnterprises; // Variable pour stocker toutes les entreprises
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

                try
                {
                    JArray results = await api.SearchEnterprise(tb_Search.Text);
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
    }
}
