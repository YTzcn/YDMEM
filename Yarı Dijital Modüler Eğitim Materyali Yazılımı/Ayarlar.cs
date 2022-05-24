using System;
using System.Linq;
using System.Runtime.InteropServices;
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
           
          
            var setler = context.VeriSets.ToList();

            foreach (var item in setler)
            {
                listBox1.Items.Add(item.Id+" -"+item.SetAdı);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

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
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            

        
                if (tbxSetAdı.Text != string.Empty&&tbxSetAdı.Text != "" && tbxSetAdı.Text != " " && tbxSetAdı.Text != "Set Adını Girin")
                {
                    VeriSet veriSet = new VeriSet();
                    veriSet.SetAdı = tbxSetAdı.Text;
                    context.VeriSets.Add(veriSet);
                    tbxSetAdı.Clear();
                    tbxSetAdı.Visible = true;
                    listBox1.Items.Clear();
                    context.SaveChanges();
                    Ayarlar_Load(sender,e);                    
                }
          





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
        private void button1_Click_2(object sender, EventArgs e)
        {
            string ıd = listBox1.Text;

            //foreach (var item in context.Veris.Select(x=>x.))
            //{

            //}

         //dataGridView1.Rows.Add(x.Id, x.BaglantıVerisi, x.FotografVerisi, x.SesVerisi, x.YaziVerisi, x.VideoVerisi, Image.FromFile(@"~\Resources\Kaynaklar\" + x.Id + ".png"));

            
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}
