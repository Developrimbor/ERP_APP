namespace ERP_APP
{
    partial class dilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dilForm));
            dilSearchControl = new DevExpress.XtraEditors.GroupControl();
            textDilName = new DevExpress.XtraEditors.TextEdit();
            labelDilName = new DevExpress.XtraEditors.LabelControl();
            textDilCode = new DevExpress.XtraEditors.TextEdit();
            labelDilCode = new DevExpress.XtraEditors.LabelControl();
            labelDilFirmaCode = new DevExpress.XtraEditors.LabelControl();
            islemlerDilText = new DevExpress.XtraEditors.GroupControl();
            textArat = new TextBox();
            ButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            ButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            dataDilGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            comboBoxFirmaCode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dilSearchControl).BeginInit();
            dilSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textDilCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerDilText).BeginInit();
            islemlerDilText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDilGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // dilSearchControl
            // 
            dilSearchControl.Controls.Add(comboBoxFirmaCode);
            dilSearchControl.Controls.Add(textDilName);
            dilSearchControl.Controls.Add(labelDilName);
            dilSearchControl.Controls.Add(textDilCode);
            dilSearchControl.Controls.Add(labelDilCode);
            dilSearchControl.Controls.Add(labelDilFirmaCode);
            dilSearchControl.Location = new Point(-1, 0);
            dilSearchControl.Name = "dilSearchControl";
            dilSearchControl.Size = new Size(1210, 169);
            dilSearchControl.TabIndex = 6;
            dilSearchControl.Text = "Arama";
            // 
            // textDilName
            // 
            textDilName.Location = new Point(438, 90);
            textDilName.Name = "textDilName";
            textDilName.Properties.ReadOnly = true;
            textDilName.Size = new Size(154, 20);
            textDilName.TabIndex = 14;
            textDilName.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // labelDilName
            // 
            labelDilName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDilName.Appearance.Options.UseFont = true;
            labelDilName.Location = new Point(438, 55);
            labelDilName.Name = "labelDilName";
            labelDilName.Size = new Size(65, 20);
            labelDilName.TabIndex = 13;
            labelDilName.Text = "DİL ADI";
            // 
            // textDilCode
            // 
            textDilCode.Location = new Point(221, 90);
            textDilCode.Name = "textDilCode";
            textDilCode.Properties.ReadOnly = true;
            textDilCode.Size = new Size(154, 20);
            textDilCode.TabIndex = 12;
            // 
            // labelDilCode
            // 
            labelDilCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDilCode.Appearance.Options.UseFont = true;
            labelDilCode.Location = new Point(221, 55);
            labelDilCode.Name = "labelDilCode";
            labelDilCode.Size = new Size(84, 20);
            labelDilCode.TabIndex = 11;
            labelDilCode.Text = "DİL KODU";
            // 
            // labelDilFirmaCode
            // 
            labelDilFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDilFirmaCode.Appearance.Options.UseFont = true;
            labelDilFirmaCode.Location = new Point(11, 55);
            labelDilFirmaCode.Name = "labelDilFirmaCode";
            labelDilFirmaCode.Size = new Size(111, 20);
            labelDilFirmaCode.TabIndex = 9;
            labelDilFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerDilText
            // 
            islemlerDilText.Controls.Add(textArat);
            islemlerDilText.Controls.Add(ButtonGüncelle);
            islemlerDilText.Controls.Add(ButtonKaydet);
            islemlerDilText.Controls.Add(homePageButton);
            islemlerDilText.Controls.Add(dataAddButton);
            islemlerDilText.Controls.Add(searchButton);
            islemlerDilText.Controls.Add(deleteButton);
            islemlerDilText.Controls.Add(onlyViewButton);
            islemlerDilText.Controls.Add(editButton);
            islemlerDilText.Location = new Point(-1, 169);
            islemlerDilText.Name = "islemlerDilText";
            islemlerDilText.Size = new Size(1210, 73);
            islemlerDilText.TabIndex = 5;
            islemlerDilText.Text = "İşlemler";
            // 
            // textArat
            // 
            textArat.Location = new Point(221, 39);
            textArat.Margin = new Padding(3, 2, 3, 2);
            textArat.Name = "textArat";
            textArat.Size = new Size(160, 21);
            textArat.TabIndex = 46;
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(929, 34);
            ButtonGüncelle.Margin = new Padding(3, 2, 3, 2);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(101, 29);
            ButtonGüncelle.TabIndex = 45;
            ButtonGüncelle.Text = "Güncelle";
            ButtonGüncelle.Visible = false;
            ButtonGüncelle.Click += ButtonGüncelle_Click;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1035, 34);
            ButtonKaydet.Margin = new Padding(3, 2, 3, 2);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(101, 29);
            ButtonKaydet.TabIndex = 44;
            ButtonKaydet.Text = "Kaydet";
            ButtonKaydet.Visible = false;
            ButtonKaydet.Click += ButtonKaydet_Click;
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
            dataAddButton.Location = new Point(109, 32);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(32, 32);
            dataAddButton.TabIndex = 11;
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
            searchButton.TabIndex = 7;
            searchButton.Click += searchButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Appearance.BackColor = SystemColors.Menu;
            deleteButton.Appearance.Options.UseBackColor = true;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            deleteButton.ImageOptions.SvgImage = Properties.Resources.Delete2;
            deleteButton.Location = new Point(156, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
            deleteButton.TabIndex = 10;
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
            onlyViewButton.Location = new Point(398, 32);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(32, 32);
            onlyViewButton.TabIndex = 8;
            onlyViewButton.Click += onlyViewButton_Click;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(61, 32);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 32);
            editButton.TabIndex = 9;
            editButton.Click += editButton_Click;
            // 
            // dataDilGrid
            // 
            dataDilGrid.Location = new Point(-1, 241);
            dataDilGrid.MainView = gridView1;
            dataDilGrid.Name = "dataDilGrid";
            dataDilGrid.Size = new Size(1210, 405);
            dataDilGrid.TabIndex = 4;
            dataDilGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dataDilGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
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
            // dilForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 647);
            Controls.Add(dilSearchControl);
            Controls.Add(islemlerDilText);
            Controls.Add(dataDilGrid);
            Name = "dilForm";
            Text = "DİL";
            Load += dilForm_Load;
            ((System.ComponentModel.ISupportInitialize)dilSearchControl).EndInit();
            dilSearchControl.ResumeLayout(false);
            dilSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textDilCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerDilText).EndInit();
            islemlerDilText.ResumeLayout(false);
            islemlerDilText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataDilGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl dilSearchControl;
        private DevExpress.XtraEditors.TextEdit textDilCode;
        private DevExpress.XtraEditors.LabelControl labelDilCode;
        private DevExpress.XtraEditors.LabelControl labelDilFirmaCode;
        private DevExpress.XtraEditors.GroupControl islemlerDilText;
        private DevExpress.XtraGrid.GridControl dataDilGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textDilName;
        private DevExpress.XtraEditors.LabelControl labelDilName;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
        private DevExpress.XtraEditors.SimpleButton ButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton ButtonGüncelle;
        private TextBox textArat;
        private ComboBox comboBoxFirmaCode;
    }
}