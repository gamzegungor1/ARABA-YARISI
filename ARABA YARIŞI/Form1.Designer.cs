
namespace ARABA_YARIŞI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.bizimaraba = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.yol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_yuksekSkor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.bizimaraba);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol);
            this.panel1.Location = new System.Drawing.Point(21, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // carpma
            // 
            this.carpma.Image = global::ARABA_YARIŞI.Properties.Resources.explosion_icegif_3;
            this.carpma.Location = new System.Drawing.Point(285, 267);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(64, 50);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carpma.TabIndex = 4;
            this.carpma.TabStop = false;
            // 
            // bizimaraba
            // 
            this.bizimaraba.Image = global::ARABA_YARIŞI.Properties.Resources.top_view_car_123292;
            this.bizimaraba.Location = new System.Drawing.Point(206, 304);
            this.bizimaraba.Name = "bizimaraba";
            this.bizimaraba.Size = new System.Drawing.Size(73, 134);
            this.bizimaraba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizimaraba.TabIndex = 3;
            this.bizimaraba.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::ARABA_YARIŞI.Properties.Resources.png_transparent_sports_car_bird_s_eye_view_race_car_car_color_vehicle;
            this.araba2.Location = new System.Drawing.Point(340, 49);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(73, 134);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 2;
            this.araba2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::ARABA_YARIŞI.Properties.Resources.kisspng_sports_car_clip_art_overhead_car_cliparts_5ab73cb06fbec3_3416454815219580644577;
            this.araba1.Location = new System.Drawing.Point(69, 49);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(73, 134);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 1;
            this.araba1.TabStop = false;
            // 
            // yol
            // 
            this.yol.Image = global::ARABA_YARIŞI.Properties.Resources.yol;
            this.yol.Location = new System.Drawing.Point(0, -19);
            this.yol.Name = "yol";
            this.yol.Size = new System.Drawing.Size(513, 758);
            this.yol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol.TabIndex = 0;
            this.yol.TabStop = false;
            this.yol.Click += new System.EventHandler(this.yol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puan:";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(137, 578);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(26, 29);
            this.lbl_puan.TabIndex = 2;
            this.lbl_puan.Text = "0";
            // 
            // btn_baslat
            // 
            this.btn_baslat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baslat.Location = new System.Drawing.Point(322, 578);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(203, 65);
            this.btn_baslat.TabIndex = 3;
            this.btn_baslat.Text = "Oyunu Başlat ";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // lbl_yuksekSkor
            // 
            this.lbl_yuksekSkor.AutoSize = true;
            this.lbl_yuksekSkor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yuksekSkor.Location = new System.Drawing.Point(34, 628);
            this.lbl_yuksekSkor.Name = "lbl_yuksekSkor";
            this.lbl_yuksekSkor.Size = new System.Drawing.Size(162, 29);
            this.lbl_yuksekSkor.TabIndex = 4;
            this.lbl_yuksekSkor.Text = "Yüksek Skor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_yuksekSkor);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizimaraba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol;
        private System.Windows.Forms.PictureBox bizimaraba;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_yuksekSkor;
    }
}

