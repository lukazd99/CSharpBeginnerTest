using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace CSharpBeginnerTest
{
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();

            
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
        }

        private void createQuestion(int questionNumber)
        {
           
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            createQuestion(1);

        }

        bool checkAnswer(string answer)
        {
            return answer == "true";
        }
    }
}
