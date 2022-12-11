using ExamPreperation.Constants;
using ExamPreperation.Repositories.Abstracts;
using ExamPreperation.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPreperation
{
    public partial class Main : Form
    {
        private readonly Form mainForm;
        private readonly IUserRepository userRepository;
        public Main(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            userRepository = new UserRepository();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshAllData();
        }

        private void RefreshAllData()
        {
            lblRole.Text = CurrentUser.Role;
            lblUserName.Text = CurrentUser.UserName;

            LoadUsers();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = String.Empty;
            CurrentUser.Role = string.Empty;
            CurrentUser.Id = 0;
            mainForm.Show();
            this.Hide();

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab == tabUsers)
                {
                    LoadUsers();
                }
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm(this);
            this.Hide();
            addUserForm.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgwUsers.SelectedRows)
                {
                    int selectedUSerId = Convert.ToInt32(row.Cells[0].Value);
                    DialogResult dialogResult = MessageBox.Show($"Are you sure delete \"{row.Cells[1].Value.ToString()}\" user", $"Delete user", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        userRepository.DeleteUser(selectedUSerId);
                        LoadUsers();
                    }
                }

            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
        }


        private void LoadUsers()
        {
            var users = userRepository.GetUsers();
            dgwUsers.Rows.Clear();
            foreach (var item in users)
            {
                dgwUsers.Rows.Add(item.Id, item.UserName, item.Role);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            RefreshAllData();
        }
    }
}
