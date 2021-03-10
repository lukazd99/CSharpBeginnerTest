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
            createAnswers(questionNumber);
        }

        private void createAnswers(int questionNum)
        {
            int numberOfAnswers = getNumOfAnswers(questionNum);
            if (numberOfAnswers == -1)
            {
                Application.Exit();
            }


            showRadioButtons(numberOfAnswers);


        }

        private void setRadioButtonText(RadioButton radioButton, string text)
        {
            radioButton.Text = text;
        }

        private void showRadioButtons(int numberOfButtons)
        {
            switch (numberOfButtons)
            {
                case 2:
                    radioBtnAnswer1.Visible = true;
                    radioBtnAnswer2.Visible = true;
                    radioBtnAnswer3.Visible = false;
                    radioBtnAnswer4.Visible = false;
                    break;
                case 3:
                    radioBtnAnswer1.Visible = true;
                    radioBtnAnswer2.Visible = true;
                    radioBtnAnswer3.Visible = true;
                    radioBtnAnswer4.Visible = false;
                    break;
                case 4:
                    radioBtnAnswer1.Visible = true;
                    radioBtnAnswer2.Visible = true;
                    radioBtnAnswer3.Visible = true;
                    radioBtnAnswer4.Visible = true;
                    break;
            }
        }

        int getNumOfAnswers(int questionNumber)
        {
            int result;
            StreamReader sr = null;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                sr = new StreamReader(@"C:\Work\C# Lecturing\CSharpBeginnerTest\NumOfAnswers.txt");

                int i = 1;
                while (i != questionNumber)
                {
                    sr.ReadLine();
                }
                result = int.Parse(sr.ReadLine());
                sr.Close();
                return result;

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: \n" + e.Message);
                return -1;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        bool checkAnswer(string answer)
        {
            return answer == "true";
        }
    }
}
