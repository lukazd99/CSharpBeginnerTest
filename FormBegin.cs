using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpBeginnerTest
{
    public partial class FormBegin : Form
    {
        public FormBegin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormQuiz formQuiz = new FormQuiz();
            formQuiz.Show();
            Hide();
        }

        private void linkLabelw3Reference_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.w3schools.com/cs/cs_quiz.asp");
        }
    }
}
