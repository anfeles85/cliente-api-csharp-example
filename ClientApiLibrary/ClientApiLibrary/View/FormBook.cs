using ClientApiLibrary.Controller;
using ClientApiLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApiLibrary.View
{
    public partial class FormBook : Form
    {
        private BookController bookController;
        private EditorialController editorialController;
        private CategoryController categoryController;
        public FormBook()
        {
            InitializeComponent();
            bookController = new BookController();
            editorialController = new EditorialController();
            categoryController = new CategoryController();
            LoadBooks();
            LoadCombos();
        }

        private async void LoadCombos()
        {
            List<Editorial> editorials = await editorialController.findAll();
            List<Category> categories = await categoryController.findAll();
            if (editorials != null && categoryController != null)
            {
                comboBoxEditorials.DataSource = editorials;
                comboBoxEditorials.DisplayMember = "name";
                comboBoxEditorials.ValueMember = "id";
                comboBoxEditorials.SelectedIndex = -1; //para que no aparezca seleccionado

                comboBoxCategories.DataSource = categories;
                comboBoxCategories.DisplayMember = "Name";
                comboBoxCategories.ValueMember = "Id";
                comboBoxCategories.SelectedIndex = -1; //para que no aparezca seleccionado
            }
            else
            {
                MessageBox.Show("Error al consultar editoriales/categorías");
            }
        }

        private async void LoadBooks()
        {
            List<Book> books = await bookController.findAll();
            if (books != null)
            {
                foreach (var book in books)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewBooks);
                    row.Cells[0].Value = book.id;
                    row.Cells[1].Value = book.title;
                    row.Cells[2].Value = book.author;
                    row.Cells[3].Value = book.CategoryName;
                    dataGridViewBooks.Rows.Add(row);
                }

            }
            else
            {
                MessageBox.Show("Error al consultar libros");
            }

        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.Show();
            Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            textBoxId.Text = "";
            textBoxIsbn.Text = "";
            textBoxTitle.Text = "";
            textBoxAuthor.Text = "";
            comboBoxCategories.SelectedIndex = -1;
            comboBoxEditorials.SelectedIndex = -1;
            dataGridViewBooks.ClearSelection();
            buttonInsert.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            LoadBooks();
        }

        private bool ValidateForm(Book book)
        {
            if (string.IsNullOrEmpty(book.isbn))
            {
                MessageBox.Show("El ISBN es obligatorio!");
                return false;
            }

            if (string.IsNullOrEmpty(book.title))
            {
                MessageBox.Show("El título es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(book.author))
            {
                MessageBox.Show("El autor es obligatorio");
                return false;
            }

            if (book.editorial_id <= 0)
            {
                MessageBox.Show("La editorial es obligatoria");
                return false;
            }

            if (book.category_id <= 0)
            {
                MessageBox.Show("La categoría es obligatoria");
                return false;
            }

            return true;
        }

        private async void buttonInsert_ClickAsync(object sender, EventArgs e)
        {
            Book book = new Book();
            book.isbn = textBoxIsbn.Text;
            book.title = textBoxTitle.Text;
            book.author = textBoxAuthor.Text;
            book.editorial_id = (int)comboBoxEditorials.SelectedValue;
            book.category_id = (int)comboBoxCategories.SelectedValue;

            if (ValidateForm(book))
            {
                BookResponse response = await bookController.store(book);
                MessageBox.Show(response.Message);
            }

            clear();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.id = textBoxId.Text != "" ? int.Parse(textBoxId.Text) : 0;
            book.isbn = textBoxIsbn.Text;
            book.title = textBoxTitle.Text;
            book.author = textBoxAuthor.Text;
            book.editorial_id = (int)comboBoxEditorials.SelectedValue;
            book.category_id = (int)comboBoxCategories.SelectedValue;

            if (ValidateForm(book))
            {
                BookResponse response = await bookController.update(book.id, book);
                MessageBox.Show(response.Message);
            }

            clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BookResponse response = await bookController.delete(int.Parse(textBoxId.Text));
                MessageBox.Show(response.Message);
            }

            clear();
        }

        private async void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];
            // Asignar valores a los TextBox            
            Book book = await bookController.findById(Convert.ToInt64(row.Cells["Id"].Value.ToString()));

            textBoxId.Text = book.id.ToString();
            textBoxIsbn.Text = book.isbn;
            textBoxTitle.Text = book.title;
            textBoxAuthor.Text = book.author;
            comboBoxEditorials.SelectedValue = book.editorial_id;
            comboBoxCategories.SelectedValue = book.category_id; 

            buttonInsert.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }
    }
}
