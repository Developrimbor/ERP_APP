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

                textFirmaCode.Text = dr["FİRMA KODU"].ToString();
                textUrunAgcTip.Text = dr["ÜRÜN AĞACI TİPİ"].ToString();
                textUrunAgcKod.Text = dr["ÜRÜN AĞACI KODU"].ToString();
                textGecBas.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                textGecBit.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                textMalzemeTip.Text = dr["MALZEME TİPİ"].ToString();
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
            textFirmaCode.ReadOnly = false;
            textUrunAgcTip.ReadOnly = false;
            textUrunAgcKod.ReadOnly = false;
            textGecBas.ReadOnly = false;
            textGecBit.ReadOnly = false;
            textMalzemeTip.ReadOnly = false;
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

            textFirmaCode.ReadOnly = false;
            textUrunAgcTip.ReadOnly = false;
            textUrunAgcKod.ReadOnly = false;
            textGecBas.ReadOnly = false;
            textGecBit.ReadOnly = false;
            textMalzemeTip.ReadOnly = false;
            textMalzemeKodu.ReadOnly = false;
            textTemelMiktar.ReadOnly = false;
            textCizimNo.ReadOnly = false;

            // CheckBoxlar aktif hale geliyor
            checkBoxSilindi.Enabled = true;
            checkBoxPasif.Enabled = true;

            // CheckBoxların varsayılan değerlerini ayarlıyoruz
            checkBoxSilindi.Checked = false;
            checkBoxPasif.Checked = false;

            textFirmaCode.Text = string.Empty;
            textUrunAgcTip.Text = string.Empty;
            textUrunAgcKod.Text = string.Empty;
            textGecBas.Text = string.Empty;
            textGecBit.Text = string.Empty;
            textMalzemeTip.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMROTHEAD where ROTDOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textUrunAgcTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textUrunAgcTip.ReadOnly = true;
                textUrunAgcKod.ReadOnly = true;
                textGecBas.ReadOnly = true;
                textGecBit.ReadOnly = true;
                textMalzemeTip.ReadOnly = true;
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
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMROTHEAD SET COMCODE = @P1, ROTDOCTYPE = @P2, ROTDOCNUM = @P3, ROTDOCFROM = @P4, ROTDOCUNTIL = @P5, MATDOCTYPE = @P6, MATDOCNUM = @P7, QUANTITY = @P8, ISDELETED = @P9, ISPASSIVE = @P10, DRAWNUM = @P11 WHERE ROTDOCTYPE = @P2", bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textUrunAgcTip.Text);
            komut.Parameters.AddWithValue("@P3", textUrunAgcKod.Text);
            komut.Parameters.AddWithValue("@P4", textGecBas.Text);
            komut.Parameters.AddWithValue("@P5", textGecBit.Text);
            komut.Parameters.AddWithValue("@P6", textMalzemeTip.Text);
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
                textFirmaCode.ReadOnly = true;
                textUrunAgcTip.ReadOnly = true;
                textUrunAgcKod.ReadOnly = true;
                textGecBas.ReadOnly = true;
                textGecBit.ReadOnly = true;
                textMalzemeTip.ReadOnly = true;
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
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textUrunAgcTip.Text);
            komut.Parameters.AddWithValue("@p3", textUrunAgcKod.Text);
            komut.Parameters.AddWithValue("@p4", textGecBas.Text);
            komut.Parameters.AddWithValue("@p5", textGecBit.Text);
            komut.Parameters.AddWithValue("@p6", textMalzemeTip.Text);
            komut.Parameters.AddWithValue("@p7", textMalzemeKodu.Text);
            komut.Parameters.AddWithValue("@p8", textTemelMiktar.Text);
            komut.Parameters.AddWithValue("@p9", checkBoxSilindi.Checked ? 1 : 0); // ISDELETED (True -> 1, False -> 0)
            komut.Parameters.AddWithValue("@p10", checkBoxPasif.Checked ? 1 : 0); // ISPASSIVE (True -> 1, False -> 0)
            komut.Parameters.AddWithValue("@p11", textCizimNo.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textFirmaCode.Text = string.Empty;
            textUrunAgcTip.Text = string.Empty;
            textUrunAgcKod.Text = string.Empty;
            textGecBas.Text = string.Empty;
            textGecBit.Text = string.Empty;
            textMalzemeTip.Text = string.Empty;
            textMalzemeKodu.Text = string.Empty;
            textTemelMiktar.Text = string.Empty;
            textCizimNo.Text = string.Empty;

            // CheckBox'ları sıfırlama
            checkBoxSilindi.Checked = false;
            checkBoxPasif.Checked = false;

            textFirmaCode.ReadOnly = true;
            textUrunAgcTip.ReadOnly = true;
            textUrunAgcKod.ReadOnly = true;
            textGecBas.ReadOnly = true;
            textGecBit.ReadOnly = true;
            textMalzemeTip.ReadOnly = true;
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
    }
}