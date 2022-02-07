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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
            
            bt_alan.Enabled = false;
            bt_msj.Enabled = false;
        }

        SqlConnection baglantı = new SqlConnection();

        private void kapat_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmaya eminmisiniz.", "Uygulama Kapat", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {

        }
        private void button_yenıuye2_Click(object sender, EventArgs e)
        {
            YeniÜye giris = new YeniÜye();
            giris.Show();
        }

        private void button_yenıuye_Click_1(object sender, EventArgs e)
        {
            YeniÜye giris = new YeniÜye();
            giris.Show();
        }

        private void button_tumuyeler_Click(object sender, EventArgs e)
        {
            tumüyeler git = new tumüyeler();
            git.Show();
        }

        private void button_tumuyeler2_Click(object sender, EventArgs e)
        {
            tumüyeler git = new tumüyeler();
            git.Show();
        }

        private void button_mesajgonder_Click(object sender, EventArgs e)
        {
            mesajgonder gıt = new mesajgonder();
           
            gıt.Show();
        }

        private void button_zamanlımesaj_Click(object sender, EventArgs e)
        {
            zamanlımesaj git = new zamanlımesaj();
            git.Show();
        }

        private void button_grupayarları_Click(object sender, EventArgs e)
        {
            grup_ayarları git = new grup_ayarları();
            git.Show();
        }

      

        private void buton_gelırrapor_Click(object sender, EventArgs e)
        {
            frgelir git = new frgelir();
            git.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet12.yenıuye_db' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yenıuye_dbTableAdapter.Fill(this.linqotomasyonDataSet12.yenıuye_db);
            label2.Text = (data1.Rows.Count - 1).ToString();
        }

        private void buton_listele_Click(object sender, EventArgs e)
        {
            Listele(data1, "SELECT *FROM yenıuye_db WHERE bas_tarıh BETWEEN @start AND @end ;");
            label2.Text = (data1.Rows.Count-1).ToString();
            
        }
        DataTable tbl = new DataTable();
        public DataTable Listele(Bunifu.UI.WinForms.BunifuDataGridView dgrid, string sorgu)
        {
            tbl.Clear();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglantı);
            adtr.SelectCommand.Parameters.AddWithValue("@start", datepicker1.Text);
            adtr.SelectCommand.Parameters.AddWithValue("@end", datepicker2.Text);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;
            baglantı.Close();
            return tbl;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter d = new SqlDataAdapter("select *from yenıuye_db", baglantı);
            DataSet ds = new DataSet();
            d.Fill(ds);
            data1.DataSource = ds.Tables[0];
            label2.Text = (data1.Rows.Count - 1).ToString();
        }
    }
}
