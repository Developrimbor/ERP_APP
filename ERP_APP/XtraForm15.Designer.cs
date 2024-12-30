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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkranUrunAgaciForm));
            dataGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            islemlerSehirText = new DevExpress.XtraEditors.GroupControl();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textSehirUlkeCode = new DevExpress.XtraEditors.TextEdit();
            labelSehirUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textSehirName = new DevExpress.XtraEditors.TextEdit();
            labelSehirName = new DevExpress.XtraEditors.LabelControl();
            textSehirCode = new DevExpress.XtraEditors.TextEdit();
            sehirSearchControl = new DevExpress.XtraEditors.GroupControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelSehirCode = new DevExpress.XtraEditors.LabelControl();
            textSehirFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelBirimFirmaCode = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            textTemelMiktar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).BeginInit();
            islemlerSehirText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textSehirUlkeCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textSehirName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textSehirCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).BeginInit();
            sehirSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textSehirFirmaCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textTemelMiktar.Properties).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            dataGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1, gridLevelNode2 });
            dataGrid.Location = new Point(-1, 297);
            dataGrid.MainView = gridView1;
            dataGrid.Margin = new Padding(4, 4, 4, 4);
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
            // 
            // islemlerSehirText
            // 
            islemlerSehirText.Controls.Add(homePageButton);
            islemlerSehirText.Controls.Add(dataAddButton);
            islemlerSehirText.Controls.Add(deleteButton);
            islemlerSehirText.Controls.Add(editButton);
            islemlerSehirText.Controls.Add(onlyViewButton);
            islemlerSehirText.Controls.Add(searchButton);
            islemlerSehirText.Location = new Point(-1, 208);
            islemlerSehirText.Margin = new Padding(4, 4, 4, 4);
            islemlerSehirText.Name = "islemlerSehirText";
            islemlerSehirText.Size = new Size(1412, 90);
            islemlerSehirText.TabIndex = 41;
            islemlerSehirText.Text = "İşlemler";
            // 
            // homePageButton
            // 
            homePageButton.Appearance.BackColor = SystemColors.Menu;
            homePageButton.Appearance.Options.UseBackColor = true;
            homePageButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            homePageButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("homePageButton.ImageOptions.SvgImage");
            homePageButton.Location = new Point(1358, 39);
            homePageButton.Margin = new Padding(4, 4, 4, 4);
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
            dataAddButton.Location = new Point(225, 39);
            dataAddButton.Margin = new Padding(4, 4, 4, 4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
            dataAddButton.TabIndex = 14;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(295, 39);
            deleteButton.Margin = new Padding(4, 4, 4, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
            deleteButton.TabIndex = 13;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(155, 39);
            editButton.Margin = new Padding(4, 4, 4, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(37, 39);
            editButton.TabIndex = 12;
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
            onlyViewButton.Margin = new Padding(4, 4, 4, 4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 11;
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
            searchButton.Margin = new Padding(4, 4, 4, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(37, 39);
            searchButton.TabIndex = 10;
            // 
            // textEdit5
            // 
            textEdit5.Location = new Point(1087, 162);
            textEdit5.Margin = new Padding(4, 4, 4, 4);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new Size(180, 22);
            textEdit5.TabIndex = 26;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(1087, 119);
            labelControl5.Margin = new Padding(4, 4, 4, 4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(186, 25);
            labelControl5.TabIndex = 25;
            labelControl5.Text = "GEÇERLİLİK BİTİŞ";
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(764, 162);
            textEdit4.Margin = new Padding(4, 4, 4, 4);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(180, 22);
            textEdit4.TabIndex = 24;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(764, 119);
            labelControl4.Margin = new Padding(4, 4, 4, 4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(261, 25);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "GEÇERLİLİK BAŞLANGICI";
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(905, 39);
            textEdit3.Margin = new Padding(4, 4, 4, 4);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(23, 22);
            textEdit3.TabIndex = 22;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(780, 36);
            labelControl3.Margin = new Padding(4, 4, 4, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(117, 25);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "SİLİNDİ Mİ?";
            // 
            // textSehirUlkeCode
            // 
            textSehirUlkeCode.Location = new Point(322, 162);
            textSehirUlkeCode.Margin = new Padding(4, 4, 4, 4);
            textSehirUlkeCode.Name = "textSehirUlkeCode";
            textSehirUlkeCode.Size = new Size(180, 22);
            textSehirUlkeCode.TabIndex = 16;
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(322, 119);
            labelSehirUlkeCode.Margin = new Padding(4, 4, 4, 4);
            labelSehirUlkeCode.Name = "labelSehirUlkeCode";
            labelSehirUlkeCode.Size = new Size(201, 25);
            labelSehirUlkeCode.TabIndex = 15;
            labelSehirUlkeCode.Text = "ÜRÜN AĞACI KODU";
            // 
            // textSehirName
            // 
            textSehirName.Location = new Point(439, 78);
            textSehirName.Margin = new Padding(4, 4, 4, 4);
            textSehirName.Name = "textSehirName";
            textSehirName.Size = new Size(308, 22);
            textSehirName.TabIndex = 14;
            // 
            // labelSehirName
            // 
            labelSehirName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirName.Appearance.Options.UseFont = true;
            labelSehirName.Location = new Point(439, 34);
            labelSehirName.Margin = new Padding(4, 4, 4, 4);
            labelSehirName.Name = "labelSehirName";
            labelSehirName.Size = new Size(172, 25);
            labelSehirName.TabIndex = 13;
            labelSehirName.Text = "MALZEME KODU";
            // 
            // textSehirCode
            // 
            textSehirCode.Location = new Point(195, 78);
            textSehirCode.Margin = new Padding(4, 4, 4, 4);
            textSehirCode.Name = "textSehirCode";
            textSehirCode.Size = new Size(227, 22);
            textSehirCode.TabIndex = 12;
            // 
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(textTemelMiktar);
            sehirSearchControl.Controls.Add(labelControl6);
            sehirSearchControl.Controls.Add(textEdit2);
            sehirSearchControl.Controls.Add(labelControl2);
            sehirSearchControl.Controls.Add(textEdit5);
            sehirSearchControl.Controls.Add(labelControl5);
            sehirSearchControl.Controls.Add(textEdit4);
            sehirSearchControl.Controls.Add(labelControl4);
            sehirSearchControl.Controls.Add(textEdit3);
            sehirSearchControl.Controls.Add(labelControl3);
            sehirSearchControl.Controls.Add(textEdit1);
            sehirSearchControl.Controls.Add(labelControl1);
            sehirSearchControl.Controls.Add(textSehirUlkeCode);
            sehirSearchControl.Controls.Add(labelSehirUlkeCode);
            sehirSearchControl.Controls.Add(textSehirName);
            sehirSearchControl.Controls.Add(labelSehirName);
            sehirSearchControl.Controls.Add(textSehirCode);
            sehirSearchControl.Controls.Add(labelSehirCode);
            sehirSearchControl.Controls.Add(textSehirFirmaCode);
            sehirSearchControl.Controls.Add(labelBirimFirmaCode);
            sehirSearchControl.Location = new Point(-1, 0);
            sehirSearchControl.Margin = new Padding(4, 4, 4, 4);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1412, 208);
            sehirSearchControl.TabIndex = 42;
            sehirSearchControl.Text = "Arama";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(1100, 40);
            textEdit2.Margin = new Padding(4, 4, 4, 4);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(23, 22);
            textEdit2.TabIndex = 28;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(987, 36);
            labelControl2.Margin = new Padding(4, 4, 4, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(105, 25);
            labelControl2.TabIndex = 27;
            labelControl2.Text = "PASİF Mİ?";
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(9, 162);
            textEdit1.Margin = new Padding(4, 4, 4, 4);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(275, 22);
            textEdit1.TabIndex = 18;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(9, 119);
            labelControl1.Margin = new Padding(4, 4, 4, 4);
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
            labelSehirCode.Margin = new Padding(4, 4, 4, 4);
            labelSehirCode.Name = "labelSehirCode";
            labelSehirCode.Size = new Size(150, 25);
            labelSehirCode.TabIndex = 11;
            labelSehirCode.Text = "MALZEME TİPİ";
            // 
            // textSehirFirmaCode
            // 
            textSehirFirmaCode.Location = new Point(9, 78);
            textSehirFirmaCode.Margin = new Padding(4, 4, 4, 4);
            textSehirFirmaCode.Name = "textSehirFirmaCode";
            textSehirFirmaCode.Size = new Size(168, 22);
            textSehirFirmaCode.TabIndex = 10;
            // 
            // labelBirimFirmaCode
            // 
            labelBirimFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelBirimFirmaCode.Appearance.Options.UseFont = true;
            labelBirimFirmaCode.Location = new Point(9, 34);
            labelBirimFirmaCode.Margin = new Padding(4, 4, 4, 4);
            labelBirimFirmaCode.Name = "labelBirimFirmaCode";
            labelBirimFirmaCode.Size = new Size(134, 25);
            labelBirimFirmaCode.TabIndex = 9;
            labelBirimFirmaCode.Text = "FİRMA KODU";
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
            // textTemelMiktar
            // 
            textTemelMiktar.Location = new Point(547, 162);
            textTemelMiktar.Margin = new Padding(4);
            textTemelMiktar.Name = "textTemelMiktar";
            textTemelMiktar.Size = new Size(180, 22);
            textTemelMiktar.TabIndex = 30;
            // 
            // anaEkranUrunAgaciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(dataGrid);
            Controls.Add(islemlerSehirText);
            Controls.Add(sehirSearchControl);
            Margin = new Padding(4, 4, 4, 4);
            Name = "anaEkranUrunAgaciForm";
            Text = "Ana Ekran Ürün Ağacı";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textSehirUlkeCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textSehirName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textSehirCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textSehirFirmaCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textTemelMiktar.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl islemlerSehirText;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textSehirUlkeCode;
        private DevExpress.XtraEditors.LabelControl labelSehirUlkeCode;
        private DevExpress.XtraEditors.TextEdit textSehirName;
        private DevExpress.XtraEditors.LabelControl labelSehirName;
        private DevExpress.XtraEditors.TextEdit textSehirCode;
        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelSehirCode;
        private DevExpress.XtraEditors.TextEdit textSehirFirmaCode;
        private DevExpress.XtraEditors.LabelControl labelBirimFirmaCode;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.TextEdit textTemelMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}