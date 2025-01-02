namespace ERP_APP
{
    partial class XtraForm17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm17));
            pictureBox1 = new PictureBox();
            textusername = new TextBox();
            textsifre = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1159, 632);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textusername
            // 
            textusername.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textusername.Location = new Point(604, 240);
            textusername.Name = "textusername";
            textusername.Size = new Size(193, 28);
            textusername.TabIndex = 1;
            // 
            // textsifre
            // 
            textsifre.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textsifre.Location = new Point(604, 299);
            textsifre.Name = "textsifre";
            textsifre.Size = new Size(193, 28);
            textsifre.TabIndex = 2;
            textsifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(604, 342);
            button1.Name = "button1";
            button1.Size = new Size(193, 29);
            button1.TabIndex = 3;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // XtraForm17
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 631);
            Controls.Add(button1);
            Controls.Add(textsifre);
            Controls.Add(textusername);
            Controls.Add(pictureBox1);
            Name = "XtraForm17";
            Text = "XtraForm17";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textusername;
        private TextBox textsifre;
        private Button button1;
    }
}