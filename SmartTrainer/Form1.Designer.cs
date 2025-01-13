namespace SmartTrainer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cbPlus = new System.Windows.Forms.CheckBox();
            this.cbMinus = new System.Windows.Forms.CheckBox();
            this.cbMultiply = new System.Windows.Forms.CheckBox();
            this.cbDivide = new System.Windows.Forms.CheckBox();
            this.lCount = new System.Windows.Forms.Label();
            this.lDifficulty = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.cbTimer = new System.Windows.Forms.CheckBox();
            this.cbSigned = new System.Windows.Forms.CheckBox();
            this.cbCountDown = new System.Windows.Forms.CheckBox();
            this.countDownPanel = new System.Windows.Forms.Panel();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lSeconds = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.countDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(288, 24);
            this.msMenu.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAbout,
            this.msiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // msiAbout
            // 
            this.msiAbout.Name = "msiAbout";
            this.msiAbout.Size = new System.Drawing.Size(149, 22);
            this.msiAbout.Text = "О программе";
            this.msiAbout.Click += new System.EventHandler(this.msiAbout_Click);
            // 
            // msiExit
            // 
            this.msiExit.Name = "msiExit";
            this.msiExit.Size = new System.Drawing.Size(149, 22);
            this.msiExit.Text = "Выход";
            this.msiExit.Click += new System.EventHandler(this.msiExit_Click);
            // 
            // cbPlus
            // 
            this.cbPlus.AutoSize = true;
            this.cbPlus.Checked = true;
            this.cbPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPlus.Location = new System.Drawing.Point(12, 27);
            this.cbPlus.Name = "cbPlus";
            this.cbPlus.Size = new System.Drawing.Size(77, 17);
            this.cbPlus.TabIndex = 1;
            this.cbPlus.Text = "Сложение";
            this.cbPlus.UseVisualStyleBackColor = true;
            // 
            // cbMinus
            // 
            this.cbMinus.AutoSize = true;
            this.cbMinus.Location = new System.Drawing.Point(12, 50);
            this.cbMinus.Name = "cbMinus";
            this.cbMinus.Size = new System.Drawing.Size(81, 17);
            this.cbMinus.TabIndex = 2;
            this.cbMinus.Text = "Вычитание";
            this.cbMinus.UseVisualStyleBackColor = true;
            // 
            // cbMultiply
            // 
            this.cbMultiply.AutoSize = true;
            this.cbMultiply.Location = new System.Drawing.Point(12, 73);
            this.cbMultiply.Name = "cbMultiply";
            this.cbMultiply.Size = new System.Drawing.Size(86, 17);
            this.cbMultiply.TabIndex = 3;
            this.cbMultiply.Text = "Умножение";
            this.cbMultiply.UseVisualStyleBackColor = true;
            // 
            // cbDivide
            // 
            this.cbDivide.AutoSize = true;
            this.cbDivide.Location = new System.Drawing.Point(12, 96);
            this.cbDivide.Name = "cbDivide";
            this.cbDivide.Size = new System.Drawing.Size(71, 17);
            this.cbDivide.TabIndex = 4;
            this.cbDivide.Text = "Деление";
            this.cbDivide.UseVisualStyleBackColor = true;
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(9, 180);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(66, 13);
            this.lCount.TabIndex = 5;
            this.lCount.Text = "Количество";
            // 
            // lDifficulty
            // 
            this.lDifficulty.AutoSize = true;
            this.lDifficulty.Location = new System.Drawing.Point(9, 206);
            this.lDifficulty.Name = "lDifficulty";
            this.lDifficulty.Size = new System.Drawing.Size(63, 13);
            this.lDifficulty.TabIndex = 6;
            this.lDifficulty.Text = "Сложность";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(78, 177);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(72, 20);
            this.tbCount.TabIndex = 7;
            this.tbCount.Text = "10";
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCount_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(264, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Запустить";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Низкая",
            "Средняя",
            "Высокая",
            "Максимум"});
            this.cbDifficulty.Location = new System.Drawing.Point(78, 203);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(198, 21);
            this.cbDifficulty.TabIndex = 10;
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Location = new System.Drawing.Point(176, 27);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(65, 17);
            this.cbTimer.TabIndex = 11;
            this.cbTimer.Text = "Таймер";
            this.cbTimer.UseVisualStyleBackColor = true;
            // 
            // cbSigned
            // 
            this.cbSigned.AutoSize = true;
            this.cbSigned.Location = new System.Drawing.Point(12, 119);
            this.cbSigned.Name = "cbSigned";
            this.cbSigned.Size = new System.Drawing.Size(138, 17);
            this.cbSigned.TabIndex = 12;
            this.cbSigned.Text = "Отрицательные числа";
            this.cbSigned.UseVisualStyleBackColor = true;
            // 
            // cbCountDown
            // 
            this.cbCountDown.AutoSize = true;
            this.cbCountDown.Location = new System.Drawing.Point(176, 50);
            this.cbCountDown.Name = "cbCountDown";
            this.cbCountDown.Size = new System.Drawing.Size(75, 17);
            this.cbCountDown.TabIndex = 13;
            this.cbCountDown.Text = "На время";
            this.cbCountDown.UseVisualStyleBackColor = true;
            this.cbCountDown.CheckedChanged += new System.EventHandler(this.cbCountDown_CheckedChanged);
            // 
            // countDownPanel
            // 
            this.countDownPanel.Controls.Add(this.nudSeconds);
            this.countDownPanel.Controls.Add(this.nudMinutes);
            this.countDownPanel.Controls.Add(this.lSeconds);
            this.countDownPanel.Controls.Add(this.lMinutes);
            this.countDownPanel.Location = new System.Drawing.Point(176, 73);
            this.countDownPanel.Name = "countDownPanel";
            this.countDownPanel.Size = new System.Drawing.Size(100, 63);
            this.countDownPanel.TabIndex = 14;
            this.countDownPanel.Visible = false;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(58, 29);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(36, 20);
            this.nudSeconds.TabIndex = 23;
            this.nudSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(7, 29);
            this.nudMinutes.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(36, 20);
            this.nudMinutes.TabIndex = 22;
            // 
            // lSeconds
            // 
            this.lSeconds.AutoSize = true;
            this.lSeconds.Location = new System.Drawing.Point(60, 13);
            this.lSeconds.Name = "lSeconds";
            this.lSeconds.Size = new System.Drawing.Size(25, 13);
            this.lSeconds.TabIndex = 21;
            this.lSeconds.Text = "сек";
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Location = new System.Drawing.Point(8, 13);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(27, 13);
            this.lMinutes.TabIndex = 20;
            this.lMinutes.Text = "мин";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 276);
            this.Controls.Add(this.countDownPanel);
            this.Controls.Add(this.cbCountDown);
            this.Controls.Add(this.cbSigned);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lDifficulty);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.cbDivide);
            this.Controls.Add(this.cbMultiply);
            this.Controls.Add(this.cbMinus);
            this.Controls.Add(this.cbPlus);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажёр";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.countDownPanel.ResumeLayout(false);
            this.countDownPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.CheckBox cbPlus;
        private System.Windows.Forms.CheckBox cbMinus;
        private System.Windows.Forms.CheckBox cbMultiply;
        private System.Windows.Forms.CheckBox cbDivide;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lDifficulty;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiAbout;
        private System.Windows.Forms.ToolStripMenuItem msiExit;
        private System.Windows.Forms.CheckBox cbTimer;
        private System.Windows.Forms.CheckBox cbSigned;
        private System.Windows.Forms.CheckBox cbCountDown;
        private System.Windows.Forms.Panel countDownPanel;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lSeconds;
        private System.Windows.Forms.Label lMinutes;
    }
}

