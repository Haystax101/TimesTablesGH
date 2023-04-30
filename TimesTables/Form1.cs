using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace TimesTables
{
    public partial class Form1 : Form
    {
        int numCorrect = 0;
        int numProblems = 10;
        int numAnswered = 0;
        int currentProblem;
        int currentAnswer;
        int timeLeft;
        int index1, index2, num1, num2;
        List<string> available = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(850, 500);
            initialiseTimer();
            numProblems = tbNumOfQuestions.Value + 10;
            lblInstructions.Visible = false;
            btnSubmit.Visible = false;
            txtAnswer.Visible = false;
            lblIncorrect.Visible = false;
            lblCorrect.Visible = false;
            btnRestart.Visible = false;
            pictureBox1.Visible = true;
            panel1.Visible = false;
            panel2.Visible = true;
            clock5.Visible = false;
            clock10.Visible = false;
            clock15.Visible = false;
            clock20.Visible = false;
            clock25.Visible = false;
            clock30.Visible = false;
            clock35.Visible = false;
            clock40.Visible = false;
            clock45.Visible = false;
            clock50.Visible = false;
            clock55.Visible = false;
            clock60.Visible = true;
            sadEmoji.Visible = false;
            elatedEmoji.Visible = false;
            happyEmoji.Visible = false;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            available.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                available.Add(s);
            }
        }

        private void initialiseTimer()
        {
            timer1.Interval = 1000;
            timeLeft = 60;
        }

        private void startTimer()
        {
            timer1.Start();
            lblTimeLeft.Text = $"Time Left: \n{timeLeft} seconds";
            btnStart.Visible = false;
            lblTitle.Visible = false;
            btnSubmit.Visible = true;
            txtAnswer.Visible = true;
            lblInstructions.Visible = true;
        }


        private void stopTimer()
        {
            timer1.Stop();
            MessageBox.Show("Time's Up!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimeLeft.Text = $"Time Left: \n{timeLeft} seconds";
            if (timeLeft == 55)
            {
                clock60.Hide();
                clock5.Show();
            }
            if (timeLeft == 50)
            {
                clock5.Hide();
                clock10.Show();
            }
            if (timeLeft == 45)
            {
                clock10.Hide();
                clock15.Show();
            }
            if (timeLeft == 40)
            {
                clock15.Hide();
                clock20.Show();
            }
            if (timeLeft == 35)
            {
                clock20.Hide();
                clock25.Show();
            }
            if (timeLeft == 30)
            {
                clock25.Hide();
                clock30.Show();
            }
            if (timeLeft == 25)
            {
                clock30.Hide();
                clock35.Show();
            }
            if (timeLeft == 20)
            {
                clock35.Hide();
                clock40.Show();
            }
            if (timeLeft == 15)
            {
                clock40.Hide();
                clock45.Show();
            }
            if (timeLeft == 10)
            {
                clock45.Hide();
                clock50.Show();
            }
            if (timeLeft == 5)
            {
                clock50.Hide();
                clock55.Show();
            }
            if (timeLeft == 0)
            {
                clock55.Hide();
                clock60.Show();
                stopTimer();
                endgame();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTimer();
            btnStart.Visible = false;
            txtAnswer.Select();
        }

        private void generateNewProblem()
        {
            Random rand = new Random();
            index1 = rand.Next(checkedListBox1.CheckedItems.Count);
            num2 = rand.Next(1, 13);
            num1 = Int32.Parse(available[index1]);
            currentProblem = num1 * num2;
            currentAnswer = num2;
            lblInstructions.Text = $"{num1} x ? = {currentProblem}";
            txtAnswer.Text = "";
            txtAnswer.Focus();
        }

        private void correct()
        {
            lblIncorrect.Visible = false;
            lblCorrect.Visible = true;
        }

        private void incorrect()
        {
            lblCorrect.Visible = false;
            lblIncorrect.Visible = true;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (int.TryParse(txtAnswer.Text, out userAnswer))
            {
                numAnswered++;
                if (userAnswer == currentAnswer)
                {
                    numCorrect++;
                    correct();
                    generateNewProblem();
                }
                else
                {
                    incorrect();
                    generateNewProblem();
                }
                if (numAnswered == numProblems)
                {
                    timer1.Stop();
                    endgame();
                }

            }
            else
            {
                MessageBox.Show("Please enter a valid integer answer.");
                txtAnswer.Text = "";
                txtAnswer.Focus();
            }

        }

        private void endgame()
        {
            double dec;
            double percentage;
            txtAnswer.Visible = false;
            lblInstructions.Visible = false;
            lblIncorrect.Visible = false;
            lblCorrect.Visible = false;
            btnSubmit.Visible = false;
            btnRestart.Visible = true;
            dec = Convert.ToDouble(numCorrect) / Convert.ToDouble(numProblems);
            percentage = Math.Round(dec * 100);
            if (percentage < 50)
            {
                lblResults.Text = $"{percentage}%: Keep revising!";
                sadEmoji.Visible = true;
            }
            else if (percentage == 100)
            {
                lblResults.Text = "Full Marks: Amazing!";
                elatedEmoji.Visible = true;
            }
            else
            {
                lblResults.Text = $"{percentage}%: Very good!";
                happyEmoji.Visible = true;
            }
            lblResults.Visible = true;
        }

        private void restart()
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
            numCorrect = 0;
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();

        }

        private void btnBackSettings_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) 
            {
                MessageBox.Show("At least one box must be ticked.");
                return;
            }
            panel2.Hide();
            panel1.Show();
            available.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                available.Add(s);
            }
            numProblems = tbNumOfQuestions.Value + 10;
            numCorrect = 0;
            lblInstructions.Text = $"Enter the answers to the questions then press submit. Get {numProblems} before the time runs out!";
            generateNewProblem();
        }

        private void tbNumOfQuestions_Scroll(object sender, EventArgs e)
        {
            lbltbqnumber.Text = "" + (tbNumOfQuestions.Value + 10);
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSubmit_Click(sender, e);

            }
        }

    }
}