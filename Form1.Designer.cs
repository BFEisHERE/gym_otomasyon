
namespace sgates_software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.giris_bt = new System.Windows.Forms.Button();
            this.kapat_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giris_bt
            // 
            this.giris_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_bt.Location = new System.Drawing.Point(447, 237);
            this.giris_bt.Name = "giris_bt";
            this.giris_bt.Size = new System.Drawing.Size(75, 23);
            this.giris_bt.TabIndex = 0;
            this.giris_bt.Text = "GİRİŞ";
            this.giris_bt.UseVisualStyleBackColor = true;
            this.giris_bt.Click += new System.EventHandler(this.giris_bt_Click);
            // 
            // kapat_bt
            // 
            this.kapat_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat_bt.Location = new System.Drawing.Point(447, 276);
            this.kapat_bt.Name = "kapat_bt";
            this.kapat_bt.Size = new System.Drawing.Size(75, 23);
            this.kapat_bt.TabIndex = 1;
            this.kapat_bt.Text = "KAPAT";
            this.kapat_bt.UseVisualStyleBackColor = true;
            this.kapat_bt.Click += new System.EventHandler(this.kapat_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.kapat_bt);
            this.Controls.Add(this.giris_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giris_bt;
        private System.Windows.Forms.Button kapat_bt;
    }
}

