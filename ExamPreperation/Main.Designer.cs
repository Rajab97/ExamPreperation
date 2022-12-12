
namespace ExamPreperation
{
    partial class Main
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExams = new System.Windows.Forms.TabPage();
            this.dgwExams = new System.Windows.Forms.DataGridView();
            this.ExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.btnExamQuestions = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.tabExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(75, 7);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Role :";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(75, 24);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 13);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "label4";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(608, 10);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(81, 28);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabExams);
            this.tabControl.Location = new System.Drawing.Point(9, 51);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(688, 462);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnDeleteUser);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.dgwUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(2);
            this.tabUsers.Size = new System.Drawing.Size(680, 436);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.Location = new System.Drawing.Point(116, 6);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(102, 30);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Location = new System.Drawing.Point(4, 6);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(106, 30);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgwUsers
            // 
            this.dgwUsers.AllowUserToAddRows = false;
            this.dgwUsers.AllowUserToDeleteRows = false;
            this.dgwUsers.AllowUserToResizeRows = false;
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.userRole});
            this.dgwUsers.Location = new System.Drawing.Point(2, 41);
            this.dgwUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgwUsers.MultiSelect = false;
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.RowHeadersWidth = 51;
            this.dgwUsers.RowTemplate.Height = 24;
            this.dgwUsers.Size = new System.Drawing.Size(670, 390);
            this.dgwUsers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // userRole
            // 
            this.userRole.HeaderText = "Role";
            this.userRole.MinimumWidth = 6;
            this.userRole.Name = "userRole";
            // 
            // tabExams
            // 
            this.tabExams.Controls.Add(this.btnExamQuestions);
            this.tabExams.Controls.Add(this.dgwExams);
            this.tabExams.Controls.Add(this.btnDeleteExam);
            this.tabExams.Controls.Add(this.btnAddExam);
            this.tabExams.Location = new System.Drawing.Point(4, 22);
            this.tabExams.Name = "tabExams";
            this.tabExams.Padding = new System.Windows.Forms.Padding(3);
            this.tabExams.Size = new System.Drawing.Size(680, 436);
            this.tabExams.TabIndex = 1;
            this.tabExams.Text = "Exams";
            this.tabExams.UseVisualStyleBackColor = true;
            // 
            // dgwExams
            // 
            this.dgwExams.AllowUserToAddRows = false;
            this.dgwExams.AllowUserToDeleteRows = false;
            this.dgwExams.AllowUserToResizeColumns = false;
            this.dgwExams.AllowUserToResizeRows = false;
            this.dgwExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamId,
            this.ExamName,
            this.PassScore});
            this.dgwExams.Location = new System.Drawing.Point(4, 46);
            this.dgwExams.MultiSelect = false;
            this.dgwExams.Name = "dgwExams";
            this.dgwExams.ReadOnly = true;
            this.dgwExams.Size = new System.Drawing.Size(669, 382);
            this.dgwExams.TabIndex = 2;
            // 
            // ExamId
            // 
            this.ExamId.HeaderText = "Id";
            this.ExamId.Name = "ExamId";
            this.ExamId.ReadOnly = true;
            this.ExamId.Visible = false;
            // 
            // ExamName
            // 
            this.ExamName.HeaderText = "Name";
            this.ExamName.Name = "ExamName";
            this.ExamName.ReadOnly = true;
            // 
            // PassScore
            // 
            this.PassScore.HeaderText = "Passing Score";
            this.PassScore.Name = "PassScore";
            this.PassScore.ReadOnly = true;
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.Red;
            this.btnDeleteExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteExam.Location = new System.Drawing.Point(103, 7);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(86, 32);
            this.btnDeleteExam.TabIndex = 1;
            this.btnDeleteExam.Text = "Delete";
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddExam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddExam.Location = new System.Drawing.Point(7, 7);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(90, 32);
            this.btnAddExam.TabIndex = 0;
            this.btnAddExam.Text = "Add";
            this.btnAddExam.UseVisualStyleBackColor = false;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // btnExamQuestions
            // 
            this.btnExamQuestions.BackColor = System.Drawing.Color.Green;
            this.btnExamQuestions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExamQuestions.Location = new System.Drawing.Point(195, 7);
            this.btnExamQuestions.Name = "btnExamQuestions";
            this.btnExamQuestions.Size = new System.Drawing.Size(91, 32);
            this.btnExamQuestions.TabIndex = 3;
            this.btnExamQuestions.Text = "Questions";
            this.btnExamQuestions.UseVisualStyleBackColor = false;
            this.btnExamQuestions.Click += new System.EventHandler(this.btnExamQuestions_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 513);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            this.tabControl.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.tabExams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.DataGridView dgwUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRole;
        private System.Windows.Forms.TabPage tabExams;
        private System.Windows.Forms.DataGridView dgwExams;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassScore;
        private System.Windows.Forms.Button btnExamQuestions;
    }
}