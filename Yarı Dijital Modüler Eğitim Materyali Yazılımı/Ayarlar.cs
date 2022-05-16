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
using Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class Ayarlar : Form
    {
        Context context = new Context();
        
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            //var degerler = context.VeriSets.ToList();
            //foreach (var x in degerler)
            //{
            //    lbxSets.Items.Add(x.SetAdı);
            //}

            listView1.Columns.Add("Şekil", 550);
            listView1.Columns.Add("Veri", 1920);
            listView1.Items.Add("A", 0);
            listView1.Items.Add("B", 1);
            listView1.Items.Add("C", 2);
            listView1.Items.Add("Türkçe Dersi", 3);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbxSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbxSets_MouseClick(object sender, MouseEventArgs e)
        {
            string seçim = lbxSets.Text;
            var YeniDeger = context.VeriSets.Where(x=>x.SetAdı==seçim).Select(z=>z.Id);

        }
    }
}
