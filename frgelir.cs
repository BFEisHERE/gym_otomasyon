using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace sgates_software
{
    public partial class frgelir : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void verileriGoster(string veriler)
        {
            SqlDataAdapter d = new SqlDataAdapter(veriler, baglantı);
            DataTable ds = new DataTable();
            d.Fill(ds);
            data1.DataSource = ds.Rows[0];
        }
        public frgelir()
        {
            InitializeComponent();
            
        }
       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                db.yenıuye_db.ToList();
                textbox_ara.Enabled = false;
            }
            else
            {
                textbox_ara.Enabled = true;
            }
        }

        private void frgelir_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet14.yenıuye_db' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yenıuye_dbTableAdapter2.Fill(this.linqotomasyonDataSet14.yenıuye_db);
            // TODO: Bu kod satırı 'linqotomasyonDataSet3.yenıuye_db' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yenıuye_dbTableAdapter.Fill(this.linqotomasyonDataSet3.yenıuye_db);
            datepicker1.Value = DateTime.Now;
            datepicker2.Value = DateTime.Now;
            
        }

        private void buton_ara_Click(object sender, EventArgs e)
        {
            Listele(data1, "SELECT *FROM yenıuye_db WHERE bas_tarıh BETWEEN @start AND @end ;");
            decimal tutar = 0;
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                tutar += decimal.Parse(data1.Rows[i].Cells["grup"].Value.ToString());


            }
            label4.Text = tutar.ToString("0.00") + " ₺";
           
        }

        private void frgelir_Shown(object sender, EventArgs e)
        {
            textbox_ara.Focus();
        }

        private void textbox_ara_TextChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select [mno],[ad],[soyad],[tcno],[telno],[bas_Tarıh],[bıt_tarıh],[emaıl],[ıl],[ılce],[adres] from yenıuye_db where  [mno] like '%" + textbox_ara.Text + "%'or [ad] like '%" + textbox_ara.Text + "%' OR [soyad] LIKE '%" + textbox_ara.Text + "%' OR [tcno] LIKE '%" + textbox_ara.Text + "%' OR [telno] LIKE '%" + textbox_ara.Text + "%' OR [bas_tarıh] LIKE '%" + textbox_ara.Text + "%' OR [bıt_tarıh] LIKE '%" + textbox_ara.Text + "%' OR [emaıl] LIKE '%" + textbox_ara.Text + "%' OR [ıl] LIKE '%" + textbox_ara.Text + "%' OR [ılce] LIKE '%" + textbox_ara.Text + "%' OR [adres] LIKE '%" + textbox_ara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            data1.DataSource = ds.Tables[0];
            baglantı.Close();

            if (textbox_ara.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_ara.Text.Substring(0, 1))))
                {
                    textbox_ara.Text = char.ToUpper(textbox_ara.Text[0]).ToString() + textbox_ara.Text.Substring(1);
                    textbox_ara.SelectionStart = textbox_ara.TextLength;
                }
            }
        }

        private void textbox_ara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
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
    }
}
