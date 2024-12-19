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
            ulkeSearchControl = new DevExpress.XtraEditors.GroupControl();
            textDilName = new DevExpress.XtraEditors.TextEdit();
            labelUlkeName = new DevExpress.XtraEditors.LabelControl();
            textUlkeCode = new DevExpress.XtraEditors.TextEdit();
            labelUlkeCode = new DevExpress.XtraEditors.LabelControl();
            textUlkeFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelUlkeFirmaCode = new DevExpress.XtraEditors.LabelControl();
            islemlerUlkeText = new DevExpress.XtraEditors.GroupControl();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            dataUlkeGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)ulkeSearchControl).BeginInit();
            ulkeSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeFirmaCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerUlkeText).BeginInit();
            islemlerUlkeText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUlkeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // ulkeSearchControl
            // 
            ulkeSearchControl.Controls.Add(textDilName);
            ulkeSearchControl.Controls.Add(labelUlkeName);
            ulkeSearchControl.Controls.Add(textUlkeCode);
            ulkeSearchControl.Controls.Add(labelUlkeCode);
            ulkeSearchControl.Controls.Add(textUlkeFirmaCode);
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
            textDilName.Size = new Size(154, 20);
            textDilName.TabIndex = 14;
            // 
            // labelUlkeName
            // 
            labelUlkeName.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelUlkeName.Appearance.Options.UseFont = true;
            labelUlkeName.Location = new Point(438, 55);
            labelUlkeName.Name = "labelUlkeName";
            labelUlkeName.Size = new Size(71, 29);
            labelUlkeName.TabIndex = 13;
            labelUlkeName.Text = "ÜLKE ADI";
            // 
            // textUlkeCode
            // 
            textUlkeCode.Location = new Point(221, 90);
            textUlkeCode.Name = "textUlkeCode";
            textUlkeCode.Size = new Size(154, 20);
            textUlkeCode.TabIndex = 12;
            // 
            // labelUlkeCode
            // 
            labelUlkeCode.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelUlkeCode.Appearance.Options.UseFont = true;
            labelUlkeCode.Location = new Point(221, 55);
            labelUlkeCode.Name = "labelUlkeCode";
            labelUlkeCode.Size = new Size(89, 29);
            labelUlkeCode.TabIndex = 11;
            labelUlkeCode.Text = "ÜLKE KODU";
            // 
            // textUlkeFirmaCode
            // 
            textUlkeFirmaCode.Location = new Point(11, 90);
            textUlkeFirmaCode.Name = "textUlkeFirmaCode";
            textUlkeFirmaCode.Size = new Size(154, 20);
            textUlkeFirmaCode.TabIndex = 10;
            // 
            // labelUlkeFirmaCode
            // 
            labelUlkeFirmaCode.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelUlkeFirmaCode.Appearance.Options.UseFont = true;
            labelUlkeFirmaCode.Location = new Point(11, 55);
            labelUlkeFirmaCode.Name = "labelUlkeFirmaCode";
            labelUlkeFirmaCode.Size = new Size(97, 29);
            labelUlkeFirmaCode.TabIndex = 9;
            labelUlkeFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerUlkeText
            // 
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
            // dataAddButton
            // 
            dataAddButton.Location = new Point(193, 32);
            dataAddButton.Name = "dataAddButton";
            dataAddButton.Size = new Size(32, 32);
            dataAddButton.TabIndex = 4;
            dataAddButton.Text = "ADD";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(253, 32);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "DELETE";
            // 
            // editButton
            // 
            editButton.Location = new Point(133, 32);
            editButton.Name = "editButton";
            editButton.Size = new Size(32, 32);
            editButton.TabIndex = 2;
            editButton.Text = "EDIT";
            // 
            // onlyViewButton
            // 
            onlyViewButton.Location = new Point(73, 32);
            onlyViewButton.Name = "onlyViewButton";
            onlyViewButton.Size = new Size(32, 32);
            onlyViewButton.TabIndex = 1;
            onlyViewButton.Text = "OnlyView";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(13, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 0;
            searchButton.Text = "SEARCH";
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
            ((System.ComponentModel.ISupportInitialize)ulkeSearchControl).EndInit();
            ulkeSearchControl.ResumeLayout(false);
            ulkeSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textUlkeFirmaCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerUlkeText).EndInit();
            islemlerUlkeText.ResumeLayout(false);
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
        private DevExpress.XtraEditors.TextEdit textUlkeFirmaCode;
        private DevExpress.XtraEditors.LabelControl labelUlkeFirmaCode;
        private DevExpress.XtraEditors.GroupControl islemlerUlkeText;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraGrid.GridControl dataUlkeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}