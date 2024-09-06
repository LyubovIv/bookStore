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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookStoreForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFindBy = new CustomElements.CustomComboBox();
            this.FiltrComboBox = new CustomElements.CustomComboBox();
            this.textParam = new clientChat.CustomTextbox();
            this.books = new CustomElements.CustomButton();
            this.sales = new CustomElements.CustomButton();
            this.find = new CustomElements.CustomButton();
            this.showFiltr = new CustomElements.CustomButton();
            this.textBox2 = new clientChat.CustomTextbox();
            this.sell = new CustomElements.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimized = new CustomElements.CustomButton();
            this.close = new CustomElements.CustomButton();
            this.customButton1 = new CustomElements.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(375, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.label2.Location = new System.Drawing.Point(1091, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "Встаньте на ячейку \r\nс id товара и введите \r\nколичество на продажу:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 281);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Показать по фильтру:";
            // 
            // comboBoxFindBy
            // 
            this.comboBoxFindBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.comboBoxFindBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.comboBoxFindBy.BorderSize = 1;
            this.comboBoxFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxFindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.comboBoxFindBy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.comboBoxFindBy.Items.AddRange(new object[] {
            "автору",
            "жанру",
            "имени"});
            this.comboBoxFindBy.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.comboBoxFindBy.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.comboBoxFindBy.Location = new System.Drawing.Point(472, 57);
            this.comboBoxFindBy.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxFindBy.Name = "comboBoxFindBy";
            this.comboBoxFindBy.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxFindBy.Size = new System.Drawing.Size(253, 30);
            this.comboBoxFindBy.TabIndex = 32;
            this.comboBoxFindBy.Texts = "";
            // 
            // FiltrComboBox
            // 
            this.FiltrComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FiltrComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.FiltrComboBox.BorderSize = 1;
            this.FiltrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.FiltrComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FiltrComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.FiltrComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.FiltrComboBox.Items.AddRange(new object[] {
            "Список новинок",
            "Список самых продаваемых книг",
            "Популярные авторы",
            "Самый популярный жанр за день",
            "Самый популярный жанр за неделю",
            "Самый популярный жанр за месяц",
            "Самый популярный жанр за год"});
            this.FiltrComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.FiltrComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.FiltrComboBox.Location = new System.Drawing.Point(17, 90);
            this.FiltrComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.FiltrComboBox.Name = "FiltrComboBox";
            this.FiltrComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.FiltrComboBox.Size = new System.Drawing.Size(347, 30);
            this.FiltrComboBox.TabIndex = 32;
            this.FiltrComboBox.Texts = "";
            // 
            // textParam
            // 
            this.textParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.textParam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.textParam.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.textParam.BorderSize = 1;
            this.textParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.textParam.Location = new System.Drawing.Point(380, 89);
            this.textParam.Margin = new System.Windows.Forms.Padding(4);
            this.textParam.Multiline = false;
            this.textParam.Name = "textParam";
            this.textParam.Padding = new System.Windows.Forms.Padding(7);
            this.textParam.PasswordChar = false;
            this.textParam.Size = new System.Drawing.Size(345, 31);
            this.textParam.TabIndex = 33;
            this.textParam.UnderLineStyle = true;
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
            this.books.Location = new System.Drawing.Point(732, 57);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(354, 45);
            this.books.TabIndex = 34;
            this.books.Text = "Все книги";
            this.books.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.sales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.sales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.sales.BorderRadius = 5;
            this.sales.BorderSize = 1;
            this.sales.FlatAppearance.BorderSize = 0;
            this.sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.sales.Location = new System.Drawing.Point(732, 109);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(354, 45);
            this.sales.TabIndex = 34;
            this.sales.Text = "Мои продажи";
            this.sales.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.find.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.find.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.find.BorderRadius = 5;
            this.find.BorderSize = 1;
            this.find.FlatAppearance.BorderSize = 0;
            this.find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.find.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.find.Location = new System.Drawing.Point(380, 127);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(345, 27);
            this.find.TabIndex = 34;
            this.find.Text = "Найти";
            this.find.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // showFiltr
            // 
            this.showFiltr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.showFiltr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.showFiltr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.showFiltr.BorderRadius = 5;
            this.showFiltr.BorderSize = 1;
            this.showFiltr.FlatAppearance.BorderSize = 0;
            this.showFiltr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.showFiltr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.showFiltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showFiltr.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.showFiltr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.showFiltr.Location = new System.Drawing.Point(17, 127);
            this.showFiltr.Name = "showFiltr";
            this.showFiltr.Size = new System.Drawing.Size(347, 27);
            this.showFiltr.TabIndex = 34;
            this.showFiltr.Text = "Показать";
            this.showFiltr.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.showFiltr.UseVisualStyleBackColor = false;
            this.showFiltr.Click += new System.EventHandler(this.showFiltr_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.textBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.textBox2.BorderSize = 1;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.textBox2.Location = new System.Drawing.Point(1093, 227);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(7);
            this.textBox2.PasswordChar = false;
            this.textBox2.Size = new System.Drawing.Size(160, 31);
            this.textBox2.TabIndex = 33;
            this.textBox2.UnderLineStyle = false;
            // 
            // sell
            // 
            this.sell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.sell.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.sell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.sell.BorderRadius = 5;
            this.sell.BorderSize = 1;
            this.sell.FlatAppearance.BorderSize = 0;
            this.sell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.sell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.sell.Location = new System.Drawing.Point(1093, 265);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(160, 35);
            this.sell.TabIndex = 34;
            this.sell.Text = "Продать";
            this.sell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.sell.UseVisualStyleBackColor = false;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(17, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 283);
            this.panel1.TabIndex = 35;
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
            this.minimized.Location = new System.Drawing.Point(1179, 12);
            this.minimized.Name = "minimized";
            this.minimized.Size = new System.Drawing.Size(34, 34);
            this.minimized.TabIndex = 36;
            this.minimized.TextColor = System.Drawing.Color.White;
            this.minimized.UseVisualStyleBackColor = false;
            this.minimized.Click += new System.EventHandler(this.minimized_Click);
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
            this.close.Location = new System.Drawing.Point(1219, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 34);
            this.close.TabIndex = 36;
            this.close.TextColor = System.Drawing.Color.White;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(1219, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(34, 34);
            this.customButton1.TabIndex = 36;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // bookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1268, 454);
            this.Controls.Add(this.minimized);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showFiltr);
            this.Controls.Add(this.find);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.books);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textParam);
            this.Controls.Add(this.FiltrComboBox);
            this.Controls.Add(this.comboBoxFindBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookStoreForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Книжный магазин";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bookStoreForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private CustomElements.CustomComboBox comboBoxFindBy;
        private CustomElements.CustomComboBox FiltrComboBox;
        private CustomTextbox textParam;
        private CustomElements.CustomButton books;
        private CustomElements.CustomButton sales;
        private CustomElements.CustomButton find;
        private CustomElements.CustomButton showFiltr;
        private CustomTextbox textBox2;
        private CustomElements.CustomButton sell;
        private System.Windows.Forms.Panel panel1;
        private CustomElements.CustomButton close;
        private CustomElements.CustomButton minimized;
        private CustomElements.CustomButton customButton1;
    }
}