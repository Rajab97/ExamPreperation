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
    public partial class AddQuestionForm : Form
    {
        private readonly Form prevForm;
        private readonly int examId;
        private readonly IExamQuestionRepository examQuestionRepository;
        private readonly IQuestionAnswerRepository questionAnswerRepository;
        public AddQuestionForm(Form prevForm,int examId)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.examId = examId;
            examQuestionRepository = new ExamQuestionRepository();
            questionAnswerRepository = new QuestionAnswerRepository();
        }

        private void btnSubmitQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                int score = 0;
                if (!Int32.TryParse(txtQuestionScore.Text, out score))
                {
                    MessageBox.Show("You need send valid number for score");
                    return;
                }
                if (score <= 0)
                {
                    MessageBox.Show("Score must be bigger than zero");
                    return;
                }
                if (string.IsNullOrEmpty(txtQuestionText.Text))
                {
                    MessageBox.Show("Question text is required");
                    return;
                }
                var variants = new List<string>() { txtA.Text, txtB.Text, txtC.Text, txtD.Text };
                var isCorrect = new List<bool>() { cmbA.Checked, cmbB.Checked, cmbC.Checked, cmbD.Checked };

                if (variants.Any(m=> String.IsNullOrEmpty(m)))
                {
                    MessageBox.Show("You need feel all variants");
                    return;
                }
                if (isCorrect.Count(m=>m == true) != 1)
                {
                    MessageBox.Show("You need select one correct answer");
                    return;
                }
                var question = new ExamQuestion();
                question.Score = score;
                question.Name = txtQuestionText.Text;
                question.ExamId = examId;
                var questionId = examQuestionRepository.Add(question);
                for (int i = 0; i < variants.Count; i++)
                {
                    var answer = new QuestionAnswer()
                    {
                        IsCorrectAnswer = isCorrect[i],
                        Name = variants[i],
                        QuestionId = questionId
                    };
                    questionAnswerRepository.Add(answer);
                }
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

        private void AddQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            prevForm.Show();
        }
    }
}
