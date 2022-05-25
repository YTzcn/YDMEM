using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{

    public partial class t : Form
    {
        Context context = new Context();
        public t()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (spArduino.IsOpen)
                spArduino.Close();
            Link link = new Link();
            link.Show();
        }

        private void btnLink_MouseEnter(object sender, EventArgs e)
        {
            btnLink.BackgroundImage = Properties.Resources.global;
        }

        private void btnLink_MouseLeave(object sender, EventArgs e)
        {
            btnLink.BackgroundImage = Properties.Resources.internet;
        }

        private void btnYT_MouseEnter(object sender, EventArgs e)
        {
            btnYT.BackgroundImage = Properties.Resources.youtube;
        }

        private void btnYT_MouseLeave(object sender, EventArgs e)
        {

            btnYT.BackgroundImage = Properties.Resources.Video;
        }

        private void btnSes_MouseEnter(object sender, EventArgs e)
        {
            btnSes.BackgroundImage = Properties.Resources.musical_note;
        }

        private void btnSes_MouseLeave(object sender, EventArgs e)
        {

            btnSes.BackgroundImage = Properties.Resources.Ses;
        }

        private void btnFoto_MouseEnter(object sender, EventArgs e)
        {
            btnFoto.BackgroundImage = Properties.Resources.insert_picture_icon;
        }

        private void btnFoto_MouseLeave(object sender, EventArgs e)
        {
            btnFoto.BackgroundImage = Properties.Resources.Fotoğraf;
        }

        private void btnYazi_MouseEnter(object sender, EventArgs e)
        {
            btnYazi.BackgroundImage = Properties.Resources.paper;
        }

        private void btnYazi_MouseLeave(object sender, EventArgs e)
        {

            btnYazi.BackgroundImage = Properties.Resources.Yazı;
        }
        string[] pot;
        string yazı;
        private void TKontrol_Tick(object sender, EventArgs e)
        {

            try
            {

                spArduino.Open();
                Thread.Sleep(400);
                yazı = spArduino.ReadLine();
                pot = yazı.Split('-');
                for (int i = 0; i < pot.Length; i++)
                {
                    pot[i] = pot[i].Replace("{", "");
                    pot[i] = pot[i].Replace("}", "");
                    pot[i] = pot[i].Replace("\r", "");


                }
                spArduino.DiscardInBuffer();
                spArduino.Close();
             
            }
            catch (Exception)
            {

                
            }




        }

        private void pbDurum_Click(object sender, EventArgs e)
        {
            

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            Fotoğraf fotoğraf = new Fotoğraf();
            fotoğraf.Show();
        }

        private void btnYazi_Click(object sender, EventArgs e)
        {
            Yazı yazı = new Yazı();
            yazı.Show();
        }
    }

}
