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
            textDilFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelDilFirmaCode = new DevExpress.XtraEditors.LabelControl();
            islemlerDilText = new DevExpress.XtraEditors.GroupControl();
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
            ((System.ComponentModel.ISupportInitialize)dilSearchControl).BeginInit();
            dilSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textDilCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textDilFirmaCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerDilText).BeginInit();
            islemlerDilText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDilGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // dilSearchControl
            // 
            dilSearchControl.Controls.Add(textDilName);
            dilSearchControl.Controls.Add(labelDilName);
            dilSearchControl.Controls.Add(textDilCode);
            dilSearchControl.Controls.Add(labelDilCode);
            dilSearchControl.Controls.Add(textDilFirmaCode);
            dilSearchControl.Controls.Add(labelDilFirmaCode);
            dilSearchControl.Location = new Point(-1, 0);
            dilSearchControl.Margin = new Padding(4);
            dilSearchControl.Name = "dilSearchControl";
            dilSearchControl.Size = new Size(1412, 208);
            dilSearchControl.TabIndex = 6;
            dilSearchControl.Text = "Arama";
            // 
            // textDilName
            // 
            textDilName.Location = new Point(511, 111);
            textDilName.Margin = new Padding(4);
            textDilName.Name = "textDilName";
            textDilName.Properties.ReadOnly = true;
            textDilName.Size = new Size(180, 22);
            textDilName.TabIndex = 14;
            textDilName.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // labelDilName
            // 
            labelDilName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDilName.Appearance.Options.UseFont = true;
            labelDilName.Location = new Point(511, 68);
            labelDilName.Margin = new Padding(4);
            labelDilName.Name = "labelDilName";
            labelDilName.Size = new Size(75, 25);
            labelDilName.TabIndex = 13;
            labelDilName.Text = "DİL ADI";
            // 
            // textDilCode
            // 
            textDilCode.Location = new Point(258, 111);
            textDilCode.Margin = new Padding(4);
            textDilCode.Name = "textDilCode";
            textDilCode.Properties.ReadOnly = true;
            textDilCode.Size = new Size(180, 22);
            textDilCode.TabIndex = 12;
            // 
            // labelDilCode
            // 
            labelDilCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDilCode.Appearance.Options.UseFont = true;
            labelDilCode.Location = new Point(258, 68);
            labelDilCode.Margin = new Padding(4);
            labelDilCode.Name = "labelDilCode";
            labelDilCode.Size = new Size(101, 25);
            labelDilCode.TabIndex = 11;
            labelDilCode.Text = "DİL KODU";
            // 
            // textDilFirmaCode
            // 
            textDilFirmaCode.Location = new Point(13, 111);
            textDilFirmaCode.Margin = new Padding(4);
            textDilFirmaCode.Name = "textDilFirmaCode";
            textDilFirmaCode.Properties.ReadOnly = true;
            textDilFirmaCode.Size = new Size(180, 22);
            textDilFirmaCode.TabIndex = 10;
            // 
            // labelDilFirmaCode
            // 
            labelDilFirmaCode.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelDilFirmaCode.Appearance.Options.UseFont = true;
            labelDilFirmaCode.Location = new Point(13, 68);
            labelDilFirmaCode.Margin = new Padding(4);
            labelDilFirmaCode.Name = "labelDilFirmaCode";
            labelDilFirmaCode.Size = new Size(134, 25);
            labelDilFirmaCode.TabIndex = 9;
            labelDilFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerDilText
            // 
            islemlerDilText.Controls.Add(ButtonGüncelle);
            islemlerDilText.Controls.Add(ButtonKaydet);
            islemlerDilText.Controls.Add(homePageButton);
            islemlerDilText.Controls.Add(dataAddButton);
            islemlerDilText.Controls.Add(searchButton);
            islemlerDilText.Controls.Add(deleteButton);
            islemlerDilText.Controls.Add(onlyViewButton);
            islemlerDilText.Controls.Add(editButton);
            islemlerDilText.Location = new Point(-1, 208);
            islemlerDilText.Margin = new Padding(4);
            islemlerDilText.Name = "islemlerDilText";
            islemlerDilText.Size = new Size(1412, 90);
            islemlerDilText.TabIndex = 5;
            islemlerDilText.Text = "İşlemler";
            // 
            // ButtonGüncelle
            // 
            ButtonGüncelle.Location = new Point(1208, 41);
            ButtonGüncelle.Name = "ButtonGüncelle";
            ButtonGüncelle.Size = new Size(118, 36);
            ButtonGüncelle.TabIndex = 45;
            ButtonGüncelle.Text = "Güncelle";
            ButtonGüncelle.Visible = false;
            ButtonGüncelle.Click += ButtonGüncelle_Click;
            // 
            // ButtonKaydet
            // 
            ButtonKaydet.Location = new Point(1208, 42);
            ButtonKaydet.Name = "ButtonKaydet";
            ButtonKaydet.Size = new Size(118, 36);
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
            dataAddButton.Location = new Point(225, 39);
            dataAddButton.Margin = new Padding(4);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(37, 39);
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
            searchButton.Location = new Point(15, 39);
            searchButton.Margin = new Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(37, 39);
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
            deleteButton.Location = new Point(295, 39);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(37, 39);
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
            onlyViewButton.Location = new Point(85, 39);
            onlyViewButton.Margin = new Padding(4);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(37, 39);
            onlyViewButton.TabIndex = 8;
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
            editButton.TabIndex = 9;
            editButton.Click += editButton_Click;
            // 
            // dataDilGrid
            // 
            dataDilGrid.EmbeddedNavigator.Margin = new Padding(4);
            dataDilGrid.Location = new Point(-1, 297);
            dataDilGrid.MainView = gridView1;
            dataDilGrid.Margin = new Padding(4);
            dataDilGrid.Name = "dataDilGrid";
            dataDilGrid.Size = new Size(1412, 498);
            dataDilGrid.TabIndex = 4;
            dataDilGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 431;
            gridView1.GridControl = dataDilGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.FocusedRowObjectChanged += gridView1_FocusedRowObjectChanged;
            // 
            // dilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(dilSearchControl);
            Controls.Add(islemlerDilText);
            Controls.Add(dataDilGrid);
            Margin = new Padding(4);
            Name = "dilForm";
            Text = "DİL";
            Load += dilForm_Load;
            ((System.ComponentModel.ISupportInitialize)dilSearchControl).EndInit();
            dilSearchControl.ResumeLayout(false);
            dilSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textDilCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textDilFirmaCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerDilText).EndInit();
            islemlerDilText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataDilGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl dilSearchControl;
        private DevExpress.XtraEditors.TextEdit textDilCode;
        private DevExpress.XtraEditors.LabelControl labelDilCode;
        private DevExpress.XtraEditors.TextEdit textDilFirmaCode;
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
    }
}