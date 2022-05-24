
namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    partial class Ayarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxSetAdı = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yDMEMDBDataSet3 = new Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.YDMEMDBDataSet3();
            this.verisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verisTableAdapter = new Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı.YDMEMDBDataSet3TableAdapters.VerisTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sekilVerisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veriSetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baglantıVerisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografVerisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesVerisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yaziVerisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoVerisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ŞekilResmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDMEMDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 32);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(12, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ayarlar";
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Cornsilk;
            this.button12.Location = new System.Drawing.Point(1368, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(39, 32);
            this.button12.TabIndex = 6;
            this.button12.Text = "X";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Şekil1.jpg");
            this.ımageList1.Images.SetKeyName(1, "Şekil2.jpg");
            this.ımageList1.Images.SetKeyName(2, "Şekil3.jpg");
            this.ımageList1.Images.SetKeyName(3, "Şekil4.jpg");
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(381, 691);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(136, 26);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Set Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxSetAdı
            // 
            this.tbxSetAdı.Location = new System.Drawing.Point(337, 659);
            this.tbxSetAdı.Name = "tbxSetAdı";
            this.tbxSetAdı.Size = new System.Drawing.Size(180, 26);
            this.tbxSetAdı.TabIndex = 14;
            this.tbxSetAdı.Text = "Set Adını Girin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Seçili Seti Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.sekilVerisiDataGridViewTextBoxColumn,
            this.veriSetIdDataGridViewTextBoxColumn,
            this.baglantıVerisiDataGridViewTextBoxColumn,
            this.fotografVerisiDataGridViewTextBoxColumn,
            this.sesVerisiDataGridViewTextBoxColumn,
            this.yaziVerisiDataGridViewTextBoxColumn,
            this.videoVerisiDataGridViewTextBoxColumn,
            this.ŞekilResmi});
            this.dataGridView1.DataSource = this.verisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(381, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 578);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yDMEMDBDataSet3
            // 
            this.yDMEMDBDataSet3.DataSetName = "YDMEMDBDataSet3";
            this.yDMEMDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verisBindingSource
            // 
            this.verisBindingSource.DataMember = "Veris";
            this.verisBindingSource.DataSource = this.yDMEMDBDataSet3;
            // 
            // verisTableAdapter
            // 
            this.verisTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sekilVerisiDataGridViewTextBoxColumn
            // 
            this.sekilVerisiDataGridViewTextBoxColumn.DataPropertyName = "SekilVerisi";
            this.sekilVerisiDataGridViewTextBoxColumn.HeaderText = "SekilVerisi";
            this.sekilVerisiDataGridViewTextBoxColumn.Name = "sekilVerisiDataGridViewTextBoxColumn";
            this.sekilVerisiDataGridViewTextBoxColumn.Visible = false;
            // 
            // veriSetIdDataGridViewTextBoxColumn
            // 
            this.veriSetIdDataGridViewTextBoxColumn.DataPropertyName = "VeriSet_Id";
            this.veriSetIdDataGridViewTextBoxColumn.HeaderText = "VeriSet_Id";
            this.veriSetIdDataGridViewTextBoxColumn.Name = "veriSetIdDataGridViewTextBoxColumn";
            this.veriSetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // baglantıVerisiDataGridViewTextBoxColumn
            // 
            this.baglantıVerisiDataGridViewTextBoxColumn.DataPropertyName = "BaglantıVerisi";
            this.baglantıVerisiDataGridViewTextBoxColumn.HeaderText = "BaglantıVerisi";
            this.baglantıVerisiDataGridViewTextBoxColumn.Name = "baglantıVerisiDataGridViewTextBoxColumn";
            // 
            // fotografVerisiDataGridViewTextBoxColumn
            // 
            this.fotografVerisiDataGridViewTextBoxColumn.DataPropertyName = "FotografVerisi";
            this.fotografVerisiDataGridViewTextBoxColumn.HeaderText = "FotografVerisi";
            this.fotografVerisiDataGridViewTextBoxColumn.Name = "fotografVerisiDataGridViewTextBoxColumn";
            // 
            // sesVerisiDataGridViewTextBoxColumn
            // 
            this.sesVerisiDataGridViewTextBoxColumn.DataPropertyName = "SesVerisi";
            this.sesVerisiDataGridViewTextBoxColumn.HeaderText = "SesVerisi";
            this.sesVerisiDataGridViewTextBoxColumn.Name = "sesVerisiDataGridViewTextBoxColumn";
            // 
            // yaziVerisiDataGridViewTextBoxColumn
            // 
            this.yaziVerisiDataGridViewTextBoxColumn.DataPropertyName = "YaziVerisi";
            this.yaziVerisiDataGridViewTextBoxColumn.HeaderText = "YaziVerisi";
            this.yaziVerisiDataGridViewTextBoxColumn.Name = "yaziVerisiDataGridViewTextBoxColumn";
            // 
            // videoVerisiDataGridViewTextBoxColumn
            // 
            this.videoVerisiDataGridViewTextBoxColumn.DataPropertyName = "VideoVerisi";
            this.videoVerisiDataGridViewTextBoxColumn.HeaderText = "VideoVerisi";
            this.videoVerisiDataGridViewTextBoxColumn.Name = "videoVerisiDataGridViewTextBoxColumn";
            // 
            // ŞekilResmi
            // 
            this.ŞekilResmi.DataPropertyName = "Id";
            this.ŞekilResmi.HeaderText = "ŞekilResmi";
            this.ŞekilResmi.Name = "ŞekilResmi";
            this.ŞekilResmi.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 664);
            this.listBox1.TabIndex = 17;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 729);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxSetAdı);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDMEMDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxSetAdı;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YDMEMDBDataSet3 yDMEMDBDataSet3;
        private System.Windows.Forms.BindingSource verisBindingSource;
        private YDMEMDBDataSet3TableAdapters.VerisTableAdapter verisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sekilVerisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veriSetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baglantıVerisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografVerisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesVerisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaziVerisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoVerisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ŞekilResmi;
        private System.Windows.Forms.ListBox listBox1;
    }
}