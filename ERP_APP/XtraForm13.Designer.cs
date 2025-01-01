namespace ERP_APP
{
    partial class costCenterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(costCenterForm));
            dataGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            sehirSearchControl = new DevExpress.XtraEditors.GroupControl();
            dateTimeBitis = new DateTimePicker();
            dateTimeBaslangic = new DateTimePicker();
            comboBoxDil = new ComboBox();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textMaliyetMerUzunAcik = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textMaliyetMerkezCode = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textUlkeCode = new DevExpress.XtraEditors.TextEdit();
            labelSehirUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textMalMerAcik = new DevExpress.XtraEditors.TextEdit();
            labelSehirName = new DevExpress.XtraEditors.LabelControl();
            textMaliyetMerkTip = new DevExpress.XtraEditors.TextEdit();
            labelSehirCode = new DevExpress.XtraEditors.LabelControl();
            textFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelBirimFirmaCode = new DevExpress.XtraEditors.LabelControl();
            islemlerSehirText = new DevExpress.XtraEditors.GroupControl();
            textArat = new TextBox();
            ButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).BeginInit();
            sehirSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerUzunAcik.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerkezCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textMalMerAcik.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerkTip.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).BeginInit();
            islemlerSehirText.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.Location = new Point(-1, 241);
            dataGrid.MainView = gridView1;
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1210, 405);
            dataGrid.TabIndex = 34;
            dataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dataGrid;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(dateTimeBitis);
            sehirSearchControl.Controls.Add(dateTimeBaslangic);
            sehirSearchControl.Controls.Add(comboBoxDil);
            sehirSearchControl.Controls.Add(labelControl5);
            sehirSearchControl.Controls.Add(labelControl4);
            sehirSearchControl.Controls.Add(textMaliyetMerUzunAcik);
            sehirSearchControl.Controls.Add(labelControl3);
            sehirSearchControl.Controls.Add(textMaliyetMerkezCode);
            sehirSearchControl.Controls.Add(labelControl1);
            sehirSearchControl.Controls.Add(textUlkeCode);
            sehirSearchControl.Controls.Add(labelSehirUlkeCode);
            sehirSearchControl.Controls.Add(textMalMerAcik);
            sehirSearchControl.Controls.Add(labelSehirName);
            sehirSearchControl.Controls.Add(textMaliyetMerkTip);
            sehirSearchControl.Controls.Add(labelSehirCode);
            sehirSearchControl.Controls.Add(textFirmaCode);
            sehirSearchControl.Controls.Add(labelBirimFirmaCode);
            sehirSearchControl.Location = new Point(-1, 0);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1210, 169);
            sehirSearchControl.TabIndex = 36;
            sehirSearchControl.Text = "Arama";
            // 
            // dateTimeBitis
            // 
            dateTimeBitis.Enabled = false;
            dateTimeBitis.Location = new Point(907, 128);
            dateTimeBitis.Margin = new Padding(3, 2, 3, 2);
            dateTimeBitis.Name = "dateTimeBitis";
            dateTimeBitis.Size = new Size(215, 21);
            dateTimeBitis.TabIndex = 30;
            // 
            // dateTimeBaslangic
            // 
            dateTimeBaslangic.Enabled = false;
            dateTimeBaslangic.Location = new Point(655, 128);
            dateTimeBaslangic.Margin = new Padding(3, 2, 3, 2);
            dateTimeBaslangic.Name = "dateTimeBaslangic";
            dateTimeBaslangic.Size = new Size(215, 21);
            dateTimeBaslangic.TabIndex = 29;
            // 
            // comboBoxDil
            // 
            comboBoxDil.Enabled = false;
            comboBoxDil.FormattingEnabled = true;
            comboBoxDil.Location = new Point(269, 130);
            comboBoxDil.Margin = new Padding(3, 2, 3, 2);
            comboBoxDil.Name = "comboBoxDil";
            comboBoxDil.Size = new Size(130, 21);
            comboBoxDil.TabIndex = 27;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(907, 97);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(157, 20);
            labelControl5.TabIndex = 25;
            labelControl5.Text = "GEÇERLİLİK BİTİŞ";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(655, 97);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(219, 20);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "GEÇERLİLİK BAŞLANGICI";
            // 
            // textMaliyetMerUzunAcik
            // 
            textMaliyetMerUzunAcik.Location = new Point(655, 63);
            textMaliyetMerUzunAcik.Name = "textMaliyetMerUzunAcik";
            textMaliyetMerUzunAcik.Properties.ReadOnly = true;
            textMaliyetMerUzunAcik.Size = new Size(541, 20);
            textMaliyetMerUzunAcik.TabIndex = 22;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(655, 28);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(234, 20);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "MALZEME UZUN AÇIKLAMA";
            // 
            // textMaliyetMerkezCode
            // 
            textMaliyetMerkezCode.Location = new Point(8, 132);
            textMaliyetMerkezCode.Name = "textMaliyetMerkezCode";
            textMaliyetMerkezCode.Properties.ReadOnly = true;
            textMaliyetMerkezCode.Size = new Size(236, 20);
            textMaliyetMerkezCode.TabIndex = 18;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(8, 97);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(215, 20);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "MALİYET MERKEZİ KODU";
            // 
            // textUlkeCode
            // 
            textUlkeCode.Location = new Point(451, 130);
            textUlkeCode.Name = "textUlkeCode";
            textUlkeCode.Properties.ReadOnly = true;
            textUlkeCode.Size = new Size(154, 20);
            textUlkeCode.TabIndex = 16;
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(258, 97);
            labelSehirUlkeCode.Name = "labelSehirUlkeCode";
            labelSehirUlkeCode.Size = new Size(179, 20);
            labelSehirUlkeCode.TabIndex = 15;
            labelSehirUlkeCode.Text = "DİL KODU (dropdown)";
            // 
            // textMalMerAcik
            // 
            textMalMerAcik.Location = new Point(376, 63);
            textMalMerAcik.Name = "textMalMerAcik";
            textMalMerAcik.Properties.ReadOnly = true;
            textMalMerAcik.Size = new Size(264, 20);
            textMalMerAcik.TabIndex = 14;
            // 
            // labelSehirName
            // 
            labelSehirName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirName.Appearance.Options.UseFont = true;
            labelSehirName.Location = new Point(376, 28);
            labelSehirName.Name = "labelSehirName";
            labelSehirName.Size = new Size(243, 20);
            labelSehirName.TabIndex = 13;
            labelSehirName.Text = "MALZEME KISA AÇIKLAMASI";
            // 
            // textMaliyetMerkTip
            // 
            textMaliyetMerkTip.Location = new Point(167, 63);
            textMaliyetMerkTip.Name = "textMaliyetMerkTip";
            textMaliyetMerkTip.Properties.ReadOnly = true;
            textMaliyetMerkTip.Size = new Size(195, 20);
            textMaliyetMerkTip.TabIndex = 12;
            // 
            // labelSehirCode
            // 
            labelSehirCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirCode.Appearance.Options.UseFont = true;
            labelSehirCode.Location = new Point(167, 28);
            labelSehirCode.Name = "labelSehirCode";
            labelSehirCode.Size = new Size(198, 20);
            labelSehirCode.TabIndex = 11;
            labelSehirCode.Text = "MALİYET MERKEZİ TİPİ";
            // 
            // textFirmaCode
            // 
            textFirmaCode.Location = new Point(8, 63);
            textFirmaCode.Name = "textFirmaCode";
            textFirmaCode.Properties.ReadOnly = true;
            textFirmaCode.Size = new Size(144, 20);
            textFirmaCode.TabIndex = 10;
            // 
            // labelBirimFirmaCode
            // 
            labelBirimFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelBirimFirmaCode.Appearance.Options.UseFont = true;
            labelBirimFirmaCode.Location = new Point(8, 28);
            labelBirimFirmaCode.Name = "labelBirimFirmaCode";
            labelBirimFirmaCode.Size = new Size(111, 20);
            labelBirimFirmaCode.TabIndex = 9;
            labelBirimFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerSehirText
            // 
            islemlerSehirText.Controls.Add(textArat);
            islemlerSehirText.Controls.Add(ButtonKaydet);
            islemlerSehirText.Controls.Add(ButtonGüncelle);
            islemlerSehirText.Controls.Add(homePageButton);
            islemlerSehirText.Controls.Add(dataAddButton);
            islemlerSehirText.Controls.Add(searchButton);
            islemlerSehirText.Controls.Add(deleteButton);
            islemlerSehirText.Controls.Add(onlyViewButton);
            islemlerSehirText.Controls.Add(editButton);
            islemlerSehirText.Location = new Point(-1, 169);
            islemlerSehirText.Name = "islemlerSehirText";
            islemlerSehirText.Size = new Size(1210, 73);
            islemlerSehirText.TabIndex = 35;
            islemlerSehirText.Text = "İşlemler";
            // 
            // textArat
            // 
            textArat.Location = new Point(239, 40);
            textArat.Margin = new Padding(3, 2, 3, 2);
            textArat.Name = "textArat";
            textArat.Size = new Size(160, 21);
            textArat.TabIndex = 48;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1047, 32);
            ButtonKaydet.Margin = new Padding(3, 2, 3, 2);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(101, 29);
            ButtonKaydet.TabIndex = 52;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(941, 32);
            ButtonGüncelle.Margin = new Padding(3, 2, 3, 2);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(101, 29);
            ButtonGüncelle.TabIndex = 51;
            ButtonGüncelle.Text = "Güncelle";
            ButtonGüncelle.Visible = false;
            ButtonGüncelle.Click += ButtonGüncelle_Click;
            // 
            // homePageButton
            // 
            homePageButton.Appearance.BackColor = SystemColors.Menu;
            homePageButton.Appearance.Options.UseBackColor = true;
            homePageButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            homePageButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("homePageButton.ImageOptions.SvgImage");
            homePageButton.Location = new Point(1164, 32);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(32, 32);
            homePageButton.TabIndex = 42;
            homePageButton.Click += homePageButton_Click;
            // 
            // dataAddButton
            // 
            dataAddButton.Appearance.BackColor = SystemColors.Menu;
            dataAddButton.Appearance.Options.UseBackColor = true;
            dataAddButton.BackgroundImage = (Image)resources.GetObject("dataAddButton.BackgroundImage");
            dataAddButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            dataAddButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dataAddButton.ImageOptions.SvgImage");
            dataAddButton.Location = new Point(131, 32);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(32, 32);
            dataAddButton.TabIndex = 41;
            dataAddButton.Click += dataAddButton_Click;
            // 
            // searchButton
            // 
            searchButton.Appearance.BackColor = SystemColors.Menu;
            searchButton.Appearance.BorderColor = SystemColors.Menu;
            searchButton.Appearance.Options.UseBackColor = true;
            searchButton.Appearance.Options.UseBorderColor = true;
            searchButton.BackgroundImage = (Image)resources.GetObject("searchButton.BackgroundImage");
            searchButton.BackgroundImageLayout = ImageLayout.None;
            searchButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            searchButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("searchButton.ImageOptions.SvgImage");
            searchButton.Location = new Point(13, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 37;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(191, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
            deleteButton.TabIndex = 40;
            deleteButton.Click += deleteButton_Click;
            // 
            // onlyViewButton
            // 
            onlyViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            onlyViewButton.Appearance.BackColor = SystemColors.Menu;
            onlyViewButton.Appearance.Options.UseBackColor = true;
            onlyViewButton.BackgroundImage = (Image)resources.GetObject("onlyViewButton.BackgroundImage");
            onlyViewButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            onlyViewButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("onlyViewButton.ImageOptions.SvgImage");
            onlyViewButton.Location = new Point(412, 32);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(32, 32);
            onlyViewButton.TabIndex = 38;
            onlyViewButton.Click += onlyViewButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(71, 32);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 32);
            editButton.TabIndex = 39;
            editButton.Click += editButton_Click;
            // 
            // costCenterForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 647);
            Controls.Add(dataGrid);
            Controls.Add(sehirSearchControl);
            Controls.Add(islemlerSehirText);
            Name = "costCenterForm";
            Text = "MALİYET MERKEZİ";
            Load += costCenterForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerUzunAcik.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerkezCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMalMerAcik.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerkTip.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            islemlerSehirText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textMaliyetMerUzunAcik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textMaliyetMerkezCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textUlkeCode;
        private DevExpress.XtraEditors.LabelControl labelSehirUlkeCode;
        private DevExpress.XtraEditors.TextEdit textMalMerAcik;
        private DevExpress.XtraEditors.LabelControl labelSehirName;
        private DevExpress.XtraEditors.TextEdit textMaliyetMerkTip;
        private DevExpress.XtraEditors.LabelControl labelSehirCode;
        private DevExpress.XtraEditors.TextEdit textFirmaCode;
        private DevExpress.XtraEditors.LabelControl labelBirimFirmaCode;
        private DevExpress.XtraEditors.GroupControl islemlerSehirText;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private TextBox textArat;
        private ComboBox comboBoxDil;
        private DateTimePicker dateTimeBaslangic;
        private DateTimePicker dateTimeBitis;
    }
}