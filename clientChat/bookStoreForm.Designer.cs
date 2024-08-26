namespace clientChat
{
    partial class bookStoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sell = new System.Windows.Forms.Button();
            this.textParam = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.books = new System.Windows.Forms.Button();
            this.showFiltr = new System.Windows.Forms.Button();
            this.FiltrComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFindBy = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1097, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Встаньте на ячейку \r\nс id товара и введите \r\nколичество на продажу:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1097, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 6;
            // 
            // sell
            // 
            this.sell.Location = new System.Drawing.Point(1096, 160);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(162, 37);
            this.sell.TabIndex = 7;
            this.sell.Text = "Продать";
            this.sell.UseVisualStyleBackColor = true;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // textParam
            // 
            this.textParam.Location = new System.Drawing.Point(518, 32);
            this.textParam.Name = "textParam";
            this.textParam.Size = new System.Drawing.Size(262, 20);
            this.textParam.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1075, 283);
            this.dataGridView1.TabIndex = 13;
            // 
            // books
            // 
            this.books.Location = new System.Drawing.Point(795, 32);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(295, 56);
            this.books.TabIndex = 14;
            this.books.Text = "Показать все книги";
            this.books.UseVisualStyleBackColor = true;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // showFiltr
            // 
            this.showFiltr.Location = new System.Drawing.Point(15, 59);
            this.showFiltr.Name = "showFiltr";
            this.showFiltr.Size = new System.Drawing.Size(353, 29);
            this.showFiltr.TabIndex = 27;
            this.showFiltr.Text = "Показать";
            this.showFiltr.UseVisualStyleBackColor = true;
            this.showFiltr.Click += new System.EventHandler(this.showFiltr_Click);
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.FormattingEnabled = true;
            this.FiltrComboBox.Items.AddRange(new object[] {
            "Список новинок",
            "Список самых продаваемых книг",
            "Популярные авторы",
            "Самый популярный жанр за день",
            "Самый популярный жанр за неделю",
            "Самый популярный жанр за месяц",
            "Самый популярный жанр за год"});
            this.FiltrComboBox.Location = new System.Drawing.Point(15, 32);
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Size = new System.Drawing.Size(353, 21);
            this.FiltrComboBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Показать по фильтру:";
            // 
            // comboBoxFindBy
            // 
            this.comboBoxFindBy.FormattingEnabled = true;
            this.comboBoxFindBy.Items.AddRange(new object[] {
            "автору",
            "жанру",
            "имени"});
            this.comboBoxFindBy.Location = new System.Drawing.Point(384, 32);
            this.comboBoxFindBy.Name = "comboBoxFindBy";
            this.comboBoxFindBy.Size = new System.Drawing.Size(128, 21);
            this.comboBoxFindBy.TabIndex = 30;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(384, 59);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(396, 29);
            this.find.TabIndex = 31;
            this.find.Text = "Найти";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // bookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 392);
            this.Controls.Add(this.find);
            this.Controls.Add(this.comboBoxFindBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FiltrComboBox);
            this.Controls.Add(this.showFiltr);
            this.Controls.Add(this.books);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textParam);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bookStoreForm";
            this.Text = "Книжный магазин";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bookStoreForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.TextBox textParam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button books;
        private System.Windows.Forms.Button showFiltr;
        private System.Windows.Forms.ComboBox FiltrComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFindBy;
        private System.Windows.Forms.Button find;
    }
}