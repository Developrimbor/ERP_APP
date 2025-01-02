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
    public partial class ulkeForm : DevExpress.XtraEditors.XtraForm
    {
        public ulkeForm()
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", COUNTRYCODE AS \"ÜLKE KODU\", COUNTRYTEXT AS \"ÜLKE ADI\" FROM BSMGRCDMGEN003;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataUlkeGrid.DataSource = dt;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaCode.Enabled = true;
            textUlkeCode.ReadOnly = false;
            textDilName.ReadOnly = false;

            comboBoxFirmaCode.SelectedIndex = -1;
            textUlkeCode.Text = string.Empty;
            textDilName.Text = string.Empty;
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMGEN003 (COMCODE,COUNTRYCODE,COUNTRYTEXT) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaCode?.Text ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", textUlkeCode.Text);
            komut.Parameters.AddWithValue("@p3", textDilName.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaCode.SelectedIndex = -1;
            comboBoxFirmaCode.Enabled = false;
            textUlkeCode.Text = string.Empty;
            textDilName.Text = string.Empty;
            ButtonKaydet.Visible = false;
            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            comboBoxFirmaCode.Enabled = true;
            textUlkeCode.ReadOnly = true;
            textDilName.ReadOnly = false;

        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMGEN003 SET COMCODE = @P1, COUNTRYCODE = @P2, COUNTRYTEXT = @P3 WHERE COUNTRYCODE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaCode.Text ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", textUlkeCode.Text);
            komut.Parameters.AddWithValue("@P3", textDilName.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
             
            comboBoxFirmaCode.Enabled = false;
            textUlkeCode.ReadOnly = true;
            textDilName.ReadOnly = true;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMGEN003 where COUNTRYCODE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textUlkeCode.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxFirmaCode.Enabled = false;
                textUlkeCode.ReadOnly = true;
                textDilName.ReadOnly = true;
                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                // Kullanıcı "İptal" butonuna basarsa hiçbir işlem yapılmaz
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                comboBoxFirmaCode.SelectedItem = dr["FİRMA KODU"].ToString();
                textUlkeCode.Text = dr["ÜLKE KODU"].ToString();
                textDilName.Text = dr["ÜLKE ADI"].ToString();

            }
        }

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS 'FİRMA KODU', COUNTRYCODE AS 'ÜLKE KODU', COUNTRYTEXT AS 'ÜLKE ADI' " +
                "FROM BSMGRCDMGEN003 " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR COUNTRYCODE LIKE '%' + @p1 + '%' OR COUNTRYTEXT LIKE '%' + @p1 + '%';",
                bgl.baglanti()
            ))
            {
                komut.Parameters.AddWithValue("@p1", textArat.Text);

                using (SqlDataAdapter da = new SqlDataAdapter(komut))
                {
                    da.Fill(dt);
                    dataUlkeGrid.DataSource = dt;
                }
            }
        }

        void FirmaCodeComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT COMCODE FROM BSMGRCDMGEN001", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxFirmaCode.Items.Add(dr["COMCODE"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void ulkeForm_Load(object sender, EventArgs e)
        {
            FirmaCodeComboBoxDoldur();
        }
    }
}
