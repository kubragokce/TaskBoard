
namespace TaskBoardProjesi
{
    partial class TaskEkleme
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTarih = new System.Windows.Forms.TextBox();
            this.textBoxKartNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTeknikUzman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProjeAd = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxGerceklesenSure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTahminiSure = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxIsinAciklamasi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxNotlar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tblTaskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBoardProjectDataSet1 = new TaskBoardProjesi.TaskBoardProjectDataSet1();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAnaEkranaDon = new System.Windows.Forms.Button();
            this.tbl_TaskStatusTableAdapter = new TaskBoardProjesi.TaskBoardProjectDataSet1TableAdapters.Tbl_TaskStatusTableAdapter();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih:";
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTarih.Location = new System.Drawing.Point(88, 16);
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(135, 24);
            this.textBoxTarih.TabIndex = 2;
            // 
            // textBoxKartNo
            // 
            this.textBoxKartNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKartNo.Location = new System.Drawing.Point(88, 55);
            this.textBoxKartNo.Name = "textBoxKartNo";
            this.textBoxKartNo.Size = new System.Drawing.Size(135, 24);
            this.textBoxKartNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kart No:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxKartNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxTarih);
            this.panel1.Location = new System.Drawing.Point(443, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 94);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "TEKNİK KART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxTeknikUzman);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxProjeAd);
            this.panel2.Location = new System.Drawing.Point(25, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 94);
            this.panel2.TabIndex = 7;
            // 
            // textBoxTeknikUzman
            // 
            this.textBoxTeknikUzman.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeknikUzman.Location = new System.Drawing.Point(135, 53);
            this.textBoxTeknikUzman.Name = "textBoxTeknikUzman";
            this.textBoxTeknikUzman.Size = new System.Drawing.Size(135, 24);
            this.textBoxTeknikUzman.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Proje No / Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teknik Uzmanı:";
            // 
            // textBoxProjeAd
            // 
            this.textBoxProjeAd.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjeAd.Location = new System.Drawing.Point(135, 15);
            this.textBoxProjeAd.Name = "textBoxProjeAd";
            this.textBoxProjeAd.Size = new System.Drawing.Size(135, 24);
            this.textBoxProjeAd.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxGerceklesenSure);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxTahminiSure);
            this.panel3.Location = new System.Drawing.Point(443, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 94);
            this.panel3.TabIndex = 8;
            // 
            // textBoxGerceklesenSure
            // 
            this.textBoxGerceklesenSure.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGerceklesenSure.Location = new System.Drawing.Point(141, 53);
            this.textBoxGerceklesenSure.Name = "textBoxGerceklesenSure";
            this.textBoxGerceklesenSure.Size = new System.Drawing.Size(135, 24);
            this.textBoxGerceklesenSure.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tahmini Süre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Gerçekleşen Süre:";
            // 
            // textBoxTahminiSure
            // 
            this.textBoxTahminiSure.Enabled = false;
            this.textBoxTahminiSure.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTahminiSure.Location = new System.Drawing.Point(141, 14);
            this.textBoxTahminiSure.Name = "textBoxTahminiSure";
            this.textBoxTahminiSure.Size = new System.Drawing.Size(135, 24);
            this.textBoxTahminiSure.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBoxIsinAciklamasi);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(25, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 162);
            this.panel4.TabIndex = 9;
            // 
            // textBoxIsinAciklamasi
            // 
            this.textBoxIsinAciklamasi.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsinAciklamasi.Location = new System.Drawing.Point(-1, 28);
            this.textBoxIsinAciklamasi.Multiline = true;
            this.textBoxIsinAciklamasi.Name = "textBoxIsinAciklamasi";
            this.textBoxIsinAciklamasi.Size = new System.Drawing.Size(714, 133);
            this.textBoxIsinAciklamasi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "İşin Açıklaması:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBoxNotlar);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(25, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 152);
            this.panel5.TabIndex = 10;
            // 
            // textBoxNotlar
            // 
            this.textBoxNotlar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotlar.Location = new System.Drawing.Point(-1, 28);
            this.textBoxNotlar.Multiline = true;
            this.textBoxNotlar.Name = "textBoxNotlar";
            this.textBoxNotlar.Size = new System.Drawing.Size(714, 123);
            this.textBoxNotlar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Notlar:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(25, 584);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(714, 210);
            this.panel6.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.status,
            this.todo,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 182);
            this.dataGridView1.TabIndex = 1;
            // 
            // date
            // 
            this.date.HeaderText = "Tarih";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // status
            // 
            this.status.HeaderText = "Durum";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // todo
            // 
            this.todo.HeaderText = "Yapılacak İş";
            this.todo.MinimumWidth = 6;
            this.todo.Name = "todo";
            // 
            // description
            // 
            this.description.HeaderText = "Açıklama";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "İş Takibi:";
            // 
            // tblTaskStatusBindingSource
            // 
            this.tblTaskStatusBindingSource.DataMember = "Tbl_TaskStatus";
            this.tblTaskStatusBindingSource.DataSource = this.taskBoardProjectDataSet1;
            // 
            // taskBoardProjectDataSet1
            // 
            this.taskBoardProjectDataSet1.DataSetName = "TaskBoardProjectDataSet1";
            this.taskBoardProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(584, 813);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 29);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Bilgileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAnaEkranaDon
            // 
            this.btnAnaEkranaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaEkranaDon.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaEkranaDon.Location = new System.Drawing.Point(402, 813);
            this.btnAnaEkranaDon.Name = "btnAnaEkranaDon";
            this.btnAnaEkranaDon.Size = new System.Drawing.Size(155, 29);
            this.btnAnaEkranaDon.TabIndex = 13;
            this.btnAnaEkranaDon.Text = "Ana Ekrana Dön";
            this.btnAnaEkranaDon.UseVisualStyleBackColor = true;
            this.btnAnaEkranaDon.Click += new System.EventHandler(this.btnAnaEkranaDon_Click);
            // 
            // tbl_TaskStatusTableAdapter
            // 
            this.tbl_TaskStatusTableAdapter.ClearBeforeFill = true;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(217, 813);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(155, 29);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // TaskEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 856);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnaEkranaDon);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskEkleme";
            this.Load += new System.EventHandler(this.TaskEkleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTarih;
        private System.Windows.Forms.TextBox textBoxKartNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTeknikUzman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProjeAd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxGerceklesenSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTahminiSure;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxIsinAciklamasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxNotlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaEkranaDon;
        private TaskBoardProjectDataSet1 taskBoardProjectDataSet1;
        private System.Windows.Forms.BindingSource tblTaskStatusBindingSource;
        private TaskBoardProjectDataSet1TableAdapters.Tbl_TaskStatusTableAdapter tbl_TaskStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btnCikis;
    }
}