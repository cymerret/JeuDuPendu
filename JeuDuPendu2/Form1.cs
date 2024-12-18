/* Title : Jeu du pendu
 * Author : Cyril Merret
 * Date : 19/09/2024
 * Upgrade : améliorations pour partie en plusieurs rounds
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu2
{
    public partial class Form1 : Form
    {
        int essai = 0;
        int erreur = 0;
        string motMystere;
        TextBox txtMot;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreaLettres();
            ChangePhase();
        }

        /// <summary>
        /// Création des boutons lettres
        /// </summary>
        private void CreaLettres()
        {
            int corX = 10;
            int corY = 20;
            for(int i = 0; i < 26; i++)
            {
                // création des boutons
                Button btnLettre = new Button();
                grbLettres.Controls.Add(btnLettre);
                btnLettre.Location = new Point(corX, corY);
                btnLettre.Size = new Size(23, 23);
                btnLettre.Text = ((char)('A' + i)).ToString();
                btnLettre.Click += new EventHandler(btnLettre_Click);

                // positionnement des boutons
                corX += 25;
                if ((i + 1) % 9 == 0)
                {
                    corX = 10;
                    corY += 25;
                }
            }
        }

        /// <summary>
        /// Changement de phases : phase de saisie du mot <-> phase de recherche du mot
        /// </summary>
        private void ChangePhase()
        {
            grbLettres.Enabled = !grbLettres.Enabled;
            txtMot.Visible = !txtMot.Visible;
            txtMot.Text = "";
            pctRejouer.Visible = !pctRejouer.Visible;

            // préparation pour phase de recherche du mot
            if (txtMot.Visible == false)
            {
                for (int i = 0; i < motMystere.Length; i++)
                {
                    lblMot.Text += "-";
                }
            }
            // préparation pour phase de saisie du mot
            else
            {
                lblMot.Text = "";
                txtMot.Focus();
                essai = 0;
                erreur = 0;
                ChangeImage();
                for (int lettre = 0; lettre < grbLettres.Controls.Count; lettre++)
                {
                    grbLettres.Controls[lettre].Enabled = true;
                }
            }
        }

        /// <summary>
        /// Test pour vérifier si la lettre choisie est dans le mot à trouver
        /// </summary>
        /// <param name="lettre"></param>
        private void TestLettre(char lettre)
        {
            // recherche de la lettre dans le mot
            bool isValide = false;
            for (int i = 0; i < motMystere.Length; i++)
            {
                char x = motMystere[i];
                // vérifie si la lettre est valide
                if (motMystere[i].Equals(lettre))
                {
                    lblMot.Text = lblMot.Text.Remove(i, 1);
                    lblMot.Text = lblMot.Text.Insert(i, lettre.ToString());
                    isValide = true;
                }
            }
            // vérifie si la lettre est invalide
            if (!isValide)
            {
                erreur++;
                ChangeImage();
            }
            // vérifie si une des conditions de fin de partie est atteinte
            if (lblMot.Text.Equals(motMystere) || (erreur == 10))
            {
                FinPartie();
            }
        }

        /// <summary>
        /// Mise à jour de l'image du pendu
        /// </summary>
        private void ChangeImage()
        {
            string pathImage = "E:\\Programmes\\Visual Studio Entreprise 2019\\Projets\\B12SQ2\\JeuDuPendu2\\JeuDuPendu2\\Ressources\\pendu" + erreur + ".png";
            pctPendu.Image = Image.FromFile(pathImage);
        }

        /// <summary>
        /// Arrêt de la partie et affichage du résultat
        /// </summary>
        private void FinPartie()
        {
            string message;
            if (erreur == 10)
            {
                message = "Perdu... \r\nLe mot à trouver était : " + motMystere;
            }
            else
            {
                message = "Bravo ! \r\nNombre d'essai : " + essai;
            }
            DialogResult conclusion = MessageBox.Show(message, "Partie terminée", MessageBoxButtons.OK);
            if (conclusion == DialogResult.OK)
            {
                ChangePhase();
            }
        }

        /// <summary>
        /// Récupération de la lettre choisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLettre_Click(object sender, EventArgs e)
        {
            Button btnLettre = (Button)sender;
            char lettre = char.Parse(((Button)sender).Text);
            essai++;
            btnLettre.Enabled = false;
            TestLettre(lettre);
        }
        
        /// <summary>
        /// Passage à la phase de recherche du mot si le mot est valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && (txtMot.Text != ""))
            {
                bool isValide = true;
                for (int i = 0; i < txtMot.Text.Length; i++)
                {
                    if (((char)txtMot.Text[i] < 65) || ((char)txtMot.Text[i] > 90 && (char)txtMot.Text[i] < 97) || ((char)txtMot.Text[i] > 122))
                    {
                        isValide = false;
                    }
                }
                if (isValide)
                {
                    motMystere = txtMot.Text.ToUpper();
                    ChangePhase();
                }
                else
                {
                    if (MessageBox.Show("Veillez à ne saisir que des lettres simples (pas d'accents, de caractères spéciaux ou de nombres)", "Erreur de saisie", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        txtMot.Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// Arrêt et relance d'une partie (non finie)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctRejouer_Click(object sender, EventArgs e)
        {
            ChangePhase();
        }
    }
}
