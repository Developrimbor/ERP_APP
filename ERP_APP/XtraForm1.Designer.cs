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
            dataFirmaGrid.Location = new Point(0, 241);
            dataFirmaGrid.MainView = gridView1;
            dataFirmaGrid.Name = "dataFirmaGrid";
            dataFirmaGrid.Size = new Size(1210, 405);
            dataFirmaGrid.TabIndex = 0;
            dataFirmaGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dataFirmaGrid;
            gridView1.Name = "gridView1";
            // 
            // islemlerFirmaText
            // 
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
            // dataAddButton
            // 
            dataAddButton.Appearance.BackColor = SystemColors.Menu;
            dataAddButton.Appearance.Options.UseBackColor = true;
            dataAddButton.BackgroundImage = (Image)resources.GetObject("dataAddButton.BackgroundImage");
            dataAddButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            dataAddButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("dataAddButton.ImageOptions.SvgImage");
            dataAddButton.Location = new Point(193, 32);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(32, 32);
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
            deleteButton.Location = new Point(253, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
            deleteButton.TabIndex = 3;
            // 
            // editButton
            // 
            editButton.Appearance.BackColor = SystemColors.Menu;
            editButton.Appearance.Options.UseBackColor = true;
            editButton.BackgroundImage = (Image)resources.GetObject("editButton.BackgroundImage");
            editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            editButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("editButton.ImageOptions.SvgImage");
            editButton.Location = new Point(133, 32);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 32);
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
            onlyViewButton.Location = new Point(73, 32);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(32, 32);
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
            searchButton.Location = new Point(13, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 0;
            // 
            // firmaSearchControl
            // 
            firmaSearchControl.Controls.Add(textFirmaInfoEdit);
            firmaSearchControl.Controls.Add(labelFirmaInfo);
            firmaSearchControl.Controls.Add(textFirmaNameEdit);
            firmaSearchControl.Controls.Add(labelFirmaName);
            firmaSearchControl.Location = new Point(0, 0);
            firmaSearchControl.Name = "firmaSearchControl";
            firmaSearchControl.Size = new Size(1210, 169);
            firmaSearchControl.TabIndex = 3;
            firmaSearchControl.Text = "Arama";
            // 
            // textFirmaInfoEdit
            // 
            textFirmaInfoEdit.Location = new Point(221, 90);
            textFirmaInfoEdit.Name = "textFirmaInfoEdit";
            textFirmaInfoEdit.Size = new Size(253, 20);
            textFirmaInfoEdit.TabIndex = 12;
            // 
            // labelFirmaInfo
            // 
            labelFirmaInfo.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelFirmaInfo.Appearance.Options.UseFont = true;
            labelFirmaInfo.Location = new Point(221, 55);
            labelFirmaInfo.Name = "labelFirmaInfo";
            labelFirmaInfo.Size = new Size(148, 29);
            labelFirmaInfo.TabIndex = 11;
            labelFirmaInfo.Text = "FİRMA AÇIKLAMASI";
            // 
            // textFirmaNameEdit
            // 
            textFirmaNameEdit.Location = new Point(11, 90);
            textFirmaNameEdit.Name = "textFirmaNameEdit";
            textFirmaNameEdit.Size = new Size(154, 20);
            textFirmaNameEdit.TabIndex = 10;
            // 
            // labelFirmaName
            // 
            labelFirmaName.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelFirmaName.Appearance.Options.UseFont = true;
            labelFirmaName.Location = new Point(11, 55);
            labelFirmaName.Name = "labelFirmaName";
            labelFirmaName.Size = new Size(49, 29);
            labelFirmaName.TabIndex = 9;
            labelFirmaName.Text = "FİRMA";
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
    }
}