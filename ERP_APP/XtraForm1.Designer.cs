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
            homePageButton = new DevExpress.XtraEditors.SimpleButton();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            firmaSearchControl = new DevExpress.XtraEditors.GroupControl();
            textFirmaInfoEdit = new DevExpress.XtraEditors.TextEdit();
            labelFirmaInfo = new DevExpress.XtraEditors.LabelControl();
            textFirmaNameEdit = new DevExpress.XtraEditors.TextEdit();
            labelFirmaName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)dataFirmaGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerFirmaText).BeginInit();
            islemlerFirmaText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)firmaSearchControl).BeginInit();
            firmaSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textFirmaInfoEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaNameEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // dataFirmaGrid
            // 
            dataFirmaGrid.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
            dataFirmaGrid.Location = new Point(0, 297);
            dataFirmaGrid.MainView = gridView1;
            dataFirmaGrid.Margin = new Padding(4, 4, 4, 4);
            dataFirmaGrid.Name = "dataFirmaGrid";
            dataFirmaGrid.Size = new Size(1412, 498);
            dataFirmaGrid.TabIndex = 0;
            dataFirmaGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 431;
            gridView1.GridControl = dataFirmaGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // islemlerFirmaText
            // 
            islemlerFirmaText.Controls.Add(homePageButton);
            islemlerFirmaText.Controls.Add(dataAddButton);
            islemlerFirmaText.Controls.Add(deleteButton);
            islemlerFirmaText.Controls.Add(editButton);
            islemlerFirmaText.Controls.Add(onlyViewButton);
            islemlerFirmaText.Controls.Add(searchButton);
            islemlerFirmaText.Location = new Point(0, 208);
            islemlerFirmaText.Margin = new Padding(4, 4, 4, 4);
            islemlerFirmaText.Name = "islemlerFirmaText";
            islemlerFirmaText.Size = new Size(1412, 90);
            islemlerFirmaText.TabIndex = 1;
            islemlerFirmaText.Text = "İşlemler";
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
            dataAddButton.TabIndex = 4;
            dataAddButton.Click += simpleButton1_Click;
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
            deleteButton.TabIndex = 3;
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
            editButton.TabIndex = 2;
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
            onlyViewButton.TabIndex = 1;
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
            searchButton.TabIndex = 0;
            searchButton.Click += searchButton_Click;
            // 
            // firmaSearchControl
            // 
            firmaSearchControl.Controls.Add(textFirmaInfoEdit);
            firmaSearchControl.Controls.Add(labelFirmaInfo);
            firmaSearchControl.Controls.Add(textFirmaNameEdit);
            firmaSearchControl.Controls.Add(labelFirmaName);
            firmaSearchControl.Location = new Point(0, 0);
            firmaSearchControl.Margin = new Padding(4, 4, 4, 4);
            firmaSearchControl.Name = "firmaSearchControl";
            firmaSearchControl.Size = new Size(1412, 208);
            firmaSearchControl.TabIndex = 3;
            firmaSearchControl.Text = "Arama";
            // 
            // textFirmaInfoEdit
            // 
            textFirmaInfoEdit.Location = new Point(258, 111);
            textFirmaInfoEdit.Margin = new Padding(4, 4, 4, 4);
            textFirmaInfoEdit.Name = "textFirmaInfoEdit";
            textFirmaInfoEdit.Size = new Size(295, 22);
            textFirmaInfoEdit.TabIndex = 12;
            // 
            // labelFirmaInfo
            // 
            labelFirmaInfo.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelFirmaInfo.Appearance.Options.UseFont = true;
            labelFirmaInfo.Location = new Point(258, 68);
            labelFirmaInfo.Margin = new Padding(4, 4, 4, 4);
            labelFirmaInfo.Name = "labelFirmaInfo";
            labelFirmaInfo.Size = new Size(205, 25);
            labelFirmaInfo.TabIndex = 11;
            labelFirmaInfo.Text = "FİRMA AÇIKLAMASI";
            // 
            // textFirmaNameEdit
            // 
            textFirmaNameEdit.Location = new Point(13, 111);
            textFirmaNameEdit.Margin = new Padding(4, 4, 4, 4);
            textFirmaNameEdit.Name = "textFirmaNameEdit";
            textFirmaNameEdit.Size = new Size(180, 22);
            textFirmaNameEdit.TabIndex = 10;
            // 
            // labelFirmaName
            // 
            labelFirmaName.Appearance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            labelFirmaName.Appearance.Options.UseFont = true;
            labelFirmaName.Location = new Point(13, 68);
            labelFirmaName.Margin = new Padding(4, 4, 4, 4);
            labelFirmaName.Name = "labelFirmaName";
            labelFirmaName.Size = new Size(67, 25);
            labelFirmaName.TabIndex = 9;
            labelFirmaName.Text = "FİRMA";
            // 
            // firmaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(firmaSearchControl);
            Controls.Add(islemlerFirmaText);
            Controls.Add(dataFirmaGrid);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("firmaForm.IconOptions.SvgImage");
            IsMdiContainer = true;
            Margin = new Padding(4, 4, 4, 4);
            Name = "firmaForm";
            Text = "FİRMA";
            Load += firmaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataFirmaGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerFirmaText).EndInit();
            islemlerFirmaText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)firmaSearchControl).EndInit();
            firmaSearchControl.ResumeLayout(false);
            firmaSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textFirmaInfoEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textFirmaNameEdit.Properties).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textFirmaNameEdit;
        private DevExpress.XtraEditors.LabelControl labelFirmaName;
        private DevExpress.XtraEditors.SimpleButton homePageButton;
    }
}