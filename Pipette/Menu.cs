using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        Color leDernierPixel;
        // -------------------------------------



        // ====================================================================
        public Menu()
        {
            // -------------------------------------
            InitializeComponent();
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
                this.textBoxHex.Text =
                    (lePixel.R.ToString("x").Length < 2 ? "0" : "") + lePixel.R.ToString("x").ToUpper() +
                    (lePixel.G.ToString("x").Length < 2 ? "0" : "") + lePixel.G.ToString("x").ToUpper() +
                    (lePixel.B.ToString("x").Length < 2 ? "0" : "") + lePixel.B.ToString("x").ToUpper();
                this.panelCouleur.BackColor = lePixel;
                changerCouleurImage(lePixel);
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
                this.numericUpDownR.Value = lePixel.R;
                this.numericUpDownG.Value = lePixel.G;
                this.numericUpDownB.Value = lePixel.B;
                this.panelCouleur.BackColor = lePixel;
                changerCouleurImage(lePixel);
            }
            // -------------------------------------
        }

        private void changerCouleurImage(Color uneNewColor)
        {
            // -------------------------------------
            Bitmap newImage = (Bitmap)this.pictureBoxBureau.BackgroundImage.Clone();

            for (int i = 0; i < this.pictureBoxBureau.BackgroundImage.Width; i++)
            {
                for (int j = 0; j < this.pictureBoxBureau.BackgroundImage.Height; j++)
                {
                    if (newImage.GetPixel(i, j) == this.leDernierPixel)
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
            bureau.Opacity = .50;
            bureau.TopMost = true;
            bureau.Show(); // Afficher avant de déplacer
            bureau.Location = new Point(screenx, screeny);
            bureau.Size = new Size(screenw, screenh);


            bureau.MouseMove += new MouseEventHandler((s, m) =>
            {
                // Decoupe le bureau
                Bitmap save = new Bitmap(50, 50, PixelFormat.Format32bppArgb);
                Graphics.FromImage(save).DrawImage(desktop, -(m.X - 25), -(m.Y - 25));

                this.leDernierPixel = save.GetPixel(25, 25);

                this.pictureBoxBureau.BackgroundImage = save;
                this.numericUpDownR.Value = this.leDernierPixel.R;
                this.numericUpDownG.Value = this.leDernierPixel.G;
                this.numericUpDownB.Value = this.leDernierPixel.B;
                this.textBoxHex.Text =
                    (this.leDernierPixel.R.ToString("x").Length < 2 ? "0" : "") + this.leDernierPixel.R.ToString("x").ToUpper() +
                    (this.leDernierPixel.G.ToString("x").Length < 2 ? "0" : "") + this.leDernierPixel.G.ToString("x").ToUpper() +
                    (this.leDernierPixel.B.ToString("x").Length < 2 ? "0" : "") + this.leDernierPixel.B.ToString("x").ToUpper();
                this.panelCouleur.BackColor = this.leDernierPixel;

            });

            bureau.Click += new EventHandler((s, m) => { bureau.Close(); });
            // -------------------------------------
        }
        // ====================================================================
    }
}
