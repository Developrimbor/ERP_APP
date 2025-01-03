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
    public partial class urunAgaciForm : DevExpress.XtraEditors.XtraForm
    {
        public urunAgaciForm()
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
                textUrnAgcTip.Text = dr["ÜRÜN AĞACI TİPİ"].ToString();
                textUrnAgcTipAck.Text = dr["ÜRÜN AĞACI TİPİ AÇIKLAMASI"].ToString();
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", DOCTYPE AS \"ÜRÜN AĞACI TİPİ\", DOCTYPETEXT AS \"ÜRÜN AĞACI TİPİ AÇIKLAMASI\" , CASE \r\n           WHEN ISPASSIVE = 1 THEN 'Evet' \r\n           WHEN ISPASSIVE = 0 THEN 'Hayır' \r\n           ELSE 'Bilinmiyor' \r\n       END AS \"PASİF Mİ\"   FROM BSMGRCDMBOM001;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataSehirGrid.DataSource = dt;
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
            textUrnAgcTip.ReadOnly = true;
            textUrnAgcTipAck.ReadOnly = false;
            checkBoxPasif.Enabled = true;

        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMBOM001 SET COMCODE = @P1, DOCTYPE = @P2, DOCTYPETEXT = @P3, ISPASSIVE = @P4 WHERE DOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", textUrnAgcTip.Text);
            komut.Parameters.AddWithValue("@P3", textUrnAgcTipAck.Text);
            komut.Parameters.AddWithValue("@P4", checkBoxPasif.Checked ? 1 : 0);

            try { 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            comboBoxFirmaKod.Enabled = false;
            textUrnAgcTip.ReadOnly = true;
            textUrnAgcTipAck.ReadOnly = true;
            checkBoxPasif.Checked = false;

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
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMBOM001 (COMCODE,DOCTYPE,DOCTYPETEXT,ISPASSIVE) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", textUrnAgcTip.Text);
            komut.Parameters.AddWithValue("@p3", textUrnAgcTipAck.Text);
            komut.Parameters.AddWithValue("@p4", checkBoxPasif.Checked ? 1 : 0); // ISPASSIVE (True -> 1, False -> 0)


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1; ;
            textUrnAgcTip.Text = string.Empty;
            textUrnAgcTipAck.Text = string.Empty;
            checkBoxPasif.Checked = false;

            comboBoxFirmaKod.Enabled = false;
            textUrnAgcTip.ReadOnly = true;
            textUrnAgcTipAck.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaKod.Enabled = true;
            textUrnAgcTip.ReadOnly = false;
            textUrnAgcTipAck.ReadOnly = false;

            checkBoxPasif.Enabled = true;
            checkBoxPasif.Checked = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            textUrnAgcTip.Text = string.Empty;
            textUrnAgcTipAck.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMBOM001 where DOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textUrnAgcTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxFirmaKod.Enabled = false;
                textUrnAgcTip.ReadOnly = true;
                textUrnAgcTipAck.ReadOnly = true;
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

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS \"FİRMA KODU\", DOCTYPE AS \"ÜRÜN AĞACI TİPİ\", DOCTYPETEXT AS \"ÜRÜN AĞACI TİPİ AÇIKLAMASI\" , ISPASSIVE AS \"PASİF Mİ\"   FROM BSMGRCDMBOM001\r\n" +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR DOCTYPE LIKE '%' + @p1 + '%' OR DOCTYPETEXT LIKE '%' + @p1 + '%' ;",
                bgl.baglanti()
            ))
            {
                komut.Parameters.AddWithValue("@p1", textArat.Text);

                using (SqlDataAdapter da = new SqlDataAdapter(komut))
                {
                    da.Fill(dt);
                    dataSehirGrid.DataSource = dt;
                }
            }
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

        private void urunAgaciForm_Load(object sender, EventArgs e)
        {
            FirmaKodComboBoxDoldur();
        }
    }
}