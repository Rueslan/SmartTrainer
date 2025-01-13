using System;
using System.IO;
using System.Timers;

namespace SmartTrainer
{
    public class Controller
    {
        public bool AskingDone = false;
        public bool currentResult = false;
        public string currentOperation, currentSampleText;
        public int operand1, operand2, answer, correctResult, difficulty, count, correctTotal, variant, currentTaskIndex;
        Random rand = new Random();
        public Settings settings;
        System.Timers.Timer timer = new System.Timers.Timer();
        public DateTime StartTime = DateTime.Now;
        public TimeSpan Duration;

        public Controller(Settings settings)
        {
            this.settings = settings;
            difficulty = settings.difficulty;
            count = settings.count;
            if (settings.countDown)
            {
                StartCountDown();
            }
        }

        public void SetRandomNumbers(string operation)
        {
            if (!settings.signed)
            {
                if (operation == "+")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand1 = rand.Next(1, 10);
                            operand2 = rand.Next(1, 10);
                            break;
                        case 2:
                            operand1 = rand.Next(10, 50);
                            operand2 = rand.Next(10, 50);
                            break;
                        case 3:
                            operand1 = rand.Next(100, 500);
                            operand2 = rand.Next(100, 500);
                            break;
                        case 4:
                            operand1 = rand.Next(1000, 5000);
                            operand2 = rand.Next(1000, 5000);
                            break;
                    }
                }
                if (operation == "-")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand1 = rand.Next(1, 10);
                            operand2 = rand.Next(0, operand1);
                            break;
                        case 2:
                            operand1 = rand.Next(10, 50);
                            operand2 = rand.Next(10, operand1);
                            break;
                        case 3:
                            operand1 = rand.Next(100, 500);
                            operand2 = rand.Next(99, operand1);
                            break;
                        case 4:
                            operand1 = rand.Next(1000, 5000);
                            operand2 = rand.Next(999, operand1);
                            break;
                    }
                }
                if (operation == "*")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand1 = rand.Next(1, 5);
                            operand2 = rand.Next(1, 5);
                            break;
                        case 2:
                            operand1 = rand.Next(2, 10);
                            operand2 = rand.Next(2, 10);
                            break;
                        case 3:
                            operand1 = rand.Next(10, 20);
                            operand2 = rand.Next(10, 20);
                            break;
                        case 4:
                            operand1 = rand.Next(20, 100);
                            operand2 = rand.Next(20, 100);
                            break;
                    }
                }
                if (operation == "/")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand2 = rand.Next(2, 5);
                            operand1 = operand2 * rand.Next(1, 10);
                            break;
                        case 2:
                            operand2 = rand.Next(3, 10);
                            operand1 = operand2 * rand.Next(1, 10);
                            break;
                        case 3:
                            operand2 = rand.Next(10, 20);
                            operand1 = operand2 * rand.Next(1, 10);
                            break;
                        case 4:
                            operand2 = rand.Next(20, 100);
                            operand1 = operand2 * rand.Next(1, 10);
                            break;
                    }
                }
            }
            else
            {
                if (operation == "+")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand1 = rand.Next(-10, 10);
                            operand2 = rand.Next(-10, 10);
                            break;
                        case 2:
                            operand1 = rand.Next(-50, 50);
                            operand2 = rand.Next(-50, 50);
                            break;
                        case 3:
                            operand1 = rand.Next(-500, 500);
                            operand2 = rand.Next(-500, 500);
                            break;
                        case 4:
                            operand1 = rand.Next(-5000, 5000);
                            operand2 = rand.Next(-5000, 5000);
                            break;
                    }
                }
                if (operation == "-")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand1 = rand.Next(-10, 10);
                            operand2 = rand.Next(-10, operand1);
                            break;
                        case 2:
                            operand1 = rand.Next(-50, 50);
                            operand2 = rand.Next(-50, operand1);
                            break;
                        case 3:
                            operand1 = rand.Next(-500, 500);
                            operand2 = rand.Next(-500, operand1);
                            break;
                        case 4:
                            operand1 = rand.Next(-5000, 5000);
                            operand2 = rand.Next(-5000, operand1);
                            break;
                    }
                }
                if (operation == "*")
                {
                    switch (difficulty)
                    {
                        case 1:
                            operand1 = rand.Next(-5, 5);
                            operand2 = rand.Next(-5, 5);
                            break;
                        case 2:
                            operand1 = rand.Next(-10, 10);
                            operand2 = rand.Next(-10, 10);
                            break;
                        case 3:
                            operand1 = rand.Next(-20, 20);
                            operand2 = rand.Next(-20, 20);
                            break;
                        case 4:
                            operand1 = rand.Next(-100, 100);
                            operand2 = rand.Next(-100, 100);
                            break;
                    }
                }
                if (operation == "/")
                {
                    switch (difficulty)
                    {
                        case 1:
                            do
                            {
                                operand2 = rand.Next(-5, 5);
                            } while (operand2 == 0);                            
                            operand1 = operand2 * rand.Next(-10, 10);
                            break;
                        case 2:
                            do
                            {
                                operand2 = rand.Next(-10, 10);
                            } while (operand2 == 0);                            
                            operand1 = operand2 * rand.Next(-10, 10);
                            break;
                        case 3:
                            do
                            {
                                operand2 = rand.Next(-30, 30);
                            } while (operand2 == 0);                            
                            operand1 = operand2 * rand.Next(-10, 10);
                            break;
                        case 4:
                            do
                            {
                                operand2 = rand.Next(-100, 100);
                            } while (operand2 == 0);                            
                            operand1 = operand2 * rand.Next(-10, 10);
                            break;
                    }
                }
            }

        }
        public bool CheckResult()
        {
            if (answer == correctResult)
            {
                correctTotal++;                
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TaskMultiply()
        {
            currentOperation = "*";
            SetRandomNumbers(currentOperation);
            correctResult = operand1 * operand2;
        }
        public void TaskDivide()
        {
            currentOperation = "/";
            SetRandomNumbers(currentOperation);
            correctResult = operand1 / operand2;
        }
        public void TaskPlus()
        {
            currentOperation = "+";
            SetRandomNumbers(currentOperation);
            correctResult = operand1 + operand2;
        }
        public void TaskMinus()
        {
            currentOperation = "-";
            SetRandomNumbers(currentOperation);
            correctResult = operand1 - operand2;
        }
        public void Ask()
        {
            do
            {
                variant = rand.Next(1, 5);
                if (settings.operators[variant - 1])
                {
                    switch (variant)
                    {
                        case 1:
                            TaskPlus();
                            return;
                        case 2:
                            TaskMinus();
                            return;
                        case 3:
                            TaskMultiply();
                            return;
                        case 4:
                            TaskDivide();
                            return;
                    }
                }
            } while (true);
        }
        public void HandleAnswer(string textAnswer)
        {
            if (textAnswer.Length > 0)
            {
                answer = Convert.ToInt32(textAnswer);
                currentResult = CheckResult();
                if (currentResult)
                {
                    currentSampleText = $"{currentTaskIndex + 1}) Правильно ({operand1} {currentOperation} {operand2} = {correctResult}) {Environment.NewLine}";
                }
                else
                {
                    currentSampleText = $"{currentTaskIndex + 1}) Неправильно ({operand1} {currentOperation} {operand2} = {correctResult} а не {answer}) {Environment.NewLine}";
                }
                if (currentTaskIndex < count - 1)
                {
                    currentTaskIndex++;
                    Ask();
                }
                else
                {
                    currentTaskIndex = 0;
                    AskingDone = true; ;
                }
            }            
        }
        public string StartAsking()
        {
            string diffstring = "";
            switch (difficulty)
            {
                case 1:
                    diffstring = "Низкая";
                    break;
                case 2:
                    diffstring = "Средняя";
                    break;
                case 3:
                    diffstring = "Высокая";
                    break;
                case 4:
                    diffstring = "Максимальная";
                    break;
            }
            Ask();
            string operators = string.Empty;
            if (settings.operators[0]) operators += " +, ";
            if (settings.operators[1]) operators += " -, ";
            if (settings.operators[2]) operators += " *, ";
            if (settings.operators[3]) operators += " /, ";
            operators = operators.Substring(0, operators.Length - 2) + " ";
            return $"Сложность: {diffstring}{Environment.NewLine}Количество примеров: {count}{Environment.NewLine}Операторы: ({operators}){Environment.NewLine}{Environment.NewLine}";
            
        }
        public void SaveToFile(string content)
        {
            DirectoryInfo drInfo = new DirectoryInfo("Records");
            if (!drInfo.Exists)
            {
                drInfo.Create();
            }
            File.WriteAllText(@"Records\record " + DateTime.Now.ToString("d-M-yyyy HH-mm-ss") + ".txt", content);
        }

        public void StartCountDown()
        {            
            timer.Interval = settings.countDownTimer;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            AskingDone = true;
            timer.Stop();
        }
    }
}
