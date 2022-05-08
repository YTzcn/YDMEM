
namespace Yarı_Dijital_Modüler_Eğitim_Materyali_Yazılımı
{
    partial class Veri_Ekle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx0 = new System.Windows.Forms.CheckBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cbx4 = new System.Windows.Forms.CheckBox();
            this.cbx5 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx5);
            this.groupBox1.Controls.Add(this.cbx4);
            this.groupBox1.Controls.Add(this.cbx3);
            this.groupBox1.Controls.Add(this.cbx2);
            this.groupBox1.Controls.Add(this.cbx1);
            this.groupBox1.Controls.Add(this.cbx0);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blok Şekli";
            // 
            // cbx0
            // 
            this.cbx0.AutoSize = true;
            this.cbx0.Location = new System.Drawing.Point(38, 54);
            this.cbx0.Name = "cbx0";
            this.cbx0.Size = new System.Drawing.Size(15, 14);
            this.cbx0.TabIndex = 0;
            this.cbx0.UseVisualStyleBackColor = true;
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(177, 54);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(15, 14);
            this.cbx1.TabIndex = 1;
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(38, 122);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(15, 14);
            this.cbx2.TabIndex = 2;
            this.cbx2.UseVisualStyleBackColor = true;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Location = new System.Drawing.Point(177, 122);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(15, 14);
            this.cbx3.TabIndex = 3;
            this.cbx3.UseVisualStyleBackColor = true;
            // 
            // cbx4
            // 
            this.cbx4.AutoSize = true;
            this.cbx4.Location = new System.Drawing.Point(38, 190);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(15, 14);
            this.cbx4.TabIndex = 4;
            this.cbx4.UseVisualStyleBackColor = true;
            // 
            // cbx5
            // 
            this.cbx5.AutoSize = true;
            this.cbx5.Location = new System.Drawing.Point(177, 190);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(15, 14);
            this.cbx5.TabIndex = 5;
            this.cbx5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Harf",
            "Fotoğraf",
            "Ses",
            "Video",
            "Bağlantı"});
            this.comboBox1.Location = new System.Drawing.Point(289, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veri Türü";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(289, 114);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 101);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // Veri_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 352);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Veri_Ekle";
            this.Text = "Veri Ekle";
            this.Load += new System.EventHandler(this.Veri_Ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx5;
        private System.Windows.Forms.CheckBox cbx4;
        private System.Windows.Forms.CheckBox cbx3;
        private System.Windows.Forms.CheckBox cbx2;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.CheckBox cbx0;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}