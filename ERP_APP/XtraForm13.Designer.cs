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
            textGecerlilikBit = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textGecerlilikBas = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)textGecerlilikBit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textGecerlilikBas.Properties).BeginInit();
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
            dataGrid.EmbeddedNavigator.Margin = new Padding(4);
            dataGrid.Location = new Point(-1, 297);
            dataGrid.MainView = gridView1;
            dataGrid.Margin = new Padding(4);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1412, 498);
            dataGrid.TabIndex = 34;
            dataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 431;
            gridView1.GridControl = dataGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(textGecerlilikBit);
            sehirSearchControl.Controls.Add(labelControl5);
            sehirSearchControl.Controls.Add(textGecerlilikBas);
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
            sehirSearchControl.Margin = new Padding(4);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1412, 208);
            sehirSearchControl.TabIndex = 36;
            sehirSearchControl.Text = "Arama";
            // 
            // textGecerlilikBit
            // 
            textGecerlilikBit.Location = new Point(1016, 162);
            textGecerlilikBit.Margin = new Padding(4);
            textGecerlilikBit.Name = "textGecerlilikBit";
            textGecerlilikBit.Properties.ReadOnly = true;
            textGecerlilikBit.Size = new Size(180, 22);
            textGecerlilikBit.TabIndex = 26;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(1016, 119);
            labelControl5.Margin = new Padding(4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(186, 25);
            labelControl5.TabIndex = 25;
            labelControl5.Text = "GEÇERLİLİK BİTİŞ";
            // 
            // textGecerlilikBas
            // 
            textGecerlilikBas.Location = new Point(764, 162);
            textGecerlilikBas.Margin = new Padding(4);
            textGecerlilikBas.Name = "textGecerlilikBas";
            textGecerlilikBas.Properties.ReadOnly = true;
            textGecerlilikBas.Size = new Size(180, 22);
            textGecerlilikBas.TabIndex = 24;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(764, 119);
            labelControl4.Margin = new Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(261, 25);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "GEÇERLİLİK BAŞLANGICI";
            // 
            // textMaliyetMerUzunAcik
            // 
            textMaliyetMerUzunAcik.Location = new Point(764, 78);
            textMaliyetMerUzunAcik.Margin = new Padding(4);
            textMaliyetMerUzunAcik.Name = "textMaliyetMerUzunAcik";
            textMaliyetMerUzunAcik.Properties.ReadOnly = true;
            textMaliyetMerUzunAcik.Size = new Size(631, 22);
            textMaliyetMerUzunAcik.TabIndex = 22;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(764, 34);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(287, 25);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "MALZEME UZUN AÇIKLAMA";
            // 
            // textMaliyetMerkezCode
            // 
            textMaliyetMerkezCode.Location = new Point(9, 162);
            textMaliyetMerkezCode.Margin = new Padding(4);
            textMaliyetMerkezCode.Name = "textMaliyetMerkezCode";
            textMaliyetMerkezCode.Properties.ReadOnly = true;
            textMaliyetMerkezCode.Size = new Size(275, 22);
            textMaliyetMerkezCode.TabIndex = 18;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(9, 119);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(261, 25);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "MALİYET MERKEZİ KODU";
            // 
            // textUlkeCode
            // 
            textUlkeCode.Location = new Point(301, 162);
            textUlkeCode.Margin = new Padding(4);
            textUlkeCode.Name = "textUlkeCode";
            textUlkeCode.Properties.ReadOnly = true;
            textUlkeCode.Size = new Size(180, 22);
            textUlkeCode.TabIndex = 16;
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(301, 119);
            labelSehirUlkeCode.Margin = new Padding(4);
            labelSehirUlkeCode.Name = "labelSehirUlkeCode";
            labelSehirUlkeCode.Size = new Size(217, 25);
            labelSehirUlkeCode.TabIndex = 15;
            labelSehirUlkeCode.Text = "DİL KODU (dropdown)";
            // 
            // textMalMerAcik
            // 
            textMalMerAcik.Location = new Point(439, 78);
            textMalMerAcik.Margin = new Padding(4);
            textMalMerAcik.Name = "textMalMerAcik";
            textMalMerAcik.Properties.ReadOnly = true;
            textMalMerAcik.Size = new Size(308, 22);
            textMalMerAcik.TabIndex = 14;
            // 
            // labelSehirName
            // 
            labelSehirName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirName.Appearance.Options.UseFont = true;
            labelSehirName.Location = new Point(439, 34);
            labelSehirName.Margin = new Padding(4);
            labelSehirName.Name = "labelSehirName";
            labelSehirName.Size = new Size(300, 25);
            labelSehirName.TabIndex = 13;
            labelSehirName.Text = "MALZEME KISA AÇIKLAMASI";
            // 
            // textMaliyetMerkTip
            // 
            textMaliyetMerkTip.Location = new Point(195, 78);
            textMaliyetMerkTip.Margin = new Padding(4);
            textMaliyetMerkTip.Name = "textMaliyetMerkTip";
            textMaliyetMerkTip.Properties.ReadOnly = true;
            textMaliyetMerkTip.Size = new Size(227, 22);
            textMaliyetMerkTip.TabIndex = 12;
            // 
            // labelSehirCode
            // 
            labelSehirCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirCode.Appearance.Options.UseFont = true;
            labelSehirCode.Location = new Point(195, 34);
            labelSehirCode.Margin = new Padding(4);
            labelSehirCode.Name = "labelSehirCode";
            labelSehirCode.Size = new Size(239, 25);
            labelSehirCode.TabIndex = 11;
            labelSehirCode.Text = "MALİYET MERKEZİ TİPİ";
            // 
            // textFirmaCode
            // 
            textFirmaCode.Location = new Point(9, 78);
            textFirmaCode.Margin = new Padding(4);
            textFirmaCode.Name = "textFirmaCode";
            textFirmaCode.Properties.ReadOnly = true;
            textFirmaCode.Size = new Size(168, 22);
            textFirmaCode.TabIndex = 10;
            // 
            // labelBirimFirmaCode
            // 
            labelBirimFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelBirimFirmaCode.Appearance.Options.UseFont = true;
            labelBirimFirmaCode.Location = new Point(9, 34);
            labelBirimFirmaCode.Margin = new Padding(4);
            labelBirimFirmaCode.Name = "labelBirimFirmaCode";
            labelBirimFirmaCode.Size = new Size(134, 25);
            labelBirimFirmaCode.TabIndex = 9;
            labelBirimFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerSehirText
            // 
            islemlerSehirText.Controls.Add(ButtonKaydet);
            islemlerSehirText.Controls.Add(ButtonGüncelle);
            islemlerSehirText.Controls.Add(homePageButton);
            islemlerSehirText.Controls.Add(dataAddButton);
            islemlerSehirText.Controls.Add(searchButton);
            islemlerSehirText.Controls.Add(deleteButton);
            islemlerSehirText.Controls.Add(onlyViewButton);
            islemlerSehirText.Controls.Add(editButton);
            islemlerSehirText.Location = new Point(-1, 208);
            islemlerSehirText.Margin = new Padding(4);
            islemlerSehirText.Name = "islemlerSehirText";
            islemlerSehirText.Size = new Size(1412, 90);
            islemlerSehirText.TabIndex = 35;
            islemlerSehirText.Text = "İşlemler";
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1222, 40);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(118, 36);
            ButtonKaydet.TabIndex = 52;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(1098, 39);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(118, 36);
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
            homePageButton.Location = new Point(1358, 39);
            homePageButton.Margin = new Padding(4);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(37, 39);
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
            dataAddButton.Location = new Point(225, 39);
            dataAddButton.Margin = new Padding(4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
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
            searchButton.Location = new Point(15, 39);
            searchButton.Margin = new Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(37, 39);
            searchButton.TabIndex = 37;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(295, 39);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
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
            onlyViewButton.Location = new Point(85, 39);
            onlyViewButton.Margin = new Padding(4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 38;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(155, 39);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(37, 39);
            editButton.TabIndex = 39;
            editButton.Click += editButton_Click;
            // 
            // costCenterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(dataGrid);
            Controls.Add(sehirSearchControl);
            Controls.Add(islemlerSehirText);
            Margin = new Padding(4);
            Name = "costCenterForm";
            Text = "MALİYET MERKEZİ";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textGecerlilikBit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textGecerlilikBas.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerUzunAcik.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerkezCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMalMerAcik.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMaliyetMerkTip.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.TextEdit textGecerlilikBit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textGecerlilikBas;
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
    }
}