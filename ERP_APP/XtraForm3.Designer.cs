namespace ERP_APP
{
    partial class ulkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ulkeForm));
            ulkeSearchControl = new DevExpress.XtraEditors.GroupControl();
            textDilName = new DevExpress.XtraEditors.TextEdit();
            labelUlkeName = new DevExpress.XtraEditors.LabelControl();
            textUlkeCode = new DevExpress.XtraEditors.TextEdit();
            labelUlkeCode = new DevExpress.XtraEditors.LabelControl();
            labelUlkeFirmaCode = new DevExpress.XtraEditors.LabelControl();
            islemlerUlkeText = new DevExpress.XtraEditors.GroupControl();
            textArat = new TextBox();
            ButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            dataUlkeGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            comboBoxFirmaCode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ulkeSearchControl).BeginInit();
            ulkeSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerUlkeText).BeginInit();
            islemlerUlkeText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUlkeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // ulkeSearchControl
            // 
            ulkeSearchControl.Controls.Add(comboBoxFirmaCode);
            ulkeSearchControl.Controls.Add(textDilName);
            ulkeSearchControl.Controls.Add(labelUlkeName);
            ulkeSearchControl.Controls.Add(textUlkeCode);
            ulkeSearchControl.Controls.Add(labelUlkeCode);
            ulkeSearchControl.Controls.Add(labelUlkeFirmaCode);
            ulkeSearchControl.Location = new Point(-1, 0);
            ulkeSearchControl.Name = "ulkeSearchControl";
            ulkeSearchControl.Size = new Size(1210, 169);
            ulkeSearchControl.TabIndex = 9;
            ulkeSearchControl.Text = "Arama";
            // 
            // textDilName
            // 
            textDilName.Location = new Point(438, 90);
            textDilName.Name = "textDilName";
            textDilName.Properties.ReadOnly = true;
            textDilName.Size = new Size(154, 20);
            textDilName.TabIndex = 14;
            // 
            // labelUlkeName
            // 
            labelUlkeName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelUlkeName.Appearance.Options.UseFont = true;
            labelUlkeName.Location = new Point(438, 55);
            labelUlkeName.Name = "labelUlkeName";
            labelUlkeName.Size = new Size(82, 20);
            labelUlkeName.TabIndex = 13;
            labelUlkeName.Text = "ÜLKE ADI";
            // 
            // textUlkeCode
            // 
            textUlkeCode.Location = new Point(221, 90);
            textUlkeCode.Name = "textUlkeCode";
            textUlkeCode.Properties.ReadOnly = true;
            textUlkeCode.Size = new Size(154, 20);
            textUlkeCode.TabIndex = 12;
            // 
            // labelUlkeCode
            // 
            labelUlkeCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelUlkeCode.Appearance.Options.UseFont = true;
            labelUlkeCode.Location = new Point(221, 55);
            labelUlkeCode.Name = "labelUlkeCode";
            labelUlkeCode.Size = new Size(101, 20);
            labelUlkeCode.TabIndex = 11;
            labelUlkeCode.Text = "ÜLKE KODU";
            // 
            // labelUlkeFirmaCode
            // 
            labelUlkeFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelUlkeFirmaCode.Appearance.Options.UseFont = true;
            labelUlkeFirmaCode.Location = new Point(11, 55);
            labelUlkeFirmaCode.Name = "labelUlkeFirmaCode";
            labelUlkeFirmaCode.Size = new Size(111, 20);
            labelUlkeFirmaCode.TabIndex = 9;
            labelUlkeFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerUlkeText
            // 
            islemlerUlkeText.Controls.Add(textArat);
            islemlerUlkeText.Controls.Add(ButtonKaydet);
            islemlerUlkeText.Controls.Add(ButtonGüncelle);
            islemlerUlkeText.Controls.Add(homePageButton);
            islemlerUlkeText.Controls.Add(dataAddButton);
            islemlerUlkeText.Controls.Add(deleteButton);
            islemlerUlkeText.Controls.Add(editButton);
            islemlerUlkeText.Controls.Add(onlyViewButton);
            islemlerUlkeText.Controls.Add(searchButton);
            islemlerUlkeText.Location = new Point(-1, 169);
            islemlerUlkeText.Name = "islemlerUlkeText";
            islemlerUlkeText.Size = new Size(1210, 73);
            islemlerUlkeText.TabIndex = 8;
            islemlerUlkeText.Text = "İşlemler";
            // 
            // textArat
            // 
            textArat.Location = new Point(253, 39);
            textArat.Margin = new Padding(3, 2, 3, 2);
            textArat.Name = "textArat";
            textArat.Size = new Size(160, 21);
            textArat.TabIndex = 47;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1057, 34);
            ButtonKaydet.Margin = new Padding(3, 2, 3, 2);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(101, 29);
            ButtonKaydet.TabIndex = 47;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(942, 34);
            ButtonGüncelle.Margin = new Padding(3, 2, 3, 2);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(101, 29);
            ButtonGüncelle.TabIndex = 46;
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
            dataAddButton.Location = new Point(134, 32);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(32, 32);
            dataAddButton.TabIndex = 9;
            dataAddButton.Click += dataAddButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = Properties.Resources.Delete3;
            deleteButton.Location = new Point(194, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
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
            editButton.Location = new Point(74, 32);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 32);
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
            onlyViewButton.Location = new Point(438, 32);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(32, 32);
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
            searchButton.Location = new Point(13, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 5;
            searchButton.Click += searchButton_Click;
            // 
            // dataUlkeGrid
            // 
            dataUlkeGrid.Location = new Point(-1, 241);
            dataUlkeGrid.MainView = gridView1;
            dataUlkeGrid.Name = "dataUlkeGrid";
            dataUlkeGrid.Size = new Size(1210, 405);
            dataUlkeGrid.TabIndex = 7;
            dataUlkeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dataUlkeGrid;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowObjectChanged += gridView1_FocusedRowObjectChanged;
            // 
            // comboBoxFirmaCode
            // 
            comboBoxFirmaCode.Enabled = false;
            comboBoxFirmaCode.FormattingEnabled = true;
            comboBoxFirmaCode.Location = new Point(11, 90);
            comboBoxFirmaCode.Name = "comboBoxFirmaCode";
            comboBoxFirmaCode.Size = new Size(154, 21);
            comboBoxFirmaCode.TabIndex = 15;
            // 
            // ulkeForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 647);
            Controls.Add(ulkeSearchControl);
            Controls.Add(islemlerUlkeText);
            Controls.Add(dataUlkeGrid);
            Name = "ulkeForm";
            Text = "ÜLKE";
            Load += ulkeForm_Load;
            ((System.ComponentModel.ISupportInitialize)ulkeSearchControl).EndInit();
            ulkeSearchControl.ResumeLayout(false);
            ulkeSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerUlkeText).EndInit();
            islemlerUlkeText.ResumeLayout(false);
            islemlerUlkeText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataUlkeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl ulkeSearchControl;
        private DevExpress.XtraEditors.TextEdit textDilName;
        private DevExpress.XtraEditors.LabelControl labelUlkeName;
        private DevExpress.XtraEditors.TextEdit textUlkeCode;
        private DevExpress.XtraEditors.LabelControl labelUlkeCode;
        private DevExpress.XtraEditors.LabelControl labelUlkeFirmaCode;
        private DevExpress.XtraEditors.GroupControl islemlerUlkeText;
        private DevExpress.XtraGrid.GridControl dataUlkeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private TextBox textArat;
        private ComboBox comboBoxFirmaCode;
    }
}