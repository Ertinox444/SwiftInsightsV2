using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwiftInsightsV2.Class
{
    public class EntrepriseEtablissement
    {
        public string Siret { get; set; }
        public string Deno { get; set; }
        public string TypeEtab { get; set; }
        public bool EstActive { get; set; }

        public string TypVoieInsee { get; set; }
        public string LibVoieInsee { get; set; }
        public string NomAdressage { get; set; }
        public bool EstDiffusable { get; set; }
        
        public string Nic { get; set; }
        
        public string NumVoieInsee { get; set; }
        public string IndRepInsee { get; set; }
        
        public string CpltnomAdressage { get; set; }
        public string CpltAdr { get; set; }
        public string VoieAdr { get; set; }
        public string Dispadr { get; set; }
        public string CodePostal { get; set; }
        public string VilleBrut { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string DepUrb { get; set; }
        public string TailleUrb { get; set; }
        public string NumUrb { get; set; }
        public string Enseigne { get; set; }
        public string NomCommercial { get; set; }
        public string Naf { get; set; }
        public string NafLib { get; set; }
        public string Aprm { get; set; }
        public string AprmLib { get; set; }
        public string TrancheEffInsee { get; set; }
        public string DateApparition { get; set; }
        public string DateFermeture { get; set; }
    }

    public class EntrepriseData
    {
        public string VersionCourante { get; set; }
        public string LienDocVersionCourante { get; set; }
        public string DerniereVersion { get; set; }
        public string LienDocDerniereVersion { get; set; }
        public string SiretSiege { get; set; }
        public int NbEtablissements { get; set; }
        public List<EntrepriseEtablissement> Etablissements { get; set; }
    }

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