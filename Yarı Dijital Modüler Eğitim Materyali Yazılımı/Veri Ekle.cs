using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.Siniflar;
namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    public partial class Veri_Ekle : Form
    {
        Context context = new Context();
        public Veri_Ekle()
        {
            InitializeComponent();
        }

        private void Veri_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string SekilVerisi="";

            if (cbx0.Checked)
                SekilVerisi += "1";
            else
                SekilVerisi += "0";
            if (cbx1.Checked)
                SekilVerisi += "1";
            else
                SekilVerisi += "0";
            if (cbx2.Checked)
                SekilVerisi += "1";
            else
                SekilVerisi += "0";
            if (cbx3.Checked)
                SekilVerisi += "1";
            else
                SekilVerisi += "0";
            if (cbx4.Checked)
                SekilVerisi += "1";
            else
                SekilVerisi += "0";
            if (cbx5.Checked)
                SekilVerisi += "1";
            else
                SekilVerisi += "0";

            string VeriTuru = comboBox1.Text;

            Veri veri = new Veri();
            veri.SekilVerisi = SekilVerisi;
            veri.VeriTuru = VeriTuru;
            context.Veris.Add(veri);
            MessageBox.Show("Veri Ekle");
        }
    }
}
