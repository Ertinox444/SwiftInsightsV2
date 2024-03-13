using Newtonsoft.Json;
using RestSharp;
using SwiftInsightsV2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using SwiftInsightsV2.Controller;
using SwiftInsightsV2.Class;




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
            /*   if (tb_Search.Text != "")
               {
                   //string token = "5579319a6e051e1f440765081f15d458";
                   Api api = new Api();

                   try
                   {
                       string[] results = await api.SearchEnterprise(tb_Search.Text);

                       // Afficher les informations de toutes les entreprises dans la zone de texte
                       textBox1.Text = string.Join(Environment.NewLine + Environment.NewLine, results);
                   }
                   catch (Exception ex)
                   {
                       textBox1.Text = "Erreur lors de la requête à l'API : " + ex.Message;
                   }
               }
               else
               {
                   MessageBox.Show("Entrez un nom d'entreprise");
               }*/
        }
    }
}

