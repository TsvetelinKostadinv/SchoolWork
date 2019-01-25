using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private static int questionCounter = -1;
        private static readonly string[] questions =
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
            };
        private static readonly string[][] answers =
        {
            new string[]{ "1", "11", "111" },
            new string[]{ "2", "22", "222" },
            new string[]{ "3", "33", "333" },
            new string[]{ "4", "44", "444" },
            new string[]{ "5", "55", "555" },
            new string[]{ "6", "66", "666" },
            new string[]{ "7", "77", "777" },
            new string[]{ "8", "88", "888" },
            new string[]{ "9", "99", "999" },
            new string[]{ "10", "1010", "101010" },
        };

        private static readonly int[] correctAnswerIndex =
        {
            1,
            2,
            0,
            1,
            2,
            0,
            1,
            2,
            0,
            1
        };

        private static readonly int[] givenAnswers =
            {
                -1,
                -1,
                -1,
                -1,
                -1,
                -1,
                -1,
                -1,
                -1,
                -1
            };

        private static int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnNext_Click(object sender, EventArgs e)
        {
            //int lastIndex = questions.Length - 2;
            switch (questionCounter)
            {
                case -1:
                    questionCounter++;
                    btnNext.Text = ">";
                    updateQuestionAndAnswers();
                    break;
                case 0:
                    questionCounter++;
                    btnPrevious.Enabled = true;
                    updateQuestionAndAnswers();
                    break;
                case 8:
                    questionCounter++;
                    btnNext.Enabled = false;
                    updateQuestionAndAnswers();
                    break;
                default:
                    questionCounter++;
                    updateQuestionAndAnswers();
                    break;
            }
        }

        private void updateQuestionAndAnswers()
        {

            int answerIndex;
            if (rdBtnA.Checked)
            {
                answerIndex = 0;
            }
            else if (rdBtnB.Checked)
            {
                answerIndex = 1;
            }
            else if (rdBtnC.Checked)
            {
                answerIndex = 2;
            }
            else
            {
                answerIndex = -1;
            }

            if (answerIndex == correctAnswerIndex[questionCounter])
                score++;

            

            lblRes.Text = "Резултат: " + score;

            txtQuestion.Text = questions[questionCounter];
            rdBtnA.Text = answers[questionCounter][0];
            rdBtnB.Text = answers[questionCounter][1];
            rdBtnC.Text = answers[questionCounter][2];

            rdBtnA.Checked = false;
            rdBtnB.Checked = false;
            rdBtnC.Checked = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            switch (questionCounter)
            {
                case 1:
                    questionCounter--;
                    updateQuestionAndAnswers();
                    btnPrevious.Enabled = false;
                    break;
                default:
                    questionCounter--;
                    btnNext.Enabled = true;
                    updateQuestionAndAnswers();
                    break;
            }
        }
    }
}
