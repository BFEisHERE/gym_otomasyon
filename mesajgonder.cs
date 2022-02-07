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
using System.Net.Mail;
using System.Net;

namespace sgates_software
{
    public partial class mesajgonder : Form
    {
        private SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
        private MailMessage mesajım = new MailMessage();
        private SmtpClient istemci = new SmtpClient();
        public mesajgonder()
        {
            InitializeComponent();
        }
        bool enter = true;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textbox_ara.Enabled = false;
            }
            else
            {
                textbox_ara.Enabled = true;
            }
        }
        private void mesajgonder_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet4.yenıuye_db' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yenıuye_dbTableAdapter.Fill(this.linqotomasyonDataSet4.yenıuye_db);
            // TODO: Bu kod satırı 'linqotomasyonDataSet2.yenıuye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ActiveControl = checkBox1;
            
        }

        private void button_sıl_Click(object sender, EventArgs e)
        {
            textbox_mesaj.Text = "";
        }

        private void button_ıptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textbox_mesaj_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_mesaj.Text))
            {
                //textbox_mesaj.PasswordChar = '\0';
                textbox_mesaj.Text = "Mesajı Giriniz!";
                enter = true;
            }
        }

        private void textbox_mesaj_Enter(object sender, EventArgs e)
        {
            if (enter)
            {
                textbox_mesaj.Text = "";
                enter = false;
            }
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

        private void button_gonder_Click(object sender, EventArgs e)
        {
            if (textbox_mesaj.Text=="" && textbox_baslık.Text=="")
            {
                MessageBox.Show("Lütfen Bir Metin Giriniz!", "Mesaj Hatası!");
            }
            else 
            {
                if (checkBox1.Checked == true)
                {
                    istemci.Credentials = new System.Net.NetworkCredential("burakerkemen@hotmail.com", "05414133440burak");
                    istemci.Port = 587;
                    istemci.Host = "smtp.live.com";
                    istemci.EnableSsl = true;
                    textbox1.Text = data1.CurrentRow.Cells[6].Value.ToString();
                    mesajım.To.Add(textbox1.Text);
                    mesajım.From = new MailAddress("burakerkemen@hotmail.com");
                    mesajım.Subject = textbox_baslık.Text;
                    mesajım.Body = textbox_mesaj.Text;
                    istemci.Send(mesajım);
                }
            }
        }
       

        private void yenıuyedbBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void yenıuyeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void linqotomasyonDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==8)
            {
                istemci.Credentials = new System.Net.NetworkCredential("burakerkemen@hotmail.com", "05414133440burak");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                textbox1.Text = data1.CurrentRow.Cells[6].Value.ToString();
                mesajım.To.Add(textbox1.Text);
                mesajım.From = new MailAddress("burakerkemen@hotmail.com");
                mesajım.Subject = textbox_baslık.Text;
                mesajım.Body = textbox_mesaj.Text;
                istemci.Send(mesajım);
            }
        }

        private void textbox_baslık_TextChanged(object sender, EventArgs e)
        {
            if (textbox_baslık.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_baslık.Text.Substring(0, 1))))
                {
                    textbox_baslık.Text = char.ToUpper(textbox_baslık.Text[0]).ToString() + textbox_baslık.Text.Substring(1);
                    textbox_baslık.SelectionStart = textbox_baslık.TextLength;
                }
            }
        }

        private void textbox_mesaj_TextChanged(object sender, EventArgs e)
        {
            if (textbox_mesaj.Text != "")
            { // or different from null
                if (char.IsLower(Convert.ToChar(textbox_mesaj.Text.Substring(0, 1))))
                {
                    textbox_mesaj.Text = char.ToUpper(textbox_mesaj.Text[0]).ToString() + textbox_mesaj.Text.Substring(1);
                    textbox_mesaj.SelectionStart = textbox_mesaj.TextLength;
                }
            }
        }
    }
}

