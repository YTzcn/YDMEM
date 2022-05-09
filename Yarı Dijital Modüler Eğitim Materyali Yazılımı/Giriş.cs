using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        int mousey, mousex;

        private void timer1_Tick(object sender, EventArgs e)
        {
        //    this.Left = MousePosition.X - mousex;
        //    this.Top = MousePosition.Y - mousey;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kadi, sifre;
            kadi = textBox1.Text;
            sifre = textBox2.Text;
            if (kadi == "suleymankoc@gmail.com" && sifre == "123")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Sifre Hatalı");
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //mousex = MousePosition.X - panel1.Left;
            //mousey = MousePosition.Y - panel1.Top;
            //timer1.Enabled = true;
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
