
namespace TaskBoardProjesi
{
    partial class TaskListeleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTodo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewInProgress = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewRevison = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewDone = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnaEkranaDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.taskBoardProjectDataSet5 = new TaskBoardProjesi.TaskBoardProjectDataSet5();
            this.tblTaskStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TaskStatusTableAdapter = new TaskBoardProjesi.TaskBoardProjectDataSet5TableAdapters.Tbl_TaskStatusTableAdapter();
            this.todoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInProgress)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevison)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewTodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 545);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewTodo
            // 
            this.dataGridViewTodo.AllowUserToAddRows = false;
            this.dataGridViewTodo.AllowUserToDeleteRows = false;
            this.dataGridViewTodo.AutoGenerateColumns = false;
            this.dataGridViewTodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTodo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.todoDataGridViewTextBoxColumn});
            this.dataGridViewTodo.DataSource = this.tblTaskStatusBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTodo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTodo.Location = new System.Drawing.Point(-1, 23);
            this.dataGridViewTodo.Name = "dataGridViewTodo";
            this.dataGridViewTodo.ReadOnly = true;
            this.dataGridViewTodo.RowHeadersWidth = 51;
            this.dataGridViewTodo.RowTemplate.Height = 24;
            this.dataGridViewTodo.Size = new System.Drawing.Size(247, 521);
            this.dataGridViewTodo.TabIndex = 1;
            this.dataGridViewTodo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTodo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewInProgress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(278, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 545);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewInProgress
            // 
            this.dataGridViewInProgress.AllowUserToAddRows = false;
            this.dataGridViewInProgress.AllowUserToDeleteRows = false;
            this.dataGridViewInProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInProgress.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InProgress});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInProgress.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInProgress.Location = new System.Drawing.Point(-1, 23);
            this.dataGridViewInProgress.Name = "dataGridViewInProgress";
            this.dataGridViewInProgress.ReadOnly = true;
            this.dataGridViewInProgress.RowHeadersWidth = 51;
            this.dataGridViewInProgress.RowTemplate.Height = 24;
            this.dataGridViewInProgress.Size = new System.Drawing.Size(247, 521);
            this.dataGridViewInProgress.TabIndex = 1;
            this.dataGridViewInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewInProgress_DragDrop);
            this.dataGridViewInProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewInProgress_DragOver);
            this.dataGridViewInProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewInProgress_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "In Progress";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridViewRevison);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(544, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 545);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewRevison
            // 
            this.dataGridViewRevison.AllowUserToAddRows = false;
            this.dataGridViewRevison.AllowUserToDeleteRows = false;
            this.dataGridViewRevison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRevison.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewRevison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Revison});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRevison.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRevison.Location = new System.Drawing.Point(-1, 23);
            this.dataGridViewRevison.Name = "dataGridViewRevison";
            this.dataGridViewRevison.ReadOnly = true;
            this.dataGridViewRevison.RowHeadersWidth = 51;
            this.dataGridViewRevison.RowTemplate.Height = 24;
            this.dataGridViewRevison.Size = new System.Drawing.Size(247, 521);
            this.dataGridViewRevison.TabIndex = 1;
            this.dataGridViewRevison.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewRevison_DragDrop);
            this.dataGridViewRevison.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewRevison_DragOver);
            this.dataGridViewRevison.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewRevison_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Revison";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridViewCheck);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(812, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 545);
            this.panel4.TabIndex = 3;
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.AllowUserToAddRows = false;
            this.dataGridViewCheck.AllowUserToDeleteRows = false;
            this.dataGridViewCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCheck.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheck.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCheck.Location = new System.Drawing.Point(-1, 23);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.ReadOnly = true;
            this.dataGridViewCheck.RowHeadersWidth = 51;
            this.dataGridViewCheck.RowTemplate.Height = 24;
            this.dataGridViewCheck.Size = new System.Drawing.Size(247, 521);
            this.dataGridViewCheck.TabIndex = 1;
            this.dataGridViewCheck.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewCheck_DragDrop);
            this.dataGridViewCheck.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewCheck_DragOver);
            this.dataGridViewCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCheck_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridViewDone);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1079, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 545);
            this.panel5.TabIndex = 4;
            // 
            // dataGridViewDone
            // 
            this.dataGridViewDone.AllowUserToAddRows = false;
            this.dataGridViewDone.AllowUserToDeleteRows = false;
            this.dataGridViewDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDone.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Done});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDone.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDone.Location = new System.Drawing.Point(-1, 23);
            this.dataGridViewDone.Name = "dataGridViewDone";
            this.dataGridViewDone.ReadOnly = true;
            this.dataGridViewDone.RowHeadersWidth = 51;
            this.dataGridViewDone.RowTemplate.Height = 24;
            this.dataGridViewDone.Size = new System.Drawing.Size(247, 521);
            this.dataGridViewDone.TabIndex = 1;
            this.dataGridViewDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewDone_DragDrop);
            this.dataGridViewDone.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewDone_DragOver);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Done";
            // 
            // btnAnaEkranaDon
            // 
            this.btnAnaEkranaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnaEkranaDon.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaEkranaDon.Location = new System.Drawing.Point(1171, 581);
            this.btnAnaEkranaDon.Name = "btnAnaEkranaDon";
            this.btnAnaEkranaDon.Size = new System.Drawing.Size(155, 29);
            this.btnAnaEkranaDon.TabIndex = 15;
            this.btnAnaEkranaDon.Text = "Ana Ekrana Dön";
            this.btnAnaEkranaDon.UseVisualStyleBackColor = true;
            this.btnAnaEkranaDon.Click += new System.EventHandler(this.btnAnaEkranaDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(990, 581);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(155, 29);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // taskBoardProjectDataSet5
            // 
            this.taskBoardProjectDataSet5.DataSetName = "TaskBoardProjectDataSet5";
            this.taskBoardProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTaskStatusBindingSource
            // 
            this.tblTaskStatusBindingSource.DataMember = "Tbl_TaskStatus";
            this.tblTaskStatusBindingSource.DataSource = this.taskBoardProjectDataSet5;
            // 
            // tbl_TaskStatusTableAdapter
            // 
            this.tbl_TaskStatusTableAdapter.ClearBeforeFill = true;
            // 
            // todoDataGridViewTextBoxColumn
            // 
            this.todoDataGridViewTextBoxColumn.DataPropertyName = "todo";
            this.todoDataGridViewTextBoxColumn.HeaderText = "todo";
            this.todoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.todoDataGridViewTextBoxColumn.Name = "todoDataGridViewTextBoxColumn";
            this.todoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InProgress
            // 
            this.InProgress.HeaderText = "In Progress";
            this.InProgress.MinimumWidth = 6;
            this.InProgress.Name = "InProgress";
            this.InProgress.ReadOnly = true;
            // 
            // Revison
            // 
            this.Revison.HeaderText = "Revison";
            this.Revison.MinimumWidth = 6;
            this.Revison.Name = "Revison";
            this.Revison.ReadOnly = true;
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            // 
            // Done
            // 
            this.Done.HeaderText = "Done";
            this.Done.MinimumWidth = 6;
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            // 
            // TaskListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 622);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnaEkranaDon);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskListeleme";
            this.Load += new System.EventHandler(this.TaskListeleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInProgress)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevison)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBoardProjectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaskStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewInProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewRevison;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewDone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnaEkranaDon;
        private System.Windows.Forms.Button btnCikis;
        private TaskBoardProjectDataSet5 taskBoardProjectDataSet5;
        private System.Windows.Forms.BindingSource tblTaskStatusBindingSource;
        private TaskBoardProjectDataSet5TableAdapters.Tbl_TaskStatusTableAdapter tbl_TaskStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revison;
        private System.Windows.Forms.DataGridViewTextBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Done;
    }
}