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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.UserBox = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEnter = new CustomElements.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.UserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.UserBox.Location = new System.Drawing.Point(1, 1);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(207, 29);
            this.UserBox.TabIndex = 0;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.FormattingEnabled = true;
            this.chatBox.Location = new System.Drawing.Point(1, 1);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(546, 299);
            this.chatBox.TabIndex = 3;
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.msgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgBox.Location = new System.Drawing.Point(1, 1);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(546, 81);
            this.msgBox.TabIndex = 5;
            this.msgBox.Text = "";
            this.msgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msgBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Имя пользователя:";
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonEnter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonEnter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.buttonEnter.BorderRadius = 5;
            this.buttonEnter.BorderSize = 1;
            this.buttonEnter.FlatAppearance.BorderSize = 0;
            this.buttonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.buttonEnter.Location = new System.Drawing.Point(408, 16);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(157, 31);
            this.buttonEnter.TabIndex = 35;
            this.buttonEnter.Text = "Отключиться";
            this.buttonEnter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.UserBox);
            this.panel1.Location = new System.Drawing.Point(193, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 31);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.chatBox);
            this.panel2.Location = new System.Drawing.Point(17, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 301);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.msgBox);
            this.panel3.Location = new System.Drawing.Point(17, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 83);
            this.panel3.TabIndex = 38;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(582, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.Text = "Чат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Label label4;
        private CustomElements.CustomButton buttonEnter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

