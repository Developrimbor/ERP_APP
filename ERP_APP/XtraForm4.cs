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
    public partial class sehirForm : DevExpress.XtraEditors.XtraForm
    {
        public sehirForm()
        {
            InitializeComponent();
        }

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
            SqlDataAdapter da = new SqlDataAdapter(
      "SELECT COMCODE AS 'FİRMA KODU', " +
      "CITYCODE AS 'ŞEHİR KODU', " +
      "CITYTEXT AS 'ŞEHİR ADI', " +
      "COUNTRYCODE AS 'ÜLKE KODU' " +
      "FROM BSMGRCDMGEN004;",
      bgl.baglanti()
  );

            da.Fill(dt);
            dataSehirGrid.DataSource = dt;
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

                textSehirCode.Text = dr["ŞEHİR KODU"].ToString();
                comboBoxFirmaKod.SelectedItem = dr["FİRMA KODU"].ToString();
                textSehirName.Text = dr["ŞEHİR ADI"].ToString();
                comboBoxUlkeKod.SelectedItem = dr["ÜLKE KODU"].ToString();


            }
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;
            textSehirCode.ReadOnly = false;
            comboBoxFirmaKod.Enabled = true;
            textSehirName.ReadOnly = false;
            comboBoxUlkeKod.Enabled = true;

            textSehirCode.Text = string.Empty;
            comboBoxFirmaKod.SelectedIndex = -1;
            textSehirName.Text = string.Empty;
            comboBoxUlkeKod.SelectedIndex = -1;

        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMGEN004 (COMCODE,CITYCODE,CITYTEXT,COUNTRYCODE) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", textSehirCode.Text);
            komut.Parameters.AddWithValue("@p3", textSehirName.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxUlkeKod.SelectedItem?.ToString() ?? string.Empty);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textSehirCode.Text = string.Empty;
            comboBoxFirmaKod.SelectedIndex = -1;
            textSehirName.Text = string.Empty;
            comboBoxUlkeKod.SelectedIndex = -1;
            textSehirCode.ReadOnly = true;
            comboBoxFirmaKod.Enabled = false;
            textSehirName.ReadOnly = true;
            comboBoxUlkeKod.Enabled = false;
            ButtonKaydet.Visible = false;
            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMGEN004 SET COMCODE = @P1, CITYCODE = @P2, CITYTEXT = @P3, COUNTRYCODE =@P4  WHERE CITYCODE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", textSehirCode.Text);
            komut.Parameters.AddWithValue("@p3", textSehirName.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxUlkeKod.SelectedItem?.ToString() ?? string.Empty);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textSehirCode.ReadOnly = true;
            comboBoxFirmaKod.Enabled = false;
            textSehirName.ReadOnly = true;
            comboBoxUlkeKod.Enabled = false;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMGEN004 where CITYCODE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textSehirCode.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textSehirCode.ReadOnly = true;
                comboBoxFirmaKod.Enabled = false;
                textSehirName.ReadOnly = true;
                comboBoxUlkeKod.Enabled = false;
                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                // Kullanıcı "İptal" butonuna basarsa hiçbir işlem yapılmaz
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textSehirCode.ReadOnly = true;
            comboBoxFirmaKod.Enabled = true;
            textSehirName.ReadOnly = false;
            comboBoxUlkeKod.Enabled = true;
        }

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS 'FİRMA KODU', CITYCODE AS 'ŞEHİR KODU', CITYTEXT AS 'ŞEHİR ADI', COUNTRYCODE AS 'ÜLKE KODU' " +
                "FROM BSMGRCDMGEN004 " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR CITYCODE LIKE '%' + @p1 + '%' OR CITYTEXT LIKE '%' + @p1 + '%' OR COUNTRYCODE LIKE '%' + @p1 + '%';",
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

        void UlkeKodComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT COUNTRYCODE FROM BSMGRCDMGEN003", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxUlkeKod.Items.Add(dr["COUNTRYCODE"].ToString());
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

        private void sehirForm_Load(object sender, EventArgs e)
        {
            UlkeKodComboBoxDoldur();
            FirmaKodComboBoxDoldur();
        }
    }
}
