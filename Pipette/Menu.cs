using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipette
{
    public partial class Menu : Form
    {
        // -------------------------------------
        Bitmap leDernierScreen;
        int zoom = 50;
        // -------------------------------------



        // ====================================================================
        public Menu()
        {
            // -------------------------------------
            InitializeComponent();
            this.leDernierScreen = new Bitmap(this.pictureBoxBureau.Width, this.pictureBoxBureau.Height);
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void linkLabelAide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // -------------------------------------
            try
            {
                Process.Start("https://github.com/TheRake66/Pipette");
            }
            catch { }
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void copyToClipBoard()
        {
            // -------------------------------------
            try
            {
                Clipboard.SetData(DataFormats.Text, (Object)("#" + this.textBoxHex.Text));
            }
            catch
            {
                MessageBox.Show("Impossible de copier le code hexadécimal dans le presse-papiers !", "Pipette", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void changerCouleurRGB(object sender, KeyEventArgs e)
        {
            // -------------------------------------
            if (e.KeyCode == Keys.Enter)
            {
                Color lePixel = Color.FromArgb((int)this.numericUpDownR.Value, (int)this.numericUpDownG.Value, (int)this.numericUpDownB.Value);
                changerTexbox(lePixel);
                changerCouleurImage(lePixel);
                copyToClipBoard();
                this.panelCouleur.BackColor = lePixel;
            }
            // -------------------------------------
        }

        private void changerCouleurHex(object sender, KeyEventArgs e)
        {
            // -------------------------------------
            if (e.KeyCode == Keys.Enter)
            {
                while (this.textBoxHex.Text.Length < 6) { this.textBoxHex.Text += "0"; }
                char[] lesHex = this.textBoxHex.Text.ToCharArray();
                Color lePixel = Color.FromArgb(
                    Convert.ToInt32(lesHex[0].ToString() + lesHex[1], 16),
                    Convert.ToInt32(lesHex[2].ToString() + lesHex[3], 16),
                    Convert.ToInt32(lesHex[4].ToString() + lesHex[5], 16));
                changerUpdown(lePixel);
                changerCouleurImage(lePixel);
                copyToClipBoard();
                this.panelCouleur.BackColor = lePixel;
            }
            else if (e.KeyCode != Keys.Delete &&
                e.KeyCode != Keys.Return &&
                e.KeyCode != Keys.Left &&
                e.KeyCode != Keys.Right &&
                !new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }.Any(e.KeyCode.ToString().Contains))
            {
                e.SuppressKeyPress = true;
            }
            // -------------------------------------
        }

        private void panelCouleur_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            ColorDialog diag = new ColorDialog();
            diag.AllowFullOpen = true;
            diag.Color = this.panelCouleur.BackColor;
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Color lePixel = diag.Color;
                changerUpdown(lePixel);
                changerTexbox(lePixel);
                changerCouleurImage(lePixel);
                copyToClipBoard();
                this.panelCouleur.BackColor = lePixel;
            }
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void changerUpdown(Color lePixel)
        {
            // -------------------------------------
            this.numericUpDownR.Value = lePixel.R;
            this.numericUpDownG.Value = lePixel.G;
            this.numericUpDownB.Value = lePixel.B;
            // -------------------------------------
        }
        private void changerTexbox(Color lePixel)
        {
            // -------------------------------------
            this.textBoxHex.Text =
                (lePixel.R.ToString("x").Length < 2 ? "0" : "") + lePixel.R.ToString("x").ToUpper() +
                (lePixel.G.ToString("x").Length < 2 ? "0" : "") + lePixel.G.ToString("x").ToUpper() +
                (lePixel.B.ToString("x").Length < 2 ? "0" : "") + lePixel.B.ToString("x").ToUpper();
            // -------------------------------------
        }
        private void changerCouleurImage(Color uneNewColor)
        {
            // -------------------------------------
            Bitmap newImage = (Bitmap)this.leDernierScreen.Clone();

            for (int i = 0; i < this.leDernierScreen.Width; i++)
            {
                for (int j = 0; j < this.leDernierScreen.Height; j++)
                {
                    if (newImage.GetPixel(i, j) == this.leDernierScreen.GetPixel(this.zoom / 2, this.zoom / 2))
                    {
                        newImage.SetPixel(i, j, uneNewColor);
                    }
                }
            }
            this.pictureBoxBureau.BackgroundImage = newImage;
            // -------------------------------------
        }
        // ====================================================================



        // ====================================================================
        private void pictureBoxPipette_Click(object sender, EventArgs e)
        {
            // -------------------------------------
            this.pictureBoxPipette.Visible = false;

            // Récupère tous les écrans
            int screenx = SystemInformation.VirtualScreen.Left;
            int screeny = SystemInformation.VirtualScreen.Top;
            int screenw = SystemInformation.VirtualScreen.Width;
            int screenh = SystemInformation.VirtualScreen.Height;

            // Precharge le bureau avant d'afficher l'écran noir
            Bitmap desktop = new Bitmap(screenw, screenh, PixelFormat.Format32bppArgb);
            Graphics.FromImage(desktop).CopyFromScreen(screenx, screeny, 0, 0, new Size(screenw, screenh));

            // Créer une form foncée
            Form bureau = new Form();
            bureau.FormBorderStyle = FormBorderStyle.None;
            bureau.ShowInTaskbar = false;
            byte[] buffer = Properties.Resources.pipette;
            using (MemoryStream m = new MemoryStream(buffer)) bureau.Cursor = new Cursor(m);
            bureau.BackColor = Color.Black;
            bureau.TransparencyKey = Color.Blue;
            bureau.Opacity = 0.01;
            bureau.TopMost = true;
            bureau.Show(); // Afficher avant de déplacer

            bureau.Location = new Point(screenx, screeny);
            bureau.Size = new Size(screenw, screenh);


            bureau.MouseMove += new MouseEventHandler((s, m) =>
            {
                // Decoupe le bureau
                Bitmap save = new Bitmap(this.zoom, this.zoom, PixelFormat.Format32bppArgb);
                Graphics.FromImage(save).DrawImage(desktop, -(m.X - this.zoom / 2), -(m.Y - this.zoom / 2));
                Color lePixel = save.GetPixel(this.zoom / 2, this.zoom / 2);

                this.pictureBoxBureau.BackgroundImage = save;
                this.leDernierScreen = (Bitmap)save.Clone();

                changerUpdown(lePixel);
                changerTexbox(lePixel);
                this.panelCouleur.BackColor = lePixel;
            });

            bureau.Click += new EventHandler((s, m) =>
            {
                bureau.Close();

                copyToClipBoard();
                this.pictureBoxPipette.Visible = true;
            });
            // -------------------------------------
        }
        // ====================================================================
    }
}
