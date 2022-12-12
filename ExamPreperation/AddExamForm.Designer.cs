
namespace ExamPreperation
{
    partial class AddExamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.txtPassingScore = new System.Windows.Forms.TextBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passing Score";
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(43, 78);
            this.txtExamName.Multiline = true;
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExamName.Size = new System.Drawing.Size(284, 46);
            this.txtExamName.TabIndex = 2;
            // 
            // txtPassingScore
            // 
            this.txtPassingScore.Location = new System.Drawing.Point(43, 164);
            this.txtPassingScore.Name = "txtPassingScore";
            this.txtPassingScore.Size = new System.Drawing.Size(284, 20);
            this.txtPassingScore.TabIndex = 3;
            // 
            // btnAddExam
            // 
            this.btnAddExam.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExam.Location = new System.Drawing.Point(43, 205);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(284, 36);
            this.btnAddExam.TabIndex = 4;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = false;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Exam";
            // 
            // AddExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.txtPassingScore);
            this.Controls.Add(this.txtExamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddExamForm";
            this.Text = "AddExamForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddExamForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.TextBox txtPassingScore;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Label label3;
    }
}