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
            listView1.Columns.Add("Setler");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            var setler = context.VeriSets.ToList();

            foreach (var item in setler)
            {
                listView1.Items.Add(item.SetAdı);
            }

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
           
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
