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

namespace sgates_software
{
    public partial class zamanlımesaj : Form
    {
        private SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
        private MailMessage mesajım = new MailMessage();
        private SmtpClient istemci = new SmtpClient();
        private zamanlıımesaj kayıt = new zamanlıımesaj();
        public zamanlımesaj()
        {
            InitializeComponent();
        }
        bool enter = true;
        private void chechbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked == true)
            {
                textbox_ara.Enabled = false;
            }
            else
            {
                textbox_ara.Enabled = true;
            }
        }

        private void zamanlımesaj_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'linqotomasyonDataSet6.yenıuye_db' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yenıuye_dbTableAdapter.Fill(this.linqotomasyonDataSet6.yenıuye_db);
            datepicker1.Value = DateTime.Now;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_mesaj.Text))
            {
                //textbox_mesaj.PasswordChar = '\0';
                textbox_mesaj.Text = "Mesajı Giriniz!";
                enter = true;
            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (enter)
            {
                textbox_mesaj.Text = "";
                enter = false;
            }
        }

        private void buton_ıptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void buton_gonder_Click(object sender, EventArgs e)
        {
            if (textbox_mesaj.Text == "" && textbox_baslık.Text == "")
            {
                MessageBox.Show("Lütfen Bir Metin Giriniz!", "Mesaj Hatası!");
            }
            else
            {
                kayıt.tarıh = datepicker1.Text;
                kayıt.baslık = textbox_baslık.Text;
                kayıt.mesaj = textbox_mesaj.Text;
                kayıt.emaıl = textbox1.Text;
                db.zamanlıımesaj.InsertOnSubmit(kayıt);
                db.SubmitChanges();

                if (checkbox1.Checked == true)
                {

                    if (kayıt.tarıh==DateTime.Now.ToString())
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
                this.Hide();
            }
        }

        private void data1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kayıt.tarıh = datepicker1.Text;
            kayıt.baslık = textbox_baslık.Text;
            kayıt.mesaj = textbox_mesaj.Text;
            kayıt.emaıl = textbox1.Text;
            db.zamanlıımesaj.InsertOnSubmit(kayıt);
            db.SubmitChanges();
            if (kayıt.tarıh==DateTime.Now.ToString())
            {
                if (e.ColumnIndex == 7)
                {
                istemci.Credentials = new System.Net.NetworkCredential("burakerkemen@hotmail.com", "05414133440burak");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                textbox1.Text = data1.CurrentRow.Cells[6].Value.ToString();
                mesajım.To.Add(kayıt.emaıl.ToString());
                mesajım.From = new MailAddress("burakerkemen@hotmail.com");
                mesajım.Subject = kayıt.baslık;
                mesajım.Body = kayıt.mesaj;
                istemci.Send(mesajım);
                }
            }
           
        }

        private void textbox_ara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textbox_baslık_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
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
            SqlCommand komut = new SqlCommand("Select [mno],[ad],[soyad],[tcno],[telno],[bas_Tarıh],[bıt_tarıh],[emaıl],[ıl],[ılce],[adres] from yenıuye_db where  [mno] like '%" + textbox_ara.Text + "%'or [ad] like '%" + textbox_ara.Text + "%' OR [soyad] LIKE '%" + textbox_ara.Text + "%' OR [tcno] LIKE '%" + textbox_ara.Text + "%' OR [telno] LIKE '%" + textbox_ara.Text + "%' OR [bas_tarıh] LIKE '%" + textbox_ara.Text + "%' OR [bıt_tarıh] LIKE '%" + textbox_ara.Text + "%' OR [emaıl] LIKE '%" + textbox_ara.Text + "%' OR [ıl] LIKE '%" + textbox_ara.Text + "%' OR [ılce] LIKE '%" + textbox_ara.Text + "%' OR [adres] LIKE '%" + textbox_ara.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            data1.DataSource = ds.Tables[0];
            baglantı.Close();
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
    }
}
