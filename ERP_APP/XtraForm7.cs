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
    public partial class malMerForm : DevExpress.XtraEditors.XtraForm
    {
        public malMerForm()
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
                textMalMerkTip.Text = dr["MALZEME TİPİ"].ToString();
                textMalMerTipAck.Text = dr["MALZEME TİPİ AÇIKLAMASI"].ToString();
                textIspassive.Text = dr["PASİF Mİ"].ToString();

            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", DOCTYPE AS \"MALZEME TİPİ\", DOCTYPETEXT AS \"MALZEME TİPİ AÇIKLAMASI\", ISPASSIVE AS \"PASİF Mİ\" FROM BSMGRCDMCCM001;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataMaliyetMerkezi.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMCCM001 SET COMCODE = @P1, DOCTYPE = @P2, DOCTYPETEXT = @P3, ISPASSIVE = @P4 WHERE DOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textMalMerkTip.Text);
            komut.Parameters.AddWithValue("@P3", textMalMerTipAck.Text);
            komut.Parameters.AddWithValue("@P4", textIspassive.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.ReadOnly = true;
            textMalMerkTip.ReadOnly = true;
            textMalMerTipAck.ReadOnly = true;
            textIspassive.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textFirmaCode.ReadOnly = false;
            textMalMerkTip.ReadOnly = false;
            textMalMerTipAck.ReadOnly = false;
            textIspassive.ReadOnly = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;
            textFirmaCode.ReadOnly = false;
            textMalMerkTip.ReadOnly = false;
            textMalMerTipAck.ReadOnly = false;
            textIspassive.ReadOnly = false;
            textFirmaCode.Text = string.Empty;
            textMalMerkTip.Text = string.Empty;
            textMalMerTipAck.Text = string.Empty;
            textIspassive.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMCCM001 where DOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textMalMerkTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textMalMerkTip.ReadOnly = true;
                textMalMerTipAck.ReadOnly = true;
                textIspassive.ReadOnly = true;
                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                // Kullanıcı "İptal" butonuna basarsa hiçbir işlem yapılmaz
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMCCM001 (COMCODE,DOCTYPE,DOCTYPETEXT,ISPASSIVE) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textMalMerkTip.Text);
            komut.Parameters.AddWithValue("@p3", textMalMerTipAck.Text);
            komut.Parameters.AddWithValue("@p4", textIspassive.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.Text = string.Empty;
            textMalMerkTip.Text = string.Empty;
            textMalMerTipAck.Text = string.Empty;
            textIspassive.Text = string.Empty;
            textFirmaCode.ReadOnly = true;
            textMalMerkTip.ReadOnly = true;
            textMalMerTipAck.ReadOnly = true;
            textIspassive.ReadOnly = true;
            ButtonKaydet.Visible = false;
            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS \"FİRMA KODU\", DOCTYPE AS \"MALZEME TİPİ\", DOCTYPETEXT AS \"MALZEME TİPİ AÇIKLAMASI\", ISPASSIVE AS \"PASİF Mİ\" FROM BSMGRCDMCCM001\r\n" +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR DOCTYPE LIKE '%' + @p1 + '%' OR DOCTYPETEXT LIKE '%' + @p1 + '%' ;",
                bgl.baglanti()
            ))
            {
                komut.Parameters.AddWithValue("@p1", textArat.Text);

                using (SqlDataAdapter da = new SqlDataAdapter(komut))
                {
                    da.Fill(dt);
                    dataMaliyetMerkezi.DataSource = dt;
                }
            }
        }
    }
}