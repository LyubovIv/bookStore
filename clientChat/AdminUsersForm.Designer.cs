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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveUsers = new System.Windows.Forms.Button();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
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
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.Location = new System.Drawing.Point(594, 26);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(133, 56);
            this.buttonSaveUsers.TabIndex = 19;
            this.buttonSaveUsers.Text = "Сохранить изменения списка пользователей";
            this.buttonSaveUsers.UseVisualStyleBackColor = true;
            this.buttonSaveUsers.Click += new System.EventHandler(this.buttonSaveUsers_Click);
            // 
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(12, 26);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.Size = new System.Drawing.Size(576, 154);
            this.DGVUsers.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Активные пользователи";
            // 
            // AdminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveUsers);
            this.Controls.Add(this.DGVUsers);
            this.Name = "AdminUsersForm";
            this.Text = "Книжный магазин (администратор)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUsersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveUsers;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.Label label1;
    }
}