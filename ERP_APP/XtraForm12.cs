using DevExpress.DataProcessing.InMemoryDataProcessor;
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

                comboBoxFirmaKod.SelectedItem = dr["FİRMA KODU"].ToString();
                comboBoxMalzemeTip.SelectedItem = dr["MALZEME TİPİ"].ToString();
                textMalzKodu.Text = dr["MALZEME KODU"].ToString();
                dateTimeBaslangic.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                dateTimeBitis.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
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
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", comboBoxMalzemeTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P3", textMalzKodu.Text);
            komut.Parameters.AddWithValue("@P4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P6", textDilKodu.Text);
            komut.Parameters.AddWithValue("@P7", textMalzKısaAck.Text);
            komut.Parameters.AddWithValue("@P8", textUzunAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            comboBoxFirmaKod.Enabled = false;
            comboBoxMalzemeTip.Enabled = false;
            textMalzKodu.ReadOnly = true;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
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
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", comboBoxMalzemeTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p3", textMalzKodu.Text);


            komut.Parameters.AddWithValue("@p4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@p5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));

            komut.Parameters.AddWithValue("@p6", textDilKodu.Text);
            komut.Parameters.AddWithValue("@p7", textMalzKısaAck.Text);
            komut.Parameters.AddWithValue("@p8", textUzunAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxMalzemeTip.SelectedIndex = -1;
            textMalzKodu.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            textDilKodu.Text = string.Empty;
            textMalzKısaAck.Text = string.Empty;
            textUzunAck.Text = string.Empty;

            comboBoxFirmaKod.Enabled = false;
            comboBoxMalzemeTip.Enabled = false;
            textMalzKodu.ReadOnly = true;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
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
            comboBoxFirmaKod.Enabled = true;
            comboBoxMalzemeTip.Enabled = true;
            textMalzKodu.ReadOnly = false;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            textDilKodu.ReadOnly = false;
            textMalzKısaAck.ReadOnly = false;
            textUzunAck.ReadOnly = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaKod.Enabled = true;
            comboBoxMalzemeTip.Enabled = true;
            textMalzKodu.ReadOnly = false;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            textDilKodu.ReadOnly = false;
            textMalzKısaAck.ReadOnly = false;
            textUzunAck.ReadOnly = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxMalzemeTip.SelectedIndex = -1;
            textMalzKodu.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
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
                komutsil.Parameters.AddWithValue("@p1", comboBoxMalzemeTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxFirmaKod.Enabled = false;
                comboBoxMalzemeTip.Enabled = false;
                textMalzKodu.ReadOnly = true;
                dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
                dateTimeBitis.Enabled = false;
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

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS 'FİRMA KODU', MATDOCTYPE AS 'MALZEME TİPİ', MATDOCNUM AS 'MALZEME KODU', MATDOCFROM AS 'GEÇERLİLİK BAŞLANGIÇ', MATDOCUNTIL AS 'GEÇERLİLİK BİTİŞ', LANCODE AS 'DİL KODU', MATSTEXT AS 'MALZEME KISA AÇIKLAMASI', MATLTEXT AS 'MALZEME UZUN AÇIKLAMASI' " +
                "FROM BSMGRCDMMATTEXT " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR MATDOCTYPE LIKE '%' + @p1 + '%' OR MATDOCNUM LIKE '%' + @p1 + '%' OR MATDOCFROM LIKE '%' + @p1 + '%' OR MATDOCUNTIL LIKE '%' + @p1 + '%' OR LANCODE LIKE '%' + @p1 + '%' OR MATSTEXT LIKE '%' + @p1 + '%' OR MATLTEXT LIKE '%' + @p1 + '%';",
                bgl.baglanti()
            ))
            {
                komut.Parameters.AddWithValue("@p1", textArat.Text);

                using (SqlDataAdapter da = new SqlDataAdapter(komut))
                {
                    da.Fill(dt);
                    dataGrid.DataSource = dt;
                }
            }
        }

        private void dateTimeBitis_ValueChanged(object sender, EventArgs e)
        {

        }

        void FirmaKodComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT COMCODE FROM BSMGRCDMGEN001", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxFirmaKod.Items.Add(dr["COMCODE"].ToString());
            }
            bgl.baglanti().Close();
        }

        void MalzemeTipiComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT DOCTYPE FROM BSMGRCDMMAT001", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxMalzemeTip.Items.Add(dr["DOCTYPE"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void matInfoForm_Load(object sender, EventArgs e)
        {
            FirmaKodComboBoxDoldur();
            MalzemeTipiComboBoxDoldur();
        }
    }
}