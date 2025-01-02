namespace ERP_APP
{
    partial class firmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firmaForm));
            dataFirmaGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            islemlerFirmaText = new DevExpress.XtraEditors.GroupControl();
            ButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            textArat = new TextBox();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            firmaSearchControl = new DevExpress.XtraEditors.GroupControl();
            comboBoxDil = new ComboBox();
            comboBoxSehir = new ComboBox();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textFirmaAdres2 = new DevExpress.XtraEditors.TextEdit();
            textFirmaAdres1 = new DevExpress.XtraEditors.TextEdit();
            textFirmaInfoEdit = new DevExpress.XtraEditors.TextEdit();
            labelFirmaInfo = new DevExpress.XtraEditors.LabelControl();
            textFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelFirmaName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)dataFirmaGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerFirmaText).BeginInit();
            islemlerFirmaText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)firmaSearchControl).BeginInit();
            firmaSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textFirmaAdres2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaAdres1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaInfoEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // dataFirmaGrid
            // 
            dataFirmaGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataFirmaGrid.Location = new Point(0, 242);
            dataFirmaGrid.MainView = gridView1;
            dataFirmaGrid.Name = "dataFirmaGrid";
            dataFirmaGrid.Size = new Size(1209, 1080);
            dataFirmaGrid.TabIndex = 0;
            dataFirmaGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dataFirmaGrid;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // islemlerFirmaText
            // 
            islemlerFirmaText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            islemlerFirmaText.Controls.Add(ButtonKaydet);
            islemlerFirmaText.Controls.Add(ButtonGüncelle);
            islemlerFirmaText.Controls.Add(textArat);
            islemlerFirmaText.Controls.Add(homePageButton);
            islemlerFirmaText.Controls.Add(dataAddButton);
            islemlerFirmaText.Controls.Add(deleteButton);
            islemlerFirmaText.Controls.Add(editButton);
            islemlerFirmaText.Controls.Add(onlyViewButton);
            islemlerFirmaText.Controls.Add(searchButton);
            islemlerFirmaText.Location = new Point(0, 169);
            islemlerFirmaText.Name = "islemlerFirmaText";
            islemlerFirmaText.Size = new Size(1210, 73);
            islemlerFirmaText.TabIndex = 1;
            islemlerFirmaText.Text = "İşlemler";
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Dock = DockStyle.Right;
            ButtonKaydet.Location = new Point(948, 23);
            ButtonKaydet.Margin = new Padding(3, 2, 3, 2);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(101, 48);
            ButtonKaydet.TabIndex = 52;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Dock = DockStyle.Right;
            ButtonGüncelle.Location = new Point(1049, 23);
            ButtonGüncelle.Margin = new Padding(3, 2, 3, 2);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(101, 48);
            ButtonGüncelle.TabIndex = 51;
            ButtonGüncelle.Text = "Güncelle";
            ButtonGüncelle.Visible = false;
            ButtonGüncelle.Click += ButtonGüncelle_Click;
            // 
            // textArat
            // 
            textArat.Location = new Point(248, 39);
            textArat.Margin = new Padding(3, 2, 3, 2);
            textArat.Name = "textArat";
            textArat.Size = new Size(160, 21);
            textArat.TabIndex = 48;
            // 
            // homePageButton
            // 
            homePageButton.Appearance.BackColor = SystemColors.Menu;
            homePageButton.Appearance.Options.UseBackColor = true;
            homePageButton.Dock = DockStyle.Right;
            homePageButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            homePageButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("homePageButton.ImageOptions.SvgImage");
            homePageButton.Location = new Point(1150, 23);
            homePageButton.Name = "homePageButton";
            homePageButton.Size = new Size(58, 48);
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
            dataAddButton.Location = new Point(135, 32);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(32, 32);
            dataAddButton.TabIndex = 4;
            dataAddButton.Click += dataAddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("deleteButton.ImageOptions.SvgImage");
            deleteButton.Location = new Point(195, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
            deleteButton.TabIndex = 3;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(75, 32);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 32);
            editButton.TabIndex = 2;
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
            onlyViewButton.Location = new Point(427, 32);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(0, 0);
            onlyViewButton.TabIndex = 1;
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
            searchButton.Location = new Point(13, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 0;
            searchButton.Click += searchButton_Click;
            // 
            // firmaSearchControl
            // 
            firmaSearchControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            firmaSearchControl.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            firmaSearchControl.AppearanceCaption.Options.UseBorderColor = true;
            firmaSearchControl.Controls.Add(comboBoxDil);
            firmaSearchControl.Controls.Add(comboBoxSehir);
            firmaSearchControl.Controls.Add(labelControl4);
            firmaSearchControl.Controls.Add(labelControl3);
            firmaSearchControl.Controls.Add(labelControl2);
            firmaSearchControl.Controls.Add(labelControl1);
            firmaSearchControl.Controls.Add(textFirmaAdres2);
            firmaSearchControl.Controls.Add(textFirmaAdres1);
            firmaSearchControl.Controls.Add(textFirmaInfoEdit);
            firmaSearchControl.Controls.Add(labelFirmaInfo);
            firmaSearchControl.Controls.Add(textFirmaCode);
            firmaSearchControl.Controls.Add(labelFirmaName);
            firmaSearchControl.Location = new Point(0, 0);
            firmaSearchControl.Name = "firmaSearchControl";
            firmaSearchControl.Size = new Size(1209, 169);
            firmaSearchControl.TabIndex = 3;
            firmaSearchControl.Text = "Arama";
            // 
            // comboBoxDil
            // 
            comboBoxDil.Enabled = false;
            comboBoxDil.FormattingEnabled = true;
            comboBoxDil.Location = new Point(219, 125);
            comboBoxDil.Name = "comboBoxDil";
            comboBoxDil.Size = new Size(154, 21);
            comboBoxDil.TabIndex = 22;
            // 
            // comboBoxSehir
            // 
            comboBoxSehir.Enabled = false;
            comboBoxSehir.FormattingEnabled = true;
            comboBoxSehir.Location = new Point(13, 125);
            comboBoxSehir.Name = "comboBoxSehir";
            comboBoxSehir.Size = new Size(154, 21);
            comboBoxSehir.TabIndex = 21;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(219, 98);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(101, 20);
            labelControl4.TabIndex = 18;
            labelControl4.Text = "ÜLKE KODU";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(13, 98);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(111, 20);
            labelControl3.TabIndex = 17;
            labelControl3.Text = "ŞEHİR KODU";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(765, 29);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(145, 20);
            labelControl2.TabIndex = 16;
            labelControl2.Text = "FİRMA ADRESİ-2";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(486, 29);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(145, 20);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "FİRMA ADRESİ-1";
            // 
            // textFirmaAdres2
            // 
            textFirmaAdres2.Location = new Point(765, 64);
            textFirmaAdres2.Name = "textFirmaAdres2";
            textFirmaAdres2.Properties.ReadOnly = true;
            textFirmaAdres2.Size = new Size(230, 20);
            textFirmaAdres2.TabIndex = 14;
            // 
            // textFirmaAdres1
            // 
            textFirmaAdres1.Location = new Point(486, 64);
            textFirmaAdres1.Name = "textFirmaAdres1";
            textFirmaAdres1.Properties.ReadOnly = true;
            textFirmaAdres1.Size = new Size(232, 20);
            textFirmaAdres1.TabIndex = 13;
            // 
            // textFirmaInfoEdit
            // 
            textFirmaInfoEdit.Location = new Point(219, 64);
            textFirmaInfoEdit.Name = "textFirmaInfoEdit";
            textFirmaInfoEdit.Properties.ReadOnly = true;
            textFirmaInfoEdit.Size = new Size(216, 20);
            textFirmaInfoEdit.TabIndex = 12;
            // 
            // labelFirmaInfo
            // 
            labelFirmaInfo.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelFirmaInfo.Appearance.Options.UseFont = true;
            labelFirmaInfo.Location = new Point(219, 29);
            labelFirmaInfo.Name = "labelFirmaInfo";
            labelFirmaInfo.Size = new Size(92, 20);
            labelFirmaInfo.TabIndex = 11;
            labelFirmaInfo.Text = "FİRMA ADI";
            // 
            // textFirmaCode
            // 
            textFirmaCode.Location = new Point(13, 64);
            textFirmaCode.Name = "textFirmaCode";
            textFirmaCode.Properties.ReadOnly = true;
            textFirmaCode.Size = new Size(154, 20);
            textFirmaCode.TabIndex = 10;
            // 
            // labelFirmaName
            // 
            labelFirmaName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelFirmaName.Appearance.Options.UseFont = true;
            labelFirmaName.Location = new Point(13, 29);
            labelFirmaName.Name = "labelFirmaName";
            labelFirmaName.Size = new Size(111, 20);
            labelFirmaName.TabIndex = 9;
            labelFirmaName.Text = "FİRMA KODU";
            // 
            // firmaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 647);
            Controls.Add(firmaSearchControl);
            Controls.Add(islemlerFirmaText);
            Controls.Add(dataFirmaGrid);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("firmaForm.IconOptions.SvgImage");
            IsMdiContainer = true;
            Name = "firmaForm";
            Text = "FİRMA";
            Load += firmaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataFirmaGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerFirmaText).EndInit();
            islemlerFirmaText.ResumeLayout(false);
            islemlerFirmaText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)firmaSearchControl).EndInit();
            firmaSearchControl.ResumeLayout(false);
            firmaSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textFirmaAdres2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaAdres1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaInfoEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl dataFirmaGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl islemlerFirmaText;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.GroupControl firmaSearchControl;
        private DevExpress.XtraEditors.TextEdit textFirmaInfoEdit;
        private DevExpress.XtraEditors.LabelControl labelFirmaInfo;
        private DevExpress.XtraEditors.TextEdit textFirmaCode;
        private DevExpress.XtraEditors.LabelControl labelFirmaName;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textFirmaAdres2;
        private DevExpress.XtraEditors.TextEdit textFirmaAdres1;
        private TextBox textArat;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private ComboBox comboBoxDil;
        private ComboBox comboBoxSehir;
    }
}