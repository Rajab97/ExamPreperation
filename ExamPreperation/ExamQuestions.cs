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
    public partial class ExamQuestions : Form
    {
        private readonly Form previousForm;
        private readonly int examId;
        private readonly IExamRepository examRepository;
        private readonly IExamQuestionRepository examQuestionRepository;
        public ExamQuestions(Form previousForm,int examId)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            examRepository = new ExamRepository();
            examQuestionRepository = new ExamQuestionRepository();
            this.examId = examId;
        }

        private void ExamQuestions_Load(object sender, EventArgs e)
        {
            try
            {
                LoadQuestions();
                if (CurrentUser.Role == Roles.User)
                {
                    btnAddQuestion.Enabled = false;
                    btnDeleteQuestion.Enabled = false;
                }
                else
                {
                    btnAddQuestion.Enabled = true;
                    btnDeleteQuestion.Enabled = true;
                }
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured while get exam questions");
            }
        }


        private void LoadQuestions()
        {
            var examQuestions = examQuestionRepository.GetExamQuestions(examId);
            dgwExamQuestions.Rows.Clear();
            foreach (var item in examQuestions)
            {
                dgwExamQuestions.Rows.Add(item.Id, item.Name, item.Score);
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedQuestinId = -1;
                string name = String.Empty;
                foreach (DataGridViewRow row in dgwExamQuestions.SelectedRows)
                {
                    selectedQuestinId = Convert.ToInt32(row.Cells[0].Value);
                    name = row.Cells[1].Value.ToString();
                    break;
                }
                if (selectedQuestinId != -1)
                {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure delete \"{name}\" question", $"Delete question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        examQuestionRepository.Delete(selectedQuestinId);
                        LoadQuestions();
                    }
                }
                else
                    MessageBox.Show("You need select question");
                
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured while delete question");
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var form = new AddQuestionForm(this,examId);
                form.Show();
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

        private void ExamQuestions_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                LoadQuestions();
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

        private void ExamQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            previousForm.Show();
        }
    }
}
