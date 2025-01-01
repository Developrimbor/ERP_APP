namespace ERP_APP
{
    partial class rotaTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rotaTypeForm));
            sehirSearchControl = new DevExpress.XtraEditors.GroupControl();
            textIsPassive = new DevExpress.XtraEditors.TextEdit();
            labelSehirUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textRotaTipAck = new DevExpress.XtraEditors.TextEdit();
            labelSehirName = new DevExpress.XtraEditors.LabelControl();
            textRotaTip = new DevExpress.XtraEditors.TextEdit();
            labelSehirCode = new DevExpress.XtraEditors.LabelControl();
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
            dataSehirGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            comboBoxFirmaKod = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).BeginInit();
            sehirSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textIsPassive.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textRotaTipAck.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textRotaTip.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).BeginInit();
            islemlerSehirText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSehirGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // sehirSearchControl
            // 
            sehirSearchControl.Controls.Add(comboBoxFirmaKod);
            sehirSearchControl.Controls.Add(textIsPassive);
            sehirSearchControl.Controls.Add(labelSehirUlkeCode);
            sehirSearchControl.Controls.Add(textRotaTipAck);
            sehirSearchControl.Controls.Add(labelSehirName);
            sehirSearchControl.Controls.Add(textRotaTip);
            sehirSearchControl.Controls.Add(labelSehirCode);
            sehirSearchControl.Controls.Add(labelBirimFirmaCode);
            sehirSearchControl.Location = new Point(-1, 0);
            sehirSearchControl.Margin = new Padding(4);
            sehirSearchControl.Name = "sehirSearchControl";
            sehirSearchControl.Size = new Size(1412, 208);
            sehirSearchControl.TabIndex = 24;
            sehirSearchControl.Text = "Arama";
            // 
            // textIsPassive
            // 
            textIsPassive.Location = new Point(768, 111);
            textIsPassive.Margin = new Padding(4);
            textIsPassive.Name = "textIsPassive";
            textIsPassive.Properties.ReadOnly = true;
            textIsPassive.Size = new Size(180, 22);
            textIsPassive.TabIndex = 16;
            // 
            // labelSehirUlkeCode
            // 
            labelSehirUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirUlkeCode.Appearance.Options.UseFont = true;
            labelSehirUlkeCode.Location = new Point(768, 68);
            labelSehirUlkeCode.Margin = new Padding(4);
            labelSehirUlkeCode.Name = "labelSehirUlkeCode";
            labelSehirUlkeCode.Size = new Size(105, 25);
            labelSehirUlkeCode.TabIndex = 15;
            labelSehirUlkeCode.Text = "PASİF Mİ?";
            // 
            // textRotaTipAck
            // 
            textRotaTipAck.Location = new Point(511, 111);
            textRotaTipAck.Margin = new Padding(4);
            textRotaTipAck.Name = "textRotaTipAck";
            textRotaTipAck.Properties.ReadOnly = true;
            textRotaTipAck.Size = new Size(180, 22);
            textRotaTipAck.TabIndex = 14;
            // 
            // labelSehirName
            // 
            labelSehirName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirName.Appearance.Options.UseFont = true;
            labelSehirName.Location = new Point(511, 68);
            labelSehirName.Margin = new Padding(4);
            labelSehirName.Name = "labelSehirName";
            labelSehirName.Size = new Size(245, 25);
            labelSehirName.TabIndex = 13;
            labelSehirName.Text = "ROTA TİPİ AÇIKLAMASI";
            // 
            // textRotaTip
            // 
            textRotaTip.Location = new Point(258, 111);
            textRotaTip.Margin = new Padding(4);
            textRotaTip.Name = "textRotaTip";
            textRotaTip.Properties.ReadOnly = true;
            textRotaTip.Size = new Size(180, 22);
            textRotaTip.TabIndex = 12;
            // 
            // labelSehirCode
            // 
            labelSehirCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelSehirCode.Appearance.Options.UseFont = true;
            labelSehirCode.Location = new Point(258, 68);
            labelSehirCode.Margin = new Padding(4);
            labelSehirCode.Name = "labelSehirCode";
            labelSehirCode.Size = new Size(106, 25);
            labelSehirCode.TabIndex = 11;
            labelSehirCode.Text = "ROTA TİPİ";
            // 
            // labelBirimFirmaCode
            // 
            labelBirimFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelBirimFirmaCode.Appearance.Options.UseFont = true;
            labelBirimFirmaCode.Location = new Point(13, 68);
            labelBirimFirmaCode.Margin = new Padding(4);
            labelBirimFirmaCode.Name = "labelBirimFirmaCode";
            labelBirimFirmaCode.Size = new Size(134, 25);
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
            islemlerSehirText.Location = new Point(-1, 208);
            islemlerSehirText.Margin = new Padding(4);
            islemlerSehirText.Name = "islemlerSehirText";
            islemlerSehirText.Size = new Size(1412, 90);
            islemlerSehirText.TabIndex = 23;
            islemlerSehirText.Text = "İşlemler";
            // 
            // textArat
            // 
            textArat.Location = new Point(279, 49);
            textArat.Name = "textArat";
            textArat.Size = new Size(186, 23);
            textArat.TabIndex = 50;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1217, 42);
            ButtonKaydet.Margin = new Padding(4, 2, 4, 2);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(118, 36);
            ButtonKaydet.TabIndex = 51;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(1092, 42);
            ButtonGüncelle.Margin = new Padding(4, 2, 4, 2);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(118, 36);
            ButtonGüncelle.TabIndex = 50;
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
            dataAddButton.Location = new Point(156, 39);
            dataAddButton.Margin = new Padding(4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
            dataAddButton.TabIndex = 29;
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
            searchButton.TabIndex = 25;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(226, 39);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
            deleteButton.TabIndex = 28;
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
            onlyViewButton.Location = new Point(485, 42);
            onlyViewButton.Margin = new Padding(4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 26;
            onlyViewButton.Click += onlyViewButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(86, 39);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(37, 39);
            editButton.TabIndex = 27;
            editButton.Click += editButton_Click;
            // 
            // dataSehirGrid
            // 
            dataSehirGrid.EmbeddedNavigator.Margin = new Padding(4);
            dataSehirGrid.Location = new Point(-1, 297);
            dataSehirGrid.MainView = gridView1;
            dataSehirGrid.Margin = new Padding(4);
            dataSehirGrid.Name = "dataSehirGrid";
            dataSehirGrid.Size = new Size(1412, 498);
            dataSehirGrid.TabIndex = 22;
            dataSehirGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 431;
            gridView1.GridControl = dataSehirGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // comboBoxFirmaKod
            // 
            comboBoxFirmaKod.Enabled = false;
            comboBoxFirmaKod.FormattingEnabled = true;
            comboBoxFirmaKod.Location = new Point(14, 109);
            comboBoxFirmaKod.Margin = new Padding(4, 2, 4, 2);
            comboBoxFirmaKod.Name = "comboBoxFirmaKod";
            comboBoxFirmaKod.Size = new Size(151, 24);
            comboBoxFirmaKod.TabIndex = 54;
            // 
            // rotaTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(sehirSearchControl);
            Controls.Add(islemlerSehirText);
            Controls.Add(dataSehirGrid);
            Margin = new Padding(4);
            Name = "rotaTypeForm";
            Text = "ROTA TİPİ";
            Load += rotaTypeForm_Load;
            ((System.ComponentModel.ISupportInitialize)sehirSearchControl).EndInit();
            sehirSearchControl.ResumeLayout(false);
            sehirSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textIsPassive.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textRotaTipAck.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textRotaTip.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerSehirText).EndInit();
            islemlerSehirText.ResumeLayout(false);
            islemlerSehirText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSehirGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl sehirSearchControl;
        private DevExpress.XtraEditors.TextEdit textIsPassive;
        private DevExpress.XtraEditors.LabelControl labelSehirUlkeCode;
        private DevExpress.XtraEditors.TextEdit textRotaTipAck;
        private DevExpress.XtraEditors.LabelControl labelSehirName;
        private DevExpress.XtraEditors.TextEdit textRotaTip;
        private DevExpress.XtraEditors.LabelControl labelSehirCode;
        private DevExpress.XtraEditors.LabelControl labelBirimFirmaCode;
        private DevExpress.XtraEditors.GroupControl islemlerSehirText;
        private DevExpress.XtraGrid.GridControl dataSehirGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private TextBox textArat;
        private ComboBox comboBoxFirmaKod;
    }
}