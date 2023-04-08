using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamTraining
{
    public partial class frmExamFinDeSession : Form
    {
        public frmExamFinDeSession()
        {
            InitializeComponent();
        }

        public struct Employee
        {
            public string numero;
            public string nom;
            public string fonction;
            public Int32 salaire;
        }

        ///-----------------Variable General---------------------
        Employee[] tabEmployes = new Employee[25];
        int numberOfEmployes, indiceEmployeeEdit, indiceActuel, counterTiret = 0;
        bool btnAjouterClicked = false, btnModifierClicked = false;
        ///-----------------Variable General---------------------

        private void examFinDeSession_Load(object sender, EventArgs e)
        {
            ///Enable les boutton on load 
            btnSauvgarder.Enabled = false;
            btnAnnuler.Enabled = false;

            ///Ouverture Fichier en Lecture-------------------------
            StreamReader compagnieFile = new StreamReader("compagnie.txt");

            int j = 0;
            while (compagnieFile.EndOfStream == false)
            {
                tabEmployes[j].numero = compagnieFile.ReadLine();
                tabEmployes[j].nom = compagnieFile.ReadLine();
                tabEmployes[j].fonction = compagnieFile.ReadLine();
                tabEmployes[j].salaire = Convert.ToInt32(compagnieFile.ReadLine());

                j++;
            }
            numberOfEmployes = j;

            compagnieFile.Close();
            ///Cloture du Fichier-------------------------------------

            ///remplir la ListBox
            for (int i = 0; i < numberOfEmployes; i++)
            {
                lstEmployee.Items.Add(tabEmployes[i].numero);
            }

            ///Afficher le premier element du tableau des les txt
            txtNumero.Text = tabEmployes[0].numero;
            txtNom.Text = tabEmployes[0].nom;
            txtFonction.Text = tabEmployes[0].fonction;
            txtSalaire.Text = tabEmployes[0].salaire.ToString();


            RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {


            btnAjouterClicked = true;

            ///Enable les boutton
            btnSauvgarder.Enabled = true;
            btnAnnuler.Enabled = true;
            btnSauvgarder.ForeColor = Color.Blue;

            ///Preparer l'ajoute
            txtNumero.Clear();
            txtNumero.Focus();
            txtNom.Clear();
            txtFonction.Clear();
            txtSalaire.Clear();

            counterTiret = 0;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ///Enable les boutton
            btnSauvgarder.Enabled = false;
            btnAnnuler.Enabled = false;

            ///Enable les boutton on load 
            btnSauvgarder.Enabled = false;
            btnAnnuler.Enabled = false;

            ResteToZero(tabEmployes);

            indiceActuel = 0;
        }

        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            ///Enable les boutton
            btnSauvgarder.Enabled = false;
            btnAnnuler.Enabled = false;
            btnSauvgarder.ForeColor = Color.Black;

            ///Prise En Comptes des Erreurs:----
            if (txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Veuillez Remplir le champs (Numero) avant de clicker sur sauvgarder");

                ResteToZero(tabEmployes);

                return;
            }

            if (txtNom.Text.Length == 0)
            {
                MessageBox.Show("Veuillez Remplir le champs (Nom) avant de clicker sur sauvgarder");

                ///Afficher le premier element du tableau des les txt
                txtNumero.Text = tabEmployes[0].numero;
                txtNom.Text = tabEmployes[0].nom;
                txtFonction.Text = tabEmployes[0].fonction;
                txtSalaire.Text = tabEmployes[0].salaire.ToString();

                return;
            }

            if (txtFonction.Text.Length == 0)
            {
                MessageBox.Show("Veuillez Remplir le champs (Fonction) avant de clicker sur sauvgarder");

                ///Afficher le premier element du tableau des les txt
                txtNumero.Text = tabEmployes[0].numero;
                txtNom.Text = tabEmployes[0].nom;
                txtFonction.Text = tabEmployes[0].fonction;
                txtSalaire.Text = tabEmployes[0].salaire.ToString();

                return;
            }

            if (txtSalaire.Text.Length == 0)
            {
                MessageBox.Show("Veuillez Remplir le champs (salaire) avant de clicker sur sauvgarder");

                ///Afficher le premier element du tableau des les txt
                txtNumero.Text = tabEmployes[0].numero;
                txtNom.Text = tabEmployes[0].nom;
                txtFonction.Text = tabEmployes[0].fonction;
                txtSalaire.Text = tabEmployes[0].salaire.ToString();

                return;
            }

            ///le salaire ne doit pas depasser le max value de Int32
            if (Convert.ToInt32(txtSalaire.Text) >= 2147483647)
            {
                MessageBox.Show("Veuillez Re-Saisir un Salaire inferieur a ce que vous avez entrez ");

                ///Afficher le premier element du tableau des les txt
                txtNumero.Text = tabEmployes[0].numero;
                txtNom.Text = tabEmployes[0].nom;
                txtFonction.Text = tabEmployes[0].fonction;
                txtSalaire.Text = tabEmployes[0].salaire.ToString();

                return;
            }


            ///Prendre en compte le nombre de tirret dans le champ txtNumero
            foreach (char c in txtNumero.Text)
            {
                if (c == '-')
                {
                    counterTiret++;
                }
            }

            if (counterTiret != 1)
            {
                MessageBox.Show("Veuillez Remplir le champs (Numer) correctement (Format: XX-XXXX) avant de clicker sur sauvgarder");

                ///Afficher le premier element du tableau des les txt
                txtNumero.Text = tabEmployes[0].numero;
                txtNom.Text = tabEmployes[0].nom;
                txtFonction.Text = tabEmployes[0].fonction;
                txtSalaire.Text = tabEmployes[0].salaire.ToString();

                return;
            }

            if (btnAjouterClicked == true)
            {
                ///Creation d'un objet via la structure Employee:----
                Employee newEmployee;
                newEmployee.numero = txtNumero.Text;
                newEmployee.nom = txtNom.Text;
                newEmployee.fonction = txtFonction.Text;
                newEmployee.salaire = Convert.ToInt32(txtSalaire.Text);

                if (numberOfEmployes < 25)
                {
                    tabEmployes[numberOfEmployes] = newEmployee;
                    numberOfEmployes++;
                    lstEmployee.Items.Add(newEmployee.numero);
                }
                else
                {
                    MessageBox.Show("Vous avez atteint le nombre maximal d'employees");
                }

                btnAjouterClicked = false;
            }


            if (btnModifierClicked == true)
            {

                tabEmployes[indiceEmployeeEdit].numero = txtNumero.Text;
                tabEmployes[indiceEmployeeEdit].nom = txtNom.Text;
                tabEmployes[indiceEmployeeEdit].fonction = txtFonction.Text;
                tabEmployes[indiceEmployeeEdit].salaire = Convert.ToInt32(txtSalaire.Text);

                btnModifierClicked = false;
            }


            ///Re-remplir la ListBox
            lstEmployee.Items.Clear();
            for (int i = 0; i < numberOfEmployes; i++)
            {
                lstEmployee.Items.Add(tabEmployes[i].numero);
            }

            RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnModifierClicked = true;

            ///Enable les boutton
            btnSauvgarder.Enabled = true;
            btnAnnuler.Enabled = true;
            btnSauvgarder.ForeColor = Color.Blue;


            ///Sauvagarder l'indice de l'employee a modifier dans une variable 
            for (int i = 0; i < numberOfEmployes; i++)
            {
                if (txtNumero.Text == tabEmployes[i].numero)
                {
                    indiceEmployeeEdit = i;
                }
            }

            ///Preparer la modification
            txtNumero.Focus();
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedIndex != -1) {
                for (int i = 0; i < numberOfEmployes; i++)
                {
                    if (lstEmployee.SelectedItem.ToString() == tabEmployes[i].numero)
                    {
                        lblAfficherNumero.Text = "Numero : " + tabEmployes[i].numero;
                        lblAfficherNom.Text = "Nom : " + tabEmployes[i].nom;
                        lblAfficherFonction.Text = "Fonction : " + tabEmployes[i].fonction;
                        lblAfficherSalaire.Text = "Salaire : " + (tabEmployes[i].salaire).ToString();
                    }
                }
            }

        }

        private void lblControl_Click(object sender, EventArgs e)
        {

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (indiceActuel != numberOfEmployes - 1)
            {
                indiceActuel++;
                txtNumero.Text = tabEmployes[indiceActuel].numero;
                txtNom.Text = tabEmployes[indiceActuel].nom;
                txtFonction.Text = tabEmployes[indiceActuel].fonction;
                txtSalaire.Text = tabEmployes[indiceActuel].salaire.ToString();

                RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);
            }

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indiceActuel != 0)
            {
                indiceActuel--;
                txtNumero.Text = tabEmployes[indiceActuel].numero;
                txtNom.Text = tabEmployes[indiceActuel].nom;
                txtFonction.Text = tabEmployes[indiceActuel].fonction;
                txtSalaire.Text = tabEmployes[indiceActuel].salaire.ToString();

                RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);
            }

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {

            ResteToZero(tabEmployes);

            RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            ///Afficher le premier element du tableau des les txt
            txtNumero.Text = tabEmployes[numberOfEmployes - 1].numero;
            txtNom.Text = tabEmployes[numberOfEmployes - 1].nom;
            txtFonction.Text = tabEmployes[numberOfEmployes - 1].fonction;
            txtSalaire.Text = tabEmployes[numberOfEmployes - 1].salaire.ToString();

            RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);
        }

        private void frmExamFinDeSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///Ouverture du fichier en mode ecriture--------------------------------
            StreamWriter compagnieFile = new StreamWriter("compagnie.txt");

            for (int i = 0; i < numberOfEmployes; i++)
            {
                compagnieFile.WriteLine(tabEmployes[i].numero);
                compagnieFile.WriteLine(tabEmployes[i].nom);
                compagnieFile.WriteLine(tabEmployes[i].fonction);

                if (i == numberOfEmployes - 1)
                {
                    compagnieFile.Write(tabEmployes[i].salaire);
                }
                else
                {
                    compagnieFile.WriteLine(tabEmployes[i].salaire);
                }
            }

            compagnieFile.Close();
            ///Cloture du Fichier---------------------------------------------------
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
        }

        private void txtFonction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (numberOfEmployes != 0)
            {
                int indexToDelete = indiceActuel;

                tabEmployes = tabEmployes.Where((source, index) => index != indexToDelete).ToArray();
                numberOfEmployes--;
                lstEmployee.Items.RemoveAt(indexToDelete);

                ResteToZero(tabEmployes);


                ///Re-remplir la ListBox
                lstEmployee.Items.Clear();
                for (int i = 0; i < numberOfEmployes; i++)
                {
                    lstEmployee.Items.Add(tabEmployes[i].numero);
                }

                RemplirLblControl(tabEmployes, numberOfEmployes, indiceActuel);


            }


        }

        private void txtSalaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) == true || char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
        }

        ///---------Methods--------
        public void ResteToZero(Employee[] _tabEmployes)
        {
            txtNumero.Text = _tabEmployes[0].numero;
            txtNom.Text = _tabEmployes[0].nom;
            txtFonction.Text = _tabEmployes[0].fonction;
            txtSalaire.Text = _tabEmployes[0].salaire.ToString();
        }

        ///Remplir le labelControl
        public void RemplirLblControl(Employee[] _tabEmployes, int _numberOfEmployes, int _indiceActuel)
        {
            for (int i = 0; i < _numberOfEmployes; i++)
            {
                if (txtNumero.Text == _tabEmployes[i].numero)
                {
                    lblControl.Text = "Employe " + (i + 1) + " sur un total de " + _numberOfEmployes;
                    _indiceActuel = i;
                }
            }

        } 
    }
}
