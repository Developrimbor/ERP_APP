﻿namespace ERP_APP
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            control_firma = new DevExpress.XtraEditors.SimpleButton();
            control_birim = new DevExpress.XtraEditors.SimpleButton();
            control_malzemeTipi = new DevExpress.XtraEditors.SimpleButton();
            control_dil = new DevExpress.XtraEditors.SimpleButton();
            control_urunAgaci = new DevExpress.XtraEditors.SimpleButton();
            control_sehir = new DevExpress.XtraEditors.SimpleButton();
            control_maliyet_merkezi = new DevExpress.XtraEditors.SimpleButton();
            control_ülke = new DevExpress.XtraEditors.SimpleButton();
            control_rotaTipi = new DevExpress.XtraEditors.SimpleButton();
            control_isMerkeziTipi = new DevExpress.XtraEditors.SimpleButton();
            control_operasyonTipi = new DevExpress.XtraEditors.SimpleButton();
            control_table = new DevExpress.XtraEditors.TextEdit();
            main_screen = new DevExpress.XtraEditors.TextEdit();
            anaEkran_materyal = new DevExpress.XtraEditors.SimpleButton();
            anaEkran_maliyetMerkezi = new DevExpress.XtraEditors.SimpleButton();
            anaEkran_isMerkezi = new DevExpress.XtraEditors.SimpleButton();
            anaEkran_urunAgaci = new DevExpress.XtraEditors.SimpleButton();
            anaEkran_rotaYonetimi = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            lblDollar = new Label();
            lblEuro = new Label();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)control_table.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)main_screen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            SuspendLayout();
            // 
            // control_firma
            // 
            control_firma.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_firma.Appearance.Options.UseFont = true;
            control_firma.Location = new Point(83, 151);
            control_firma.Margin = new Padding(4);
            control_firma.Name = "control_firma";
            control_firma.Size = new Size(225, 73);
            control_firma.TabIndex = 2;
            control_firma.Text = "FİRMA";
            control_firma.Click += simpleButton1_Click;
            // 
            // control_birim
            // 
            control_birim.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_birim.Appearance.Options.UseFont = true;
            control_birim.Location = new Point(315, 151);
            control_birim.Margin = new Padding(4);
            control_birim.Name = "control_birim";
            control_birim.Size = new Size(225, 73);
            control_birim.TabIndex = 3;
            control_birim.Text = "BİRİM";
            control_birim.Click += control_birim_Click;
            // 
            // control_malzemeTipi
            // 
            control_malzemeTipi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_malzemeTipi.Appearance.Options.UseFont = true;
            control_malzemeTipi.Location = new Point(315, 231);
            control_malzemeTipi.Margin = new Padding(4);
            control_malzemeTipi.Name = "control_malzemeTipi";
            control_malzemeTipi.Size = new Size(225, 73);
            control_malzemeTipi.TabIndex = 5;
            control_malzemeTipi.Text = "MALZEME TİPİ";
            control_malzemeTipi.Click += control_malzemeTipi_Click;
            // 
            // control_dil
            // 
            control_dil.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_dil.Appearance.Options.UseFont = true;
            control_dil.Location = new Point(83, 231);
            control_dil.Margin = new Padding(4);
            control_dil.Name = "control_dil";
            control_dil.Size = new Size(225, 73);
            control_dil.TabIndex = 4;
            control_dil.Text = "DİL";
            control_dil.Click += control_dil_Click;
            // 
            // control_urunAgaci
            // 
            control_urunAgaci.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_urunAgaci.Appearance.Options.UseFont = true;
            control_urunAgaci.Location = new Point(315, 391);
            control_urunAgaci.Margin = new Padding(4);
            control_urunAgaci.Name = "control_urunAgaci";
            control_urunAgaci.Size = new Size(225, 73);
            control_urunAgaci.TabIndex = 9;
            control_urunAgaci.Text = "ÜRÜN AĞACI";
            control_urunAgaci.Click += simpleButton5_Click;
            // 
            // control_sehir
            // 
            control_sehir.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_sehir.Appearance.Options.UseFont = true;
            control_sehir.Location = new Point(83, 391);
            control_sehir.Margin = new Padding(4);
            control_sehir.Name = "control_sehir";
            control_sehir.Size = new Size(225, 73);
            control_sehir.TabIndex = 8;
            control_sehir.Text = "ŞEHİR";
            control_sehir.Click += control_sehir_Click;
            // 
            // control_maliyet_merkezi
            // 
            control_maliyet_merkezi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_maliyet_merkezi.Appearance.Options.UseFont = true;
            control_maliyet_merkezi.Location = new Point(315, 311);
            control_maliyet_merkezi.Margin = new Padding(4);
            control_maliyet_merkezi.Name = "control_maliyet_merkezi";
            control_maliyet_merkezi.Size = new Size(225, 73);
            control_maliyet_merkezi.TabIndex = 7;
            control_maliyet_merkezi.Text = "MALİYET MERKEZİ";
            control_maliyet_merkezi.Click += control_maliyet_merkezi_Click;
            // 
            // control_ülke
            // 
            control_ülke.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_ülke.Appearance.Options.UseFont = true;
            control_ülke.Location = new Point(83, 311);
            control_ülke.Margin = new Padding(4);
            control_ülke.Name = "control_ülke";
            control_ülke.Size = new Size(225, 73);
            control_ülke.TabIndex = 6;
            control_ülke.Text = "ÜLKE";
            control_ülke.Click += control_ülke_Click;
            // 
            // control_rotaTipi
            // 
            control_rotaTipi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_rotaTipi.Appearance.Options.UseFont = true;
            control_rotaTipi.Location = new Point(192, 471);
            control_rotaTipi.Margin = new Padding(4);
            control_rotaTipi.Name = "control_rotaTipi";
            control_rotaTipi.Size = new Size(225, 73);
            control_rotaTipi.TabIndex = 10;
            control_rotaTipi.Text = "ROTA TİPİ";
            control_rotaTipi.Click += control_rotaTipi_Click;
            // 
            // control_isMerkeziTipi
            // 
            control_isMerkeziTipi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_isMerkeziTipi.Appearance.Options.UseFont = true;
            control_isMerkeziTipi.Location = new Point(192, 551);
            control_isMerkeziTipi.Margin = new Padding(4);
            control_isMerkeziTipi.Name = "control_isMerkeziTipi";
            control_isMerkeziTipi.Size = new Size(225, 73);
            control_isMerkeziTipi.TabIndex = 11;
            control_isMerkeziTipi.Text = "İŞ MERKEZİ TİPİ";
            control_isMerkeziTipi.Click += control_isMerkeziTipi_Click;
            // 
            // control_operasyonTipi
            // 
            control_operasyonTipi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            control_operasyonTipi.Appearance.Options.UseFont = true;
            control_operasyonTipi.Location = new Point(192, 631);
            control_operasyonTipi.Margin = new Padding(4);
            control_operasyonTipi.Name = "control_operasyonTipi";
            control_operasyonTipi.Size = new Size(225, 73);
            control_operasyonTipi.TabIndex = 12;
            control_operasyonTipi.Text = "OPERASYON TİPİ";
            control_operasyonTipi.Click += control_operasyonTipi_Click;
            // 
            // control_table
            // 
            control_table.EditValue = "KONTROL TABLOLARI";
            control_table.Location = new Point(192, 84);
            control_table.Margin = new Padding(4);
            control_table.Name = "control_table";
            control_table.Properties.Appearance.BackColor = SystemColors.Menu;
            control_table.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            control_table.Properties.Appearance.Options.UseBackColor = true;
            control_table.Properties.Appearance.Options.UseFont = true;
            control_table.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            control_table.Size = new Size(249, 34);
            control_table.TabIndex = 13;
            // 
            // main_screen
            // 
            main_screen.EditValue = "ANA EKRANLAR";
            main_screen.Location = new Point(755, 84);
            main_screen.Margin = new Padding(4);
            main_screen.Name = "main_screen";
            main_screen.Properties.Appearance.BackColor = SystemColors.Menu;
            main_screen.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            main_screen.Properties.Appearance.Options.UseBackColor = true;
            main_screen.Properties.Appearance.Options.UseFont = true;
            main_screen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            main_screen.Size = new Size(172, 34);
            main_screen.TabIndex = 14;
            // 
            // anaEkran_materyal
            // 
            anaEkran_materyal.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            anaEkran_materyal.Appearance.Options.UseFont = true;
            anaEkran_materyal.Location = new Point(728, 151);
            anaEkran_materyal.Margin = new Padding(4);
            anaEkran_materyal.Name = "anaEkran_materyal";
            anaEkran_materyal.Size = new Size(225, 73);
            anaEkran_materyal.TabIndex = 15;
            anaEkran_materyal.Text = "MATERYAL";
            anaEkran_materyal.Click += anaEkran_materyal_Click;
            // 
            // anaEkran_maliyetMerkezi
            // 
            anaEkran_maliyetMerkezi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            anaEkran_maliyetMerkezi.Appearance.Options.UseFont = true;
            anaEkran_maliyetMerkezi.Location = new Point(728, 231);
            anaEkran_maliyetMerkezi.Margin = new Padding(4);
            anaEkran_maliyetMerkezi.Name = "anaEkran_maliyetMerkezi";
            anaEkran_maliyetMerkezi.Size = new Size(225, 73);
            anaEkran_maliyetMerkezi.TabIndex = 16;
            anaEkran_maliyetMerkezi.Text = "MALİYET MERKEZİ";
            anaEkran_maliyetMerkezi.Click += anaEkran_maliyetMerkezi_Click;
            // 
            // anaEkran_isMerkezi
            // 
            anaEkran_isMerkezi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            anaEkran_isMerkezi.Appearance.Options.UseFont = true;
            anaEkran_isMerkezi.Location = new Point(728, 311);
            anaEkran_isMerkezi.Margin = new Padding(4);
            anaEkran_isMerkezi.Name = "anaEkran_isMerkezi";
            anaEkran_isMerkezi.Size = new Size(225, 73);
            anaEkran_isMerkezi.TabIndex = 17;
            anaEkran_isMerkezi.Text = "İŞ MERKEZİ";
            anaEkran_isMerkezi.Click += anaEkran_isMerkezi_Click;
            // 
            // anaEkran_urunAgaci
            // 
            anaEkran_urunAgaci.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            anaEkran_urunAgaci.Appearance.Options.UseFont = true;
            anaEkran_urunAgaci.Location = new Point(728, 391);
            anaEkran_urunAgaci.Margin = new Padding(4);
            anaEkran_urunAgaci.Name = "anaEkran_urunAgaci";
            anaEkran_urunAgaci.Size = new Size(225, 73);
            anaEkran_urunAgaci.TabIndex = 18;
            anaEkran_urunAgaci.Text = "ÜRÜN AĞACI";
            anaEkran_urunAgaci.Click += anaEkran_urunAgaci_Click;
            // 
            // anaEkran_rotaYonetimi
            // 
            anaEkran_rotaYonetimi.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            anaEkran_rotaYonetimi.Appearance.Options.UseFont = true;
            anaEkran_rotaYonetimi.Location = new Point(728, 471);
            anaEkran_rotaYonetimi.Margin = new Padding(4);
            anaEkran_rotaYonetimi.Name = "anaEkran_rotaYonetimi";
            anaEkran_rotaYonetimi.Size = new Size(225, 73);
            anaEkran_rotaYonetimi.TabIndex = 19;
            anaEkran_rotaYonetimi.Text = "ROTA YÖNETİMİ";
            anaEkran_rotaYonetimi.Click += anaEkran_rotaYonetimi_Click;
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "DÖVİZ KURLARI";
            textEdit1.Location = new Point(1086, 84);
            textEdit1.Margin = new Padding(4);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.BackColor = SystemColors.Menu;
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textEdit1.Properties.Appearance.Options.UseBackColor = true;
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            textEdit1.Size = new Size(213, 34);
            textEdit1.TabIndex = 21;
            // 
            // textEdit2
            // 
            textEdit2.EditValue = "$ = ";
            textEdit2.Location = new Point(1073, 167);
            textEdit2.Margin = new Padding(4);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.BackColor = SystemColors.Menu;
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textEdit2.Properties.Appearance.Options.UseBackColor = true;
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            textEdit2.Size = new Size(92, 50);
            textEdit2.TabIndex = 22;
            // 
            // lblDollar
            // 
            lblDollar.AutoSize = true;
            lblDollar.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDollar.Location = new Point(1172, 176);
            lblDollar.Name = "lblDollar";
            lblDollar.Size = new Size(107, 36);
            lblDollar.TabIndex = 23;
            lblDollar.Text = "label1";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEuro.Location = new Point(1172, 263);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(107, 36);
            lblEuro.TabIndex = 24;
            lblEuro.Text = "label1";
            // 
            // textEdit3
            // 
            textEdit3.EditValue = "£ = ";
            textEdit3.Location = new Point(1073, 254);
            textEdit3.Margin = new Padding(4);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.Appearance.BackColor = SystemColors.Menu;
            textEdit3.Properties.Appearance.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textEdit3.Properties.Appearance.Options.UseBackColor = true;
            textEdit3.Properties.Appearance.Options.UseFont = true;
            textEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            textEdit3.Size = new Size(92, 50);
            textEdit3.TabIndex = 25;
            // 
            // mainForm
            // 
            Appearance.BackColor = SystemColors.MenuBar;
            Appearance.ForeColor = Color.FromArgb(40, 40, 40);
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 796);
            Controls.Add(textEdit3);
            Controls.Add(lblEuro);
            Controls.Add(lblDollar);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(anaEkran_rotaYonetimi);
            Controls.Add(anaEkran_urunAgaci);
            Controls.Add(anaEkran_isMerkezi);
            Controls.Add(anaEkran_maliyetMerkezi);
            Controls.Add(anaEkran_materyal);
            Controls.Add(main_screen);
            Controls.Add(control_table);
            Controls.Add(control_operasyonTipi);
            Controls.Add(control_isMerkeziTipi);
            Controls.Add(control_rotaTipi);
            Controls.Add(control_urunAgaci);
            Controls.Add(control_sehir);
            Controls.Add(control_maliyet_merkezi);
            Controls.Add(control_ülke);
            Controls.Add(control_malzemeTipi);
            Controls.Add(control_dil);
            Controls.Add(control_birim);
            Controls.Add(control_firma);
            IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mainForm.IconOptions.SvgImage");
            Margin = new Padding(4);
            Name = "mainForm";
            Text = "ERP_CDM";
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)control_table.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)main_screen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton control_firma;
        private DevExpress.XtraEditors.SimpleButton control_birim;
        private DevExpress.XtraEditors.SimpleButton control_malzemeTipi;
        private DevExpress.XtraEditors.SimpleButton control_dil;
        private DevExpress.XtraEditors.SimpleButton control_urunAgaci;
        private DevExpress.XtraEditors.SimpleButton control_sehir;
        private DevExpress.XtraEditors.SimpleButton control_maliyet_merkezi;
        private DevExpress.XtraEditors.SimpleButton control_ülke;
        private DevExpress.XtraEditors.SimpleButton control_rotaTipi;
        private DevExpress.XtraEditors.SimpleButton control_isMerkeziTipi;
        private DevExpress.XtraEditors.SimpleButton control_operasyonTipi;
        private DevExpress.XtraEditors.TextEdit control_table;
        private DevExpress.XtraEditors.TextEdit main_screen;
        private DevExpress.XtraEditors.SimpleButton anaEkran_materyal;
        private DevExpress.XtraEditors.SimpleButton anaEkran_maliyetMerkezi;
        private DevExpress.XtraEditors.SimpleButton anaEkran_isMerkezi;
        private DevExpress.XtraEditors.SimpleButton anaEkran_urunAgaci;
        private DevExpress.XtraEditors.SimpleButton anaEkran_rotaYonetimi;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private Label lblDollar;
        private Label lblEuro;
        private DevExpress.XtraEditors.TextEdit textEdit3;
    }
}