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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.DGVBooks = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.books = new CustomElements.CustomButton();
            this.close = new CustomElements.CustomButton();
            this.minimized = new CustomElements.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVBooks
            // 
            this.DGVBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.DGVBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBooks.Location = new System.Drawing.Point(1, 1);
            this.DGVBooks.Name = "DGVBooks";
            this.DGVBooks.Size = new System.Drawing.Size(959, 281);
            this.DGVBooks.TabIndex = 14;
            this.DGVBooks.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DGVBooks_RowPrePaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Книги в наличии:";
            // 
            // books
            // 
            this.books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.books.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.books.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.books.BorderRadius = 5;
            this.books.BorderSize = 1;
            this.books.FlatAppearance.BorderSize = 0;
            this.books.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.books.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.books.Location = new System.Drawing.Point(649, 376);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(324, 44);
            this.books.TabIndex = 35;
            this.books.Text = "Сохранить изменения в наличии";
            this.books.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.buttonSaveBooks_Click);
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
            this.close.Location = new System.Drawing.Point(939, 12);
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
            this.minimized.Location = new System.Drawing.Point(899, 12);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(34, 34);
            this.minimized.TabIndex = 38;
            this.minimized.TextColor = System.Drawing.Color.White;
            this.minimized.UseVisualStyleBackColor = false;
            this.minimized.Click += new System.EventHandler(this.minimized_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.DGVBooks);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 283);
            this.panel1.TabIndex = 39;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(988, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimized);
            this.Controls.Add(this.close);
            this.Controls.Add(this.books);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Книжный магазин (администратор)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVBooks;
        private System.Windows.Forms.Label label4;
        private CustomElements.CustomButton books;
        private CustomElements.CustomButton close;
        private CustomElements.CustomButton minimized;
        private System.Windows.Forms.Panel panel1;
    }
}