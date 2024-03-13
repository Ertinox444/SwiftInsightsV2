using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwiftInsightsV2.Class
{
    public class Entreprise
    {
        public string NomCommercial { get; set; }
        public string Siren { get; set; }
        public string NafCode { get; set; }
        public string NafLib { get; set; }
        public string CpVille { get; set; }
        public string Dep { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }

    public class ApiResponse
    {
        public List<Entreprise> Results { get; set; }
    }
}