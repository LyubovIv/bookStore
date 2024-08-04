namespace clientChat
{
    partial class ChatForm
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
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(121, 12);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(136, 20);
            this.UserBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя пользователя:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(263, 10);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(113, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Подключиться";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // chatBox
            // 
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(15, 38);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(361, 316);
            this.chatBox.TabIndex = 3;
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(15, 360);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(361, 65);
            this.msgBox.TabIndex = 5;
            this.msgBox.Text = "";
            this.msgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msgBox_KeyDown);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 437);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserBox);
            this.Name = "ChatForm";
            this.Text = "Чат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.RichTextBox msgBox;
    }
}

