using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInsightsV2
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Vérifier si le champ de recherche n'est pas vide
            if (!string.IsNullOrWhiteSpace(tb_Search.Text))
            {
                // Appeler la méthode pour envoyer la requête à l'API avec le contenu de tb_Search
                string responseData = await EnvoyerRequeteAPI(tb_Search.Text);

                // Vérifier si la réponse de l'API n'est pas vide
                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    try
                    {
                        // Désérialiser la réponse JSON en un objet ResponseData
                        ResponseData data = JsonConvert.DeserializeObject<ResponseData>(responseData);

                        // Afficher les données dans textBox1
                        AfficherDonnees(data);
                    }
                    catch (Exception ex)
                    {
                        // Afficher un message en cas d'erreur de désérialisation
                        MessageBox.Show($"Erreur de désérialisation : {ex.Message}");
                    }
                }
                else
                {
                    // Afficher un message d'erreur si la réponse de l'API est vide
                    MessageBox.Show("Aucune donnée trouvée.");
                }
            }
            else
            {
                // Afficher un message si le champ de recherche est vide
                MessageBox.Show("Veuillez entrer un terme de recherche.");
            }
        }

        private void AfficherDonnees(ResponseData data)
        {
            // Afficher les données dans textBox1
            textBox1.Clear();
            textBox1.AppendText($"Version courante : {data.Data.VersionCourante}\r\n");
            textBox1.AppendText($"Dernière version : {data.Data.DerniereVersion}\r\n");
            textBox1.AppendText($"Lien vers la documentation (version courante) : {data.Data.LienDocVersionCourante}\r\n");
            textBox1.AppendText($"Lien vers la documentation (dernière version) : {data.Data.LienDocDerniereVersion}\r\n");

            // Afficher les établissements
            textBox1.AppendText("\r\nÉtablissements :\r\n");
            foreach (var etablissement in data.Data.Etablissements)
            {
                textBox1.AppendText($"Nom Commercial : {etablissement.Deno}\r\n");
                textBox1.AppendText($"N° Siren : {etablissement.Siret}\r\n");
                textBox1.AppendText($"Code APE : {etablissement.Naf}\r\n");
                textBox1.AppendText($"Activité Principale : {etablissement.NafLib}\r\n");
                textBox1.AppendText($"Code Postal : {etablissement.CodePostal}\r\n");
                textBox1.AppendText("\r\n");
            }
        }


        private async Task<string> EnvoyerRequeteAPI(string termeRecherche)
        {
            // Jeton d'authentification (à remplacer par votre jeton)
            string token = "5579319a6e051e1f440765081f15d458";

            // URL de l'API avec le terme de recherche et le token
            string apiUrl = $"https://api.societe.com/api/v1/entreprise/{termeRecherche}" + "/etablissements";

            try
            {
                // Créer un objet HttpClient
                using (HttpClient client = new HttpClient())
                {
                    // Ajouter le header d’authentification X-Authorization avec le jeton
                    client.DefaultRequestHeaders.Add("X-Authorization", $"socapi {token}");

                    // Envoyer la requête GET à l'API et récupérer la réponse
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Vérifier si la réponse est réussie (code 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Si la requête échoue, retourner une chaîne vide
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // En cas d'erreur lors de l'envoi de la requête, afficher l'exception
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
                return string.Empty;
            }
        }
    }

    public class Etablissement
    {
        [JsonProperty("typeetab")]
        public string TypeEtab { get; set; }

        [JsonProperty("estactive")]
        public bool EstActive { get; set; }

        [JsonProperty("estdiffusable")]
        public bool EstDiffusable { get; set; }

        [JsonProperty("siret")]
        public string Siret { get; set; }

        [JsonProperty("nic")]
        public string Nic { get; set; }

        [JsonProperty("deno")]
        public string Deno { get; set; }

        [JsonProperty("numvoieinsee")]
        public string NumVoieInsee { get; set; }

        [JsonProperty("indrepinsee")]
        public string IndRepInsee { get; set; }

        [JsonProperty("typvoieinsee")]
        public string TypVoieInsee { get; set; }

        [JsonProperty("libvoieinsee")]
        public string LibVoieInsee { get; set; }

        [JsonProperty("nomadressage")]
        public string NomAdressage { get; set; }

        [JsonProperty("cpltnomadressage")]
        public string CpltNomAdressage { get; set; }

        [JsonProperty("cpltadr")]
        public string CpltAdr { get; set; }

        [JsonProperty("voieadr")]
        public string VoieAdr { get; set; }

        [JsonProperty("dispadr")]
        public string DispAdr { get; set; }

        [JsonProperty("codepostal")]
        public string CodePostal { get; set; }

        [JsonProperty("villebrut")]
        public string VilleBrut { get; set; }

        [JsonProperty("ville")]
        public string Ville { get; set; }

        [JsonProperty("pays")]
        public string Pays { get; set; }

        [JsonProperty("depurb")]
        public string DepUrb { get; set; }

        [JsonProperty("tailleurb")]
        public string TailleUrb { get; set; }

        [JsonProperty("numurb")]
        public string NumUrb { get; set; }

        [JsonProperty("enseigne")]
        public string Enseigne { get; set; }

        [JsonProperty("nomcommercial")]
        public string NomCommercial { get; set; }

        [JsonProperty("naf")]
        public string Naf { get; set; }

        [JsonProperty("naflib")]
        public string NafLib { get; set; }

        [JsonProperty("aprm")]
        public string Aprm { get; set; }

        [JsonProperty("aprmlib")]
        public string AprmLib { get; set; }

        [JsonProperty("trancheeffinsee")]
        public string TrancheEffInsee { get; set; }

        [JsonProperty("dateapparition")]
        public string DateApparition { get; set; }

        [JsonProperty("datefermeture")]
        public string DateFermeture { get; set; }
    }

    public class Data
    {
        [JsonProperty("versioncourante")]
        public string VersionCourante { get; set; }

        [JsonProperty("liendocversioncourante")]
        public string LienDocVersionCourante { get; set; }

        [JsonProperty("derniereversion")]
        public string DerniereVersion { get; set; }

        [JsonProperty("liendocderniereversion")]
        public string LienDocDerniereVersion { get; set; }

        [JsonProperty("siretsiege")]
        public string SiretSiege { get; set; }

        [JsonProperty("nbetablissements")]
        public int NbEtablissements { get; set; }

        [JsonProperty("etablissements")]
        public List<Etablissement> Etablissements { get; set; }
    }

    public class ResponseData
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
