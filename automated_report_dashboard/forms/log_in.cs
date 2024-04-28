using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using automated_report_dashboard.Data;
using AutomatedReportCore.Responces.AdminDashboard;
using MaterialSkin.Controls;

namespace automated_report_dashboard.forms
{
    public partial class log_in : MaterialForm
    {
        DataService data = new DataService();
        GetAllUsersResponse items;


        public log_in()
        {
            InitializeComponent();
        }

        private async void log_in_Load(object sender, EventArgs e)
        {
            var response = await data.GetAllUsers();
            items = response.Data.ToObj<GetAllUsersResponse>();
            foreach (var item in items.users)
            {
                user_type.Items.Add(item.Type);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (user_type.SelectedIndex == -1 || password.Text == "")
                MessageBox.Show("إملاء البيانات المطلوبة");
            else
            {

                menu home = new();
                var UserId = items.users.Find(u => u.Type == user_type.SelectedItem).Id.ToString();
                var result = await data.Login(UserId, password.Text);
                if (result.StatusCode == AutomatedReportCore.Enums.Requests_Status.Ok)
                {
                    home.Show();
                    this.Hide();
                }
               else
                    MessageBox.Show("wrong password","hh",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
    }
}
