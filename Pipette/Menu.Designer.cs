namespace Pipette
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxPipette = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBureau = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownG = new System.Windows.Forms.NumericUpDown();
            this.linkLabelAide = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipette)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBureau)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "R :";
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownR.Location = new System.Drawing.Point(40, 35);
            this.numericUpDownR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownR.TabIndex = 0;
            this.numericUpDownR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changerCouleurRGB);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "B :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "G :";
            // 
            // textBoxHex
            // 
            this.textBoxHex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHex.Location = new System.Drawing.Point(26, 170);
            this.textBoxHex.MaxLength = 6;
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(65, 29);
            this.textBoxHex.TabIndex = 3;
            this.textBoxHex.Text = "000000";
            this.textBoxHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changerCouleurHex);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "HEX :";
            // 
            // pictureBoxPipette
            // 
            this.pictureBoxPipette.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPipette.Image")));
            this.pictureBoxPipette.Location = new System.Drawing.Point(28, 33);
            this.pictureBoxPipette.Name = "pictureBoxPipette";
            this.pictureBoxPipette.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxPipette.TabIndex = 9;
            this.pictureBoxPipette.TabStop = false;
            this.pictureBoxPipette.Click += new System.EventHandler(this.pictureBoxPipette_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxPipette);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pipette";
            // 
            // panelCouleur
            // 
            this.panelCouleur.BackColor = System.Drawing.Color.Black;
            this.panelCouleur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCouleur.Location = new System.Drawing.Point(15, 215);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(75, 26);
            this.panelCouleur.TabIndex = 11;
            this.panelCouleur.Click += new System.EventHandler(this.panelCouleur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxBureau);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(165, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 380);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoom";
            // 
            // pictureBoxBureau
            // 
            this.pictureBoxBureau.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBureau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBureau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBureau.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBureau.Image")));
            this.pictureBoxBureau.Location = new System.Drawing.Point(20, 35);
            this.pictureBoxBureau.Name = "pictureBoxBureau";
            this.pictureBoxBureau.Size = new System.Drawing.Size(270, 320);
            this.pictureBoxBureau.TabIndex = 12;
            this.pictureBoxBureau.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxHex);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDownB);
            this.groupBox3.Controls.Add(this.panelCouleur);
            this.groupBox3.Controls.Add(this.numericUpDownG);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDownR);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.Location = new System.Drawing.Point(30, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 255);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Couleur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "#";
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownB.Location = new System.Drawing.Point(40, 105);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownB.TabIndex = 2;
            this.numericUpDownB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changerCouleurRGB);
            // 
            // numericUpDownG
            // 
            this.numericUpDownG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownG.Location = new System.Drawing.Point(40, 70);
            this.numericUpDownG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownG.Name = "numericUpDownG";
            this.numericUpDownG.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownG.TabIndex = 1;
            this.numericUpDownG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changerCouleurRGB);
            // 
            // linkLabelAide
            // 
            this.linkLabelAide.AutoSize = true;
            this.linkLabelAide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAide.Location = new System.Drawing.Point(12, 656);
            this.linkLabelAide.Name = "linkLabelAide";
            this.linkLabelAide.Size = new System.Drawing.Size(41, 21);
            this.linkLabelAide.TabIndex = 4;
            this.linkLabelAide.TabStop = true;
            this.linkLabelAide.Text = "Aide";
            this.linkLabelAide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAide_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "2.7";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.trackBar2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(30, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 200);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paramètres";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(268, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "60 sur 100";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(106, 112);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(320, 45);
            this.trackBar2.TabIndex = 25;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Value = 40;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "Zoom :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "30 sur 255";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(106, 30);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(320, 45);
            this.trackBar1.TabIndex = 22;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tolérance :";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 686);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabelAide);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Pipette";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipette)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBureau)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownG)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxPipette;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownG;
        private System.Windows.Forms.PictureBox pictureBoxBureau;
        private System.Windows.Forms.LinkLabel linkLabelAide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
    }
}

