
namespace TaskBoardProjesi
{
    partial class TaskGuncelleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTaskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBoardProjectDataSet3 = new TaskBoardProjesi.TaskBoardProjectDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaskStatusUpdate = new System.Windows.Forms.Button();
            this.textBoxTaskNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTask = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTechnicalCardUpdate = new System.Windows.Forms.Button();
            this.textBoxCardNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCard = new System.Windows.Forms.ComboBox();
            this.textBoxKartNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblTechnicalCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskBoardProjectDataSet2 = new TaskBoardProjesi.TaskBoardProjectDataSet2();
            this.btnAnaEkranaDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.taskBoardProjectDataSet1 = new TaskBoardProjesi.TaskBoardProjectDataSet1();
            this.taskBoardProjectDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TechnicalCardTableAdapter = new TaskBoardProjesi.TaskBoardProjectDataSet2TableAdapters.Tbl_TechnicalCardTableAdapter();
            this.tbl_TaskStatusTableAdapter = new TaskBoardProjesi.TaskBoardProjectDataSet3TableAdapters.Tbl_TaskStatusTableAdapter();
            this.taskBoardProjectDataSet4 = new TaskBoardProjesi.TaskBoardProjectDataSet4();
            this.tblTechnicalCardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TechnicalCardTableAdapter1 = new TaskBoardProjesi.TaskBoardProjectDataSet4TableAdapters.Tbl_TechnicalCardTableAdapter();
            this.cardnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicalExpertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTechnicalCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTechnicalCardBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.todoDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.tblTaskStatusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // taskIDDataGridViewTextBoxColumn
            // 
            this.taskIDDataGridViewTextBoxColumn.DataPropertyName = "taskID";
            this.taskIDDataGridViewTextBoxColumn.HeaderText = "taskID";
            this.taskIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taskIDDataGridViewTextBoxColumn.Name = "taskIDDataGridViewTextBoxColumn";
            this.taskIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // todoDataGridViewTextBoxColumn
            // 
            this.todoDataGridViewTextBoxColumn.DataPropertyName = "todo";
            this.todoDataGridViewTextBoxColumn.HeaderText = "Yapılacak İş";
            this.todoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.todoDataGridViewTextBoxColumn.Name = "todoDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Açıklama";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // tblTaskStatusBindingSource
            // 
            this.tblTaskStatusBindingSource.DataMember = "Tbl_TaskStatus";
            this.tblTaskStatusBindingSource.DataSource = this.taskBoardProjectDataSet3;
            // 
            // taskBoardProjectDataSet3
            // 
            this.taskBoardProjectDataSet3.DataSetName = "TaskBoardProjectDataSet3";
            this.taskBoardProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTaskStatusUpdate);
            this.panel1.Controls.Add(this.textBoxTaskNew);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxTask);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(769, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 482);
            this.panel1.TabIndex = 1;
            // 
            // btnTaskStatusUpdate
            // 
            this.btnTaskStatusUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaskStatusUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskStatusUpdate.Location = new System.Drawing.Point(579, 397);
            this.btnTaskStatusUpdate.Name = "btnTaskStatusUpdate";
            this.btnTaskStatusUpdate.Size = new System.Drawing.Size(121, 29);
            this.btnTaskStatusUpdate.TabIndex = 13;
            this.btnTaskStatusUpdate.Text = "Güncelle";
            this.btnTaskStatusUpdate.UseVisualStyleBackColor = true;
            this.btnTaskStatusUpdate.Click += new System.EventHandler(this.btnTaskStatusUpdate_Click);
            // 
            // textBoxTaskNew
            // 
            this.textBoxTaskNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskNew.Location = new System.Drawing.Point(449, 287);
            this.textBoxTaskNew.Multiline = true;
            this.textBoxTaskNew.Name = "textBoxTaskNew";
            this.textBoxTaskNew.Size = new System.Drawing.Size(251, 82);
            this.textBoxTaskNew.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Güncellecenecek Kısmı Seçiniz:";
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Items.AddRange(new object[] {
            "Tarih",
            "Durum",
            "Yapılacak İş",
            "Açıklama"});
            this.comboBoxTask.Location = new System.Drawing.Point(284, 344);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(121, 27);
            this.comboBoxTask.TabIndex = 4;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(284, 287);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 24);
            this.textBoxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTechnicalCardUpdate);
            this.panel2.Controls.Add(this.textBoxCardNew);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxCard);
            this.panel2.Controls.Add(this.textBoxKartNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 482);
            this.panel2.TabIndex = 2;
            // 
            // btnTechnicalCardUpdate
            // 
            this.btnTechnicalCardUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTechnicalCardUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicalCardUpdate.Location = new System.Drawing.Point(576, 397);
            this.btnTechnicalCardUpdate.Name = "btnTechnicalCardUpdate";
            this.btnTechnicalCardUpdate.Size = new System.Drawing.Size(121, 29);
            this.btnTechnicalCardUpdate.TabIndex = 13;
            this.btnTechnicalCardUpdate.Text = "Güncelle";
            this.btnTechnicalCardUpdate.UseVisualStyleBackColor = true;
            this.btnTechnicalCardUpdate.Click += new System.EventHandler(this.btnTechnicalCardUpdate_Click);
            // 
            // textBoxCardNew
            // 
            this.textBoxCardNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNew.Location = new System.Drawing.Point(451, 287);
            this.textBoxCardNew.Multiline = true;
            this.textBoxCardNew.Name = "textBoxCardNew";
            this.textBoxCardNew.Size = new System.Drawing.Size(246, 84);
            this.textBoxCardNew.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Güncellecenecek Kısmı Seçiniz:";
            // 
            // comboBoxCard
            // 
            this.comboBoxCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCard.FormattingEnabled = true;
            this.comboBoxCard.Items.AddRange(new object[] {
            "Tarih",
            "Proje Adı",
            "Teknik Uzmanı",
            "İşin Açıklaması",
            "Notlar",
            "Gerçekleşen Süre"});
            this.comboBoxCard.Location = new System.Drawing.Point(284, 344);
            this.comboBoxCard.Name = "comboBoxCard";
            this.comboBoxCard.Size = new System.Drawing.Size(121, 27);
            this.comboBoxCard.TabIndex = 4;
            // 
            // textBoxKartNo
            // 
            this.textBoxKartNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKartNo.Location = new System.Drawing.Point(284, 287);
            this.textBoxKartNo.Name = "textBoxKartNo";
            this.textBoxKartNo.Size = new System.Drawing.Size(121, 24);
            this.textBoxKartNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kart No:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardnoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.technicalExpertDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.preDateDataGridViewTextBoxColumn,
            this.realDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblTechnicalCardBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(709, 232);
            this.dataGridView2.TabIndex = 0;
            // 
            // tblTechnicalCardBindingSource
            // 
            this.tblTechnicalCardBindingSource.DataMember = "Tbl_TechnicalCard";
            this.tblTechnicalCardBindingSource.DataSource = this.taskBoardProjectDataSet2;
            // 
            // taskBoardProjectDataSet2
            // 
            this.taskBoardProjectDataSet2.DataSetName = "TaskBoardProjectDataSet2";
            this.taskBoardProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAnaEkranaDon
            // 
            this.btnAnaEkranaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaEkranaDon.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaEkranaDon.Location = new System.Drawing.Point(1331, 501);
            this.btnAnaEkranaDon.Name = "btnAnaEkranaDon";
            this.btnAnaEkranaDon.Size = new System.Drawing.Size(155, 29);
            this.btnAnaEkranaDon.TabIndex = 14;
            this.btnAnaEkranaDon.Text = "Ana Ekrana Dön";
            this.btnAnaEkranaDon.UseVisualStyleBackColor = true;
            this.btnAnaEkranaDon.Click += new System.EventHandler(this.btnAnaEkranaDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(1157, 501);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(155, 29);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // taskBoardProjectDataSet1
            // 
            this.taskBoardProjectDataSet1.DataSetName = "TaskBoardProjectDataSet1";
            this.taskBoardProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBoardProjectDataSet1BindingSource
            // 
            this.taskBoardProjectDataSet1BindingSource.DataSource = this.taskBoardProjectDataSet1;
            this.taskBoardProjectDataSet1BindingSource.Position = 0;
            // 
            // tbl_TechnicalCardTableAdapter
            // 
            this.tbl_TechnicalCardTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_TaskStatusTableAdapter
            // 
            this.tbl_TaskStatusTableAdapter.ClearBeforeFill = true;
            // 
            // taskBoardProjectDataSet4
            // 
            this.taskBoardProjectDataSet4.DataSetName = "TaskBoardProjectDataSet4";
            this.taskBoardProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTechnicalCardBindingSource1
            // 
            this.tblTechnicalCardBindingSource1.DataMember = "Tbl_TechnicalCard";
            this.tblTechnicalCardBindingSource1.DataSource = this.taskBoardProjectDataSet4;
            // 
            // tbl_TechnicalCardTableAdapter1
            // 
            this.tbl_TechnicalCardTableAdapter1.ClearBeforeFill = true;
            // 
            // cardnoDataGridViewTextBoxColumn
            // 
            this.cardnoDataGridViewTextBoxColumn.DataPropertyName = "cardno";
            this.cardnoDataGridViewTextBoxColumn.HeaderText = "Kart No";
            this.cardnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardnoDataGridViewTextBoxColumn.Name = "cardnoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "projectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "Proje Adı";
            this.projectNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            // 
            // technicalExpertDataGridViewTextBoxColumn
            // 
            this.technicalExpertDataGridViewTextBoxColumn.DataPropertyName = "technicalExpert";
            this.technicalExpertDataGridViewTextBoxColumn.HeaderText = "Teknik Uzmanı";
            this.technicalExpertDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.technicalExpertDataGridViewTextBoxColumn.Name = "technicalExpertDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "İşin Açıklaması";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notlar";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // preDateDataGridViewTextBoxColumn
            // 
            this.preDateDataGridViewTextBoxColumn.DataPropertyName = "preDate";
            this.preDateDataGridViewTextBoxColumn.HeaderText = "Tahmini Süre";
            this.preDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preDateDataGridViewTextBoxColumn.Name = "preDateDataGridViewTextBoxColumn";
            // 
            // realDateDataGridViewTextBoxColumn
            // 
            this.realDateDataGridViewTextBoxColumn.DataPropertyName = "realDate";
            this.realDateDataGridViewTextBoxColumn.HeaderText = "Gerçekleşen Süre";
            this.realDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.realDateDataGridViewTextBoxColumn.Name = "realDateDataGridViewTextBoxColumn";
            // 
            // TaskGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 556);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnaEkranaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskGuncelleme";
            this.Load += new System.EventHandler(this.TaskGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTechnicalCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTechnicalCardBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTaskNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTask;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnTaskStatusUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTechnicalCardUpdate;
        private System.Windows.Forms.TextBox textBoxCardNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCard;
        private System.Windows.Forms.TextBox textBoxKartNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAnaEkranaDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.BindingSource taskBoardProjectDataSet1BindingSource;
        private TaskBoardProjectDataSet1 taskBoardProjectDataSet1;
        private TaskBoardProjectDataSet2 taskBoardProjectDataSet2;
        private System.Windows.Forms.BindingSource tblTechnicalCardBindingSource;
        private TaskBoardProjectDataSet2TableAdapters.Tbl_TechnicalCardTableAdapter tbl_TechnicalCardTableAdapter;
        private TaskBoardProjectDataSet3 taskBoardProjectDataSet3;
        private System.Windows.Forms.BindingSource tblTaskStatusBindingSource;
        private TaskBoardProjectDataSet3TableAdapters.Tbl_TaskStatusTableAdapter tbl_TaskStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private TaskBoardProjectDataSet4 taskBoardProjectDataSet4;
        private System.Windows.Forms.BindingSource tblTechnicalCardBindingSource1;
        private TaskBoardProjectDataSet4TableAdapters.Tbl_TechnicalCardTableAdapter tbl_TechnicalCardTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicalExpertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realDateDataGridViewTextBoxColumn;
    }
}