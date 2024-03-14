using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SwiftInsightsV2.Controller
{
    public class Api
    {
        private readonly string _token = "5579319a6e051e1f440765081f15d458";

        public Api()
        {

        }

        //Fonction de recherche d'entreprise par nom
        public async Task<JArray> SearchEnterprise(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                throw new ArgumentException("Le terme de recherche ne peut pas être vide.");

            string url = "https://api.societe.com/api/v1/entreprise/search?nom=" + searchTerm + "&token=" + _token;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dynamic jsonObject = JsonConvert.DeserializeObject(content);

                    return jsonObject.data.results;
                }
                else
                {
                    throw new Exception("Erreur lors de la requête à l'API : " + response.StatusCode);
                }
            }
        }
        //Fonction de recherche d'entreprise par Siren ou Siret
        public async Task<JArray> SearchEnterpriseBySiren(string siret)
        {
            if (string.IsNullOrWhiteSpace(siret))
                throw new ArgumentException("Le terme de recherche ne peut pas être vide.");

            string url = "https://api.societe.com/api/v1/entreprise/"+siret+"/etablissements?token=" + _token;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    dynamic jsonObject = JsonConvert.DeserializeObject(content);

                    return jsonObject.data.etablissements;
                }
                else
                {
                    throw new Exception("Erreur lors de la requête à l'API : " + response.StatusCode);
                }
            }
        }
    }
}
