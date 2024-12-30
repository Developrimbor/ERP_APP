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
    public partial class malzForm : DevExpress.XtraEditors.XtraForm
    {
        public malzForm()
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
                textMalzemeTipi.Text = dr["MALZEME TİPİ"].ToString();
                textMalzTipAcik.Text = dr["MALZEME TİPİ AÇIKLAMASI"].ToString();
                textIspassıve.Text = dr["PASİF Mİ"].ToString();


            }
        }
        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", DOCTYPE AS \"MALZEME TİPİ\", DOCTYPETEXT AS \"MALZEME TİPİ AÇIKLAMASI\" , ISPASSIVE AS \"PASİF Mİ\"   FROM BSMGRCDMMAT001;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataSehirGrid.DataSource = dt;
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

            textFirmaCode.ReadOnly = false;
            textMalzemeTipi.ReadOnly = false;
            textMalzTipAcik.ReadOnly = false;
            textIspassıve.ReadOnly = false;

            textFirmaCode.Text = string.Empty;
            textMalzemeTipi.Text = string.Empty;
            textMalzTipAcik.Text = string.Empty;
            textIspassıve.Text = string.Empty;


        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMMAT001 (COMCODE,DOCTYPE,DOCTYPETEXT,ISPASSIVE) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textMalzemeTipi.Text);
            komut.Parameters.AddWithValue("@p3", textMalzTipAcik.Text);
            komut.Parameters.AddWithValue("@p4", textIspassıve.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textFirmaCode.Text = string.Empty;
            textMalzemeTipi.Text = string.Empty;
            textMalzTipAcik.Text = string.Empty;
            textIspassıve.Text = string.Empty;

            textFirmaCode.ReadOnly = true;
            textMalzemeTipi.ReadOnly = true;
            textMalzTipAcik.ReadOnly = true;
            textIspassıve.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textFirmaCode.ReadOnly = false;
            textMalzemeTipi.ReadOnly = false;
            textMalzTipAcik.ReadOnly = false;
            textIspassıve.ReadOnly = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMMAT001 SET COMCODE = @P1, DOCTYPE = @P2, DOCTYPETEXT = @P3, ISPASSIVE = @P4 WHERE DOCTYPE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textMalzemeTipi.Text);
            komut.Parameters.AddWithValue("@P3", textMalzTipAcik.Text);
            komut.Parameters.AddWithValue("@P4", textIspassıve.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textFirmaCode.ReadOnly = true;
            textMalzemeTipi.ReadOnly = true;
            textMalzTipAcik.ReadOnly = true;
            textIspassıve.ReadOnly = true;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMMAT001 where DOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textMalzemeTipi.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textFirmaCode.ReadOnly = true;
                textMalzemeTipi.ReadOnly = true;
                textMalzTipAcik.ReadOnly = true;
                textIspassıve.ReadOnly = true;
                MessageBox.Show("Veri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                // Kullanıcı "İptal" butonuna basarsa hiçbir işlem yapılmaz
                MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
