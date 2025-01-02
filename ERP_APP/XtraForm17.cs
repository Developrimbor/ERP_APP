using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_APP
{
    public partial class XtraForm17 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm17()
        {
            InitializeComponent();
        }

       
            private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre kontrolü
            string username = textusername.Text;
            string password = textsifre.Text;

            if (username == "admin" && password == "1234")
            {
                // Yeni formu yükle
                mainForm xtraForm17 = new mainForm();
                xtraForm17.Show();
                this.Hide(); ;

                
            }
            else
            {
                // Uyarı mesajı göster
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
