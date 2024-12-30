using DevExpress.RichEdit.Core.Accessibility;
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
    public partial class dilForm : DevExpress.XtraEditors.XtraForm
    {
        public dilForm()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        
        private void dilForm_Load(object sender, EventArgs e)
        {



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
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", LANCODE AS \"DİL KODU\", LANTEXT AS \"DİL ADI\" FROM BSMGRCDMGEN002;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataDilGrid.DataSource = dt;
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
            textDilCode.ReadOnly = false;
            textDilFirmaCode.ReadOnly = false;
            textDilName.ReadOnly = false;
            textDilCode.Text = string.Empty;
            textDilFirmaCode.Text = string.Empty;
            textDilName.Text = string.Empty;
           
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMGEN002 (COMCODE,LANCODE,LANTEXT) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textDilFirmaCode.Text);
            komut.Parameters.AddWithValue("@p2", textDilCode.Text);
            komut.Parameters.AddWithValue("@p3", textDilName.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            textDilCode.Text = string.Empty;
            textDilFirmaCode.Text = string.Empty ;
            textDilName.Text = string.Empty;

            textDilCode.ReadOnly = true;
            textDilFirmaCode.ReadOnly = true;
            textDilName.ReadOnly = true;
            ButtonKaydet.Visible = false;
            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                textDilFirmaCode.Text = dr["FİRMA KODU"].ToString();
                textDilCode.Text = dr["DİL KODU"].ToString();
                textDilName.Text = dr["DİL ADI"].ToString();

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            textDilCode.ReadOnly = false;
            textDilFirmaCode.ReadOnly = false;
            textDilName.ReadOnly = false;

        }


        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMGEN002 SET COMCODE = @P1, LANCODE = @P2, LANTEXT = @P3 WHERE LANCODE = @P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", textDilFirmaCode.Text);
            komut.Parameters.AddWithValue("@P2", textDilCode.Text);
            komut.Parameters.AddWithValue("@P3", textDilName.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            textDilCode.ReadOnly = true;
            textDilFirmaCode.ReadOnly = true;
            textDilName.ReadOnly = true;
            MessageBox.Show("Veri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ButtonGüncelle.Visible=false;
            listele();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible=false;
            ButtonGüncelle.Visible=false;
            // Soru sorma MessageBox
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // SQL komutunu çalıştırma
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMGEN002 where LANCODE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", textDilCode.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                textDilCode.ReadOnly = true;
                textDilFirmaCode.ReadOnly = true;
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

    }
}

