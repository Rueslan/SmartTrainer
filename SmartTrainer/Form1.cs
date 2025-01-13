using System;
using System.Windows.Forms;

namespace SmartTrainer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidationSuccessful())
            {
                Settings settings = new Settings();
                SetupSettings(settings);

                Controller controller = new Controller(settings);

                AskForm askForm = new AskForm(this, controller);
                askForm.Show();

                this.Hide();
            }                   
        }

        private bool ValidationSuccessful()
        {
            if (!cbPlus.Checked && !cbMinus.Checked && !cbMultiply.Checked && !cbDivide.Checked)
            {
                MessageBox.Show("Не выбраны операторы", "Ошибка");
                return false;
            }
            if (tbCount.Text.Length == 0 || Convert.ToInt32(tbCount.Text) == 0)
            {
                MessageBox.Show("Недопустимое количество примеров", "Ошибка");
                return false;
            }
            if (cbDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Сложность не выбрана", "Ошибка");
                return false;
            }
            return true;
        }

        private void SetupSettings(Settings settings)
        {
            settings.operators[0] = cbPlus.Checked;
            settings.operators[1] = cbMinus.Checked;
            settings.operators[2] = cbMultiply.Checked;
            settings.operators[3] = cbDivide.Checked;
            if (tbCount.Text.Length > 0)
            {
                settings.count = Convert.ToInt32(tbCount.Text);
            }            
            settings.difficulty = cbDifficulty.SelectedIndex + 1;
            settings.signed = cbSigned.Checked;
            settings.withTimer = cbTimer.Checked;
            settings.countDown = cbCountDown.Checked;
            settings.countDownTimer = CalculateCountDownTime(nudMinutes.Value,nudSeconds.Value);
        }

        private long CalculateCountDownTime(decimal minutes, decimal seconds)
        {
            decimal result = (minutes * 60 + seconds) * 1000;
            return (long)result;
        }

        private void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void msiAbout_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
        }

        private void msiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbCountDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCountDown.Checked)
            {
                countDownPanel.Visible = true;
                cbTimer.Checked = false;
                cbTimer.Enabled = false;
            }
            else 
            {
                countDownPanel.Visible = false;
                cbTimer.Enabled = true;
            }
        }

        private void tbCountDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
