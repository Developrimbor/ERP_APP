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
    public partial class costCenterForm : DevExpress.XtraEditors.XtraForm
    {
        public costCenterForm()
        {
            InitializeComponent();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            mainForm xtraForm = new mainForm();

            xtraForm.Show();
            this.Hide();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                textFirmaCode.Text = dr["FİRMA KODU"].ToString();
                textMaliyetMerkTip.Text = dr["MALİYET MERKEZİ TİPİ"].ToString();
                textMaliyetMerkezCode.Text = dr["MALİYET MERKEZİ KODU"].ToString();
                textGecerlilikBas.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                textGecerlilikBit.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                textUlkeCode.Text = dr["DİL KODU"].ToString();
                textMalMerAcik.Text = dr["MALİYET MERKEZİ KISA AÇIKLAMASI"].ToString();
                textMaliyetMerUzunAcik.Text = dr["MALİYET MERKEZİ UZUN AÇIKLAMASI"].ToString();

            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", CCMDOCTYPE AS \"MALİYET MERKEZİ TİPİ\", CCMDOCNUM AS \"MALİYET MERKEZİ KODU\" , CCMDOCFROM AS \"GEÇERLİLİK BAŞLANGIÇ\" , CCMDOCUNTIL AS \"GEÇERLİLİK BİTİŞ\" , LANCODE AS \"DİL KODU\" , CCMSTEXT AS \"MALİYET MERKEZİ KISA AÇIKLAMASI\" , CCMLTEXT AS \"MALİYET MERKEZİ UZUN AÇIKLAMASI\"  FROM BSMGRCDMCCMTEXT;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textFirmaCode.ReadOnly = false;
            textMaliyetMerkTip.ReadOnly = false;
            textMaliyetMerkezCode.ReadOnly = false;
            textGecerlilikBas.ReadOnly = false;
            textGecerlilikBit.ReadOnly = false;
            textUlkeCode.ReadOnly = false;
            textMalMerAcik.ReadOnly = false;
            textMaliyetMerUzunAcik.ReadOnly = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMCCMTEXT SET COMCODE = @P1, CCMDOCTYPE = @P2, CCMDOCNUM = @P3, CCMDOCFROM = @P4, CCMDOCUNTIL = @P5, LANCODE = @P6, CCMSTEXT = @P7, CCMLTEXT = @P8  WHERE CCMDOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textMaliyetMerkTip.Text);
            komut.Parameters.AddWithValue("@P3", textMaliyetMerkezCode.Text);
            komut.Parameters.AddWithValue("@P4", textGecerlilikBas.Text);
            komut.Parameters.AddWithValue("@P5", textGecerlilikBit.Text);
            komut.Parameters.AddWithValue("@P6", textUlkeCode.Text);
            komut.Parameters.AddWithValue("@P7", textMalMerAcik.Text);
            komut.Parameters.AddWithValue("@P8", textMaliyetMerUzunAcik.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.ReadOnly = true;
            textMaliyetMerkTip.ReadOnly = true;
            textMaliyetMerkezCode.ReadOnly = true;
            textGecerlilikBas.ReadOnly = true;
            textGecerlilikBit.ReadOnly = true;
            textUlkeCode.ReadOnly = true;
            textMalMerAcik.ReadOnly = true;
            textMaliyetMerUzunAcik.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMCCMTEXT (COMCODE,CCMDOCTYPE,CCMDOCNUM,CCMDOCFROM,CCMDOCUNTIL,LANCODE,CCMSTEXT,CCMLTEXT) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textMaliyetMerkTip.Text);
            komut.Parameters.AddWithValue("@p3", textMaliyetMerkezCode.Text);
            komut.Parameters.AddWithValue("@p4", textGecerlilikBas.Text);
            komut.Parameters.AddWithValue("@p5", textGecerlilikBit.Text);
            komut.Parameters.AddWithValue("@p6", textUlkeCode.Text);
            komut.Parameters.AddWithValue("@p7", textMalMerAcik.Text);
            komut.Parameters.AddWithValue("@p8", textMaliyetMerUzunAcik.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textFirmaCode.Text = string.Empty;
            textMaliyetMerkTip.Text = string.Empty;
            textMaliyetMerkezCode.Text = string.Empty;
            textGecerlilikBas.Text = string.Empty;
            textGecerlilikBit.Text = string.Empty;
            textUlkeCode.Text = string.Empty;
            textMalMerAcik.Text = string.Empty;
            textMaliyetMerUzunAcik.Text = string.Empty;


            textFirmaCode.ReadOnly = true;
            textMaliyetMerkTip.ReadOnly = true;
            textMaliyetMerkezCode.ReadOnly = true;
            textGecerlilikBas.ReadOnly = true;
            textGecerlilikBit.ReadOnly = true;
            textUlkeCode.ReadOnly = true;
            textMalMerAcik.ReadOnly = true;
            textMaliyetMerUzunAcik.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            textFirmaCode.ReadOnly = false;
            textMaliyetMerkTip.ReadOnly = false;
            textMaliyetMerkezCode.ReadOnly = false;
            textGecerlilikBas.ReadOnly = false;
            textGecerlilikBit.ReadOnly = false;
            textUlkeCode.ReadOnly = false;
            textMalMerAcik.ReadOnly = false;
            textMaliyetMerUzunAcik.ReadOnly = false;

            textFirmaCode.Text = string.Empty;
            textMaliyetMerkTip.Text = string.Empty;
            textMaliyetMerkezCode.Text = string.Empty;
            textGecerlilikBas.Text = string.Empty;
            textGecerlilikBit.Text = string.Empty;
            textUlkeCode.Text = string.Empty;
            textMalMerAcik.Text = string.Empty;
            textMaliyetMerUzunAcik.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMCCMTEXT where CCMDOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textMaliyetMerkTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textMaliyetMerkTip.ReadOnly = true;
                textMaliyetMerkezCode.ReadOnly = true;
                textGecerlilikBas.ReadOnly = true;
                textGecerlilikBit.ReadOnly = true;
                textUlkeCode.ReadOnly = true;
                textMalMerAcik.ReadOnly = true;
                textMaliyetMerUzunAcik.ReadOnly = true;
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