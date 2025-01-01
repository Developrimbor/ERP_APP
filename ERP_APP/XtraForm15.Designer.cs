namespace ERP_APP
{
    partial class anaEkranUrunAgaciForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkranUrunAgaciForm));
            dataGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            islemlerSehirText = new DevExpress.XtraEditors.GroupControl();
            ButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            textGecBit = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textGecBas = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textSilindiMi = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textUrunAgacKod = new DevExpress.XtraEditors.TextEdit();
            labelSehirUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textMalzemeKodu = new DevExpress.XtraEditors.TextEdit();
            labelSehirName = new DevExpress.XtraEditors.LabelControl();
            textMalzemeTipi = new DevExpress.XtraEditors.TextEdit();
            sehirSearchControl = new DevExpress.XtraEditors.GroupControl();
            textCizimNo = new DevExpress.XtraEditors.TextEdit();
            labelCizimNo = new DevExpress.XtraEditors.LabelControl();
            textTemelMiktar = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            textIsPassive = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textUrunAgcTip = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelSehirCode = new DevExpress.XtraEditors.LabelControl();
            textFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelBirimFirmaCode = new DevExpress.XtraEditors.LabelControl();
            textArat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).BeginInit();
            islemlerSehirText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textGecBit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textGecBas.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textSilindiMi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUrunAgacKod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textMalzemeKodu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textMalzemeTipi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).BeginInit();
            sehirSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textCizimNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textTemelMiktar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textIsPassive.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUrunAgcTip.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.EmbeddedNavigator.Margin = new Padding(4);
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            dataGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode3, gridLevelNode4 });
            dataGrid.Location = new Point(-1, 297);
            dataGrid.MainView = gridView1;
            dataGrid.Margin = new Padding(4);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1412, 498);
            dataGrid.TabIndex = 40;
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
            // islemlerSehirText
            // 
            islemlerSehirText.Controls.Add(textArat);
            islemlerSehirText.Controls.Add(ButtonKaydet);
            islemlerSehirText.Controls.Add(ButtonGüncelle);
            islemlerSehirText.Controls.Add(homePageButton);
            islemlerSehirText.Controls.Add(dataAddButton);
            islemlerSehirText.Controls.Add(deleteButton);
            islemlerSehirText.Controls.Add(editButton);
            islemlerSehirText.Controls.Add(onlyViewButton);
            islemlerSehirText.Controls.Add(searchButton);
            islemlerSehirText.Location = new Point(-1, 208);
            islemlerSehirText.Margin = new Padding(4);
            islemlerSehirText.Name = "islemlerSehirText";
            islemlerSehirText.Size = new Size(1412, 90);
            islemlerSehirText.TabIndex = 41;
            islemlerSehirText.Text = "İşlemler";
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1222, 42);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(118, 36);
            ButtonKaydet.TabIndex = 54;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(1098, 41);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(118, 36);
            ButtonGüncelle.TabIndex = 53;
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
            homePageButton.TabIndex = 43;
            homePageButton.Click += homePageButton_Click;
            // 
            // dataAddButton
            // 
            dataAddButton.Appearance.BackColor = SystemColors.Menu;
            dataAddButton.Appearance.Options.UseBackColor = true;
            dataAddButton.BackgroundImage = (Image)resources.GetObject("dataAddButton.BackgroundImage");
            dataAddButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            dataAddButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dataAddButton.ImageOptions.SvgImage");
            dataAddButton.Location = new Point(151, 39);
            dataAddButton.Margin = new Padding(4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
            dataAddButton.TabIndex = 14;
            dataAddButton.Click += dataAddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(221, 39);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
            deleteButton.TabIndex = 13;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(81, 39);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(37, 39);
            editButton.TabIndex = 12;
            editButton.Click += editButton_Click;
            // 
            // onlyViewButton
            // 
            onlyViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            onlyViewButton.Appearance.BackColor = SystemColors.Menu;
            onlyViewButton.Appearance.Options.UseBackColor = true;
            onlyViewButton.BackgroundImage = (Image)resources.GetObject("onlyViewButton.BackgroundImage");
            onlyViewButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            onlyViewButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("onlyViewButton.ImageOptions.SvgImage");
            onlyViewButton.Location = new Point(486, 39);
            onlyViewButton.Margin = new Padding(4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 11;
            onlyViewButton.Click += onlyViewButton_Click;
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
            searchButton.TabIndex = 10;
            searchButton.Click += searchButton_Click;
            // 
            // textGecBit
            // 
            textGecBit.Location = new Point(1087, 162);
            textGecBit.Margin = new Padding(4);
            textGecBit.Name = "textGecBit";
            textGecBit.Properties.ReadOnly = true;
            textGecBit.Size = new Size(180, 22);
            textGecBit.TabIndex = 26;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(1087, 119);
            labelControl5.Margin = new Padding(4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(186, 25);
            labelControl5.TabIndex = 25;
            labelControl5.Text = "GEÇERLİLİK BİTİŞ";
            // 
            // textGecBas
            // 
            textGecBas.Location = new Point(764, 162);
            textGecBas.Margin = new Padding(4);
            textGecBas.Name = "textGecBas";
            textGecBas.Properties.ReadOnly = true;
            textGecBas.Size = new Size(180, 22);
            textGecBas.TabIndex = 24;
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
            // textSilindiMi
            // 
            textSilindiMi.Location = new Point(1165, 38);
            textSilindiMi.Margin = new Padding(4);
            textSilindiMi.Name = "textSilindiMi";
            textSilindiMi.Properties.ReadOnly = true;
            textSilindiMi.Size = new Size(23, 22);
            textSilindiMi.TabIndex = 22;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(1030, 37);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(117, 25);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "SİLİNDİ Mİ?";
            // 
            // textUrunAgacKod
            // 
            textUrunAgacKod.Location = new Point(322, 162);
            textUrunAgacKod.Margin = new Padding(4);
            textUrunAgacKod.Name = "textUrunAgacKod";
            textUrunAgacKod.Properties.ReadOnly = true;
            textUrunAgacKod.Size = new Size(180, 22);
            textUrunAgacKod.TabIndex = 16;
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(322, 119);
            labelSehirUlkeCode.Margin = new Padding(4);
            labelSehirUlkeCode.Name = "labelSehirUlkeCode";
            labelSehirUlkeCode.Size = new Size(201, 25);
            labelSehirUlkeCode.TabIndex = 15;
            labelSehirUlkeCode.Text = "ÜRÜN AĞACI KODU";
            // 
            // textMalzemeKodu
            // 
            textMalzemeKodu.Location = new Point(439, 78);
            textMalzemeKodu.Margin = new Padding(4);
            textMalzemeKodu.Name = "textMalzemeKodu";
            textMalzemeKodu.Properties.ReadOnly = true;
            textMalzemeKodu.Size = new Size(308, 22);
            textMalzemeKodu.TabIndex = 14;
            // 
            // labelSehirName
            // 
            labelSehirName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirName.Appearance.Options.UseFont = true;
            labelSehirName.Location = new Point(439, 34);
            labelSehirName.Margin = new Padding(4);
            labelSehirName.Name = "labelSehirName";
            labelSehirName.Size = new Size(172, 25);
            labelSehirName.TabIndex = 13;
            labelSehirName.Text = "MALZEME KODU";
            // 
            // textMalzemeTipi
            // 
            textMalzemeTipi.Location = new Point(195, 78);
            textMalzemeTipi.Margin = new Padding(4);
            textMalzemeTipi.Name = "textMalzemeTipi";
            textMalzemeTipi.Properties.ReadOnly = true;
            textMalzemeTipi.Size = new Size(227, 22);
            textMalzemeTipi.TabIndex = 12;
            // 
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(textCizimNo);
            sehirSearchControl.Controls.Add(labelCizimNo);
            sehirSearchControl.Controls.Add(textTemelMiktar);
            sehirSearchControl.Controls.Add(labelControl6);
            sehirSearchControl.Controls.Add(textIsPassive);
            sehirSearchControl.Controls.Add(labelControl2);
            sehirSearchControl.Controls.Add(textGecBit);
            sehirSearchControl.Controls.Add(labelControl5);
            sehirSearchControl.Controls.Add(textGecBas);
            sehirSearchControl.Controls.Add(labelControl4);
            sehirSearchControl.Controls.Add(textSilindiMi);
            sehirSearchControl.Controls.Add(labelControl3);
            sehirSearchControl.Controls.Add(textUrunAgcTip);
            sehirSearchControl.Controls.Add(labelControl1);
            sehirSearchControl.Controls.Add(textUrunAgacKod);
            sehirSearchControl.Controls.Add(labelSehirUlkeCode);
            sehirSearchControl.Controls.Add(textMalzemeKodu);
            sehirSearchControl.Controls.Add(labelSehirName);
            sehirSearchControl.Controls.Add(textMalzemeTipi);
            sehirSearchControl.Controls.Add(labelSehirCode);
            sehirSearchControl.Controls.Add(textFirmaCode);
            sehirSearchControl.Controls.Add(labelBirimFirmaCode);
            sehirSearchControl.Location = new Point(-1, 0);
            sehirSearchControl.Margin = new Padding(4);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1412, 208);
            sehirSearchControl.TabIndex = 42;
            sehirSearchControl.Text = "Arama";
            // 
            // textCizimNo
            // 
            textCizimNo.Location = new Point(772, 78);
            textCizimNo.Margin = new Padding(4);
            textCizimNo.Name = "textCizimNo";
            textCizimNo.Properties.ReadOnly = true;
            textCizimNo.Size = new Size(227, 22);
            textCizimNo.TabIndex = 32;
            // 
            // labelCizimNo
            // 
            labelCizimNo.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelCizimNo.Appearance.Options.UseFont = true;
            labelCizimNo.Location = new Point(772, 32);
            labelCizimNo.Margin = new Padding(4);
            labelCizimNo.Name = "labelCizimNo";
            labelCizimNo.Size = new Size(178, 25);
            labelCizimNo.TabIndex = 31;
            labelCizimNo.Text = "ÇİZİM NUMARASI";
            // 
            // textTemelMiktar
            // 
            textTemelMiktar.Location = new Point(547, 162);
            textTemelMiktar.Margin = new Padding(4);
            textTemelMiktar.Name = "textTemelMiktar";
            textTemelMiktar.Properties.ReadOnly = true;
            textTemelMiktar.Size = new Size(180, 22);
            textTemelMiktar.TabIndex = 30;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(547, 119);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(160, 25);
            labelControl6.TabIndex = 29;
            labelControl6.Text = "TEMEL MİKTAR";
            // 
            // textIsPassive
            // 
            textIsPassive.Location = new Point(1318, 41);
            textIsPassive.Margin = new Padding(4);
            textIsPassive.Name = "textIsPassive";
            textIsPassive.Properties.ReadOnly = true;
            textIsPassive.Size = new Size(23, 22);
            textIsPassive.TabIndex = 28;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(1205, 37);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(105, 25);
            labelControl2.TabIndex = 27;
            labelControl2.Text = "PASİF Mİ?";
            // 
            // textUrunAgcTip
            // 
            textUrunAgcTip.Location = new Point(9, 162);
            textUrunAgcTip.Margin = new Padding(4);
            textUrunAgcTip.Name = "textUrunAgcTip";
            textUrunAgcTip.Properties.ReadOnly = true;
            textUrunAgcTip.Size = new Size(275, 22);
            textUrunAgcTip.TabIndex = 18;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(9, 119);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(179, 25);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "ÜRÜN AĞACI TİPİ";
            // 
            // labelSehirCode
            // 
            labelSehirCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirCode.Appearance.Options.UseFont = true;
            labelSehirCode.Location = new Point(195, 34);
            labelSehirCode.Margin = new Padding(4);
            labelSehirCode.Name = "labelSehirCode";
            labelSehirCode.Size = new Size(150, 25);
            labelSehirCode.TabIndex = 11;
            labelSehirCode.Text = "MALZEME TİPİ";
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
            // textArat
            // 
            textArat.Location = new Point(279, 47);
            textArat.Name = "textArat";
            textArat.Size = new Size(186, 23);
            textArat.TabIndex = 48;
            // 
            // anaEkranUrunAgaciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(dataGrid);
            Controls.Add(islemlerSehirText);
            Controls.Add(sehirSearchControl);
            Margin = new Padding(4);
            Name = "anaEkranUrunAgaciForm";
            Text = "Ana Ekran Ürün Ağacı";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            islemlerSehirText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textGecBit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textGecBas.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textSilindiMi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUrunAgacKod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMalzemeKodu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMalzemeTipi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textCizimNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textTemelMiktar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textIsPassive.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUrunAgcTip.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl islemlerSehirText;
        private DevExpress.XtraEditors.TextEdit textGecBit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textGecBas;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textSilindiMi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textUrunAgacKod;
        private DevExpress.XtraEditors.LabelControl labelSehirUlkeCode;
        private DevExpress.XtraEditors.TextEdit textMalzemeKodu;
        private DevExpress.XtraEditors.LabelControl labelSehirName;
        private DevExpress.XtraEditors.TextEdit textMalzemeTipi;
        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.TextEdit textUrunAgcTip;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelSehirCode;
        private DevExpress.XtraEditors.TextEdit textFirmaCode;
        private DevExpress.XtraEditors.LabelControl labelBirimFirmaCode;
        private DevExpress.XtraEditors.TextEdit textIsPassive;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.TextEdit textTemelMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textCizimNo;
        private DevExpress.XtraEditors.LabelControl labelCizimNo;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private TextBox textArat;
    }
}