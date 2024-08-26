namespace clientChat
{
    partial class AdminForm
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
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBooks
            // 
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(12, 25);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.Size = new System.Drawing.Size(961, 283);
            this.DGVBooks.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Книги в наличии";
            // 
            // buttonSaveBooks
            // 
            this.buttonSaveBooks.Location = new System.Drawing.Point(979, 25);
            this.buttonSaveBooks.Name = "buttonSaveBooks";
            this.buttonSaveBooks.Size = new System.Drawing.Size(133, 56);
            this.buttonSaveBooks.TabIndex = 16;
            this.buttonSaveBooks.Text = "Сохранить изменения в наличии";
            this.buttonSaveBooks.UseVisualStyleBackColor = true;
            this.buttonSaveBooks.Click += new System.EventHandler(this.buttonSaveBooks_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 321);
            this.Controls.Add(this.buttonSaveBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVBooks);
            this.Name = "AdminForm";
            this.Text = "Книжный магазин (администратор)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveBooks;
    }
}