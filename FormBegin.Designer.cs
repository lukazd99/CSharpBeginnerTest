
namespace CSharpBeginnerTest
{
    partial class FormBegin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBegin));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelInstructionsDesc1 = new System.Windows.Forms.Label();
            this.linkLabelw3Reference = new System.Windows.Forms.LinkLabel();
            this.labelInstructionsDesc2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(43, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "C# Quiz";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.labelInstructions.Location = new System.Drawing.Point(46, 232);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(132, 25);
            this.labelInstructions.TabIndex = 1;
            this.labelInstructions.Text = "Instructions:";
            // 
            // labelInstructionsDesc1
            // 
            this.labelInstructionsDesc1.AutoSize = true;
            this.labelInstructionsDesc1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.labelInstructionsDesc1.Location = new System.Drawing.Point(47, 109);
            this.labelInstructionsDesc1.Name = "labelInstructionsDesc1";
            this.labelInstructionsDesc1.Size = new System.Drawing.Size(382, 66);
            this.labelInstructionsDesc1.TabIndex = 2;
            this.labelInstructionsDesc1.Text = "The test contains 25 multiple choice questions\r\n and there is no time limit.\r\nThe" +
    " identical test can be found on:";
            // 
            // linkLabelw3Reference
            // 
            this.linkLabelw3Reference.AutoSize = true;
            this.linkLabelw3Reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabelw3Reference.Location = new System.Drawing.Point(47, 188);
            this.linkLabelw3Reference.Name = "linkLabelw3Reference";
            this.linkLabelw3Reference.Size = new System.Drawing.Size(333, 20);
            this.linkLabelw3Reference.TabIndex = 3;
            this.linkLabelw3Reference.TabStop = true;
            this.linkLabelw3Reference.Text = "https://www.w3schools.com/cs/cs_quiz.asp";
            this.linkLabelw3Reference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelw3Reference_LinkClicked);
            // 
            // labelInstructionsDesc2
            // 
            this.labelInstructionsDesc2.AutoSize = true;
            this.labelInstructionsDesc2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelInstructionsDesc2.Location = new System.Drawing.Point(47, 275);
            this.labelInstructionsDesc2.Name = "labelInstructionsDesc2";
            this.labelInstructionsDesc2.Size = new System.Drawing.Size(547, 76);
            this.labelInstructionsDesc2.TabIndex = 4;
            this.labelInstructionsDesc2.Text = resources.GetString("labelInstructionsDesc2.Text");
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(621, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 44);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START TEST";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(51, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelInstructionsDesc2);
            this.Controls.Add(this.linkLabelw3Reference);
            this.Controls.Add(this.labelInstructionsDesc1);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormBegin";
            this.Text = "C# Beginner Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelInstructionsDesc1;
        private System.Windows.Forms.LinkLabel linkLabelw3Reference;
        private System.Windows.Forms.Label labelInstructionsDesc2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
    }
}

