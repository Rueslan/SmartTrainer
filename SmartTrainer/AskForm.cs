using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartTrainer
{
    public partial class AskForm : Form
    {
        Form owner;
        Controller controller;
        public AskForm(Form owner, Controller controller)
        {
            InitializeComponent();
            this.owner = owner;
            this.controller = controller;
        }

        private void tbAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar == (char)Keys.Return)
            {
                HandleAnswer();
            }
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void AskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            owner.Show();
            countDownTimer.Enabled = false;
            askTimer.Enabled = false;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AskForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                Application.Exit();
            }
        }

        private void AskForm_Shown(object sender, EventArgs e)
        {
            tbStatus.AppendText(controller.StartAsking());
            lSample.Text = $"{controller.operand1} {controller.currentOperation} {controller.operand2} = ";
            if (controller.settings.countDown)
            {
                countDownTimer.Start();
            }
            if (controller.settings.withTimer)
            {
                controller.StartTime = DateTime.Now;                
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            HandleAnswer();
        }

        private void HandleAnswer()
        {
            if (tbAnswer.Text.Length > 0)
            {
                controller.HandleAnswer(tbAnswer.Text);
                tbAnswer.Text = "";

                if (controller.currentResult == true)
                {
                    WriteColored(controller.currentSampleText, Color.Green);
                }
                else
                {
                    WriteColored(controller.currentSampleText, Color.Red);
                }

                tbAnswer.Focus();

                if (controller.AskingDone)
                {
                    btnClose.Enabled = true;
                    tbAnswer.Visible = false;
                    lSample.Visible = false;
                    btnAnswer.Visible = false;
                    WriteColored("-------------------------------------------------- \n", Color.Gray);
                    WriteColored($"Правильных {controller.correctTotal} из {controller.count}{Environment.NewLine}", Color.Black);
                    if (controller.settings.withTimer)
                    {
                        controller.Duration = controller.StartTime - DateTime.Now;
                        WriteColored($"Затрачено времени: {controller.Duration.ToString("mm':'ss")}", Color.Gray);
                    }
                    
                    controller.SaveToFile(tbStatus.Text);
                }
                else
                {
                    lSample.Text = $"{controller.operand1} {controller.currentOperation} {controller.operand2} = ";
                }
                tbStatus.SelectionStart = tbStatus.TextLength;
                tbStatus.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Ответ не введён","Уведомление");
            }

        }

        public void WriteColored(string text, Color textColor)
        {
            tbStatus.SelectionColor = textColor;
            tbStatus.AppendText(text);
            tbStatus.SelectionColor = tbStatus.ForeColor;
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            if (controller.AskingDone)
            {
                btnClose.Enabled = true;
                tbAnswer.Visible = false;
                lSample.Visible = false;
                btnAnswer.Visible = false;                
                WriteColored("-------------------------------------------------- \n", Color.Gray);
                WriteColored("Время вышло!\n", Color.Red);
                WriteColored($"Правильных {controller.correctTotal} из {controller.currentTaskIndex} (всего: {controller.count}){Environment.NewLine}", Color.Black);
                tbStatus.SelectionStart = tbStatus.TextLength;
                tbStatus.ScrollToCaret();
                controller.SaveToFile(tbStatus.Text);
                countDownTimer.Stop();
            }
        }
    }
}
