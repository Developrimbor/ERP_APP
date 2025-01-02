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
    public partial class rotaYonForm : DevExpress.XtraEditors.XtraForm
    {
        public rotaYonForm()
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

                comboBoxFirmaKod.SelectedItem = dr["FİRMA KODU"].ToString();
                comboBoxUrnAgcTip.SelectedItem = dr["ÜRÜN AĞACI TİPİ"].ToString();
                textUrunAgcKod.Text = dr["ÜRÜN AĞACI KODU"].ToString();
                dateTimeBaslangic.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                dateTimeBitis.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                comboBoxMalzemeTip.SelectedItem = dr["MALZEME TİPİ"].ToString();
                textMalzemeKodu.Text = dr["MALZEME KODU"].ToString();
                textTemelMiktar.Text = dr["TEMEL MİKTAR"].ToString();
                textCizimNo.Text = dr["ÇİZİM NUMARASI"].ToString();

                if (dr["SİLİNDİ Mİ"].ToString() == "Evet")
                {
                    checkBoxSilindi.Checked = true;
                }
                else
                {
                    checkBoxSilindi.Checked = false;
                }

                if (dr["PASİF Mİ"].ToString() == "Evet")
                {
                    checkBoxPasif.Checked = true;
                }
                else
                {
                    checkBoxPasif.Checked = false;
                }

            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", ROTDOCTYPE AS \"ÜRÜN AĞACI TİPİ\", ROTDOCNUM AS \"ÜRÜN AĞACI KODU\" , ROTDOCFROM AS \"GEÇERLİLİK BAŞLANGIÇ\" , ROTDOCUNTIL AS \"GEÇERLİLİK BİTİŞ\" , MATDOCTYPE AS \"MALZEME TİPİ\" , MATDOCNUM AS \"MALZEME KODU\" , QUANTITY AS \"TEMEL MİKTAR\", CASE \r\n           WHEN ISDELETED = 1 THEN 'Evet' \r\n           WHEN ISDELETED = 0 THEN 'Hayır' \r\n           ELSE 'Bilinmiyor' \r\n       END AS \"SİLİNDİ Mİ\", \r\n       CASE \r\n           WHEN ISPASSIVE = 1 THEN 'Evet' \r\n           WHEN ISPASSIVE = 0 THEN 'Hayır' \r\n           ELSE 'Bilinmiyor' \r\n       END AS \"PASİF Mİ\", DRAWNUM AS \"ÇİZİM NUMARASI\"  FROM BSMGRCDMROTHEAD;\r\n", bgl.baglanti());
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
            comboBoxFirmaKod.Enabled = true;
            comboBoxUrnAgcTip.Enabled = true;
            textUrunAgcKod.ReadOnly = true;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            comboBoxMalzemeTip.Enabled = true;
            textMalzemeKodu.ReadOnly = false;
            textTemelMiktar.ReadOnly = false;
            textCizimNo.ReadOnly = false;
            checkBoxSilindi.Enabled = true;
            checkBoxPasif.Enabled = true;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaKod.Enabled = true;
            comboBoxUrnAgcTip.Enabled = true;
            textUrunAgcKod.ReadOnly = false;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            comboBoxMalzemeTip.Enabled = true;
            textMalzemeKodu.ReadOnly = false;
            textTemelMiktar.ReadOnly = false;
            textCizimNo.ReadOnly = false;

            // CheckBoxlar aktif hale geliyor
            checkBoxSilindi.Enabled = true;
            checkBoxPasif.Enabled = true;

            // CheckBoxların varsayılan değerlerini ayarlıyoruz
            checkBoxSilindi.Checked = false;
            checkBoxPasif.Checked = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxUrnAgcTip.SelectedIndex = -1;
            textUrunAgcKod.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            comboBoxMalzemeTip.SelectedIndex = -1;
            textMalzemeKodu.Text = string.Empty;
            textTemelMiktar.Text = string.Empty;
            textCizimNo.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMROTHEAD where ROTDOCNUM =@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textUrunAgcKod.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxFirmaKod.Enabled = false;
                comboBoxUrnAgcTip.Enabled = false;
                textUrunAgcKod.ReadOnly = true;
                dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
                dateTimeBitis.Enabled = false;
                comboBoxMalzemeTip.Enabled = false;
                textMalzemeKodu.ReadOnly = true;
                textTemelMiktar.ReadOnly = true;
                textCizimNo.ReadOnly = true;

                // CheckBox'ları devre dışı bırakıyoruz
                checkBoxSilindi.Enabled = false;
                checkBoxPasif.Enabled = false;


                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                // Kullanıcı "İptal" butonuna basarsa hiçbir işlem yapılmaz
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMROTHEAD SET COMCODE = @P1, ROTDOCTYPE = @P2, ROTDOCNUM = @P3, ROTDOCFROM = @P4, ROTDOCUNTIL = @P5, MATDOCTYPE = @P6, MATDOCNUM = @P7, QUANTITY = @P8, ISDELETED = @P9, ISPASSIVE = @P10, DRAWNUM = @P11 WHERE ROTDOCNUM = @P3", bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P1", comboBoxUrnAgcTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P3", textUrunAgcKod.Text);
            komut.Parameters.AddWithValue("@P4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P6", comboBoxMalzemeTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P7", textMalzemeKodu.Text);
            komut.Parameters.AddWithValue("@P8", Convert.ToDecimal(textTemelMiktar.Text));

            // Doğru değerler: 1 (Evet) ve 0 (Hayır) kullanılmalı
            komut.Parameters.AddWithValue("@P9", checkBoxSilindi.Checked ? 1 : 0);
            komut.Parameters.AddWithValue("@P10", checkBoxPasif.Checked ? 1 : 0);

            komut.Parameters.AddWithValue("@P11", textCizimNo.Text);

            try
            {
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // Diğer işlemler
                comboBoxFirmaKod.Enabled = false;
                comboBoxUrnAgcTip.Enabled = false;
                textUrunAgcKod.ReadOnly = true;
                dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
                dateTimeBitis.Enabled = false;
                comboBoxMalzemeTip.Enabled = false;
                textMalzemeKodu.ReadOnly = true;
                textTemelMiktar.ReadOnly = true;
                checkBoxSilindi.Checked = false;
                checkBoxPasif.Checked = false;
                textCizimNo.ReadOnly = true;

                MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ButtonGüncelle.Visible = false;
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMROTHEAD (COMCODE,ROTDOCTYPE,ROTDOCNUM,ROTDOCFROM,ROTDOCUNTIL,MATDOCTYPE,MATDOCNUM,QUANTITY,ISDELETED,ISPASSIVE,DRAWNUM) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p1", comboBoxUrnAgcTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p3", textUrunAgcKod.Text);
            komut.Parameters.AddWithValue("@p4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@p5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@p6", comboBoxMalzemeTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p7", textMalzemeKodu.Text);
            komut.Parameters.AddWithValue("@p8", textTemelMiktar.Text);
            komut.Parameters.AddWithValue("@p9", checkBoxSilindi.Checked ? 1 : 0); // ISDELETED (True -> 1, False -> 0)
            komut.Parameters.AddWithValue("@p10", checkBoxPasif.Checked ? 1 : 0); // ISPASSIVE (True -> 1, False -> 0)
            komut.Parameters.AddWithValue("@p11", textCizimNo.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxUrnAgcTip.SelectedIndex = -1;
            textUrunAgcKod.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            comboBoxMalzemeTip.SelectedIndex = -1;
            textMalzemeKodu.Text = string.Empty;
            textTemelMiktar.Text = string.Empty;
            textCizimNo.Text = string.Empty;

            // CheckBox'ları sıfırlama
            checkBoxSilindi.Checked = false;
            checkBoxPasif.Checked = false;

            comboBoxFirmaKod.Enabled = false;
            comboBoxUrnAgcTip.Enabled = false;
            textUrunAgcKod.ReadOnly = true;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
            comboBoxMalzemeTip.Enabled = false;
            textMalzemeKodu.ReadOnly = true;
            textTemelMiktar.ReadOnly = true;
            textCizimNo.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS 'FİRMA KODU', ROTDOCTYPE AS 'ÜRÜN AĞACI TİPİ', ROTDOCNUM AS 'ÜRÜN AĞACI KODU', ROTDOCFROM AS 'GEÇERLİLİK BAŞLANGIÇ', ROTDOCUNTIL AS 'GEÇERLİLİK BİTİŞ', MATDOCTYPE AS 'MALZEME TİPİ', MATDOCNUM AS 'MALZEME KODU', QUANTITY AS 'TEMEL MİKTAR', ISDELETED AS 'SİLİNDİ Mİ', ISPASSIVE AS 'PASİF Mİ', DRAWNUM AS 'ÇİZİM NUMARASI'" +
                "FROM BSMGRCDMROTHEAD " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR ROTDOCTYPE LIKE '%' + @p1 + '%' OR ROTDOCNUM LIKE '%' + @p1 + '%' OR ROTDOCFROM LIKE '%' + @p1 + '%' OR ROTDOCUNTIL LIKE '%' + @p1 + '%' OR MATDOCTYPE LIKE '%' + @p1 + '%' OR MATDOCNUM LIKE '%' + @p1 + '%' OR QUANTITY LIKE '%' + @p1 + '%' OR ISDELETED LIKE '%' + @p1 + '%' OR ISPASSIVE LIKE '%' + @p1 + '%' OR DRAWNUM LIKE '%' + @p1 + '%';",
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

        void MaliyetMerkeziTipiComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT DOCTYPE FROM BSMGRCDMBOM001", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxUrnAgcTip.Items.Add(dr["DOCTYPE"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void rotaYonForm_Load(object sender, EventArgs e)
        {
            MalzemeTipiComboBoxDoldur();
            FirmaKodComboBoxDoldur();
            MaliyetMerkeziTipiComboBoxDoldur();
        }
    }
}