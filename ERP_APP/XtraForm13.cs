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
                comboBoxFirmaKod.SelectedItem = dr["FİRMA KODU"].ToString();
                comboBoxMalMerTip.SelectedItem = dr["MALİYET MERKEZİ TİPİ"].ToString();
                textMaliyetMerkezCode.Text = dr["MALİYET MERKEZİ KODU"].ToString();
                dateTimeBaslangic.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                dateTimeBitis.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                comboBoxDil.SelectedItem = dr["DİL KODU"].ToString();
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

        void DilComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT LANCODE FROM BSMGRCDMGEN002", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxDil.Items.Add(dr["LANCODE"].ToString());
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
            SqlCommand komut = new SqlCommand("SELECT DISTINCT CCMDOCTYPE FROM BSMGRCDMCCM001", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxMalMerTip.Items.Add(dr["CCMDOCTYPE"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void costCenterForm_Load(object sender, EventArgs e)
        {
            DilComboBoxDoldur();
            FirmaKodComboBoxDoldur();
            MaliyetMerkeziTipiComboBoxDoldur();
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
            comboBoxMalMerTip.Enabled = true;
            textMaliyetMerkezCode.Enabled = true;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            comboBoxDil.Enabled = true; //enabled
            textMalMerAcik.Enabled = true;
            textMaliyetMerUzunAcik.Enabled = true;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMCCMTEXT SET COMCODE = @P1, CCMDOCTYPE = @P2, CCMDOCNUM = @P3, CCMDOCFROM = @P4, CCMDOCUNTIL = @P5, LANCODE = @P6, CCMSTEXT = @P7, CCMLTEXT = @P8  WHERE CCMDOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", comboBoxMalMerTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P3", textMaliyetMerkezCode.Text);
            komut.Parameters.AddWithValue("@P4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P6", comboBoxDil.SelectedItem?.ToString() ?? string.Empty); //veriyi çektim
            komut.Parameters.AddWithValue("@P7", textMalMerAcik.Text);
            komut.Parameters.AddWithValue("@P8", textMaliyetMerUzunAcik.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            comboBoxFirmaKod.Enabled = false;
            comboBoxMalMerTip.Enabled = false;
            textMaliyetMerkezCode.ReadOnly = true;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
            comboBoxDil.Enabled = false;
            textMalMerAcik.ReadOnly = true;
            textMaliyetMerUzunAcik.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMCCMTEXT (COMCODE,CCMDOCTYPE,CCMDOCNUM,CCMDOCFROM,CCMDOCUNTIL,LANCODE,CCMSTEXT,CCMLTEXT) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", comboBoxMalMerTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p3", textMaliyetMerkezCode.Text);
            komut.Parameters.AddWithValue("@p4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@p5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@p6", comboBoxDil.SelectedItem?.ToString() ?? string.Empty); //veriyi çektim
            komut.Parameters.AddWithValue("@p7", textMalMerAcik.Text);
            komut.Parameters.AddWithValue("@p8", textMaliyetMerUzunAcik.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxMalMerTip.SelectedIndex = -1;
            textMaliyetMerkezCode.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            comboBoxDil.SelectedIndex = -1; //sıfırladık içini
            textMalMerAcik.Text = string.Empty;
            textMaliyetMerUzunAcik.Text = string.Empty;

            comboBoxFirmaKod.Enabled = false;
            comboBoxMalMerTip.Enabled = false;
            textMaliyetMerkezCode.Enabled = false;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
            comboBoxDil.Enabled = false;
            textMalMerAcik.Enabled = false;
            textMaliyetMerUzunAcik.Enabled = false;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaKod.Enabled = true;
            comboBoxMalMerTip.Enabled = true;
            textMaliyetMerkezCode.ReadOnly = false;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            comboBoxDil.Enabled = true;  // ReadOnly yerine Enabled olarak değiştirildi
            textMalMerAcik.ReadOnly = false;
            textMaliyetMerUzunAcik.ReadOnly = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxMalMerTip.SelectedIndex = -1;
            textMaliyetMerkezCode.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            comboBoxDil.SelectedIndex = -1; // ComboBox'ı sıfırla
            textMalMerAcik.Text = string.Empty;
            textMaliyetMerUzunAcik.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = false;

            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMCCMTEXT where CCMDOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", comboBoxMalMerTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();

                comboBoxFirmaKod.Enabled = false;
                comboBoxMalMerTip.Enabled = false;
                textMaliyetMerkezCode.ReadOnly = true;
                dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
                dateTimeBitis.Enabled = false;
                comboBoxDil.Enabled = false; // ReadOnly değil, artık kapalı.
                textMalMerAcik.ReadOnly = true;
                textMaliyetMerUzunAcik.ReadOnly = true;

                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS 'FİRMA KODU', CCMDOCTYPE AS 'MALİYET MERKEZİ TİPİ', CCMDOCNUM AS 'MALİYET MERKEZİ KODU', CCMDOCFROM AS 'GEÇERLİLİK BAŞLANGIÇ', CCMDOCUNTIL AS 'GEÇERLİLİK BİTİŞ', LANCODE AS 'DİL KODU', CCMSTEXT AS 'MALİYET MERKEZİ KISA AÇIKLAMASI', CCMLTEXT AS 'MALİYET MERKEZİ UZUN AÇIKLAMASI' " +
                "FROM BSMGRCDMCCMTEXT " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR CCMDOCTYPE LIKE '%' + @p1 + '%' OR CCMDOCNUM LIKE '%' + @p1 + '%' OR CCMDOCFROM LIKE '%' + @p1 + '%' OR CCMDOCUNTIL LIKE '%' + @p1 + '%' OR LANCODE LIKE '%' + @p1 + '%' OR CCMSTEXT LIKE '%' + @p1 + '%' OR CCMLTEXT LIKE '%' + @p1 + '%';",
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