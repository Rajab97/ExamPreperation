
namespace ExamPreperation
{
    partial class ExamQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwExamQuestions = new System.Windows.Forms.DataGridView();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExamQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwExamQuestions
            // 
            this.dgwExamQuestions.AllowUserToAddRows = false;
            this.dgwExamQuestions.AllowUserToDeleteRows = false;
            this.dgwExamQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwExamQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExamQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionId,
            this.QuestionText,
            this.QuestionScore});
            this.dgwExamQuestions.Location = new System.Drawing.Point(13, 55);
            this.dgwExamQuestions.Name = "dgwExamQuestions";
            this.dgwExamQuestions.ReadOnly = true;
            this.dgwExamQuestions.Size = new System.Drawing.Size(627, 333);
            this.dgwExamQuestions.TabIndex = 0;
            // 
            // QuestionId
            // 
            this.QuestionId.HeaderText = "Id";
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.ReadOnly = true;
            this.QuestionId.Visible = false;
            // 
            // QuestionText
            // 
            this.QuestionText.HeaderText = "Question";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.ReadOnly = true;
            // 
            // QuestionScore
            // 
            this.QuestionScore.HeaderText = "Score";
            this.QuestionScore.Name = "QuestionScore";
            this.QuestionScore.ReadOnly = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddQuestion.Location = new System.Drawing.Point(13, 13);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(96, 36);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.Red;
            this.btnDeleteQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(115, 13);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(93, 36);
            this.btnDeleteQuestion.TabIndex = 2;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // ExamQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 400);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.dgwExamQuestions);
            this.Name = "ExamQuestions";
            this.Text = "Exam Questions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExamQuestions_FormClosed);
            this.Load += new System.EventHandler(this.ExamQuestions_Load);
            this.VisibleChanged += new System.EventHandler(this.ExamQuestions_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgwExamQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwExamQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionScore;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
    }
}