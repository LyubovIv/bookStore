namespace clientChat
{
    partial class AdminUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersForm));
            this.label2 = new System.Windows.Forms.Label();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new CustomElements.CustomButton();
            this.minimized = new CustomElements.CustomButton();
            this.buttonSaveUsers = new CustomElements.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-150, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Активные пользователи";
            // 
            // DGVUsers
            // 
            this.DGVUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(1, 1);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.Size = new System.Drawing.Size(574, 152);
            this.DGVUsers.TabIndex = 18;
            this.DGVUsers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DGVUsers_RowPrePaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Активные пользователи";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.close.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.close.BorderRadius = 5;
            this.close.BorderSize = 1;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(554, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 34);
            this.close.TabIndex = 37;
            this.close.TextColor = System.Drawing.Color.White;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimized
            // 
            this.minimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.minimized.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.minimized.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.minimized.BorderRadius = 5;
            this.minimized.BorderSize = 1;
            this.minimized.FlatAppearance.BorderSize = 0;
            this.minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimized.ForeColor = System.Drawing.Color.White;
            this.minimized.Image = ((System.Drawing.Image)(resources.GetObject("minimized.Image")));
            this.minimized.Location = new System.Drawing.Point(514, 12);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(34, 34);
            this.minimized.TabIndex = 38;
            this.minimized.TextColor = System.Drawing.Color.White;
            this.minimized.UseVisualStyleBackColor = false;
            this.minimized.Click += new System.EventHandler(this.minimized_Click);
            // 
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonSaveUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.buttonSaveUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.buttonSaveUsers.BorderRadius = 5;
            this.buttonSaveUsers.BorderSize = 1;
            this.buttonSaveUsers.FlatAppearance.BorderSize = 0;
            this.buttonSaveUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonSaveUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.buttonSaveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveUsers.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSaveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.buttonSaveUsers.Location = new System.Drawing.Point(148, 239);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(440, 45);
            this.buttonSaveUsers.TabIndex = 39;
            this.buttonSaveUsers.Text = "Сохранить изменения списка пользователей";
            this.buttonSaveUsers.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.buttonSaveUsers.UseVisualStyleBackColor = false;
            this.buttonSaveUsers.Click += new System.EventHandler(this.buttonSaveUsers_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.DGVUsers);
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 154);
            this.panel1.TabIndex = 40;
            // 
            // AdminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(600, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSaveUsers);
            this.Controls.Add(this.minimized);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUsersForm";
            this.Text = "Книжный магазин (администратор)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUsersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Label label4;
        private CustomElements.CustomButton close;
        private CustomElements.CustomButton minimized;
        private CustomElements.CustomButton buttonSaveUsers;
        private System.Windows.Forms.Panel panel1;
    }
}