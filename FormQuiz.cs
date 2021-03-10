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

            readFile();
        }


        //Testing file reading
        private void readFile()
        {
            string line;
            StreamReader sr = null;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                sr = new StreamReader(@"C:\Work\C# Lecturing\CSharpBeginnerTest\Questions.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                //close the file
                sr.Close();
                MessageBox.Show(line);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: \n" + e.Message);
            }
            finally
            {
                MessageBox.Show("Executing finally block.");
                if(sr != null)
                {
                    sr.Close();
                }
            }
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
