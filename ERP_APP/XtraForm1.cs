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
using System.Data.SqlClient;
using System.Windows.Controls;
using DevExpress.DataProcessing.InMemoryDataProcessor;

namespace ERP_APP
{
    public partial class firmaForm : DevExpress.XtraEditors.XtraForm
    {
        public firmaForm()
        {
            InitializeComponent();
        }

        private void dataAddButton_Click(object sender, EventArgs e) //dataAddButton
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            textFirmaCode.ReadOnly = false;
            textFirmaInfoEdit.ReadOnly = false;
            textFirmaAdres1.ReadOnly = false;
            textFirmaAdres2.ReadOnly = false;
            textFirmaSehirKod.ReadOnly = false;
            textFirmaUlkeKod.ReadOnly = false;

            textFirmaCode.Text = string.Empty;
            textFirmaInfoEdit.Text = string.Empty;
            textFirmaAdres1.Text = string.Empty;
            textFirmaAdres2.Text = string.Empty;
            textFirmaSehirKod.Text = string.Empty;
            textFirmaUlkeKod.Text = string.Empty;
        }

        //private void labelControl1_Click(object sender, EventArgs e)
        //{

        //}

        //private void textEdit2_EditValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void firmaForm_Load(object sender, EventArgs e)
        //{
        //    listele();
        //}

        private void homePageButton_Click(object sender, EventArgs e)
        {
            mainForm xtraForm = new mainForm();

            xtraForm.Show();
            this.Hide();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", COMTEXT AS \"FİRMA ADI\", ADDRESS1 AS \"FİRMA ADRESİ-1\", ADDRESS2 AS \"FİRMA ADRESİ-2\", CITYCODE AS \"ŞEHİR KODU\", COUNTRYCODE AS \"ÜLKE KODU\" FROM BSMGRCDMGEN001;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataFirmaGrid.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                textFirmaCode.Text = dr["FİRMA KODU"].ToString();
                textFirmaInfoEdit.Text = dr["FİRMA ADI"].ToString();
                textFirmaAdres1.Text = dr["FİRMA ADRESİ-1"].ToString();
                textFirmaAdres2.Text = dr["FİRMA ADRESİ-2"].ToString();
                textFirmaSehirKod.Text = dr["ŞEHİR KODU"].ToString();
                textFirmaUlkeKod.Text = dr["ÜLKE KODU"].ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textFirmaCode.ReadOnly = false;
            textFirmaInfoEdit.ReadOnly = false;
            textFirmaAdres1.ReadOnly = false;
            textFirmaAdres2.ReadOnly = false;
            textFirmaSehirKod.ReadOnly = false;
            textFirmaUlkeKod.ReadOnly = false;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMGEN001 where COMCODE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textFirmaCode.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textFirmaInfoEdit.ReadOnly = true;
                textFirmaAdres1.ReadOnly = true;
                textFirmaAdres2.ReadOnly = true;
                textFirmaSehirKod.ReadOnly = true;
                textFirmaUlkeKod.ReadOnly = true;
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
                "SELECT COMCODE AS 'FİRMA KODU', COMTEXT AS 'FİRMA ADI', ADDRESS1 AS 'FİRMA ADRESİ-1', ADDRESS2 AS 'FİRMA ADRESİ-2', CITYCODE AS 'ŞEHİR KODU', COUNTRYCODE AS 'ÜLKE KODU'ASI'" +
                "FROM BSMGRCDMGEN001 " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR COMTEXT LIKE '%' + @p1 + '%' OR ADDRESS1 LIKE '%' + @p1 + '%' OR ADDRESS2 LIKE '%' + @p1 + '%' OR CITYCODE LIKE '%' + @p1 + '%' OR COUNTRYCODE LIKE '%' + @p1 + '%';",
                bgl.baglanti()
            ))
            {
                komut.Parameters.AddWithValue("@p1", textArat.Text);

                using (SqlDataAdapter da = new SqlDataAdapter(komut))
                {
                    da.Fill(dt);
                    dataFirmaGrid.DataSource = dt;
                }
            }
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMGEN001 SET COMCODE = @P1, COMTEXT = @P2, ADDRESS1 = @P3, ADDRESS2 = @P4, CITYCODE = @P5, COUNTRYCODE = @P6", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textFirmaInfoEdit.Text);
            komut.Parameters.AddWithValue("@P3", textFirmaAdres1.Text);
            komut.Parameters.AddWithValue("@P4", textFirmaAdres2.Text);
            komut.Parameters.AddWithValue("@P5", textFirmaSehirKod.Text);
            komut.Parameters.AddWithValue("@P6", textFirmaUlkeKod.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.ReadOnly = true;
            textFirmaInfoEdit.ReadOnly = true;
            textFirmaAdres1.ReadOnly = true;
            textFirmaAdres2.ReadOnly = true;
            textFirmaSehirKod.ReadOnly = true;
            textFirmaUlkeKod.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMGEN001 (COMCODE,COMTEXT,ADDRESS1,ADDRESS2,CITYCODE,COUNTRYCODE) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textFirmaInfoEdit.Text);
            komut.Parameters.AddWithValue("@p3", textFirmaAdres1.Text);
            komut.Parameters.AddWithValue("@p4", textFirmaAdres2.Text);
            komut.Parameters.AddWithValue("@p5", textFirmaSehirKod.Text);
            komut.Parameters.AddWithValue("@p6", textFirmaUlkeKod.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textFirmaCode.Text = string.Empty;
            textFirmaInfoEdit.Text = string.Empty;
            textFirmaAdres1.Text = string.Empty;
            textFirmaAdres2.Text = string.Empty;
            textFirmaSehirKod.Text = string.Empty;
            textFirmaUlkeKod.Text = string.Empty;

            textFirmaCode.ReadOnly = true;
            textFirmaInfoEdit.ReadOnly = true;
            textFirmaAdres1.ReadOnly = true;
            textFirmaAdres2.ReadOnly = true;
            textFirmaSehirKod.ReadOnly = true;
            textFirmaUlkeKod.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}