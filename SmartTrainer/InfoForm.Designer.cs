namespace SmartTrainer
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lFeedback = new System.Windows.Forms.Label();
            this.lPayInfo = new System.Windows.Forms.Label();
            this.llFeedback = new System.Windows.Forms.LinkLabel();
            this.llYoumoney = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(13, 13);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(471, 64);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TabStop = false;
            this.tbInfo.Text = "Программа тренажёр разработана для тренеровки счёта в уме для детей и подростков." +
    "\r\nЖалобы, пожелания и предложения можно отправить по почте для обратной связи.\r\n" +
    "\r\n";
            // 
            // lFeedback
            // 
            this.lFeedback.AutoSize = true;
            this.lFeedback.Location = new System.Drawing.Point(12, 92);
            this.lFeedback.Name = "lFeedback";
            this.lFeedback.Size = new System.Drawing.Size(92, 13);
            this.lFeedback.TabIndex = 1;
            this.lFeedback.Text = "Обратная связь:";
            // 
            // lPayInfo
            // 
            this.lPayInfo.AutoSize = true;
            this.lPayInfo.Location = new System.Drawing.Point(12, 120);
            this.lPayInfo.Name = "lPayInfo";
            this.lPayInfo.Size = new System.Drawing.Size(169, 13);
            this.lPayInfo.TabIndex = 2;
            this.lPayInfo.Text = "Реквизиты для пожертвований:";
            // 
            // llFeedback
            // 
            this.llFeedback.AutoSize = true;
            this.llFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llFeedback.Location = new System.Drawing.Point(110, 90);
            this.llFeedback.Name = "llFeedback";
            this.llFeedback.Size = new System.Drawing.Size(123, 17);
            this.llFeedback.TabIndex = 3;
            this.llFeedback.TabStop = true;
            this.llFeedback.Text = "krus1501@mail.ru";
            this.llFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFeedback_LinkClicked);
            // 
            // llYoumoney
            // 
            this.llYoumoney.AutoSize = true;
            this.llYoumoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llYoumoney.Location = new System.Drawing.Point(12, 142);
            this.llYoumoney.Name = "llYoumoney";
            this.llYoumoney.Size = new System.Drawing.Size(172, 17);
            this.llYoumoney.TabIndex = 4;
            this.llYoumoney.TabStop = true;
            this.llYoumoney.Text = "Юmoney (яндекс деньги)";
            this.llYoumoney.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llYoumoney_LinkClicked);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 182);
            this.Controls.Add(this.llYoumoney);
            this.Controls.Add(this.llFeedback);
            this.Controls.Add(this.lPayInfo);
            this.Controls.Add(this.lFeedback);
            this.Controls.Add(this.tbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lFeedback;
        private System.Windows.Forms.Label lPayInfo;
        private System.Windows.Forms.LinkLabel llFeedback;
        private System.Windows.Forms.LinkLabel llYoumoney;
    }
}