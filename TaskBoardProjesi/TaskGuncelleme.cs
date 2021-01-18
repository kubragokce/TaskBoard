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
    public partial class TaskGuncelleme : Form
    {
        public TaskGuncelleme()
        {
            InitializeComponent();
        }
        /*Sql bağlantısını kurduk*/
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DE6TC4RE;Initial Catalog=TaskBoardProject;Integrated Security=True");
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

        private void TaskGuncelleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskBoardProjectDataSet4.Tbl_TechnicalCard' table. You can move, or remove it, as needed.
            this.tbl_TechnicalCardTableAdapter1.Fill(this.taskBoardProjectDataSet4.Tbl_TechnicalCard);
            // TODO: This line of code loads data into the 'taskBoardProjectDataSet3.Tbl_TaskStatus' table. You can move, or remove it, as needed.
            this.tbl_TaskStatusTableAdapter.Fill(this.taskBoardProjectDataSet3.Tbl_TaskStatus);
           

        }

        private void btnTechnicalCardUpdate_Click(object sender, EventArgs e)
        {
            /*Bağlantıyı açtık*/
            connection.Open();
            switch (comboBoxCard.SelectedIndex)
            { /*Comboboxtan seçilen bölümü kart numarasına göre güncelledik*/
                case 0:
                    SqlCommand updatedate = new SqlCommand("Update Tbl_TechnicalCard set date = @newdate where cardno = @cardno ", connection);
                    updatedate.Parameters.AddWithValue("@newdate", textBoxCardNew.Text);
                    updatedate.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
                    updatedate.ExecuteNonQuery();
                    break;
                case 1:
                    SqlCommand updateprojectname = new SqlCommand("Update Tbl_TechnicalCard set projectName = @newprojectname where cardno = @cardno ", connection);
                    updateprojectname.Parameters.AddWithValue("@newprojectname", textBoxCardNew.Text);
                    updateprojectname.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
                    updateprojectname.ExecuteNonQuery();
                    break;
                case 2:
                    SqlCommand updatetechnicalexpert = new SqlCommand("Update Tbl_TechnicalCard set technicalExpert = @newtechnicalexpert where cardno = @cardno ", connection);
                    updatetechnicalexpert.Parameters.AddWithValue("@newtechnicalexpert", textBoxCardNew.Text);
                    updatetechnicalexpert.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
                    updatetechnicalexpert.ExecuteNonQuery();
                    break;

                case 3:
                    SqlCommand updatedescription = new SqlCommand("Update Tbl_TechnicalCard set description = @newdescription where cardno = @cardno ", connection);
                    updatedescription.Parameters.AddWithValue("@newdescription", textBoxCardNew.Text);
                    updatedescription.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
                    updatedescription.ExecuteNonQuery();
                    break;

                case 4:
                    SqlCommand updatenotes = new SqlCommand("Update Tbl_TechnicalCard set notes = @newnotes where cardno = @cardno ", connection);
                    updatenotes.Parameters.AddWithValue("@newnotes", textBoxCardNew.Text);
                    updatenotes.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
                    updatenotes.ExecuteNonQuery();
                    break;

                case 5:
                    SqlCommand updatepredate = new SqlCommand("Update Tbl_TechnicalCard set realDate = @newrealdate where cardno = @cardno ", connection);
                    updatepredate.Parameters.AddWithValue("@newrealdate", textBoxCardNew.Text);
                    updatepredate.Parameters.AddWithValue("@cardno", textBoxKartNo.Text);
                    updatepredate.ExecuteNonQuery();
                    break;

                default:
                    MessageBox.Show("Lütfen güncellemek istediğiniz öğeyi seçin.");
                    break;
            }

            /*Tablonun son halini tekrar tabloya doldurduk*/
            this.tbl_TechnicalCardTableAdapter1.Fill(this.taskBoardProjectDataSet4.Tbl_TechnicalCard);
            connection.Close();/*Bağlantıyı kapattık.*/
        }

       

        private void btnTaskStatusUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();

            switch (comboBoxTask.SelectedIndex)
            {/*Comboboxtan seçilen bölümü id'ye göre güncelledik*/
                case 0:
                    SqlCommand updatedate = new SqlCommand("Update Tbl_TaskStatus set date = @newdate where taskID = @taskid ", connection);
                    updatedate.Parameters.AddWithValue("@newdate", textBoxTaskNew.Text);
                    updatedate.Parameters.AddWithValue("@taskid", textBoxID.Text);
                    updatedate.ExecuteNonQuery();
                    break;

                case 1:
                    SqlCommand updatestatus = new SqlCommand("Update Tbl_TaskStatus set status = @newstatus where taskID = @taskid ", connection);
                    updatestatus.Parameters.AddWithValue("@newstatus", textBoxTaskNew.Text);
                    updatestatus.Parameters.AddWithValue("@taskid", textBoxID.Text);
                    updatestatus.ExecuteNonQuery();
                    break;

                case 2:
                    SqlCommand updatetodo = new SqlCommand("Update Tbl_TechnicalCard set todo = @newtodo where taskID = @taskid ", connection);
                    updatetodo.Parameters.AddWithValue("@newtodo", textBoxCardNew.Text);
                    updatetodo.Parameters.AddWithValue("@taskid", textBoxID.Text);
                    updatetodo.ExecuteNonQuery();
                    break;

                case 3:
                    SqlCommand updatedescription = new SqlCommand("Update Tbl_TechnicalCard set description = @newdescription where taskID = @taskid ", connection);
                    updatedescription.Parameters.AddWithValue("@newdescription", textBoxCardNew.Text);
                    updatedescription.Parameters.AddWithValue("@taskid", textBoxID.Text);
                    updatedescription.ExecuteNonQuery();
                    break;

                default:
                    MessageBox.Show("Lütfen güncellemek istediğiniz öğeyi seçin.");
                    break;
            }
            /*Tablonun güncel halini tekrar tabloya doldurduk*/
            this.tbl_TaskStatusTableAdapter.Fill(this.taskBoardProjectDataSet3.Tbl_TaskStatus);
            connection.Close();/*Bağlantıyı kapattık*/
        }


    }
}
