using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class t : Form
    {
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
    }

}
