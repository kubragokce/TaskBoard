using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBoardProjesi
{
    public partial class TaskListeleme : Form
    {
        public TaskListeleme()
        {
            InitializeComponent();
        }
        /*Sql bağlantısını açtık.*/
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DE6TC4RE;Initial Catalog=TaskBoardProject;Integrated Security=True");
        private void TaskListeleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskBoardProjectDataSet5.Tbl_TaskStatus' table. You can move, or remove it, as needed.
            this.tbl_TaskStatusTableAdapter.Fill(this.taskBoardProjectDataSet5.Tbl_TaskStatus);

            /*Tabloların başlıklarının ellenebilirliğini false yaptık*/
            dataGridViewTodo.ColumnHeadersVisible = false;
            dataGridViewInProgress.ColumnHeadersVisible = false;
            dataGridViewRevison.ColumnHeadersVisible = false;
            dataGridViewCheck.ColumnHeadersVisible = false;
            dataGridViewDone.ColumnHeadersVisible = false;

            /*Tabloları sürükle bırak için true yaptık*/
            dataGridViewInProgress.AllowDrop = true;
            dataGridViewRevison.AllowDrop = true;
            dataGridViewCheck.AllowDrop = true;
            dataGridViewDone.AllowDrop = true;

            /*Tablolara satır eklemek için fonksiyon çağırdık.*/
            AddRow(dataGridViewInProgress,dataGridViewTodo.Rows.Count);
            AddRow(dataGridViewRevison, dataGridViewTodo.Rows.Count);
            AddRow(dataGridViewCheck, dataGridViewTodo.Rows.Count);
            AddRow(dataGridViewDone, dataGridViewTodo.Rows.Count);

            


        }
        private void btnAnaEkranaDon_Click(object sender, EventArgs e)
        {
            /*Kullanıcı bu butona bastığında ana ekrana dönecek ve bu ekran kapatılacak*/
            AnaEkran anaekran = new AnaEkran();
            this.Hide();
            anaekran.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*Satır eklemek için fonksiyon açtık*/
        public void AddRow(DataGridView dataGridView, int number)
        {
            for(int i =0; i < number; i++)
            {
                dataGridView.Rows.Add();
            }
        }

        /*Taskın durumunu güncellemek için fonksiyon açtık*/
        public void UpdateStatus(string status,string todo)
        {
            connection.Open();
            SqlCommand updatestatus = new SqlCommand("Update Tbl_TaskStatus set status = @newstatus where todo = @todo ", connection);
            updatestatus.Parameters.AddWithValue("@newstatus", status);
            updatestatus.Parameters.AddWithValue("@todo", todo);
            updatestatus.ExecuteNonQuery();
            connection.Close();
        }

        /*MouseDown yapıldığında seçili satırın konumunu kopyaladık*/
        public void MouseDown(DataGridView dataGridView,MouseEventArgs e)
        {
            int kaynaksatir;
            kaynaksatir = dataGridView.HitTest(e.X, e.Y).RowIndex;
            dataGridView.DoDragDrop(kaynaksatir, DragDropEffects.Copy);
        }

        /*DragOver yapıldığında kaynak satırı kopyaladık*/
        public void DragOver(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /*DragDrop yapıldığında hedef satıra kaynak satırın bilgilerini girip kaynak satırı boşalttık*/
        public void DragDrop(DataGridView dataGridView1, DataGridView dataGridView2, DragEventArgs e, string text)
        {
            int kaynaksatir = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point hedef = dataGridView2.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView2.HitTest(hedef.X, hedef.Y);
            if ((hit.Type == DataGridViewHitTestType.Cell))
            {
                int hedefsatir = hit.RowIndex;
                int hedefsutun = hit.ColumnIndex;
                dataGridView2.Rows[hedefsatir].Cells[hedefsutun].Value = dataGridView1.Rows[kaynaksatir].Cells[0].Value;
                UpdateStatus(text, dataGridView2.Rows[hedefsatir].Cells[hedefsutun].Value.ToString());
                dataGridView1.Rows[kaynaksatir].Cells[0].Value = null;
            }
        }

        private void dataGridViewTodo_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(dataGridViewTodo, e);
        }

        private void dataGridViewInProgress_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(dataGridViewInProgress, e);
        }

        private void dataGridViewInProgress_DragOver(object sender, DragEventArgs e)
        {
            DragOver(e);
        }

        private void dataGridViewInProgress_DragDrop(object sender, DragEventArgs e)
        {
            DragDrop(dataGridViewTodo, dataGridViewInProgress, e,"In Progress");   
        }

        private void dataGridViewRevison_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(dataGridViewRevison, e);

        }

        private void dataGridViewRevison_DragOver(object sender, DragEventArgs e)
        {
            DragOver(e);
        }

        private void dataGridViewRevison_DragDrop(object sender, DragEventArgs e)
        {
            DragDrop(dataGridViewInProgress,dataGridViewRevison, e,"Revison");
        }

        private void dataGridViewCheck_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(dataGridViewCheck, e);
        }

        private void dataGridViewCheck_DragOver(object sender, DragEventArgs e)
        {
            DragOver(e);
        }

        private void dataGridViewCheck_DragDrop(object sender, DragEventArgs e)
        {
            DragDrop(dataGridViewInProgress,dataGridViewCheck, e,"Check");
        }

        private void dataGridViewDone_DragOver(object sender, DragEventArgs e)
        {
            DragOver(e);
        }

        private void dataGridViewDone_DragDrop(object sender, DragEventArgs e)
        {
            DragDrop(dataGridViewCheck,dataGridViewDone, e,"Done");
        }


    }
}
