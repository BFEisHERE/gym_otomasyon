using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sgates_software
{
    public partial class grup_ayarları : Form
    {
        public grup_ayarları()
        {
            InitializeComponent();
            verileriGoster("select *from grupayarları");
            textbox_ad.Focus();
        }
        
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
        DataClasses1DataContext db = new DataClasses1DataContext();
       
        private void verileriGoster(string veriler)
        {
            SqlDataAdapter d = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            d.Fill(ds);
            data.DataSource = ds.Tables[0];
        }
        private void buton_ıptal_Click(object sender, EventArgs e)
        {
            textbox_ad.Clear();
            textbox_fiyat.Clear();
            comboBox1.Text = "";
            richTextBox1.Clear();
        }

        private void buton_kaldır_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Üye Sil", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from grupayarları where ıd=@ıd ", baglantı);
                komut.Parameters.AddWithValue("@grup_adı,", textbox_ad.Text);
                komut.ExecuteNonQuery();
                verileriGoster("select * from grupayarları");
                baglantı.Close();
            }
            foreach (Control item in Controls) { if (item is TextBox) item.Text = ""; }
            data.DataSource = db.grupayarları.ToList();
        }

        private void buton_guncelle_Click(object sender, EventArgs e)
        {
            string grupadı = data.CurrentRow.Cells[1].Value.ToString();
            var güncelle = db.grupayarları.Where(w => w.grup_adı == grupadı).FirstOrDefault();
            güncelle.grup_adı = textbox_ad.Text;
            güncelle.cınsıyet = comboBox1.Text;
            güncelle.metin = richTextBox1.Text;
            güncelle.fiyat = Convert.ToInt32(textbox_fiyat.Text);
            
            db.SubmitChanges();
            MessageBox.Show("İşlem Başarılı", "Güncelleme");
            foreach (Control item in Controls) { if (item is TextBox) item.Text = ""; }
            data.DataSource = db.grupayarları.ToList();
        }

        private void grupayarları_Shown(object sender, EventArgs e)
        {
            textbox_ad.Focus();
        }

        private void buton_ekle_Click(object sender, EventArgs e)
        {
            grupayarları kayıt = new grupayarları();
            kayıt.grup_adı = textbox_ad.Text;
            kayıt.cınsıyet = comboBox1.Text;
            kayıt.metin = richTextBox1.Text;
            kayıt.fiyat = Convert.ToInt32(textbox_fiyat.Text);
            db.grupayarları.InsertOnSubmit(kayıt);
            db.SubmitChanges();
            MessageBox.Show("Kayıt başarıyla gerçekleşti!", "Kayıt Sayfası");
            textbox_ad.Clear();
            textbox_fiyat.Clear();
            comboBox1.Text = "";
            richTextBox1.Clear();
            verileriGoster("select *from grupayarları");
            
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textbox_ad.Text = data.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = data.CurrentRow.Cells[2].Value.ToString();
            richTextBox1.Text = data.CurrentRow.Cells[3].Value.ToString();
            textbox_fiyat.Text = data.CurrentRow.Cells[4].Value.ToString();
        }

        private void grup_ayarları_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet.grupayarları' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.grupayarlarıTableAdapter.Fill(this.linqotomasyonDataSet.grupayarları);

        }

        private void textbox_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_ad_TextChanged(object sender, EventArgs e)
        {
            if (textbox_ad.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_ad.Text.Substring(0, 1))))
                {
                    textbox_ad.Text = char.ToUpper(richTextBox1.Text[0]).ToString() + textbox_ad.Text.Substring(1);
                    textbox_ad.SelectionStart = textbox_ad.TextLength;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(richTextBox1.Text.Substring(0, 1))))
                {
                    richTextBox1.Text = char.ToUpper(richTextBox1.Text[0]).ToString() + richTextBox1.Text.Substring(1);
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                }
            }
        }
    }
}
