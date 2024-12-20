﻿namespace ERP_APP
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
            dilSearchControl = new DevExpress.XtraEditors.GroupControl();
            textDilCode = new DevExpress.XtraEditors.TextEdit();
            labelDilCode = new DevExpress.XtraEditors.LabelControl();
            textDilFirmaCode = new DevExpress.XtraEditors.TextEdit();
            labelDilFirmaCode = new DevExpress.XtraEditors.LabelControl();
            islemlerDilText = new DevExpress.XtraEditors.GroupControl();
            dataAddButton = new DevExpress.XtraEditors.SimpleButton();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            editButton = new DevExpress.XtraEditors.SimpleButton();
            onlyViewButton = new DevExpress.XtraEditors.SimpleButton();
            searchButton = new DevExpress.XtraEditors.SimpleButton();
            dataDilGrid = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            textDilName = new DevExpress.XtraEditors.TextEdit();
            labelDilName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)dilSearchControl).BeginInit();
            dilSearchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textDilCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textDilFirmaCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)islemlerDilText).BeginInit();
            islemlerDilText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDilGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).BeginInit();
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
            dilSearchControl.Name = "dilSearchControl";
            dilSearchControl.Size = new Size(1210, 169);
            dilSearchControl.TabIndex = 6;
            dilSearchControl.Text = "Arama";
            // 
            // textDilCode
            // 
            textDilCode.Location = new Point(221, 90);
            textDilCode.Name = "textDilCode";
            textDilCode.Size = new Size(154, 20);
            textDilCode.TabIndex = 12;
            // 
            // labelDilCode
            // 
            labelDilCode.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelDilCode.Appearance.Options.UseFont = true;
            labelDilCode.Location = new Point(221, 55);
            labelDilCode.Name = "labelDilCode";
            labelDilCode.Size = new Size(72, 29);
            labelDilCode.TabIndex = 11;
            labelDilCode.Text = "DİL KODU";
            // 
            // textDilFirmaCode
            // 
            textDilFirmaCode.Location = new Point(11, 90);
            textDilFirmaCode.Name = "textDilFirmaCode";
            textDilFirmaCode.Size = new Size(154, 20);
            textDilFirmaCode.TabIndex = 10;
            // 
            // labelDilFirmaCode
            // 
            labelDilFirmaCode.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelDilFirmaCode.Appearance.Options.UseFont = true;
            labelDilFirmaCode.Location = new Point(11, 55);
            labelDilFirmaCode.Name = "labelDilFirmaCode";
            labelDilFirmaCode.Size = new Size(97, 29);
            labelDilFirmaCode.TabIndex = 9;
            labelDilFirmaCode.Text = "FİRMA KODU";
            // 
            // islemlerDilText
            // 
            islemlerDilText.Controls.Add(dataAddButton);
            islemlerDilText.Controls.Add(deleteButton);
            islemlerDilText.Controls.Add(editButton);
            islemlerDilText.Controls.Add(onlyViewButton);
            islemlerDilText.Controls.Add(searchButton);
            islemlerDilText.Location = new Point(-1, 169);
            islemlerDilText.Name = "islemlerDilText";
            islemlerDilText.Size = new Size(1210, 73);
            islemlerDilText.TabIndex = 5;
            islemlerDilText.Text = "İşlemler";
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
            // 
            // textDilName
            // 
            textDilName.Location = new Point(438, 90);
            textDilName.Name = "textDilName";
            textDilName.Size = new Size(154, 20);
            textDilName.TabIndex = 14;
            textDilName.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // labelDilName
            // 
            labelDilName.Appearance.Font = new Font("Bai Jamjuree SemiBold", 12F, FontStyle.Bold);
            labelDilName.Appearance.Options.UseFont = true;
            labelDilName.Location = new Point(438, 55);
            labelDilName.Name = "labelDilName";
            labelDilName.Size = new Size(54, 29);
            labelDilName.TabIndex = 13;
            labelDilName.Text = "DİL ADI";
            labelDilName.Click += this.labelControl1_Click;
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
            ((System.ComponentModel.ISupportInitialize)dilSearchControl).EndInit();
            dilSearchControl.ResumeLayout(false);
            dilSearchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textDilCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textDilFirmaCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)islemlerDilText).EndInit();
            islemlerDilText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataDilGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textDilName.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl dilSearchControl;
        private DevExpress.XtraEditors.TextEdit textDilCode;
        private DevExpress.XtraEditors.LabelControl labelDilCode;
        private DevExpress.XtraEditors.TextEdit textDilFirmaCode;
        private DevExpress.XtraEditors.LabelControl labelDilFirmaCode;
        private DevExpress.XtraEditors.GroupControl islemlerDilText;
        private DevExpress.XtraEditors.SimpleButton dataAddButton;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton onlyViewButton;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraGrid.GridControl dataDilGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textDilName;
        private DevExpress.XtraEditors.LabelControl labelDilName;
    }
}