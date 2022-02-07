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
    public partial class login_page : Form
    {
       
        public login_page()
        {
            InitializeComponent();
           
        }
       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lütfen "+"(123)456-7890"+" numaralı müşteri hizmetlerine ulaşınız! ");
        }

        private void giris_bt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                sifre_tb.Focus();
                
            }
        }

        private void sifre_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                giris_bt_Click(this, new EventArgs());
            }
        }

        private void giris_bt_Click(object sender, EventArgs e)
        {
            
            if (kullanıcıadı_tb.Text == "")
            {
                MessageBox.Show("Kullanıcı adı giriniz");
                return;
            }

            if (sifre_tb.Text == "")
            {
                MessageBox.Show("Lütfen şifre giriniz");
                return;
            }
            bool iseq = false;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UUUU6VV;Initial Catalog=linqotomasyon;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand(@"SELECT Kullanıcı_Adı, Sifre FROM Table_1", conn);

            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();


            while (read.Read())
            {

                string em = read["Kullanıcı_Adı"].ToString();
                string pswn = read["Sifre"].ToString();
                if (kullanıcıadı_tb.Text.Equals(em) && sifre_tb.Text.Equals(pswn))
                {
                    iseq = true;
                }

            }
            conn.Close();
            if (iseq == true)
            {
                MessageBox.Show("Giriş başarılı");
                anasayfa giris = new anasayfa();
                giris.Show();
                this.Hide();
            }
            else if (iseq == false)
            {
                MessageBox.Show("Hatalı bilgi girişi");

            }

        }

        private void kapat_bt_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstiyor musunuz?");
            Application.Exit();
        }
    }

}
