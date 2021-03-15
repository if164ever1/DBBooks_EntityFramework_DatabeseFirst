
namespace DZ_DBBooks_EF_DatabeseFirst
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_showAllBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAuthor_FirstName = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.textBoxBook_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthor_SecondName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column_author,
            this.ColumnSecondName,
            this.Column_name,
            this.Column_price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(586, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // btn_showAllBooks
            // 
            this.btn_showAllBooks.Location = new System.Drawing.Point(13, 13);
            this.btn_showAllBooks.Name = "btn_showAllBooks";
            this.btn_showAllBooks.Size = new System.Drawing.Size(89, 23);
            this.btn_showAllBooks.TabIndex = 1;
            this.btn_showAllBooks.Text = "Show all books";
            this.btn_showAllBooks.UseVisualStyleBackColor = true;
            this.btn_showAllBooks.Click += new System.EventHandler(this.btn_showAllBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author First name";
            // 
            // textBoxAuthor_FirstName
            // 
            this.textBoxAuthor_FirstName.AcceptsTab = true;
            this.textBoxAuthor_FirstName.Location = new System.Drawing.Point(282, 22);
            this.textBoxAuthor_FirstName.Name = "textBoxAuthor_FirstName";
            this.textBoxAuthor_FirstName.Size = new System.Drawing.Size(213, 20);
            this.textBoxAuthor_FirstName.TabIndex = 3;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(181, 77);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(53, 13);
            this.labelBookTitle.TabIndex = 2;
            this.labelBookTitle.Text = "Book tiitle";
            // 
            // textBoxBook_title
            // 
            this.textBoxBook_title.AcceptsTab = true;
            this.textBoxBook_title.Location = new System.Drawing.Point(282, 74);
            this.textBoxBook_title.Name = "textBoxBook_title";
            this.textBoxBook_title.Size = new System.Drawing.Size(213, 20);
            this.textBoxBook_title.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AcceptsTab = true;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Location = new System.Drawing.Point(282, 100);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(95, 20);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(282, 131);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(363, 131);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(444, 131);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author second name";
            // 
            // textBoxAuthor_SecondName
            // 
            this.textBoxAuthor_SecondName.AcceptsTab = true;
            this.textBoxAuthor_SecondName.Location = new System.Drawing.Point(282, 48);
            this.textBoxAuthor_SecondName.Name = "textBoxAuthor_SecondName";
            this.textBoxAuthor_SecondName.Size = new System.Drawing.Size(213, 20);
            this.textBoxAuthor_SecondName.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Column_author
            // 
            this.Column_author.DataPropertyName = "row_FirstName";
            this.Column_author.HeaderText = "First Name";
            this.Column_author.Name = "Column_author";
            this.Column_author.ReadOnly = true;
            this.Column_author.Width = 150;
            // 
            // ColumnSecondName
            // 
            this.ColumnSecondName.DataPropertyName = "row_secondName";
            this.ColumnSecondName.HeaderText = "Second Name";
            this.ColumnSecondName.Name = "ColumnSecondName";
            this.ColumnSecondName.ReadOnly = true;
            // 
            // Column_name
            // 
            this.Column_name.DataPropertyName = "row_BookTitle";
            this.Column_name.HeaderText = "Book Title";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            this.Column_name.Width = 150;
            // 
            // Column_price
            // 
            this.Column_price.DataPropertyName = "row_BookPrice";
            this.Column_price.HeaderText = "Price";
            this.Column_price.Name = "Column_price";
            this.Column_price.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(606, 520);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBook_title);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.textBoxAuthor_SecondName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAuthor_FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showAllBooks);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "EF Database first";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_showAllBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAuthor_FirstName;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.TextBox textBoxBook_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthor_SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_price;
    }
}

