using ExamPreperation.Constants;
using ExamPreperation.Helpers;
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
    public partial class Form1 : Form
    {
        private readonly IUserRepository userRepository;
        public Form1()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var users = userRepository.GetAll();
            var hashedPassword = HashHelper.Hash(password);
            var user = users.FirstOrDefault(m => m.UserName == userName && m.Password == hashedPassword);
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect");
                return;
            }
            CurrentUser.UserName = user.UserName;
            CurrentUser.Role = user.Role;
            CurrentUser.Id = user.Id;
            this.Hide();
            var mainForm = new Main(this);
            mainForm.Show();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
            txtUserName.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
