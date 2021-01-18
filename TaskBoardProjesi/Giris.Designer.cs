
namespace TaskBoardProjesi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bttnGiris);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.textBoxParola);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxKullaniciAdi);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 384);
            this.panel2.TabIndex = 0;
            // 
            // bttnGiris
            // 
            this.bttnGiris.BackColor = System.Drawing.Color.Black;
            this.bttnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnGiris.Location = new System.Drawing.Point(225, 268);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(135, 40);
            this.bttnGiris.TabIndex = 6;
            this.bttnGiris.Text = "GİRİŞ";
            this.bttnGiris.UseVisualStyleBackColor = false;
            this.bttnGiris.Click += new System.EventHandler(this.bttnGiris_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(9, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(104, 100);
            this.panel4.TabIndex = 5;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(180, 166);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(177, 33);
            this.textBoxParola.TabIndex = 4;
            this.textBoxParola.Text = "Parola";
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 100);
            this.panel3.TabIndex = 2;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(183, 51);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(177, 33);
            this.textBoxKullaniciAdi.TabIndex = 1;
            this.textBoxKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnGiris;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
    }
}

