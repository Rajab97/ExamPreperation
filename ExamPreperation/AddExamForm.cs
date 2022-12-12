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
    public partial class AddExamForm : Form
    {
        private readonly Form prevForm;
        private readonly IExamRepository examRepository;
        public AddExamForm(Form prevForm)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            examRepository = new ExamRepository();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            try
            {
                int score = 0;
                if (!Int32.TryParse(txtPassingScore.Text,out score))
                {
                    MessageBox.Show("You need send valid number for score");
                    return;
                }
                var exam = new Exam();
                exam.PassingScore = score;
                exam.Name = txtExamName.Text;
                examRepository.Add(exam);
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

        private void AddExamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            prevForm.Show();
        }
    }
}
