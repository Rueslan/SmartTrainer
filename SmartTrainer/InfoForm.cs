using System;
using System.Windows.Forms;

namespace SmartTrainer
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void llFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "mailto:krus1501@mail.ru");
            }
            catch (Exception)
            {
                MessageBox.Show("Не указан почтовый агент по умолчанию, попробуйте отправить письмо вручную", "Ошибка");
            }
        }

        private void llYoumoney_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://yoomoney.ru/to/410019591651516/100");
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так, попробуйте связаться с разработчиком по почте", "Ошибка");
            }
        }
    }
}
