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
        private readonly IExamRepository examRepository;
        private readonly IExamQuestionRepository examQuestionRepository;
        private readonly IQuestionAnswerRepository questionAnswerRepository;
        public Main(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            userRepository = new UserRepository();
            examRepository = new ExamRepository();
            examQuestionRepository = new ExamQuestionRepository();
            questionAnswerRepository = new QuestionAnswerRepository();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshAllData();
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured while refresh data");
            }
        }

        private void RefreshAllData()
        {
            lblRole.Text = CurrentUser.Role;
            lblUserName.Text = CurrentUser.UserName;
            if (CurrentUser.Role == Roles.User)
            {
                btnAddUser.Enabled = false;
                btnDeleteUser.Enabled = false;
                btnAddExam.Enabled = false;
                btnDeleteExam.Enabled = false;
            }
            else
            {
                btnAddUser.Enabled = true;
                btnDeleteUser.Enabled = true;
                btnAddExam.Enabled = true;
                btnDeleteExam.Enabled = true;
            }
            LoadUsers();
            LoadExams();
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
                else if (tabControl.SelectedTab == tabExams)
                {
                    LoadExams();
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
                int selectedUSerId = -1;
                string name = string.Empty;
                foreach (DataGridViewRow row in dgwUsers.SelectedRows)
                {
                    selectedUSerId = Convert.ToInt32(row.Cells[0].Value);
                    name = row.Cells[1].Value.ToString();
                }
                if (selectedUSerId != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure delete \"{name}\" user", $"Delete user", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        userRepository.Delete(selectedUSerId);
                        LoadUsers();
                    }
                }
                else
                {
                    MessageBox.Show("You need select user");
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
            var users = userRepository.GetAll();
            dgwUsers.Rows.Clear();
            foreach (var item in users)
            {
                dgwUsers.Rows.Add(item.Id, item.UserName, item.Role);
            }
        }
        private void LoadExams()
        {
            var exams = examRepository.GetAll();
            dgwExams.Rows.Clear();
            foreach (var item in exams)
            {
                dgwExams.Rows.Add(item.Id, item.Name, item.PassingScore);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshAllData();
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int examId = -1;
                string name = string.Empty;
                foreach (DataGridViewRow row in dgwExams.SelectedRows)
                {
                    examId = Convert.ToInt32(row.Cells[0].Value);
                    name = row.Cells[1].Value.ToString();
                }
                if (examId != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure delete \"{name}\" exam", $"Delete exam", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        examRepository.Delete(examId);
                        LoadExams();
                    }
                }
                else
                {
                    MessageBox.Show("You need select exam");
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

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var addExamForm = new AddExamForm(this);
                addExamForm.Show();
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

        private void btnExamQuestions_Click(object sender, EventArgs e)
        {
            try
            {
                int examId = -1;
                foreach (DataGridViewRow row in dgwExams.SelectedRows)
                {
                    examId = Convert.ToInt32(row.Cells[0].Value);
                    break;
                }
                if (examId == -1)
                {
                    MessageBox.Show("You need select exam first");
                    return;
                }
                this.Hide();
                var addExamForm = new ExamQuestions(this,examId);
                addExamForm.Show();
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
    }
}
