using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class Yazı : Form
    {
        Context context = new Context();
        string[] pot;
        string yazı;
        public Yazı()
        {
            InitializeComponent();
        }
        int Döngü = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += pot[Döngü];
                if (Döngü < pot.Length)
                {
                    Döngü++;
                    richTextBox1.Text += "\n";
                }
                else
                    Döngü--;
            }
            catch (Exception)
            {
                MessageBox.Show("Şekiller Biti Başa Dönülüyor.");
                Döngü = 0;
            }

        }

        private void Yazı_Load(object sender, EventArgs e)
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

                var deneme = BaglantıVerisi.FirstOrDefault(x => x.SekilVerisi == veri);
                pot[i] = deneme.YaziVerisi;

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

                var deneme = BaglantıVerisi.FirstOrDefault(x => x.SekilVerisi == veri);
                pot[i] = deneme.YaziVerisi;

            }
            spArduino.DiscardInBuffer();
            spArduino.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Döngü = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
