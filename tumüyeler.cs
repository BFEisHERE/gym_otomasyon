using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sgates_software
{
    public partial class tumüyeler : Form
    {
        
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
        private void verileriGoster(string veriler)
        {
            SqlDataAdapter d = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            d.Fill(ds);
            data1.DataSource = ds.Tables[0];
        }
        public tumüyeler()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        
        private void tumüyeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet10.yenıuye_db' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yenıuye_dbTableAdapter4.Fill(this.linqotomasyonDataSet10.yenıuye_db);
           

            textbox_ara.Focus();
        }
        private void button_yenikayıt_Click(object sender, EventArgs e)
        {
            YeniÜye git = new YeniÜye();
            git.Show();
            this.Hide();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Üye Sil", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from yenıuye_db where mno=@mno ", baglantı);
                komut.Parameters.AddWithValue("@mno", textBox1.Text);
                komut.ExecuteNonQuery();
                verileriGoster("select *from yenıuye_db");
                baglantı.Close();
            }
            foreach (Control item in Controls) { if (item is TextBox) item.Text = ""; }
            data1.DataSource = db.yenıuye_db.ToList();
        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {
            string tc_no = data1.CurrentRow.Cells[3].Value.ToString();
            var güncelle = db.yenıuye_db.Where(w => w.tcno == tc_no).FirstOrDefault();
            güncelle.ad = textbox_ad.Text;
            güncelle.soyad = textbox_soyad.Text;
            güncelle.tcno = textbox_tcno.Text;
            güncelle.telno = textbox_telno.Text;
            güncelle.cınsıyet = combo_cınsıyet.Text;
            güncelle.grup = decimal.Parse(combo_grup.Text);
            güncelle.bas_tarıh = datapicker_baslangıc.Value.ToString();
            güncelle.bıt_tarıh = datapicker_bıtıs.Value.ToString();
            güncelle.emaıl = textbox_emaıl.Text;
            güncelle.ıl = textbox_ıl.Text;
            güncelle.ılce = textbox_ılce.Text;
            güncelle.adres = textbox_adres.Text;
            db.SubmitChanges();
            MessageBox.Show("İşlem Başarılı", "Güncelleme");
            foreach (Control item in Controls) { if (item is TextBox) item.Text = ""; }
            data1.DataSource = db.yenıuye_db.ToList();

        }

        /*
            string tc_no = data1.CurrentRow.Cells[3].Value.ToString();
            var sil = db.yenıuye.Where(w =>w.tcno = tc_no).FirstOrDefault();
            db.yenıuye.DeleteOnSubmit(sil);
            db.SubmitChanges();
            MessageBox.Show("İşlem Başarılı", "Üye Silindi");
            foreach (Control item in Controls) { if (item is TextBox) item.Text = ""; }
            data1.DataSource = db.yenıuye.ToList();*/


        private void data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = data1.CurrentRow.Cells[0].Value.ToString();
            textbox_ad.Text = data1.CurrentRow.Cells[1].Value.ToString();
            textbox_soyad.Text = data1.CurrentRow.Cells[2].Value.ToString();
            textbox_tcno.Text = data1.CurrentRow.Cells[3].Value.ToString();
            textbox_telno.Text = data1.CurrentRow.Cells[4].Value.ToString();
            combo_cınsıyet.Text = data1.CurrentRow.Cells[5].Value.ToString();
            combo_grup.Text = data1.CurrentRow.Cells[6].Value.ToString();
            datapicker_baslangıc.Text = data1.CurrentRow.Cells[7].Value.ToString();
            datapicker_bıtıs.Text = data1.CurrentRow.Cells[8].Value.ToString();
            textbox_emaıl.Text = data1.CurrentRow.Cells[9].Value.ToString();
            textbox_ıl.Text = data1.CurrentRow.Cells[10].Value.ToString();
            textbox_ılce.Text = data1.CurrentRow.Cells[11].Value.ToString();
            textbox_adres.Text = data1.CurrentRow.Cells[12].Value.ToString();
        }

        private void textbox_ara_TextChanged(object sender, EventArgs e)
        {
            if (textbox_ara.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_ara.Text.Substring(0, 1))))
                {
                    textbox_ara.Text = char.ToUpper(textbox_ara.Text[0]).ToString() + textbox_ara.Text.Substring(1);
                    textbox_ara.SelectionStart = textbox_ara.TextLength;
                }
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select [mno],[ad],[soyad],[tcno],[telno],[bas_Tarıh],[bıt_tarıh],[cınsıyet],[grup],[emaıl],[ıl],[ılce],[adres] from yenıuye_db where  [mno] like '%"+ textbox_ara.Text+ "%'or [ad] like '%" + textbox_ara.Text + "%' OR [soyad] LIKE '%" + textbox_ara.Text + "%' OR [tcno] LIKE '%" + textbox_ara.Text + "%' OR [telno] LIKE '%" + textbox_ara.Text + "%' OR [bas_tarıh] LIKE '%"+textbox_ara.Text + "%' OR [bıt_tarıh] LIKE '%" + textbox_ara.Text + "%' OR [cınsıyet] LIKE '%"+textbox_ara.Text+ "%' OR [grup] LIKE '%" + textbox_ara.Text + "%' OR [emaıl] LIKE '%"+textbox_ara.Text+"%' OR [ıl] LIKE '%"+textbox_ara.Text+"%' OR [ılce] LIKE '%"+textbox_ara.Text+"%' OR [adres] LIKE '%"+textbox_ara.Text+"%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            data1.DataSource = ds.Tables[0];
            baglantı.Close();
        }

        private void tumüyeler_Shown(object sender, EventArgs e)
        {
            textbox_ara.Focus();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
