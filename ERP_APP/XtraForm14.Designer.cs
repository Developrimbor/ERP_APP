﻿namespace ERP_APP
{
    partial class workCenterForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workCenterForm));
            dataGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            islemlerSehirText = new DevExpress.XtraEditors.GroupControl();
            textArat = new TextBox();
            ButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textIsMerUznAck = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textIsMerKod = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelSehirUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textIsMerKısaAck = new DevExpress.XtraEditors.TextEdit();
            labelSehirName = new DevExpress.XtraEditors.LabelControl();
            labelSehirCode = new DevExpress.XtraEditors.LabelControl();
            labelBirimFirmaCode = new DevExpress.XtraEditors.LabelControl();
            sehirSearchControl = new DevExpress.XtraEditors.GroupControl();
            comboBoxIsMerTip = new ComboBox();
            comboBoxDil = new ComboBox();
            comboBoxFirmaKod = new ComboBox();
            dateTimeBitis = new DateTimePicker();
            dateTimeBaslangic = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).BeginInit();
            islemlerSehirText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textIsMerUznAck.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textIsMerKod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textIsMerKısaAck.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).BeginInit();
            sehirSearchControl.SuspendLayout();
            SuspendLayout();
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
            dataGrid.TabIndex = 37;
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
            islemlerSehirText.TabIndex = 38;
            islemlerSehirText.Text = "İşlemler";
            // 
            // textArat
            // 
            textArat.Location = new Point(277, 48);
            textArat.Name = "textArat";
            textArat.Size = new Size(186, 23);
            textArat.TabIndex = 47;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1216, 40);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(118, 36);
            ButtonKaydet.TabIndex = 50;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(1092, 39);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(118, 36);
            ButtonGüncelle.TabIndex = 49;
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
            dataAddButton.Location = new Point(152, 39);
            dataAddButton.Margin = new Padding(4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
            dataAddButton.TabIndex = 9;
            dataAddButton.Click += dataAddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(222, 39);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
            deleteButton.TabIndex = 8;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(82, 39);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(37, 39);
            editButton.TabIndex = 7;
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
            onlyViewButton.Location = new Point(481, 39);
            onlyViewButton.Margin = new Padding(4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 6;
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
            searchButton.TabIndex = 5;
            searchButton.Click += searchButton_Click;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(1123, 119);
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
            labelControl4.Location = new Point(775, 119);
            labelControl4.Margin = new Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(261, 25);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "GEÇERLİLİK BAŞLANGICI";
            // 
            // textIsMerUznAck
            // 
            textIsMerUznAck.Location = new Point(775, 78);
            textIsMerUznAck.Margin = new Padding(4);
            textIsMerUznAck.Name = "textIsMerUznAck";
            textIsMerUznAck.Properties.ReadOnly = true;
            textIsMerUznAck.Size = new Size(611, 22);
            textIsMerUznAck.TabIndex = 22;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(775, 34);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(304, 25);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "İŞ MERKEZİ UZUN AÇIKLAMA";
            // 
            // textIsMerKod
            // 
            textIsMerKod.Location = new Point(9, 162);
            textIsMerKod.Margin = new Padding(4);
            textIsMerKod.Name = "textIsMerKod";
            textIsMerKod.Properties.ReadOnly = true;
            textIsMerKod.Size = new Size(275, 22);
            textIsMerKod.TabIndex = 18;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(9, 119);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(189, 25);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "İŞ MERKEZİ KODU";
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(312, 119);
            labelSehirUlkeCode.Margin = new Padding(4);
            labelSehirUlkeCode.Name = "labelSehirUlkeCode";
            labelSehirUlkeCode.Size = new Size(101, 25);
            labelSehirUlkeCode.TabIndex = 15;
            labelSehirUlkeCode.Text = "DİL KODU";
            // 
            // textIsMerKısaAck
            // 
            textIsMerKısaAck.Location = new Point(439, 78);
            textIsMerKısaAck.Margin = new Padding(4);
            textIsMerKısaAck.Name = "textIsMerKısaAck";
            textIsMerKısaAck.Properties.ReadOnly = true;
            textIsMerKısaAck.Size = new Size(308, 22);
            textIsMerKısaAck.TabIndex = 14;
            // 
            // labelSehirName
            // 
            labelSehirName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirName.Appearance.Options.UseFont = true;
            labelSehirName.Location = new Point(439, 34);
            labelSehirName.Margin = new Padding(4);
            labelSehirName.Name = "labelSehirName";
            labelSehirName.Size = new Size(317, 25);
            labelSehirName.TabIndex = 13;
            labelSehirName.Text = "İŞ MERKEZİ KISA AÇIKLAMASI";
            // 
            // labelSehirCode
            // 
            labelSehirCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirCode.Appearance.Options.UseFont = true;
            labelSehirCode.Location = new Point(195, 34);
            labelSehirCode.Margin = new Padding(4);
            labelSehirCode.Name = "labelSehirCode";
            labelSehirCode.Size = new Size(167, 25);
            labelSehirCode.TabIndex = 11;
            labelSehirCode.Text = "İŞ MERKEZİ TİPİ";
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
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(comboBoxIsMerTip);
            sehirSearchControl.Controls.Add(comboBoxDil);
            sehirSearchControl.Controls.Add(comboBoxFirmaKod);
            sehirSearchControl.Controls.Add(dateTimeBitis);
            sehirSearchControl.Controls.Add(dateTimeBaslangic);
            sehirSearchControl.Controls.Add(labelControl5);
            sehirSearchControl.Controls.Add(labelControl4);
            sehirSearchControl.Controls.Add(textIsMerUznAck);
            sehirSearchControl.Controls.Add(labelControl3);
            sehirSearchControl.Controls.Add(textIsMerKod);
            sehirSearchControl.Controls.Add(labelControl1);
            sehirSearchControl.Controls.Add(labelSehirUlkeCode);
            sehirSearchControl.Controls.Add(textIsMerKısaAck);
            sehirSearchControl.Controls.Add(labelSehirName);
            sehirSearchControl.Controls.Add(labelSehirCode);
            sehirSearchControl.Controls.Add(labelBirimFirmaCode);
            sehirSearchControl.Location = new Point(-1, 0);
            sehirSearchControl.Margin = new Padding(4);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1412, 208);
            sehirSearchControl.TabIndex = 39;
            sehirSearchControl.Text = "Arama";
            // 
            // comboBoxIsMerTip
            // 
            comboBoxIsMerTip.Enabled = false;
            comboBoxIsMerTip.FormattingEnabled = true;
            comboBoxIsMerTip.Location = new Point(195, 76);
            comboBoxIsMerTip.Margin = new Padding(4, 2, 4, 2);
            comboBoxIsMerTip.Name = "comboBoxIsMerTip";
            comboBoxIsMerTip.Size = new Size(195, 24);
            comboBoxIsMerTip.TabIndex = 56;
            // 
            // comboBoxDil
            // 
            comboBoxDil.Enabled = false;
            comboBoxDil.FormattingEnabled = true;
            comboBoxDil.Location = new Point(312, 160);
            comboBoxDil.Margin = new Padding(4, 2, 4, 2);
            comboBoxDil.Name = "comboBoxDil";
            comboBoxDil.Size = new Size(151, 24);
            comboBoxDil.TabIndex = 55;
            // 
            // comboBoxFirmaKod
            // 
            comboBoxFirmaKod.Enabled = false;
            comboBoxFirmaKod.FormattingEnabled = true;
            comboBoxFirmaKod.Location = new Point(9, 76);
            comboBoxFirmaKod.Margin = new Padding(4, 2, 4, 2);
            comboBoxFirmaKod.Name = "comboBoxFirmaKod";
            comboBoxFirmaKod.Size = new Size(151, 24);
            comboBoxFirmaKod.TabIndex = 54;
            // 
            // dateTimeBitis
            // 
            dateTimeBitis.Enabled = false;
            dateTimeBitis.Location = new Point(1123, 165);
            dateTimeBitis.Name = "dateTimeBitis";
            dateTimeBitis.Size = new Size(250, 23);
            dateTimeBitis.TabIndex = 41;
            // 
            // dateTimeBaslangic
            // 
            dateTimeBaslangic.Enabled = false;
            dateTimeBaslangic.Location = new Point(775, 165);
            dateTimeBaslangic.Name = "dateTimeBaslangic";
            dateTimeBaslangic.Size = new Size(250, 23);
            dateTimeBaslangic.TabIndex = 40;
            // 
            // workCenterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(dataGrid);
            Controls.Add(islemlerSehirText);
            Controls.Add(sehirSearchControl);
            Margin = new Padding(4);
            Name = "workCenterForm";
            Text = "İŞ MERKEZİ";
            Load += workCenterForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            islemlerSehirText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textIsMerUznAck.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textIsMerKod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textIsMerKısaAck.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl islemlerSehirText;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textIsMerUznAck;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textIsMerKod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelSehirUlkeCode;
        private DevExpress.XtraEditors.TextEdit textIsMerKısaAck;
        private DevExpress.XtraEditors.LabelControl labelSehirName;
        private DevExpress.XtraEditors.LabelControl labelSehirCode;
        private DevExpress.XtraEditors.LabelControl labelBirimFirmaCode;
        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private TextBox textArat;
        private DateTimePicker dateTimeBaslangic;
        private DateTimePicker dateTimeBitis;
        private ComboBox comboBoxFirmaKod;
        private ComboBox comboBoxIsMerTip;
        private ComboBox comboBoxDil;
    }
}