using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_APP
{
    public partial class birimForm : DevExpress.XtraEditors.XtraForm
    {
        public birimForm()
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

                textBirimCode.Text = dr["BİRİM KODU"].ToString();
                comboBoxFirmaKod.SelectedItem = dr["FİRMA KODU"].ToString();
                textBirimName.Text = dr["BİRİM ADI"].ToString();
                if (dr["ANA BİRİM Mİ"].ToString() == "Evet")
                {
                    checkBoxPasif.Checked = true;
                }
                else
                {
                    checkBoxPasif.Checked = false;
                }
                textAnabirimCode.Text = dr["ANA BİRİM KODU"].ToString();


            }
        }
        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", UNITCODE AS \"BİRİM KODU\", UNITTEXT AS \"BİRİM ADI\" , CASE \r\n           WHEN ISMAINUNIT = 1 THEN 'Evet' \r\n           WHEN ISMAINUNIT = 0 THEN 'Hayır' \r\n           ELSE 'Bilinmiyor' \r\n       END AS \"ANA BİRİM Mİ\", MAINUNITCODE AS \"ANA BİRİM KODU\"    FROM BSMGRCDMGEN005;\r\n", bgl.baglanti());


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
            textBirimCode.ReadOnly = true;
            textBirimName.ReadOnly = false;
            checkBoxPasif.Enabled = true;
            textAnabirimCode.ReadOnly = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(
   "UPDATE BSMGRCDMGEN005 " +
   "SET COMCODE = @P1, " +
   "UNITCODE = @P2, " +
   "UNITTEXT = @P3, " +
   "ISMAINUNIT = @P4, " +
   "MAINUNITCODE = @P5 " +
   "WHERE UNITCODE = @P2",
   bgl.baglanti()
);

            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", textBirimCode.Text);
            komut.Parameters.AddWithValue("@P3", textBirimName.Text);
            komut.Parameters.AddWithValue("@P4", checkBoxPasif.Checked ? 1 : 0);
            komut.Parameters.AddWithValue("@P5", textAnabirimCode.Text);

            try { 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            comboBoxFirmaKod.Enabled = false;
            textBirimCode.ReadOnly = true;
            textBirimName.ReadOnly = true;
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

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;
            comboBoxFirmaKod.Enabled = true;
            textBirimCode.ReadOnly = false;
            textBirimName.ReadOnly = false;
            textAnabirimCode.ReadOnly = false;

            checkBoxPasif.Enabled = true;
            checkBoxPasif.Checked = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            textBirimCode.Text = string.Empty;
            textBirimName.Text = string.Empty;
            textAnabirimCode.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMGEN005 where UNITCODE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textBirimCode.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxFirmaKod.Enabled = false;
                textBirimCode.ReadOnly = true;
                textBirimName.ReadOnly = true;
                checkBoxPasif.Enabled = false;
                textAnabirimCode.ReadOnly = true;
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
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMGEN005 (COMCODE,UNITCODE,UNITTEXT,ISMAINUNIT,MAINUNITCODE) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", textBirimCode.Text);
            komut.Parameters.AddWithValue("@p3", textBirimName.Text);
            komut.Parameters.AddWithValue("@p4", checkBoxPasif.Checked ? 1 : 0);
            komut.Parameters.AddWithValue("@p5", textAnabirimCode.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1;
            textBirimCode.Text = string.Empty;
            textBirimName.Text = string.Empty;
            textAnabirimCode.Text = string.Empty;

            checkBoxPasif.Checked = false;

            comboBoxFirmaKod.Enabled = false;
            textBirimCode.ReadOnly = true;
            textBirimName.ReadOnly = true;
            textAnabirimCode.ReadOnly = true;
            ButtonKaydet.Visible = false;
            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void onlyViewButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlCommand komut = new SqlCommand(
                "SELECT COMCODE AS 'FİRMA KODU', UNITCODE AS 'BİRİM KODU', UNITTEXT AS 'BİRİM ADI', ISMAINUNIT AS 'ANA BİRİM Mİ', MAINUNITCODE AS 'ANA BİRİM KODU' " +
                "FROM BSMGRCDMGEN005 " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR UNITCODE LIKE '%' + @p1 + '%' OR UNITTEXT LIKE '%' + @p1 + '%' OR ISMAINUNIT LIKE '%' + @p1 + '%' OR MAINUNITCODE LIKE '%' + @p1 + '%';",
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

        private void birimForm_Load(object sender, EventArgs e)
        {
            FirmaKodComboBoxDoldur();
        }
    }
}