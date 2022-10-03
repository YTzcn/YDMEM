using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class Link : Form
    {
        Context context = new Context();
        public Link()
        {
            InitializeComponent();
        }
        string[] pot;
        string yazı;
        private void Link_Load(object sender, EventArgs e)
        {

            spArduino.Open();
            Thread.Sleep(400);
            yazı = spArduino.ReadLine();
            pot = yazı.Split('-');
            var AktifSet = context.VeriSets.FirstOrDefault(x => x.Aktiflik == true);
            for (int i = 0; i < pot.Length; i++)
            {
                pot[i] = pot[i].Replace("{", "");
                pot[i] = pot[i].Replace("}", "");
                pot[i] = pot[i].Replace("\r", "");
                string veri = pot[i].ToString();
                var BaglantıVerisi = context.Veris.Where(x => x.VeriSetId == AktifSet.Id);
                pot[1] = pot[1].Remove(5, 2);
                var deneme = BaglantıVerisi.FirstOrDefault(x => x.SekilVerisi == veri);
                pot[i] = deneme.BaglantıVerisi;
            }

            spArduino.DiscardInBuffer();
            spArduino.Close();
        }
        private void TKontrol_Tick(object sender, EventArgs e)
        {
            spArduino.Open();
            Thread.Sleep(400);
            yazı = spArduino.ReadLine();
            pot = yazı.Split('-');
            var AktifSet = context.VeriSets.FirstOrDefault(x => x.Aktiflik == true);
            for (int i = 0; i < pot.Length; i++)
            {
                pot[i] = pot[i].Replace("{", "");
                pot[i] = pot[i].Replace("}", "");
                pot[i] = pot[i].Replace("\r", "");
                string veri = pot[i].ToString();
                var BaglantıVerisi = context.Veris.Where(x => x.VeriSetId == AktifSet.Id);
                pot[1] = pot[1].Remove(5, 2);
                var deneme = BaglantıVerisi.FirstOrDefault(x => x.SekilVerisi == veri);
                pot[i] = deneme.BaglantıVerisi;
                
            }

            spArduino.DiscardInBuffer();
            spArduino.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int Döngü = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (pot[Döngü] == "" || pot[Döngü] == " ")
                  Döngü++;
                
                System.Diagnostics.Process.Start(pot[Döngü]);
                if (Döngü < pot.Length)
                {
                    Döngü++;
                    button10.Text = "Sıradaki Bağlantıyı Aç";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Şekiller Bitti Başa Dönülüyor");
                Döngü = 0;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
