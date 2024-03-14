using SwiftInsightsV2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftInsightsV2
{
    public partial class SelectEtablissementDialog : Form
    {
        private ComboBox comboBoxEtablissements;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelInstructions;

        public EntrepriseEtablissement SelectedEtablissement { get; private set; }
        private List<EntrepriseEtablissement> etablissements;

        public SelectEtablissementDialog(List<EntrepriseEtablissement> etablissements)
        {
            InitializeComponent2();
            this.etablissements = etablissements;
            LoadEtablissements();
            labelInstructions.Text = "Veuillez choisir un des établissements de l'entreprise - " + etablissements[0].Deno + "(N° Siret)";
        }

        //Création de la fenêtre
        private void InitializeComponent2()
        {
            this.comboBoxEtablissements = new ComboBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelInstructions = new Label(); // Nouveau label ajouté

            this.SuspendLayout();

            this.Text = "Sélectionner un établissement";
            this.ClientSize = new System.Drawing.Size(500, 250); // Taille de la fenêtre augmentée
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

         
            this.labelInstructions.ForeColor = System.Drawing.ColorTranslator.FromHtml("#001D3B"); // Couleur du texte définie
            this.labelInstructions.Font = new Font("Arial", 10, FontStyle.Regular); // Police d'écriture définie
            this.labelInstructions.TextAlign = ContentAlignment.MiddleCenter; // Centrage du texte
            this.labelInstructions.Location = new System.Drawing.Point(50, 50); // Position du label ajustée
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.MaximumSize = new Size(400, 0); // Permettre le saut de ligne si nécessaire
            this.labelInstructions.AutoEllipsis = true; // Ajouter des points de suspension si le texte est trop long
            this.Controls.Add(this.labelInstructions);

            this.comboBoxEtablissements.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxEtablissements.Location = new System.Drawing.Point(50, 120); // Position de la combobox ajustée
            this.comboBoxEtablissements.Size = new System.Drawing.Size(400, 24); // Taille de la combobox ajustée

            this.buttonOK.Text = "OK";
            this.buttonOK.DialogResult = DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(150, 170); // Position du bouton OK ajustée
            this.buttonOK.Size = new System.Drawing.Size(100, 30); // Taille du bouton ajustée

            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(250, 170); // Position du bouton Annuler ajustée
            this.buttonCancel.Size = new System.Drawing.Size(100, 30); // Taille du bouton ajustée

            this.Controls.Add(this.comboBoxEtablissements);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.ResumeLayout(false);
        }



        //Chargement dans la combo box des établissements
        private void LoadEtablissements()
        {
            foreach (var etab in etablissements)
            {
                comboBoxEtablissements.Items.Add(etab.Siret);
            }

            if (comboBoxEtablissements.Items.Count > 0)
            {
                comboBoxEtablissements.SelectedIndex = 0;
            }
        }
        //Envoie vers la page de détail l'établissement choisi
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (comboBoxEtablissements.SelectedItem != null)
                {
                    string nomEtablissement = comboBoxEtablissements.SelectedItem.ToString();

                    SelectedEtablissement = etablissements.FirstOrDefault(e => e.Siret == nomEtablissement);
                }
                else
                {
                    e.Cancel = true;
                }
            }

            base.OnFormClosing(e);
        }
    }
}

