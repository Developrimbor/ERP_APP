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

namespace ERP_APP
{
    public partial class mainForm : DevExpress.XtraEditors.XtraForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            firmaForm xtraForm1 = new firmaForm();

            xtraForm1.Show();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            urunAgaciForm xtraForm8 = new urunAgaciForm();

            xtraForm8.Show();
        }

        private void control_dil_Click(object sender, EventArgs e)
        {
            dilForm xtraForm2 = new dilForm();

            xtraForm2.Show();
        }

        private void control_birim_Click(object sender, EventArgs e)
        {
            birimForm xtraForm5 = new birimForm();

            xtraForm5.Show();
        }

        private void control_malzemeTipi_Click(object sender, EventArgs e)
        {
            malzForm xtraForm6 = new malzForm();

            xtraForm6.Show();
        }

        private void control_ülke_Click(object sender, EventArgs e)
        {
            ulkeForm xtraForm3 = new ulkeForm();

            xtraForm3.Show();
        }

        private void control_maliyet_merkezi_Click(object sender, EventArgs e)
        {
            malMerForm xtraForm7 = new malMerForm();

            xtraForm7.Show();
        }

        private void control_sehir_Click(object sender, EventArgs e)
        {
            sehirForm xtraForm4 = new sehirForm();

            xtraForm4.Show();
        }

        private void control_rotaTipi_Click(object sender, EventArgs e)
        {
            rotaTypeForm xtraForm9 = new rotaTypeForm();

            xtraForm9.Show();
        }

        private void control_isMerkeziTipi_Click(object sender, EventArgs e)
        {
            isMerkezTipiForm xtraForm10 = new isMerkezTipiForm();

            xtraForm10.Show();
        }

        private void control_operasyonTipi_Click(object sender, EventArgs e)
        {
            oprsTypeForm xtraForm11 = new oprsTypeForm();

            xtraForm11.Show();
        }

        private void anaEkran_maliyetMerkezi_Click(object sender, EventArgs e)
        {
            costCenterForm xtraForm13 = new costCenterForm();

            xtraForm13.Show();
        }

        private void anaEkran_isMerkezi_Click(object sender, EventArgs e)
        {
            workCenterForm xtraForm14 = new workCenterForm();

            xtraForm14.Show();
        }

        private void anaEkran_urunAgaci_Click(object sender, EventArgs e)
        {
            urunAgaciForm xtraForm8 = new urunAgaciForm();

            xtraForm8.Show();
        }

        private void anaEkran_materyal_Click(object sender, EventArgs e)
        {
            matInfoForm xtraForm12 = new matInfoForm();

            xtraForm12.Show();
        }
    }
}