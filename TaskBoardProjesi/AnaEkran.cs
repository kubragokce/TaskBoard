using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBoardProjesi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TaskEkleme taskekle = new TaskEkleme();
            taskekle.ShowDialog();
            this.Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TaskGuncelleme taskguncelle = new TaskGuncelleme();
            taskguncelle.ShowDialog();
            this.Close();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            TaskListeleme taskListeleme = new TaskListeleme();
            taskListeleme.ShowDialog();
            this.Close();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
