
using ClientApiLibrary.Controller;
using ClientApiLibrary.Model;
using ClientApiLibrary.View;

namespace ClientApiLibrary
{
    public partial class FormCategory : Form
    {
        private CategoryController categoryController;
        public FormCategory()
        {
            InitializeComponent();
            categoryController = new CategoryController();
            LoadCategories();
        }

        private async void LoadCategories()
        {

            List<Category> categories = await categoryController.findAll();
            if (categories != null)
            {
                dataGridViewCategories.DataSource = categories; //si se dejan las columnas en inglés
                dataGridViewCategories.Columns["Description"].Width = 250;
                /*foreach (var category in categories)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewCategories);
                    row.Cells[0].Value = category.Id;
                    row.Cells[1].Value = category.Name;
                    row.Cells[2].Value = category.Description;
                    dataGridViewCategories.Rows.Add(row);
                }  */
            }
            else
            {
                MessageBox.Show("Error al consultar categorías");
            }
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            dataGridViewCategories.ClearSelection();
            buttonInsert.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            LoadCategories();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Método en API no implementado");
            clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Método en API no implementado");
            clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Método en API no implementado");
            clear();
        }

        private async void dataGridViewCategories_CellClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridViewCategories.Rows[e.RowIndex];
            // Asignar valores a los TextBox
            Category category = await categoryController.findById(Convert.ToInt32(row.Cells["Id"].Value.ToString()));

            textBoxId.Text = category.Id.ToString();
            textBoxName.Text = category.Name;
            textBoxDescription.Text = category.Description;

            buttonInsert.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditorial formEditorial = new FormEditorial();
            formEditorial.Show();
        }

        private void FormCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
