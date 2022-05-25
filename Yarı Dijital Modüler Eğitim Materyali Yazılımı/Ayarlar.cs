using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar;
using System.Data.SqlClient;

namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class Ayarlar : Form
    {
        Context context = new Context();
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=YDMEMDB;Integrated Security=True");
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int EskiAktif;
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn ımageColumn = new DataGridViewImageColumn();
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.ReadOnly = true;
            column.HeaderText = "Id";
            column.Name = "Id";
            ımageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(column);
            dataGridView1.Columns.Add("BağlantıVerisi", "BaglantıVerisi");
            dataGridView1.Columns.Add("FotoğrafVerisi", "FotoğrafVerisi");
            dataGridView1.Columns.Add("SesVerisi", "SesVerisi");
            dataGridView1.Columns.Add("YazıVerisi", "YazıVerisi");
            dataGridView1.Columns.Add("VideoVerisi", "VideoVerisi");
            dataGridView1.Columns.Add(ımageColumn);
            dataGridView1.RowTemplate.MinimumHeight = 100;

           
            var setler = context.VeriSets.ToList();

            var aktif = context.VeriSets.FirstOrDefault(x => x.Aktiflik == true);
            label1.Text = "Aktif Set = "+aktif.SetAdı;
            EskiAktif = aktif.Id;

            foreach (var item in setler)
            {
                comboBox1.Items.Add(item.Id + " -" + item.SetAdı);
            }

            Listele();

        }

        public void Listele()
        {
            var setler = context.VeriSets.ToList();

            foreach (var item in setler)
            {
                listBox1.Items.Add(item.Id + " -" + item.SetAdı);
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



            if (tbxSetAdı.Text != string.Empty && tbxSetAdı.Text != "" && tbxSetAdı.Text != " " && tbxSetAdı.Text != "Set Adını Girin")
            {
                VeriSet veriSet = new VeriSet();
                veriSet.SetAdı = tbxSetAdı.Text;
                context.VeriSets.Add(veriSet);

                tbxSetAdı.Visible = true;
                listBox1.Items.Clear();
                context.SaveChanges();
                Listele();
                int[] dizi = { 000000, 000001, 000010, 000011, 000100, 000101, 000110, 000111, 001000, 001001, 001010, 001011, 001100, 001101, 001110, 001111, 010000, 010001, 010010, 010011, 010100, 010101, 010110, 010111, 011000, 011001, 011010, 011011, 011100, 011101, 011110, 011111, 100000, 100001, 100010, 100011, 100100, 100101, 100110, 100111, 101000, 101001, 101010, 101011, 101100, 101101, 101110, 101111, 110000, 110001, 110010, 110011, 110100, 110101, 110110, 110111, 111000, 111001, 111010, 111011, 111100, 111101, 111110, 111111 };
                foreach (var item in dizi)
                {
                    Veri veris = new Veri();
                    veris.SekilVerisi = item.ToString();
                    var id = context.VeriSets.FirstOrDefault(X => X.SetAdı == tbxSetAdı.Text);
                    veris.VeriSetId = id.Id;
                    context.Veris.Add(veris);
                    context.SaveChanges();
                }
            }
            tbxSetAdı.Clear();
            var setler = context.VeriSets.ToList();
            foreach (var item in setler)
            {
                comboBox1.Items.Add(item.Id + " -" + item.SetAdı);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string arama;
        string[] SetId;
        private void button1_Click_2(object sender, EventArgs e)
        {



        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string Id, baglantıVeri, FotografVerisi, SesVerisi, YazıVerisi, VideoVerisi;

                Id = dataGridView1.Rows[i].Cells["Id"].Value?.ToString();
                baglantıVeri = dataGridView1.Rows[i].Cells["BağlantıVerisi"].Value?.ToString();
                FotografVerisi = dataGridView1.Rows[i].Cells["FotoğrafVerisi"].Value?.ToString();
                SesVerisi = dataGridView1.Rows[i].Cells["SesVerisi"].Value?.ToString();
                YazıVerisi = dataGridView1.Rows[i].Cells["YazıVerisi"].Value?.ToString();
                VideoVerisi = dataGridView1.Rows[i].Cells["VideoVerisi"].Value?.ToString();

                SqlCommand komut = new SqlCommand("update Veris set BaglantıVerisi='" + baglantıVeri + "',FotografVerisi='" + FotografVerisi + "',SesVerisi='" + SesVerisi + "',YaziVerisi='" + YazıVerisi + "',VideoVerisi='" + VideoVerisi + "' where Id='" + Id + "'", connection);
                komut.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            SetId = listBox1.Text.Split('-');
            arama = SetId[0];
            var sekiller = context.Veris.Where(x => x.VeriSetId.ToString() == arama);

            dataGridView1.Rows.Clear();

            int i = 0;
            foreach (var x in sekiller)
            {
                dataGridView1.Rows.Add(x.Id, x.BaglantıVerisi, x.FotografVerisi, x.SesVerisi, x.YaziVerisi, x.VideoVerisi, Image.FromFile(Application.StartupPath + @"\Kaynaklar\" + i + ".png"));
                i++;

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            var AktifDeğiştir = context.VeriSets.FirstOrDefault(x=>x.Id == EskiAktif);
            AktifDeğiştir.Aktiflik = false;

            string[] yeniAra = comboBox1.Text.Trim().Split('-');
            int YeniIdİnt = Convert.ToInt32(yeniAra[0]);
            var yeniId = context.VeriSets.FirstOrDefault(x=>x.Id == YeniIdİnt);
            yeniId.Aktiflik = true;

            context.SaveChanges();
            var aktif = context.VeriSets.FirstOrDefault(x => x.Aktiflik == true);
            label1.Text = "Aktif Set = " + aktif.SetAdı;
        }
    }
}
