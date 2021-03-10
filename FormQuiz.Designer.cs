
using System.Windows.Forms;

namespace CSharpBeginnerTest
{
    partial class FormQuiz
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

        private void quizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.radioBtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.radioBtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioBtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioBtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.panelAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(68, 309);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(95, 37);
            this.btnSubmitAnswer.TabIndex = 0;
            this.btnSubmitAnswer.Text = "Next";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(44, 58);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(100, 17);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "QuestionLabel";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelAnswers
            // 
            this.panelAnswers.Controls.Add(this.radioBtnAnswer4);
            this.panelAnswers.Controls.Add(this.radioBtnAnswer3);
            this.panelAnswers.Controls.Add(this.radioBtnAnswer2);
            this.panelAnswers.Controls.Add(this.radioBtnAnswer1);
            this.panelAnswers.Location = new System.Drawing.Point(44, 107);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(149, 167);
            this.panelAnswers.TabIndex = 2;
            // 
            // radioBtnAnswer4
            // 
            this.radioBtnAnswer4.AutoSize = true;
            this.radioBtnAnswer4.Location = new System.Drawing.Point(3, 120);
            this.radioBtnAnswer4.Name = "radioBtnAnswer4";
            this.radioBtnAnswer4.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAnswer4.TabIndex = 3;
            this.radioBtnAnswer4.TabStop = true;
            this.radioBtnAnswer4.Text = "Answer4";
            this.radioBtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnswer3
            // 
            this.radioBtnAnswer3.AutoSize = true;
            this.radioBtnAnswer3.Location = new System.Drawing.Point(3, 81);
            this.radioBtnAnswer3.Name = "radioBtnAnswer3";
            this.radioBtnAnswer3.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAnswer3.TabIndex = 2;
            this.radioBtnAnswer3.TabStop = true;
            this.radioBtnAnswer3.Text = "Answer3";
            this.radioBtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnswer2
            // 
            this.radioBtnAnswer2.AutoSize = true;
            this.radioBtnAnswer2.Location = new System.Drawing.Point(3, 41);
            this.radioBtnAnswer2.Name = "radioBtnAnswer2";
            this.radioBtnAnswer2.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAnswer2.TabIndex = 1;
            this.radioBtnAnswer2.TabStop = true;
            this.radioBtnAnswer2.Text = "Answer2";
            this.radioBtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // radioBtnAnswer1
            // 
            this.radioBtnAnswer1.AutoSize = true;
            this.radioBtnAnswer1.Location = new System.Drawing.Point(3, 3);
            this.radioBtnAnswer1.Name = "radioBtnAnswer1";
            this.radioBtnAnswer1.Size = new System.Drawing.Size(83, 21);
            this.radioBtnAnswer1.TabIndex = 0;
            this.radioBtnAnswer1.TabStop = true;
            this.radioBtnAnswer1.Text = "Answer1";
            this.radioBtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Name = "FormQuiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.panelAnswers.ResumeLayout(false);
            this.panelAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new FormClosingEventHandler(quizForm_FormClosing);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.RadioButton radioBtnAnswer4;
        private System.Windows.Forms.RadioButton radioBtnAnswer3;
        private System.Windows.Forms.RadioButton radioBtnAnswer2;
        private System.Windows.Forms.RadioButton radioBtnAnswer1;
    }
}