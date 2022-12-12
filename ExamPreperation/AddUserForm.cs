using ExamPreperation.Constants;
using ExamPreperation.Helpers;
using ExamPreperation.Models.Common;
using ExamPreperation.Models.Entites;
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
    public partial class AddUserForm : Form
    {
        private readonly IUserRepository userRepository;
        private readonly Form mainForm;
        public AddUserForm(Form previousForm)
        {
            InitializeComponent();
            userRepository = new UserRepository();
            this.mainForm = previousForm;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmPassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("Password and confirmation not same");
                    return;
                }
                if (cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("You need select role before save");
                    return;
                }
                var role = cmbRole.SelectedItem as ComboBoxItem<string>;
                var user = new User();
                user.UserName = txtUserName.Text;
                user.Password = HashHelper.Hash(txtPassword.Text);
                user.Role = role.Value;
                userRepository.Add(user);
                this.Close();
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

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            cmbRole.DisplayMember = ComboBoxItem<string>.DisplayMember;
            cmbRole.ValueMember = ComboBoxItem<string>.ValueMember;
            cmbRole.Items.Add(new ComboBoxItem<string>("Admin",Roles.Admin));
            cmbRole.Items.Add(new ComboBoxItem<string>("User",Roles.User));
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
