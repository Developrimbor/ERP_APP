using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        private async void mainForm_Load(object sender, EventArgs e)
        {
            // Döviz verilerini al ve Label'larda göster
            await FetchAndDisplayRates();
        }

        private async Task FetchAndDisplayRates()
        {
            try
            {
                // Döviz API'si URL'si
                string apiUrl = "https://api.exchangerate-api.com/v4/latest/USD";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    // JSON'u deserialize et
                    var exchangeRates = JsonConvert.DeserializeObject<ExchangeRateResponse>(responseBody);

                    // Dolar kuru TRY cinsinden al
                    if (exchangeRates.Rates.ContainsKey("TRY"))
                    {
                        string dolarToTry = exchangeRates.Rates["TRY"].ToString("0.00");
                        lblDollar.Text = $" {dolarToTry} TL";
                    }
                    else
                    {
                        MessageBox.Show("Dolar kuru bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Euro kuru doğrudan API'den alın
                    string euroToTry = await GetEuroRate();
                    lblEuro.Text = $" {euroToTry} TL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetEuroRate()
        {
            try
            {
                string euroApiUrl = "https://api.exchangerate-api.com/v4/latest/EUR";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(euroApiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    var exchangeRates = JsonConvert.DeserializeObject<ExchangeRateResponse>(responseBody);

                    // Euro kuru TRY cinsinden al
                    if (exchangeRates.Rates.ContainsKey("TRY"))
                    {
                        return exchangeRates.Rates["TRY"].ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("Euro kuru bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Euro kuru çekilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0.00";
            }
        }
    

        // Diğer event handler'lar

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            firmaForm xtraForm1 = new firmaForm();
            xtraForm1.Show();
            this.Hide();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            urunAgaciForm xtraForm8 = new urunAgaciForm();
            xtraForm8.Show();
            this.Hide();
        }

        private void control_dil_Click(object sender, EventArgs e)
        {
            dilForm xtraForm2 = new dilForm();
            xtraForm2.Show();
            this.Hide();
        }

        private void control_birim_Click(object sender, EventArgs e)
        {
            birimForm xtraForm5 = new birimForm();
            xtraForm5.Show();
            this.Hide();
        }

        private void control_malzemeTipi_Click(object sender, EventArgs e)
        {
            malzForm xtraForm6 = new malzForm();
            xtraForm6.Show();
            this.Hide();
        }

        private void control_ülke_Click(object sender, EventArgs e)
        {
            ulkeForm xtraForm3 = new ulkeForm();
            xtraForm3.Show();
            this.Hide();
        }

        private void control_maliyet_merkezi_Click(object sender, EventArgs e)
        {
            malMerForm xtraForm7 = new malMerForm();
            xtraForm7.Show();
            this.Hide();
        }

        private void control_sehir_Click(object sender, EventArgs e)
        {
            sehirForm xtraForm4 = new sehirForm();
            xtraForm4.Show();
            this.Hide();
        }

        private void control_rotaTipi_Click(object sender, EventArgs e)
        {
            rotaTypeForm xtraForm9 = new rotaTypeForm();
            xtraForm9.Show();
            this.Hide();
        }

        private void control_isMerkeziTipi_Click(object sender, EventArgs e)
        {
            isMerkezTipiForm xtraForm10 = new isMerkezTipiForm();
            xtraForm10.Show();
            this.Hide();
        }

        private void control_operasyonTipi_Click(object sender, EventArgs e)
        {
            oprsTypeForm xtraForm11 = new oprsTypeForm();
            xtraForm11.Show();
            this.Hide();
        }

        private void anaEkran_maliyetMerkezi_Click(object sender, EventArgs e)
        {
            costCenterForm xtraForm13 = new costCenterForm();
            xtraForm13.Show();
            this.Hide();
        }

        private void anaEkran_isMerkezi_Click(object sender, EventArgs e)
        {
            workCenterForm xtraForm14 = new workCenterForm();
            xtraForm14.Show();
            this.Hide();
        }

        private void anaEkran_urunAgaci_Click(object sender, EventArgs e)
        {
            anaEkranUrunAgaciForm xtraForm15 = new anaEkranUrunAgaciForm();
            xtraForm15.Show();
            this.Hide();
        }

        private void anaEkran_materyal_Click(object sender, EventArgs e)
        {
            matInfoForm xtraForm12 = new matInfoForm();
            xtraForm12.Show();
            this.Hide();
        }

        private void anaEkran_rotaYonetimi_Click(object sender, EventArgs e)
        {
            rotaYonForm xtraForm16 = new rotaYonForm();
            xtraForm16.Show();
            this.Hide();
        }


    }
}
    public class ExchangeRateResponse
    {
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }


