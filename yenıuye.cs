using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sgates_software
{
    public partial class YeniÜye : Form
    {
        public YeniÜye()
        {
            InitializeComponent();
            //dataGridView1.DataSource = ds.Tables[0];

        }
        DataClasses1DataContext db = new DataClasses1DataContext();
       
       
        private void button_ekle_Click(object sender, EventArgs e)
        {
            if (textbox_ad.Text == "" || textbox_soyad.Text == "" || textbox_tcno.Text == "" || textbox_telno.Text == "" || textbox_emaıl.Text == "" || textbox_ıl.Text == "" || textbox_ılce.Text == "" || textbox_adres.Text == "" || comboBox1.Text==""|| FiyatTb.Text==""||
                textbox_ad.Text == String.Empty || textbox_soyad.Text == String.Empty || textbox_tcno.Text == String.Empty || textbox_telno.Text == String.Empty || textbox_emaıl.Text == String.Empty || textbox_ıl.Text == String.Empty || textbox_ılce.Text == String.Empty || textbox_adres.Text == String.Empty || comboBox1.Text == String.Empty || FiyatTb.Text == String.Empty)
            {
                textbox_ad.BackColor = Color.Red;
                textbox_soyad.BackColor = Color.Red;
                textbox_tcno.BackColor = Color.Red;
                comboBox1.BackColor = Color.Red;
                FiyatTb.BackColor = Color.Red;
                textbox_telno.BackColor = Color.Red;
                textbox_emaıl.BackColor = Color.Red;
                textbox_ıl.BackColor = Color.Red;
                textbox_ılce.BackColor = Color.Red;
                textbox_adres.BackColor = Color.Red;
                MessageBox.Show("Kırmızı Renkli Alaları Boş Geçemezsiniz!", "Boş Alan Hatası");
            }
            else
            {
                yenıuye_db kayıt = new yenıuye_db();
                kayıt.ad = textbox_ad.Text;
                kayıt.soyad = textbox_soyad.Text;
                kayıt.tcno = textbox_tcno.Text;
                kayıt.telno = textbox_telno.Text;
                kayıt.cınsıyet = comboBox1.Text;
                //kayıt.grup = comboBox2.Text;
                kayıt.grup = Convert.ToDecimal(FiyatTb.Text);
                kayıt.bas_tarıh = datapicker_baslangıc.Value.ToString();
                kayıt.bıt_tarıh = datapicker_bıtıs.Value.ToString();
                kayıt.emaıl = textbox_emaıl.Text;
                kayıt.ıl = textbox_ıl.Text;
                kayıt.ılce = textbox_ılce.Text;
                kayıt.adres = textbox_adres.Text;
                kayıt.cınsıyet = comboBox1.Text;
                db.yenıuye_db.InsertOnSubmit(kayıt);
                db.SubmitChanges();
                MessageBox.Show("Kayıt başarıyla gerçekleşti!", "Kayıt Sayfası");
                textbox_ad.Clear();
                textbox_soyad.Clear();
                textbox_tcno.Clear();
                textbox_telno.Clear();
                textbox_emaıl.Clear();
                textbox_ıl.Clear();
                textbox_ılce.Clear();
                textbox_adres.Clear();

            }     
        } 
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
        private void listele(string veriler)
        {
            SqlDataAdapter adp = new SqlDataAdapter(veriler,baglantı);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        

        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Tümünü iptal etmek istediğine emin misin?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                textbox_ad.Clear();
                textbox_soyad.Clear();
                textbox_tcno.Clear();
                textbox_telno.Clear();
                textbox_emaıl.Clear();
                textbox_ıl.Clear();
                textbox_ılce.Clear();
                textbox_adres.Clear();

                this.Visible = false;
            }
        }

        private void YeniÜye_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet11.grupayarları' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.grupayarlarıTableAdapter.Fill(this.linqotomasyonDataSet11.grupayarları);
            datapicker_baslangıc.Value = DateTime.Now;
            datapicker_bıtıs.Value = DateTime.Now;
            listele("select *from grupayarları");
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textbox_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textbox_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textbox_ıl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textbox_ılce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textbox_tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textbox_ad_TextChanged(object sender, EventArgs e)
        {
            if (textbox_ad.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_ad.Text.Substring(0, 1))))
                {
                    textbox_ad.Text = char.ToUpper(textbox_ad.Text[0]).ToString() + textbox_ad.Text.Substring(1);
                    textbox_ad.SelectionStart = textbox_ad.TextLength;
                }
            }
        }

        private void textbox_soyad_TextChanged(object sender, EventArgs e)
        {
            if (textbox_soyad.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_soyad.Text.Substring(0, 1))))
                {
                    textbox_soyad.Text = char.ToUpper(textbox_soyad.Text[0]).ToString() + textbox_soyad.Text.Substring(1);
                    textbox_soyad.SelectionStart = textbox_soyad.TextLength;
                }
            }
        }

        private void textbox_ıl_TextChanged(object sender, EventArgs e)
        {

            if (textbox_ıl.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_ıl.Text.Substring(0, 1))))
                {
                    textbox_ıl.Text = char.ToUpper(textbox_ıl.Text[0]).ToString() + textbox_ıl.Text.Substring(1);
                    textbox_ıl.SelectionStart = textbox_ıl.TextLength;
                }
            }
        }
      
        private void textbox_ılce_TextChanged(object sender, EventArgs e)
        {
           
            if (textbox_ılce.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_ılce.Text.Substring(0, 1))))
                {
                    textbox_ılce.Text = char.ToUpper(textbox_ılce.Text[0]).ToString() + textbox_ılce.Text.Substring(1);
                    textbox_ılce.SelectionStart = textbox_ılce.TextLength;
                }
            }
        }

        private void textbox_adres_TextChanged(object sender, EventArgs e)
        {

            if (textbox_adres.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_adres.Text.Substring(0, 1))))
                {
                    textbox_adres.Text = char.ToUpper(textbox_adres.Text[0]).ToString() + textbox_adres.Text.Substring(1);
                    textbox_adres.SelectionStart = textbox_adres.TextLength;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            int fiyat = int.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
            string cins = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            FiyatTb.Text = fiyat.ToString();
            comboBox1.Text = cins.ToString();
        }
    }
}
