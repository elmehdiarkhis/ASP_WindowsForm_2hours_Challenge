namespace StreamTraining
{
    partial class frmExamFinDeSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAfficherFonction = new System.Windows.Forms.Label();
            this.lblAfficherSalaire = new System.Windows.Forms.Label();
            this.lblAfficherNom = new System.Windows.Forms.Label();
            this.lblAfficherNumero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSauvgarder = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lstEmployee);
            this.groupBox2.Location = new System.Drawing.Point(45, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 372);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche Employe Par Son Numero";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAfficherFonction);
            this.groupBox3.Controls.Add(this.lblAfficherSalaire);
            this.groupBox3.Controls.Add(this.lblAfficherNom);
            this.groupBox3.Controls.Add(this.lblAfficherNumero);
            this.groupBox3.Location = new System.Drawing.Point(404, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 288);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations de Employe Selectionne";
            // 
            // lblAfficherFonction
            // 
            this.lblAfficherFonction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAfficherFonction.Location = new System.Drawing.Point(28, 165);
            this.lblAfficherFonction.Name = "lblAfficherFonction";
            this.lblAfficherFonction.Size = new System.Drawing.Size(460, 47);
            this.lblAfficherFonction.TabIndex = 21;
            this.lblAfficherFonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAfficherSalaire
            // 
            this.lblAfficherSalaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAfficherSalaire.Location = new System.Drawing.Point(28, 224);
            this.lblAfficherSalaire.Name = "lblAfficherSalaire";
            this.lblAfficherSalaire.Size = new System.Drawing.Size(460, 47);
            this.lblAfficherSalaire.TabIndex = 20;
            this.lblAfficherSalaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAfficherNom
            // 
            this.lblAfficherNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAfficherNom.Location = new System.Drawing.Point(28, 107);
            this.lblAfficherNom.Name = "lblAfficherNom";
            this.lblAfficherNom.Size = new System.Drawing.Size(460, 47);
            this.lblAfficherNom.TabIndex = 19;
            this.lblAfficherNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAfficherNumero
            // 
            this.lblAfficherNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAfficherNumero.Location = new System.Drawing.Point(28, 49);
            this.lblAfficherNumero.Name = "lblAfficherNumero";
            this.lblAfficherNumero.Size = new System.Drawing.Size(460, 47);
            this.lblAfficherNumero.TabIndex = 18;
            this.lblAfficherNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Choisir un numero";
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 32;
            this.lstEmployee.Location = new System.Drawing.Point(45, 88);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(236, 260);
            this.lstEmployee.TabIndex = 0;
            this.lstEmployee.SelectedIndexChanged += new System.EventHandler(this.lstEmployee_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblControl);
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnSauvgarder);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtSalaire);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFonction);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(45, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 429);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Des Employes De Microsoft";
            // 
            // lblControl
            // 
            this.lblControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControl.Location = new System.Drawing.Point(151, 353);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(592, 47);
            this.lblControl.TabIndex = 17;
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControl.Click += new System.EventHandler(this.lblControl_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(573, 275);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(170, 46);
            this.btnDernier.TabIndex = 16;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(388, 278);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(170, 46);
            this.btnSuivant.TabIndex = 15;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(202, 278);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(170, 46);
            this.btnPrecedent.TabIndex = 14;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(6, 278);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(170, 46);
            this.btnPremier.TabIndex = 13;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(770, 275);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(170, 46);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSauvgarder
            // 
            this.btnSauvgarder.Location = new System.Drawing.Point(770, 223);
            this.btnSauvgarder.Name = "btnSauvgarder";
            this.btnSauvgarder.Size = new System.Drawing.Size(170, 46);
            this.btnSauvgarder.TabIndex = 11;
            this.btnSauvgarder.Text = "Sauvgarder";
            this.btnSauvgarder.UseVisualStyleBackColor = true;
            this.btnSauvgarder.Click += new System.EventHandler(this.btnSauvgarder_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(770, 142);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(170, 46);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(770, 90);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(170, 46);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(770, 38);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(170, 46);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(151, 193);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(592, 39);
            this.txtSalaire.TabIndex = 7;
            this.txtSalaire.TextChanged += new System.EventHandler(this.txtSalaire_TextChanged);
            this.txtSalaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalaire_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salaire  : ";
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(151, 148);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(592, 39);
            this.txtFonction.TabIndex = 5;
            this.txtFonction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFonction_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fonction :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(151, 103);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(592, 39);
            this.txtNom.TabIndex = 3;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom : ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(151, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(592, 39);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "EVALUATION SOMMATIVE DE FIN DE SESSION";
            // 
            // frmExamFinDeSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 1014);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmExamFinDeSession";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExamFinDeSession_FormClosing);
            this.Load += new System.EventHandler(this.examFinDeSession_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lblControl;
        private Button btnDernier;
        private Button btnSuivant;
        private Button btnPrecedent;
        private Button btnPremier;
        private Button btnAnnuler;
        private Button btnSauvgarder;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button btnAjouter;
        private TextBox txtSalaire;
        private Label label5;
        private TextBox txtFonction;
        private Label label4;
        private TextBox txtNom;
        private Label label3;
        private TextBox txtNumero;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Label lblAfficherFonction;
        private Label lblAfficherSalaire;
        private Label lblAfficherNom;
        private Label lblAfficherNumero;
        private Label label6;
        private ListBox lstEmployee;
    }
}