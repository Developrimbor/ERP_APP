﻿namespace ERP_APP
{
    partial class rotaYonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rotaYonForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
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
            sehirSearchControl = new DevExpress.XtraEditors.GroupControl();
            dateTimeBaslangic = new DateTimePicker();
            dateTimeBitis = new DateTimePicker();
            checkBoxPasif = new CheckBox();
            checkBoxSilindi = new CheckBox();
            textCizimNo = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            textTemelMiktar = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textUrunAgcKod = new DevExpress.XtraEditors.TextEdit();
            labelSehirUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textMalzemeKodu = new DevExpress.XtraEditors.TextEdit();
            labelSehirName = new DevExpress.XtraEditors.LabelControl();
            labelSehirCode = new DevExpress.XtraEditors.LabelControl();
            labelBirimFirmaCode = new DevExpress.XtraEditors.LabelControl();
            dataGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            comboBoxMalzemeTip = new ComboBox();
            comboBoxFirmaKod = new ComboBox();
            comboBoxUrnAgcTip = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).BeginInit();
            islemlerSehirText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).BeginInit();
            sehirSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textCizimNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textTemelMiktar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUrunAgcKod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textMalzemeKodu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
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
            islemlerSehirText.Location = new Point(-1, 208);
            islemlerSehirText.Margin = new Padding(4);
            islemlerSehirText.Name = "islemlerSehirText";
            islemlerSehirText.Size = new Size(1412, 90);
            islemlerSehirText.TabIndex = 44;
            islemlerSehirText.Text = "İşlemler";
            // 
            // textArat
            // 
            textArat.Location = new Point(276, 47);
            textArat.Name = "textArat";
            textArat.Size = new Size(186, 23);
            textArat.TabIndex = 49;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1219, 41);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(118, 36);
            ButtonKaydet.TabIndex = 56;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(1095, 40);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(118, 36);
            ButtonGüncelle.TabIndex = 55;
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
            homePageButton.TabIndex = 51;
            homePageButton.Click += homePageButton_Click;
            // 
            // dataAddButton
            // 
            dataAddButton.Appearance.BackColor = SystemColors.Menu;
            dataAddButton.Appearance.Options.UseBackColor = true;
            dataAddButton.BackgroundImage = (Image)resources.GetObject("dataAddButton.BackgroundImage");
            dataAddButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            dataAddButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dataAddButton.ImageOptions.SvgImage");
            dataAddButton.Location = new Point(151, 38);
            dataAddButton.Margin = new Padding(4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
            dataAddButton.TabIndex = 50;
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
            searchButton.TabIndex = 46;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(221, 38);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
            deleteButton.TabIndex = 49;
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
            onlyViewButton.Location = new Point(482, 41);
            onlyViewButton.Margin = new Padding(4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 47;
            onlyViewButton.Click += onlyViewButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(81, 38);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(37, 39);
            editButton.TabIndex = 48;
            editButton.Click += editButton_Click;
            // 
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(comboBoxUrnAgcTip);
            sehirSearchControl.Controls.Add(comboBoxFirmaKod);
            sehirSearchControl.Controls.Add(comboBoxMalzemeTip);
            sehirSearchControl.Controls.Add(dateTimeBaslangic);
            sehirSearchControl.Controls.Add(dateTimeBitis);
            sehirSearchControl.Controls.Add(checkBoxPasif);
            sehirSearchControl.Controls.Add(checkBoxSilindi);
            sehirSearchControl.Controls.Add(textCizimNo);
            sehirSearchControl.Controls.Add(labelControl7);
            sehirSearchControl.Controls.Add(textTemelMiktar);
            sehirSearchControl.Controls.Add(labelControl6);
            sehirSearchControl.Controls.Add(labelControl2);
            sehirSearchControl.Controls.Add(labelControl5);
            sehirSearchControl.Controls.Add(labelControl4);
            sehirSearchControl.Controls.Add(labelControl3);
            sehirSearchControl.Controls.Add(labelControl1);
            sehirSearchControl.Controls.Add(textUrunAgcKod);
            sehirSearchControl.Controls.Add(labelSehirUlkeCode);
            sehirSearchControl.Controls.Add(textMalzemeKodu);
            sehirSearchControl.Controls.Add(labelSehirName);
            sehirSearchControl.Controls.Add(labelSehirCode);
            sehirSearchControl.Controls.Add(labelBirimFirmaCode);
            sehirSearchControl.Location = new Point(-1, 0);
            sehirSearchControl.Margin = new Padding(4);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1412, 208);
            sehirSearchControl.TabIndex = 45;
            sehirSearchControl.Text = "Arama";
            // 
            // dateTimeBaslangic
            // 
            dateTimeBaslangic.Enabled = false;
            dateTimeBaslangic.Location = new Point(770, 160);
            dateTimeBaslangic.Name = "dateTimeBaslangic";
            dateTimeBaslangic.Size = new Size(250, 23);
            dateTimeBaslangic.TabIndex = 40;
            // 
            // dateTimeBitis
            // 
            dateTimeBitis.Enabled = false;
            dateTimeBitis.Location = new Point(1079, 165);
            dateTimeBitis.Name = "dateTimeBitis";
            dateTimeBitis.Size = new Size(250, 23);
            dateTimeBitis.TabIndex = 39;
            // 
            // checkBoxPasif
            // 
            checkBoxPasif.AutoSize = true;
            checkBoxPasif.Enabled = false;
            checkBoxPasif.Location = new Point(1315, 39);
            checkBoxPasif.Name = "checkBoxPasif";
            checkBoxPasif.Size = new Size(18, 17);
            checkBoxPasif.TabIndex = 38;
            checkBoxPasif.UseVisualStyleBackColor = true;
            // 
            // checkBoxSilindi
            // 
            checkBoxSilindi.AutoSize = true;
            checkBoxSilindi.Enabled = false;
            checkBoxSilindi.Location = new Point(1144, 39);
            checkBoxSilindi.Name = "checkBoxSilindi";
            checkBoxSilindi.Size = new Size(18, 17);
            checkBoxSilindi.TabIndex = 37;
            checkBoxSilindi.UseVisualStyleBackColor = true;
            // 
            // textCizimNo
            // 
            textCizimNo.Location = new Point(770, 78);
            textCizimNo.Margin = new Padding(4);
            textCizimNo.Name = "textCizimNo";
            textCizimNo.Properties.ReadOnly = true;
            textCizimNo.Size = new Size(180, 22);
            textCizimNo.TabIndex = 36;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(771, 35);
            labelControl7.Margin = new Padding(4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(178, 25);
            labelControl7.TabIndex = 35;
            labelControl7.Text = "ÇİZİM NUMARASI";
            // 
            // textTemelMiktar
            // 
            textTemelMiktar.Location = new Point(543, 162);
            textTemelMiktar.Margin = new Padding(4);
            textTemelMiktar.Name = "textTemelMiktar";
            textTemelMiktar.Properties.ReadOnly = true;
            textTemelMiktar.Size = new Size(180, 22);
            textTemelMiktar.TabIndex = 34;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(544, 119);
            labelControl6.Margin = new Padding(4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(160, 25);
            labelControl6.TabIndex = 33;
            labelControl6.Text = "TEMEL MİKTAR";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(1203, 33);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(105, 25);
            labelControl2.TabIndex = 27;
            labelControl2.Text = "PASİF Mİ?";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(1079, 119);
            labelControl5.Margin = new Padding(4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(186, 25);
            labelControl5.TabIndex = 25;
            labelControl5.Text = "GEÇERLİLİK BİTİŞ";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(771, 119);
            labelControl4.Margin = new Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(261, 25);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "GEÇERLİLİK BAŞLANGICI";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(1020, 33);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(117, 25);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "SİLİNDİ Mİ?";
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
            // textUrunAgcKod
            // 
            textUrunAgcKod.Location = new Point(301, 162);
            textUrunAgcKod.Margin = new Padding(4);
            textUrunAgcKod.Name = "textUrunAgcKod";
            textUrunAgcKod.Properties.ReadOnly = true;
            textUrunAgcKod.Size = new Size(180, 22);
            textUrunAgcKod.TabIndex = 16;
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(301, 119);
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
            // dataGrid
            // 
            dataGrid.EmbeddedNavigator.Margin = new Padding(4);
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            dataGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1, gridLevelNode2 });
            dataGrid.Location = new Point(-1, 297);
            dataGrid.MainView = gridView1;
            dataGrid.Margin = new Padding(4);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1412, 498);
            dataGrid.TabIndex = 43;
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
            // comboBoxMalzemeTip
            // 
            comboBoxMalzemeTip.Enabled = false;
            comboBoxMalzemeTip.FormattingEnabled = true;
            comboBoxMalzemeTip.Location = new Point(195, 76);
            comboBoxMalzemeTip.Margin = new Padding(4, 2, 4, 2);
            comboBoxMalzemeTip.Name = "comboBoxMalzemeTip";
            comboBoxMalzemeTip.Size = new Size(197, 24);
            comboBoxMalzemeTip.TabIndex = 58;
            // 
            // comboBoxFirmaKod
            // 
            comboBoxFirmaKod.Enabled = false;
            comboBoxFirmaKod.FormattingEnabled = true;
            comboBoxFirmaKod.Location = new Point(9, 76);
            comboBoxFirmaKod.Margin = new Padding(4, 2, 4, 2);
            comboBoxFirmaKod.Name = "comboBoxFirmaKod";
            comboBoxFirmaKod.Size = new Size(163, 24);
            comboBoxFirmaKod.TabIndex = 59;
            // 
            // comboBoxUrnAgcTip
            // 
            comboBoxUrnAgcTip.Enabled = false;
            comboBoxUrnAgcTip.FormattingEnabled = true;
            comboBoxUrnAgcTip.Location = new Point(9, 160);
            comboBoxUrnAgcTip.Margin = new Padding(4, 2, 4, 2);
            comboBoxUrnAgcTip.Name = "comboBoxUrnAgcTip";
            comboBoxUrnAgcTip.Size = new Size(200, 24);
            comboBoxUrnAgcTip.TabIndex = 60;
            // 
            // rotaYonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(islemlerSehirText);
            Controls.Add(sehirSearchControl);
            Controls.Add(dataGrid);
            Margin = new Padding(4);
            Name = "rotaYonForm";
            Text = "ROTA YÖNETİMİ";
            Load += rotaYonForm_Load;
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            islemlerSehirText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textCizimNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textTemelMiktar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUrunAgcKod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textMalzemeKodu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.GroupControl islemlerSehirText;
        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textUrunAgcKod;
        private DevExpress.XtraEditors.LabelControl labelSehirUlkeCode;
        private DevExpress.XtraEditors.TextEdit textMalzemeKodu;
        private DevExpress.XtraEditors.LabelControl labelSehirName;
        private DevExpress.XtraEditors.LabelControl labelSehirCode;
        private DevExpress.XtraEditors.LabelControl labelBirimFirmaCode;
        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textCizimNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textTemelMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private TextBox textArat;
        private CheckBox checkBoxPasif;
        private CheckBox checkBoxSilindi;
        private DateTimePicker dateTimeBitis;
        private DateTimePicker dateTimeBaslangic;
        private ComboBox comboBoxMalzemeTip;
        private ComboBox comboBoxFirmaKod;
        private ComboBox comboBoxUrnAgcTip;
    }
}