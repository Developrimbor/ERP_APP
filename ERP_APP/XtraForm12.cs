using DevExpress.XtraEditors;
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

namespace ERP_APP
{
    public partial class matInfoForm : DevExpress.XtraEditors.XtraForm
    {
        public matInfoForm()
        {
            InitializeComponent();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            mainForm xtraForm = new mainForm();

            xtraForm.Show();
            this.Hide();
        }

        private void gridMalzemeBilgi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridMalzemeBilgi.GetDataRow(gridMalzemeBilgi.FocusedRowHandle);
            if (dr != null)
            {

                textFirmaCode.Text = dr["FİRMA KODU"].ToString();
                textMalzTipi.Text = dr["MALZEME TİPİ"].ToString();
                textMalzKodu.Text = dr["MALZEME KODU"].ToString();
                textGecBas.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                textGecBit.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                textDilKodu.Text = dr["DİL KODU"].ToString();
                textMalzKısaAck.Text = dr["MALZEME KISA AÇIKLAMASI"].ToString();
                textUzunAck.Text = dr["MALZEME UZUN AÇIKLAMASI"].ToString();
            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", MATDOCTYPE AS \"MALZEME TİPİ\", MATDOCNUM AS \"MALZEME KODU\" , MATDOCFROM AS \"GEÇERLİLİK BAŞLANGIÇ\", MATDOCUNTIL AS \"GEÇERLİLİK BİTİŞ\", LANCODE AS \"DİL KODU\", MATSTEXT AS \"MALZEME KISA AÇIKLAMASI\", MATLTEXT AS \"MALZEME UZUN AÇIKLAMASI\"  FROM BSMGRCDMMATTEXT;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMMATTEXT SET COMCODE = @P1, MATDOCTYPE = @P2, MATDOCNUM = @P3, MATDOCFROM = @P4, MATDOCUNTIL = @P5, LANCODE = @P6, MATSTEXT = @P7, MATLTEXT = @P8 WHERE MATDOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textMalzTipi.Text);
            komut.Parameters.AddWithValue("@P3", textMalzKodu.Text);
            komut.Parameters.AddWithValue("@P4", textGecBas.Text);
            komut.Parameters.AddWithValue("@P5", textGecBit.Text);
            komut.Parameters.AddWithValue("@P6", textDilKodu.Text);
            komut.Parameters.AddWithValue("@P7", textMalzKısaAck.Text);
            komut.Parameters.AddWithValue("@P8", textUzunAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.ReadOnly = true;
            textMalzTipi.ReadOnly = true;
            textMalzKodu.ReadOnly = true;
            textGecBas.ReadOnly = true;
            textGecBit.ReadOnly = true;
            textDilKodu.ReadOnly = true;
            textMalzKısaAck.ReadOnly = true;
            textUzunAck.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMMATTEXT (COMCODE,MATDOCTYPE,MATDOCNUM,MATDOCFROM,MATDOCUNTIL,LANCODE,MATSTEXT,MATLTEXT) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textMalzTipi.Text);
            komut.Parameters.AddWithValue("@p3", textMalzKodu.Text);
            komut.Parameters.AddWithValue("@p4", textGecBas.Text);
            komut.Parameters.AddWithValue("@p5", textGecBit.Text);
            komut.Parameters.AddWithValue("@p6", textDilKodu.Text);
            komut.Parameters.AddWithValue("@p7", textMalzKısaAck.Text);
            komut.Parameters.AddWithValue("@p8", textUzunAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textFirmaCode.Text = string.Empty;
            textMalzTipi.Text = string.Empty;
            textMalzKodu.Text = string.Empty;
            textGecBas.Text = string.Empty;
            textGecBit.Text = string.Empty;
            textDilKodu.Text = string.Empty;
            textMalzKısaAck.Text = string.Empty;
            textUzunAck.Text = string.Empty;

            textFirmaCode.ReadOnly = true;
            textMalzTipi.ReadOnly = true;
            textMalzKodu.ReadOnly = true;
            textGecBas.ReadOnly = true;
            textGecBit.ReadOnly = true;
            textDilKodu.ReadOnly = true;
            textMalzKısaAck.ReadOnly = true;
            textUzunAck.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textFirmaCode.ReadOnly = false;
            textMalzTipi.ReadOnly = false;
            textMalzKodu.ReadOnly = false;
            textGecBas.ReadOnly = false;
            textGecBit.ReadOnly = false;
            textDilKodu.ReadOnly = false;
            textMalzKısaAck.ReadOnly = false;
            textUzunAck.ReadOnly = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            textFirmaCode.ReadOnly = false;
            textMalzTipi.ReadOnly = false;
            textMalzKodu.ReadOnly = false;
            textGecBas.ReadOnly = false;
            textGecBit.ReadOnly = false;
            textDilKodu.ReadOnly = false;
            textMalzKısaAck.ReadOnly = false;
            textUzunAck.ReadOnly = false;

            textFirmaCode.Text = string.Empty;
            textMalzTipi.Text = string.Empty;
            textMalzKodu.Text = string.Empty;
            textGecBas.Text = string.Empty;
            textGecBit.Text = string.Empty;
            textDilKodu.Text = string.Empty;
            textMalzKısaAck.Text = string.Empty;
            textUzunAck.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = false;
            // Soru sorma MessageBox
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // SQL komutunu çalıştırma
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMMATTEXT where MATDOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textMalzTipi.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textMalzTipi.ReadOnly = true;
                textMalzKodu.ReadOnly = true;
                textGecBas.ReadOnly = true;
                textGecBit.ReadOnly = true;
                textDilKodu.ReadOnly = true;
                textMalzKısaAck.ReadOnly = true;
                textUzunAck.ReadOnly = true;
                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                // Kullanıcı "İptal" butonuna basarsa hiçbir işlem yapılmaz
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}