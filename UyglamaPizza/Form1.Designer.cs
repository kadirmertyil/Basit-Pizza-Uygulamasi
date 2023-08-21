namespace UyglamaPizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullanıcıadı = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnsifresiz = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // txtkullanıcıadı
            // 
            this.txtkullanıcıadı.Location = new System.Drawing.Point(143, 136);
            this.txtkullanıcıadı.Name = "txtkullanıcıadı";
            this.txtkullanıcıadı.Size = new System.Drawing.Size(114, 26);
            this.txtkullanıcıadı.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(143, 175);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(114, 26);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(143, 241);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(114, 69);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnsifresiz
            // 
            this.btnsifresiz.Location = new System.Drawing.Point(14, 241);
            this.btnsifresiz.Name = "btnsifresiz";
            this.btnsifresiz.Size = new System.Drawing.Size(114, 69);
            this.btnsifresiz.TabIndex = 0;
            this.btnsifresiz.Text = "Şifresiz Giriş Yap";
            this.btnsifresiz.UseVisualStyleBackColor = true;
            this.btnsifresiz.Click += new System.EventHandler(this.btnsifresiz_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(263, 241);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(114, 69);
            this.btntemizle.TabIndex = 7;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(430, 365);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsifresiz);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanıcıadı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullanıcıadı;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnsifresiz;
        private System.Windows.Forms.Button btntemizle;
    }
}

