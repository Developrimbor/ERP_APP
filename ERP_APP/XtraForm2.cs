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

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT COMCODE AS \"FİRMA KODU\", LANCODE AS \"DİL KODU\", LANTEXT AS \"DİL ADI\" FROM BSMGRCDMGEN002;\r\n", bgl.baglanti());
            da.Fill(dt);
            dataDilGrid.DataSource = dt;
        }
        private void dilForm_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}