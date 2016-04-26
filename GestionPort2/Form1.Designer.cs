namespace GestionPort2
{
    partial class Frm_Gestion_Navire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labnLLOYD = new System.Windows.Forms.Label();
            this.labNomNav = new System.Windows.Forms.Label();
            this.labPavillon = new System.Windows.Forms.Label();
            this.labLong = new System.Windows.Forms.Label();
            this.labLarg = new System.Windows.Forms.Label();
            this.labTirant = new System.Windows.Forms.Label();
            this.txtBoxNomPort = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.grpBoxPort = new System.Windows.Forms.GroupBox();
            this.grpBoxPavPassagers = new System.Windows.Forms.GroupBox();
            this.labNomPort = new System.Windows.Forms.Label();
            this.btnCreerPort = new System.Windows.Forms.Button();
            this.txtBoxFretPresent = new System.Windows.Forms.TextBox();
            this.labFretPres = new System.Windows.Forms.Label();
            this.txtBoxPassagPres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFretCree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStaticPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxQtFret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMaxPassag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNbCabines = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreerNavPass = new System.Windows.Forms.Button();
            this.btnAffectNavPass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numNavPassInd = new System.Windows.Forms.NumericUpDown();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.grpBoxNavFret = new System.Windows.Forms.GroupBox();
            this.btnRetirerPortFret = new System.Windows.Forms.Button();
            this.numIndNavFret = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAffectPortFret = new System.Windows.Forms.Button();
            this.btnCreerNavFret = new System.Windows.Forms.Button();
            this.txtNbFret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtFret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxMaxPassag2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAfficherNav = new System.Windows.Forms.Button();
            this.listNavires = new System.Windows.Forms.ListBox();
            this.btnAfficherCeNav = new System.Windows.Forms.Button();
            this.numIndAffich = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.listNavire = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpBoxPort.SuspendLayout();
            this.grpBoxPavPassagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNavPassInd)).BeginInit();
            this.grpBoxNavFret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndNavFret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndAffich)).BeginInit();
            this.SuspendLayout();
            // 
            // labnLLOYD
            // 
            this.labnLLOYD.AutoSize = true;
            this.labnLLOYD.Location = new System.Drawing.Point(71, 25);
            this.labnLLOYD.Name = "labnLLOYD";
            this.labnLLOYD.Size = new System.Drawing.Size(82, 13);
            this.labnLLOYD.TabIndex = 0;
            this.labnLLOYD.Text = "Numéro LLOYD";
            // 
            // labNomNav
            // 
            this.labNomNav.AutoSize = true;
            this.labNomNav.Location = new System.Drawing.Point(90, 49);
            this.labNomNav.Name = "labNomNav";
            this.labNomNav.Size = new System.Drawing.Size(63, 13);
            this.labNomNav.TabIndex = 1;
            this.labNomNav.Text = "Nom Navire";
            // 
            // labPavillon
            // 
            this.labPavillon.AutoSize = true;
            this.labPavillon.Location = new System.Drawing.Point(109, 75);
            this.labPavillon.Name = "labPavillon";
            this.labPavillon.Size = new System.Drawing.Size(44, 13);
            this.labPavillon.TabIndex = 3;
            this.labPavillon.Text = "Pavillon";
            // 
            // labLong
            // 
            this.labLong.AutoSize = true;
            this.labLong.Location = new System.Drawing.Point(101, 101);
            this.labLong.Name = "labLong";
            this.labLong.Size = new System.Drawing.Size(52, 13);
            this.labLong.TabIndex = 2;
            this.labLong.Text = "Longueur";
            // 
            // labLarg
            // 
            this.labLarg.AutoSize = true;
            this.labLarg.Location = new System.Drawing.Point(110, 127);
            this.labLarg.Name = "labLarg";
            this.labLarg.Size = new System.Drawing.Size(43, 13);
            this.labLarg.TabIndex = 5;
            this.labLarg.Text = "Largeur";
            // 
            // labTirant
            // 
            this.labTirant.AutoSize = true;
            this.labTirant.Location = new System.Drawing.Point(90, 153);
            this.labTirant.Name = "labTirant";
            this.labTirant.Size = new System.Drawing.Size(63, 13);
            this.labTirant.TabIndex = 4;
            this.labTirant.Text = "Tirant d\'eau";
            // 
            // txtBoxNomPort
            // 
            this.txtBoxNomPort.Location = new System.Drawing.Point(78, 19);
            this.txtBoxNomPort.Name = "txtBoxNomPort";
            this.txtBoxNomPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNomPort.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(159, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(159, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(159, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            // 
            // grpBoxPort
            // 
            this.grpBoxPort.Controls.Add(this.txtBoxStaticPass);
            this.grpBoxPort.Controls.Add(this.label4);
            this.grpBoxPort.Controls.Add(this.txtboxFretCree);
            this.grpBoxPort.Controls.Add(this.label3);
            this.grpBoxPort.Controls.Add(this.txtBoxPassagPres);
            this.grpBoxPort.Controls.Add(this.label2);
            this.grpBoxPort.Controls.Add(this.txtBoxFretPresent);
            this.grpBoxPort.Controls.Add(this.labFretPres);
            this.grpBoxPort.Controls.Add(this.btnCreerPort);
            this.grpBoxPort.Controls.Add(this.labNomPort);
            this.grpBoxPort.Controls.Add(this.txtBoxNomPort);
            this.grpBoxPort.Location = new System.Drawing.Point(327, 46);
            this.grpBoxPort.Name = "grpBoxPort";
            this.grpBoxPort.Size = new System.Drawing.Size(562, 158);
            this.grpBoxPort.TabIndex = 13;
            this.grpBoxPort.TabStop = false;
            this.grpBoxPort.Text = "Port";
            // 
            // grpBoxPavPassagers
            // 
            this.grpBoxPavPassagers.Controls.Add(this.btnRetirer);
            this.grpBoxPavPassagers.Controls.Add(this.numNavPassInd);
            this.grpBoxPavPassagers.Controls.Add(this.label7);
            this.grpBoxPavPassagers.Controls.Add(this.btnAffectNavPass);
            this.grpBoxPavPassagers.Controls.Add(this.btnCreerNavPass);
            this.grpBoxPavPassagers.Controls.Add(this.txtBoxNbCabines);
            this.grpBoxPavPassagers.Controls.Add(this.label6);
            this.grpBoxPavPassagers.Controls.Add(this.txtBoxQtFret);
            this.grpBoxPavPassagers.Controls.Add(this.label1);
            this.grpBoxPavPassagers.Controls.Add(this.txtBoxMaxPassag);
            this.grpBoxPavPassagers.Controls.Add(this.label5);
            this.grpBoxPavPassagers.Location = new System.Drawing.Point(366, 219);
            this.grpBoxPavPassagers.Name = "grpBoxPavPassagers";
            this.grpBoxPavPassagers.Size = new System.Drawing.Size(305, 229);
            this.grpBoxPavPassagers.TabIndex = 14;
            this.grpBoxPavPassagers.TabStop = false;
            this.grpBoxPavPassagers.Text = "Navire Passagers";
            // 
            // labNomPort
            // 
            this.labNomPort.AutoSize = true;
            this.labNomPort.Location = new System.Drawing.Point(6, 21);
            this.labNomPort.Name = "labNomPort";
            this.labNomPort.Size = new System.Drawing.Size(66, 13);
            this.labNomPort.TabIndex = 15;
            this.labNomPort.Text = "Nom du Port";
            // 
            // btnCreerPort
            // 
            this.btnCreerPort.Location = new System.Drawing.Point(36, 45);
            this.btnCreerPort.Name = "btnCreerPort";
            this.btnCreerPort.Size = new System.Drawing.Size(129, 43);
            this.btnCreerPort.TabIndex = 16;
            this.btnCreerPort.Text = "Créer Le Port";
            this.btnCreerPort.UseVisualStyleBackColor = true;
            // 
            // txtBoxFretPresent
            // 
            this.txtBoxFretPresent.Location = new System.Drawing.Point(128, 95);
            this.txtBoxFretPresent.Name = "txtBoxFretPresent";
            this.txtBoxFretPresent.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFretPresent.TabIndex = 16;
            // 
            // labFretPres
            // 
            this.labFretPres.AutoSize = true;
            this.labFretPres.Location = new System.Drawing.Point(32, 98);
            this.labFretPres.Name = "labFretPres";
            this.labFretPres.Size = new System.Drawing.Size(90, 13);
            this.labFretPres.TabIndex = 15;
            this.labFretPres.Text = "Nb Frets présents";
            // 
            // txtBoxPassagPres
            // 
            this.txtBoxPassagPres.Location = new System.Drawing.Point(128, 122);
            this.txtBoxPassagPres.Name = "txtBoxPassagPres";
            this.txtBoxPassagPres.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPassagPres.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nb Passagers présents";
            // 
            // txtboxFretCree
            // 
            this.txtboxFretCree.Location = new System.Drawing.Point(350, 95);
            this.txtboxFretCree.Name = "txtboxFretCree";
            this.txtboxFretCree.Size = new System.Drawing.Size(100, 20);
            this.txtboxFretCree.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nb Frêts créés";
            // 
            // txtBoxStaticPass
            // 
            this.txtBoxStaticPass.Location = new System.Drawing.Point(350, 122);
            this.txtBoxStaticPass.Name = "txtBoxStaticPass";
            this.txtBoxStaticPass.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStaticPass.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Static Passager";
            // 
            // txtBoxQtFret
            // 
            this.txtBoxQtFret.Location = new System.Drawing.Point(147, 55);
            this.txtBoxQtFret.Name = "txtBoxQtFret";
            this.txtBoxQtFret.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQtFret.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Chambrres";
            // 
            // txtBoxMaxPassag
            // 
            this.txtBoxMaxPassag.Location = new System.Drawing.Point(147, 28);
            this.txtBoxMaxPassag.Name = "txtBoxMaxPassag";
            this.txtBoxMaxPassag.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMaxPassag.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nb Maxi Passagers";
            // 
            // txtBoxNbCabines
            // 
            this.txtBoxNbCabines.Location = new System.Drawing.Point(147, 82);
            this.txtBoxNbCabines.Name = "txtBoxNbCabines";
            this.txtBoxNbCabines.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNbCabines.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nombre Cabines";
            // 
            // btnCreerNavPass
            // 
            this.btnCreerNavPass.Location = new System.Drawing.Point(12, 118);
            this.btnCreerNavPass.Name = "btnCreerNavPass";
            this.btnCreerNavPass.Size = new System.Drawing.Size(129, 26);
            this.btnCreerNavPass.TabIndex = 23;
            this.btnCreerNavPass.Text = "Créer navire Passager";
            this.btnCreerNavPass.UseVisualStyleBackColor = true;
            // 
            // btnAffectNavPass
            // 
            this.btnAffectNavPass.Location = new System.Drawing.Point(147, 118);
            this.btnAffectNavPass.Name = "btnAffectNavPass";
            this.btnAffectNavPass.Size = new System.Drawing.Size(129, 26);
            this.btnAffectNavPass.TabIndex = 25;
            this.btnAffectNavPass.Text = "Affecter au Port";
            this.btnAffectNavPass.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Indice à supprimer";
            // 
            // numNavPassInd
            // 
            this.numNavPassInd.Location = new System.Drawing.Point(142, 164);
            this.numNavPassInd.Name = "numNavPassInd";
            this.numNavPassInd.Size = new System.Drawing.Size(27, 20);
            this.numNavPassInd.TabIndex = 28;
            // 
            // btnRetirer
            // 
            this.btnRetirer.Location = new System.Drawing.Point(175, 159);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(112, 26);
            this.btnRetirer.TabIndex = 29;
            this.btnRetirer.Text = "Retirer du Port";
            this.btnRetirer.UseVisualStyleBackColor = true;
            // 
            // grpBoxNavFret
            // 
            this.grpBoxNavFret.Controls.Add(this.btnRetirerPortFret);
            this.grpBoxNavFret.Controls.Add(this.numIndNavFret);
            this.grpBoxNavFret.Controls.Add(this.label8);
            this.grpBoxNavFret.Controls.Add(this.btnAffectPortFret);
            this.grpBoxNavFret.Controls.Add(this.btnCreerNavFret);
            this.grpBoxNavFret.Controls.Add(this.txtNbFret);
            this.grpBoxNavFret.Controls.Add(this.label9);
            this.grpBoxNavFret.Controls.Add(this.txtQtFret);
            this.grpBoxNavFret.Controls.Add(this.label10);
            this.grpBoxNavFret.Controls.Add(this.txtBoxMaxPassag2);
            this.grpBoxNavFret.Controls.Add(this.label11);
            this.grpBoxNavFret.Location = new System.Drawing.Point(39, 219);
            this.grpBoxNavFret.Name = "grpBoxNavFret";
            this.grpBoxNavFret.Size = new System.Drawing.Size(305, 229);
            this.grpBoxNavFret.TabIndex = 30;
            this.grpBoxNavFret.TabStop = false;
            this.grpBoxNavFret.Text = "Navire Frêt";
            // 
            // btnRetirerPortFret
            // 
            this.btnRetirerPortFret.Location = new System.Drawing.Point(175, 159);
            this.btnRetirerPortFret.Name = "btnRetirerPortFret";
            this.btnRetirerPortFret.Size = new System.Drawing.Size(112, 26);
            this.btnRetirerPortFret.TabIndex = 29;
            this.btnRetirerPortFret.Text = "Retirer du Port";
            this.btnRetirerPortFret.UseVisualStyleBackColor = true;
            // 
            // numIndNavFret
            // 
            this.numIndNavFret.Location = new System.Drawing.Point(142, 164);
            this.numIndNavFret.Name = "numIndNavFret";
            this.numIndNavFret.Size = new System.Drawing.Size(27, 20);
            this.numIndNavFret.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Indice à supprimer";
            // 
            // btnAffectPortFret
            // 
            this.btnAffectPortFret.Location = new System.Drawing.Point(147, 118);
            this.btnAffectPortFret.Name = "btnAffectPortFret";
            this.btnAffectPortFret.Size = new System.Drawing.Size(129, 26);
            this.btnAffectPortFret.TabIndex = 25;
            this.btnAffectPortFret.Text = "Affecter au Port";
            this.btnAffectPortFret.UseVisualStyleBackColor = true;
            // 
            // btnCreerNavFret
            // 
            this.btnCreerNavFret.Location = new System.Drawing.Point(12, 118);
            this.btnCreerNavFret.Name = "btnCreerNavFret";
            this.btnCreerNavFret.Size = new System.Drawing.Size(129, 26);
            this.btnCreerNavFret.TabIndex = 23;
            this.btnCreerNavFret.Text = "Créer navire Frêt";
            this.btnCreerNavFret.UseVisualStyleBackColor = true;
            // 
            // txtNbFret
            // 
            this.txtNbFret.Location = new System.Drawing.Point(147, 86);
            this.txtNbFret.Name = "txtNbFret";
            this.txtNbFret.Size = new System.Drawing.Size(100, 20);
            this.txtNbFret.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre de frêt";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtQtFret
            // 
            this.txtQtFret.Location = new System.Drawing.Point(147, 55);
            this.txtQtFret.Name = "txtQtFret";
            this.txtQtFret.Size = new System.Drawing.Size(100, 20);
            this.txtQtFret.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Quantité Frêt";
            // 
            // txtBoxMaxPassag2
            // 
            this.txtBoxMaxPassag2.Location = new System.Drawing.Point(147, 28);
            this.txtBoxMaxPassag2.Name = "txtBoxMaxPassag2";
            this.txtBoxMaxPassag2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMaxPassag2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nb Maxi Passagers";
            // 
            // btnAfficherNav
            // 
            this.btnAfficherNav.Location = new System.Drawing.Point(74, 475);
            this.btnAfficherNav.Name = "btnAfficherNav";
            this.btnAfficherNav.Size = new System.Drawing.Size(185, 26);
            this.btnAfficherNav.TabIndex = 30;
            this.btnAfficherNav.Text = "Afficher tous les navires du Port";
            this.btnAfficherNav.UseVisualStyleBackColor = true;
            // 
            // listNavires
            // 
            this.listNavires.FormattingEnabled = true;
            this.listNavires.Location = new System.Drawing.Point(269, 478);
            this.listNavires.Name = "listNavires";
            this.listNavires.Size = new System.Drawing.Size(362, 17);
            this.listNavires.TabIndex = 31;
            // 
            // btnAfficherCeNav
            // 
            this.btnAfficherCeNav.Location = new System.Drawing.Point(232, 526);
            this.btnAfficherCeNav.Name = "btnAfficherCeNav";
            this.btnAfficherCeNav.Size = new System.Drawing.Size(112, 26);
            this.btnAfficherCeNav.TabIndex = 32;
            this.btnAfficherCeNav.Text = "Afficher un Navire";
            this.btnAfficherCeNav.UseVisualStyleBackColor = true;
            // 
            // numIndAffich
            // 
            this.numIndAffich.Location = new System.Drawing.Point(183, 531);
            this.numIndAffich.Name = "numIndAffich";
            this.numIndAffich.Size = new System.Drawing.Size(27, 20);
            this.numIndAffich.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Indice à afficher";
            // 
            // listNavire
            // 
            this.listNavire.FormattingEnabled = true;
            this.listNavire.Location = new System.Drawing.Point(350, 533);
            this.listNavire.Name = "listNavire";
            this.listNavire.Size = new System.Drawing.Size(362, 17);
            this.listNavire.TabIndex = 33;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(856, 553);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 26);
            this.btnQuit.TabIndex = 34;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Frm_Gestion_Navire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 600);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.listNavire);
            this.Controls.Add(this.btnAfficherCeNav);
            this.Controls.Add(this.numIndAffich);
            this.Controls.Add(this.listNavires);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAfficherNav);
            this.Controls.Add(this.grpBoxNavFret);
            this.Controls.Add(this.grpBoxPavPassagers);
            this.Controls.Add(this.grpBoxPort);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labLarg);
            this.Controls.Add(this.labTirant);
            this.Controls.Add(this.labPavillon);
            this.Controls.Add(this.labLong);
            this.Controls.Add(this.labNomNav);
            this.Controls.Add(this.labnLLOYD);
            this.Name = "Frm_Gestion_Navire";
            this.Text = "Frm_Gestion_Navire";
            this.grpBoxPort.ResumeLayout(false);
            this.grpBoxPort.PerformLayout();
            this.grpBoxPavPassagers.ResumeLayout(false);
            this.grpBoxPavPassagers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNavPassInd)).EndInit();
            this.grpBoxNavFret.ResumeLayout(false);
            this.grpBoxNavFret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndNavFret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndAffich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labnLLOYD;
        private System.Windows.Forms.Label labNomNav;
        private System.Windows.Forms.Label labPavillon;
        private System.Windows.Forms.Label labLong;
        private System.Windows.Forms.Label labLarg;
        private System.Windows.Forms.Label labTirant;
        private System.Windows.Forms.TextBox txtBoxNomPort;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox grpBoxPort;
        private System.Windows.Forms.GroupBox grpBoxPavPassagers;
        private System.Windows.Forms.Label labNomPort;
        private System.Windows.Forms.TextBox txtBoxStaticPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxFretCree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPassagPres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFretPresent;
        private System.Windows.Forms.Label labFretPres;
        private System.Windows.Forms.Button btnCreerPort;
        private System.Windows.Forms.TextBox txtBoxNbCabines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxQtFret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMaxPassag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.NumericUpDown numNavPassInd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAffectNavPass;
        private System.Windows.Forms.Button btnCreerNavPass;
        private System.Windows.Forms.GroupBox grpBoxNavFret;
        private System.Windows.Forms.Button btnRetirerPortFret;
        private System.Windows.Forms.NumericUpDown numIndNavFret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAffectPortFret;
        private System.Windows.Forms.Button btnCreerNavFret;
        private System.Windows.Forms.TextBox txtNbFret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtFret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxMaxPassag2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAfficherNav;
        private System.Windows.Forms.ListBox listNavires;
        private System.Windows.Forms.Button btnAfficherCeNav;
        private System.Windows.Forms.NumericUpDown numIndAffich;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listNavire;
        private System.Windows.Forms.Button btnQuit;
    }
}

