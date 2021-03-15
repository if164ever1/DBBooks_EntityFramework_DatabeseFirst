using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_DBBooks_EF_DatabeseFirst
{
    public partial class Form1 : Form
    {
        BOOK bookModel = new BOOK();
        Author authorModel = new Author();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.Red;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_showAllBooks_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxAuthor_FirstName.Text = textBoxAuthor_SecondName.Text = textBoxBook_title.Text = textBoxPrice.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bookModel.Tittle = textBoxBook_title.Text.Trim();
            bookModel.Price = Convert.ToInt32(textBoxPrice.Text);
            authorModel.FirstName = textBoxAuthor_FirstName.Text.Trim();
            authorModel.LatsName = textBoxAuthor_SecondName.Text.Trim();


            using (LibraryEntities db = new LibraryEntities())
            {
                if (authorModel.Id == 0 && bookModel.Id == 0)
                {
                    db.Authors.Add(authorModel);
                    db.BOOKS.Add(bookModel);
                }
                else
                {
                    db.Entry(bookModel).State = System.Data.Entity.EntityState.Modified;
                    db.Entry(authorModel).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                Show();
            }
        }

        private void Show()
        {
            dataGridView1.Rows.Clear();
            var context = new LibraryEntities();

            foreach (var books in context.BOOKS)
            {
                dataGridView1.Rows.Add(books.Id.ToString(), books.Author.FirstName, books.Author.LatsName, books.Tittle, books.Price);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (dataGridView1.CurrentRow.Index != -1)
            {
                bookModel.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                using (LibraryEntities db = new LibraryEntities())
                {
                    authorModel = db.Authors.Where(x => x.Id == bookModel.Id).FirstOrDefault();
                    bookModel = db.BOOKS.Where(x => x.Id == bookModel.Id).FirstOrDefault();
                    textBoxAuthor_FirstName.Text = authorModel.FirstName;
                    textBoxAuthor_SecondName.Text = authorModel.LatsName;
                    textBoxBook_title.Text = bookModel.Tittle;
                    textBoxPrice.Text = (bookModel.Price).ToString();
                }

                buttonSave.Text = "Update";
                buttonDelete.Enabled = false;
            }
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure to delete?", "Process to delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var contextBook = db.Entry(bookModel);
                    var contextAuthor = db.Entry(authorModel);

                    if ((contextAuthor.State == System.Data.Entity.EntityState.Detached) &&
                        (contextBook.State == System.Data.Entity.EntityState.Detached))
                    {
                        db.Authors.Attach(authorModel);
                        db.BOOKS.Attach(bookModel);
                    }

                    db.Authors.Remove(authorModel);
                    db.BOOKS.Remove(bookModel);
                    db.SaveChanges();
                    Show();
                }
            }
        }
    }
}
