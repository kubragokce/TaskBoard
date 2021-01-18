using System;
using System.Collections;
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
    public partial class TaskEkleme : Form
    {
        public TaskEkleme()
        {
            InitializeComponent();
        }
        /*Sql bağlantısını kurduk*/
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DE6TC4RE;Initial Catalog=TaskBoardProject;Integrated Security=True");
        public int preDate=0;
        private void btnAnaEkranaDon_Click(object sender, EventArgs e)
        {
            /*Kullanıcı bu butona bastığında ana ekrana dönecek ve bu ekran kapatılacak*/
            AnaEkran anaekran = new AnaEkran();
            this.Hide();
            anaekran.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /*Bağlantıyı açtık*/
            connection.Open();
            /*Bilgileri yazdırmak ve tahmini süreyi hesaplatmak için gerekli fonksiyonları çağırdık*/
            TaskStatus_Write(connection);
            TechnicalCard_Write(connection);
            preDate = CalculatePreDate();
            TechnicalCard_Update(connection);
            connection.Close();
        }
        public void TechnicalCard_Write(SqlConnection connection)
        {   /*Teknik kart kısmındaki bilgileri sqle yazdırdık*/
            //   SqlCommand write = new SqlCommand("Insert Into Tbl_TechnicalCard (date,cardno,projectName,technicalExpert,description,notes) Values ('" + textBoxTarih.Text + "','" + Convert.ToInt32(textBoxKartNo.Text) + "','" + textBoxProjeAd.Text + "','" + textBoxTeknikUzman.Text + "','" + textBoxIsinAciklamasi.Text + "','" + textBoxNotlar.Text + "')", connection);
            SqlCommand write = new SqlCommand("insert into Tbl_TechnicalCard(date,cardno,projectName,technicalExpert,description,notes,realDate) Values(@date,@cardno,@projectname,@technicalexpert,@description,@notes,@realdate)",connection);
            write.Parameters.AddWithValue("@date",Convert.ToDateTime( textBoxTarih.Text));
            write.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
            write.Parameters.AddWithValue("@projectname", textBoxProjeAd.Text);
            write.Parameters.AddWithValue("@technicalexpert", textBoxTeknikUzman.Text);
            write.Parameters.AddWithValue("@description", textBoxIsinAciklamasi.Text);
            write.Parameters.AddWithValue("@notes", textBoxNotlar.Text);
            write.Parameters.AddWithValue("@realDate", textBoxGerceklesenSure.Text);
            write.ExecuteNonQuery();
        }
        public void TechnicalCard_Update(SqlConnection connection)
        {
            /*Tahmini süreyi güncelledik*/
            SqlCommand update = new SqlCommand("UPDATE Tbl_TechnicalCard SET preDate=" + preDate + " where cardno =" + Convert.ToInt32(textBoxKartNo.Text) + " ", connection);
            update.ExecuteNonQuery();
            textBoxTahminiSure.Text = preDate.ToString();
        }
        public void TaskStatus_Write(SqlConnection connection)
        {
           /*İş Takibi kısmındaki bilgileri sqle kaydettik*/
            for(int i =0; i < dataGridView1.RowCount-1; i++)
            {
                SqlCommand write = new SqlCommand("Insert Into Tbl_TaskStatus (date,status,todo,description) Values(@date,@status,@todo,@description)", connection);
                write.Parameters.AddWithValue("@date", Convert.ToDateTime( dataGridView1.Rows[i].Cells[0].Value));
                write.Parameters.AddWithValue("@status", dataGridView1.Rows[i].Cells[1].Value);
                write.Parameters.AddWithValue("@todo", dataGridView1.Rows[i].Cells[2].Value);
                write.Parameters.AddWithValue("@description", dataGridView1.Rows[i].Cells[3].Value);
                write.ExecuteNonQuery();
            }
            
        }
        public int CalculatePreDate()
        {
            /*Tahmini süreyi iş takibindeki satır sayısına bağlı olarak hesaplattık*/
            return dataGridView1.Rows.Count-1;
        }

        private void TaskEkleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskBoardProjectDataSet1.Tbl_TaskStatus' table. You can move, or remove it, as needed.
            this.tbl_TaskStatusTableAdapter.Fill(this.taskBoardProjectDataSet1.Tbl_TaskStatus);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
