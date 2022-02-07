using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sgates_software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile("C:\\Users\\bfbur\\source\\repos\\sgates_software\\logo\\logo_2.jpg");
        }
        

        private void kapat_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmaya eminmisiniz.", "Uygulama Kapat", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void giris_bt_Click(object sender, EventArgs e)
        {
            login_page giris = new login_page();
            giris.Show();
            this.Hide();
        }
    }
}
