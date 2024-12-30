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

namespace ERP_APP
{
    public partial class firmaForm : DevExpress.XtraEditors.XtraForm
    {
        public firmaForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", LANCODE AS \"DİL KODU\", LANTEXT AS \"DİL ADI\" FROM BSMGRCDMGEN002;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataFirmaGrid.DataSource = dt;
        }
        private void firmaForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            mainForm xtraForm = new mainForm();

            xtraForm.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
