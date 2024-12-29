namespace ERP_APP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDollar = new Label();
            lblEuro = new Label();
            SuspendLayout();
            // 
            // lblDollar
            // 
            lblDollar.AutoSize = true;
            lblDollar.Location = new Point(137, 117);
            lblDollar.Name = "lblDollar";
            lblDollar.Size = new Size(50, 20);
            lblDollar.TabIndex = 0;
            lblDollar.Text = "label1";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(143, 178);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(50, 20);
            lblEuro.TabIndex = 1;
            lblEuro.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEuro);
            Controls.Add(lblDollar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDollar;
        private Label lblEuro;
    }
}
