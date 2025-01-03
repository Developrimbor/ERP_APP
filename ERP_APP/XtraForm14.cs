﻿using DevExpress.DataProcessing.InMemoryDataProcessor;
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
    public partial class workCenterForm : DevExpress.XtraEditors.XtraForm
    {
        public workCenterForm()
        {
            InitializeComponent();
        }

        private void workCenterForm_Load(object sender, EventArgs e)
        {

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
                comboBoxIsMerTip.SelectedItem = dr["İŞ MERKEZİ TİPİ"].ToString();
                textIsMerKod.Text = dr["İŞ MERKEZİ KODU"].ToString();
                dateTimeBaslangic.Text = dr["GEÇERLİLİK BAŞLANGIÇ"].ToString();
                dateTimeBitis.Text = dr["GEÇERLİLİK BİTİŞ"].ToString();
                comboBoxDil.SelectedItem = dr["DİL KODU"].ToString();
                textIsMerKısaAck.Text = dr["İŞ MERKEZİ KISA AÇIKLAMASI"].ToString();
                textIsMerUznAck.Text = dr["İŞ MERKEZİ UZUN AÇIKLAMASI"].ToString();
            }
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", WCMDOCTYPE AS \"İŞ MERKEZİ TİPİ\", WCMDOCNUM AS \"İŞ MERKEZİ KODU\" , WCMDOCFROM AS \"GEÇERLİLİK BAŞLANGIÇ\", WCMDOCUNTIL AS \"GEÇERLİLİK BİTİŞ\", LANCODE AS \"DİL KODU\", WCMSTEXT AS \"İŞ MERKEZİ KISA AÇIKLAMASI\", WCMLTEXT AS \"İŞ MERKEZİ UZUN AÇIKLAMASI\"  FROM BSMGRCDMWCMTEXT;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataGrid.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listele();
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = false;
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE BSMGRCDMWCMTEXT SET COMCODE = @P1, WCMDOCTYPE = @P2, WCMDOCNUM = @P3, WCMDOCFROM = @P4, WCMDOCUNTIL = @P5, LANCODE = @P6, WCMSTEXT = @P7, WCMLTEXT = @P8 WHERE WCMDOCNUM = @P3", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", comboBoxIsMerTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P3", textIsMerKod.Text);
            komut.Parameters.AddWithValue("@P4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P6", comboBoxDil.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P7", textIsMerKısaAck.Text);
            komut.Parameters.AddWithValue("@P8", textIsMerUznAck.Text);

            try { 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            comboBoxFirmaKod.Enabled = false;
            comboBoxIsMerTip.Enabled = false;
            textIsMerKod.ReadOnly = true;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
            comboBoxDil.Enabled = false;
            textIsMerKısaAck.ReadOnly = true;
            textIsMerUznAck.ReadOnly = true;
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
            SqlCommand komut = new SqlCommand("insert into BSMGRCDMWCMTEXT (COMCODE,WCMDOCTYPE,WCMDOCNUM,WCMDOCFROM,WCMDOCUNTIL,LANCODE,WCMSTEXT,WCMLTEXT) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", comboBoxFirmaKod.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@P2", comboBoxIsMerTip.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p3", textIsMerKod.Text);
            komut.Parameters.AddWithValue("@p4", dateTimeBaslangic.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@p5", dateTimeBitis.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            komut.Parameters.AddWithValue("@P6", comboBoxDil.SelectedItem?.ToString() ?? string.Empty);
            komut.Parameters.AddWithValue("@p7", textIsMerKısaAck.Text);
            komut.Parameters.AddWithValue("@p8", textIsMerUznAck.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxIsMerTip.SelectedIndex = -1;
            textIsMerKod.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            comboBoxDil.SelectedIndex = -1;
            textIsMerKısaAck.Text = string.Empty;
            textIsMerUznAck.Text = string.Empty;

            comboBoxFirmaKod.Enabled = false;
            comboBoxIsMerTip.Enabled = false;
            textIsMerKod.ReadOnly = true;
            dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = false;
            comboBoxDil.Enabled = false;
            textIsMerKısaAck.ReadOnly = true;
            textIsMerUznAck.ReadOnly = true;
            ButtonKaydet.Visible = false;

            MessageBox.Show("Veri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ButtonKaydet.Visible = false;
            ButtonGüncelle.Visible = true;
            comboBoxFirmaKod.Enabled = true;
            comboBoxIsMerTip.Enabled = true;
            textIsMerKod.ReadOnly = true;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            comboBoxDil.Enabled = true;
            textIsMerKısaAck.ReadOnly = false;
            textIsMerUznAck.ReadOnly = false;
        }

        private void dataAddButton_Click(object sender, EventArgs e)
        {
            ButtonGüncelle.Visible = false;
            ButtonKaydet.Visible = true;

            comboBoxFirmaKod.Enabled = true;
            comboBoxIsMerTip.Enabled = true;
            textIsMerKod.ReadOnly = false;
            dateTimeBaslangic.Enabled = true;  // Bu şekilde sadece okunabilir yapabilirsiniz.
            dateTimeBitis.Enabled = true;
            comboBoxDil.Enabled = true;
            textIsMerKısaAck.ReadOnly = false;
            textIsMerUznAck.ReadOnly = false;

            comboBoxFirmaKod.SelectedIndex = -1;
            comboBoxDil.SelectedIndex = -1;
            comboBoxIsMerTip.SelectedIndex = -1;
            textIsMerKod.Text = string.Empty;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            textIsMerKısaAck.Text = string.Empty;
            textIsMerUznAck.Text = string.Empty;
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
                SqlCommand komutsil = new SqlCommand("Delete From BSMGRCDMWCMTEXT where WCMDOCTYPE=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", comboBoxIsMerTip.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                comboBoxIsMerTip.Enabled = false;
                textIsMerKod.ReadOnly = true;
                dateTimeBaslangic.Enabled = false;  // Bu şekilde sadece okunabilir yapabilirsiniz.
                dateTimeBitis.Enabled = false;
                comboBoxDil.Enabled = false;
                textIsMerKısaAck.ReadOnly = true;
                textIsMerUznAck.ReadOnly = true;
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
                "SELECT COMCODE AS 'FİRMA KODU', WCMDOCTYPE AS 'İŞ MERKEZİ TİPİ', WCMDOCNUM AS 'İŞ MERKEZİ KODU', WCMDOCFROM AS 'GEÇERLİLİK BAŞLANGIÇ', WCMDOCUNTIL AS 'GEÇERLİLİK BİTİŞ', LANCODE AS 'DİL KODU', WCMSTEXT AS 'MALİYET MERKEZİ KISA AÇIKLAMASI', WCMLTEXT AS 'MALİYET MERKEZİ UZUN AÇIKLAMASI' " +
                "FROM BSMGRCDMWCMTEXT " +
                "WHERE COMCODE LIKE '%' + @p1 + '%' OR WCMDOCTYPE LIKE '%' + @p1 + '%' OR WCMDOCNUM LIKE '%' + @p1 + '%' OR WCMDOCFROM LIKE '%' + @p1 + '%' OR WCMDOCUNTIL LIKE '%' + @p1 + '%' OR LANCODE LIKE '%' + @p1 + '%' OR WCMSTEXT LIKE '%' + @p1 + '%' OR WCMLTEXT LIKE '%' + @p1 + '%';",
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

        void IsMerkeziTipComboBoxDoldur()
        {
            SqlCommand komut = new SqlCommand("SELECT DISTINCT DOCTYPE FROM BSMGRCDMWCM001", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxIsMerTip.Items.Add(dr["DOCTYPE"].ToString());
            }
            bgl.baglanti().Close();
        }

        private void workCenterForm_Load_1(object sender, EventArgs e)
        {
            FirmaKodComboBoxDoldur();
            DilComboBoxDoldur();
            IsMerkeziTipComboBoxDoldur();
        }
    }
}