
namespace CSharpBeginnerTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionTitleLabel = new System.Windows.Forms.Label();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.referenceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(43, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "C# Quiz";
            // 
            // instructionTitleLabel
            // 
            this.instructionTitleLabel.AutoSize = true;
            this.instructionTitleLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.instructionTitleLabel.Location = new System.Drawing.Point(46, 232);
            this.instructionTitleLabel.Name = "instructionTitleLabel";
            this.instructionTitleLabel.Size = new System.Drawing.Size(132, 25);
            this.instructionTitleLabel.TabIndex = 1;
            this.instructionTitleLabel.Text = "Instructions:";
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.instructionLabel1.Location = new System.Drawing.Point(47, 109);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(382, 66);
            this.instructionLabel1.TabIndex = 2;
            this.instructionLabel1.Text = "The test contains 25 multiple choice questions\n and there is no time limit.\nThe i" +
    "dentical test can be found on:";
            // 
            // referenceLinkLabel
            // 
            this.referenceLinkLabel.AutoSize = true;
            this.referenceLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.referenceLinkLabel.Location = new System.Drawing.Point(47, 188);
            this.referenceLinkLabel.Name = "referenceLinkLabel";
            this.referenceLinkLabel.Size = new System.Drawing.Size(333, 20);
            this.referenceLinkLabel.TabIndex = 3;
            this.referenceLinkLabel.TabStop = true;
            this.referenceLinkLabel.Text = "https://www.w3schools.com/cs/cs_quiz.asp";
            this.referenceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.referenceLinkLabel_LinkClicked);
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.instructionsLabel2.Location = new System.Drawing.Point(47, 275);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(547, 76);
            this.instructionsLabel2.TabIndex = 4;
            this.instructionsLabel2.Text = resources.GetString("instructionsLabel2.Text");
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(621, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 44);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START TEST";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(51, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.referenceLinkLabel);
            this.Controls.Add(this.instructionLabel1);
            this.Controls.Add(this.instructionTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "C# Beginner Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionTitleLabel;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.LinkLabel referenceLinkLabel;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
    }
}

