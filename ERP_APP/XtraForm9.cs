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
using System.Windows.Controls;
using System.Windows.Forms;

namespace ERP_APP
{
    public partial class rotaTypeForm : DevExpress.XtraEditors.XtraForm
    {
        public rotaTypeForm()
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
                textRotaTip.Text = dr["ROTA TİPİ"].ToString();
                textRotaTipAck.Text = dr["ROTA TİPİ AÇIKLAMASI"].ToString();
                textIsPassive.Text = dr["PASİF Mİ"].ToString();
            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", DOCTYPE AS \"ROTA TİPİ\", DOCTYPETEXT AS \"ROTA TİPİ AÇIKLAMASI\" , ISPASSIVE AS \"PASİF Mİ\"   FROM BSMGRCDMROT001;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataSehirGrid.DataSource = dt;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMROT001 SET COMCODE = @P1, DOCTYPE = @P2, DOCTYPETEXT = @P3, ISPASSIVE = @P4 WHERE DOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", textRotaTip.Text);
            komut.Parameters.AddWithValue("@P3", textRotaTipAck.Text);
            komut.Parameters.AddWithValue("@P4", textIsPassive.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            comboBoxFirmaKod.Enabled = false;
            textRotaTip.ReadOnly = true;
            textRotaTipAck.ReadOnly = true;
            textIsPassive.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible = false;
            listele();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMROT001 (COMCODE,DOCTYPE,DOCTYPETEXT,ISPASSIVE) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p2", textRotaTip.Text);
            komut.Parameters.AddWithValue("@p3", textRotaTipAck.Text);
            komut.Parameters.AddWithValue("@p4", textIsPassive.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1;
            textRotaTip.Text = string.Empty;
            textRotaTipAck.Text = string.Empty;
            textIsPassive.Text = string.Empty;

            comboBoxFirmaKod.Enabled = false;
            textRotaTip.ReadOnly = true;
            textRotaTipAck.ReadOnly = true;
            textIsPassive.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            comboBoxFirmaKod.Enabled = true;
            textRotaTip.ReadOnly = false;
            textRotaTipAck.ReadOnly = false;
            textIsPassive.ReadOnly = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaKod.Enabled = true;
            textRotaTip.ReadOnly = false;
            textRotaTipAck.ReadOnly = false;
            textIsPassive.ReadOnly = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            textRotaTip.Text = string.Empty;
            textRotaTipAck.Text = string.Empty;
            textIsPassive.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMROT001 where DOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textRotaTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxFirmaKod.Enabled = false;
                textRotaTip.ReadOnly = true;
                textRotaTipAck.ReadOnly = true;
                textIsPassive.ReadOnly = true;
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
                "SELECT COMCODE AS 'FİRMA KODU', DOCTYPE AS 'ROTA TİPİ', DOCTYPETEXT AS 'ROTA TİPİ AÇIKLAMASI', ISPASSIVE AS 'PASİF Mİ'" +
                "FROM BSMGRCDMROT001 " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR DOCTYPE LIKE '%' + @p1 + '%' OR DOCTYPETEXT LIKE '%' + @p1 + '%' OR ISPASSIVE LIKE '%' + @p1 + '%';",
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

        private void rotaTypeForm_Load(object sender, EventArgs e)
        {
            FirmaKodComboBoxDoldur();
        }
    }
}