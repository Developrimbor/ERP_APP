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
    public partial class workCenterForm : DevExpress.XtraEditors.XtraForm
    {
        public workCenterForm()
        {
            InitializeComponent();
        }

        private void workCenterForm_Load(object sender, EventArgs e)
        {

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
                textIsMerTip.Text = dr["İŞ MERKEZİ TİPİ"].ToString();
                textIsMerKod.Text = dr["İŞ MERKEZİ KODU"].ToString();
                textGecBas.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                textGecBit.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                textDilKod.Text = dr["DİL KODU"].ToString();
                textIsMerKısaAck.Text = dr["İŞ MERKEZİ KISA AÇIKLAMASI"].ToString();
                textIsMerUznAck.Text = dr["İŞ MERKEZİ UZUN AÇIKLAMASI"].ToString();
            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", WCMDOCTYPE AS \"İŞ MERKEZİ TİPİ\", WCMDOCNUM AS \"İŞ MERKEZİ KODU\" , WCMDOCFROM AS \"GEÇERLİLİK BAŞLANGIÇ\", WCMDOCUNTIL AS \"GEÇERLİLİK BİTİŞ\", LANCODE AS \"DİL KODU\", WCMSTEXT AS \"İŞ MERKEZİ KISA AÇIKLAMASI\", WCMLTEXT AS \"İŞ MERKEZİ UZUN AÇIKLAMASI\"  FROM BSMGRCDMWCMTEXT;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMWCMTEXT SET COMCODE = @P1, WCMDOCTYPE = @P2, WCMDOCNUM = @P3, WCMDOCFROM = @P4, WCMDOCUNTIL = @P5, LANCODE = @P6, WCMSTEXT = @P7, WCMLTEXT = @P8 WHERE WCMDOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textIsMerTip.Text);
            komut.Parameters.AddWithValue("@P3", textIsMerKod.Text);
            komut.Parameters.AddWithValue("@P4", textGecBas.Text);
            komut.Parameters.AddWithValue("@P5", textGecBit.Text);
            komut.Parameters.AddWithValue("@P6", textDilKod.Text);
            komut.Parameters.AddWithValue("@P7", textIsMerKısaAck.Text);
            komut.Parameters.AddWithValue("@P8", textIsMerUznAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.ReadOnly = true;
            textIsMerTip.ReadOnly = true;
            textIsMerKod.ReadOnly = true;
            textGecBas.ReadOnly = true;
            textGecBit.ReadOnly = true;
            textDilKod.ReadOnly = true;
            textIsMerKısaAck.ReadOnly = true;
            textIsMerUznAck.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMWCMTEXT (COMCODE,WCMDOCTYPE,WCMDOCNUM,WCMDOCFROM,WCMDOCUNTIL,LANCODE,WCMSTEXT,WCMLTEXT) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textIsMerTip.Text);
            komut.Parameters.AddWithValue("@p3", textIsMerKod.Text);
            komut.Parameters.AddWithValue("@p4", textGecBas.Text);
            komut.Parameters.AddWithValue("@p5", textGecBit.Text);
            komut.Parameters.AddWithValue("@p6", textDilKod.Text);
            komut.Parameters.AddWithValue("@p7", textIsMerKısaAck.Text);
            komut.Parameters.AddWithValue("@p8", textIsMerUznAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textFirmaCode.Text = string.Empty;
            textIsMerTip.Text = string.Empty;
            textIsMerKod.Text = string.Empty;
            textGecBas.Text = string.Empty;
            textGecBit.Text = string.Empty;
            textDilKod.Text = string.Empty;
            textIsMerKısaAck.Text = string.Empty;
            textIsMerUznAck.Text = string.Empty;

            textFirmaCode.ReadOnly = true;
            textIsMerTip.ReadOnly = true;
            textIsMerKod.ReadOnly = true;
            textGecBas.ReadOnly = true;
            textGecBit.ReadOnly = true;
            textDilKod.ReadOnly = true;
            textIsMerKısaAck.ReadOnly = true;
            textIsMerUznAck.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textFirmaCode.ReadOnly = false;
            textIsMerTip.ReadOnly = false;
            textIsMerKod.ReadOnly = false;
            textGecBas.ReadOnly = false;
            textGecBit.ReadOnly = false;
            textDilKod.ReadOnly = false;
            textIsMerKısaAck.ReadOnly = false;
            textIsMerUznAck.ReadOnly = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            textFirmaCode.ReadOnly = false;
            textIsMerTip.ReadOnly = false;
            textIsMerKod.ReadOnly = false;
            textGecBas.ReadOnly = false;
            textGecBit.ReadOnly = false;
            textDilKod.ReadOnly = false;
            textIsMerKısaAck.ReadOnly = false;
            textIsMerUznAck.ReadOnly = false;

            textFirmaCode.Text = string.Empty;
            textIsMerTip.Text = string.Empty;
            textIsMerKod.Text = string.Empty;
            textGecBas.Text = string.Empty;
            textGecBit.Text = string.Empty;
            textDilKod.Text = string.Empty;
            textIsMerKısaAck.Text = string.Empty;
            textIsMerUznAck.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMWCMTEXT where WCMDOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textIsMerTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textIsMerTip.ReadOnly = true;
                textIsMerKod.ReadOnly = true;
                textGecBas.ReadOnly = true;
                textGecBit.ReadOnly = true;
                textDilKod.ReadOnly = true;
                textIsMerKısaAck.ReadOnly = true;
                textIsMerUznAck.ReadOnly = true;
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