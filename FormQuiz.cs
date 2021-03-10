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
            createQuestion(1);
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
        }

        private void createQuestion(int questionNumber)
        {
            #region createQuestion
            string questionString;
            StreamReader sr = null;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                sr = new StreamReader(@"C:\Work\C# Lecturing\CSharpBeginnerTest\Questions.txt");

                int i = 1;
                while (i != questionNumber){
                    sr.ReadLine();
                }
                questionString = sr.ReadLine();
                labelQuestion.Text = questionString;

                sr.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: \n" + e.Message);
                Application.Exit();
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            #endregion createQuestion
        }

        private void createAnswers(int questionNum)
        {

        }

        bool checkAnswer(string answer)
        {
            return answer == "true";
        }
    }
}
