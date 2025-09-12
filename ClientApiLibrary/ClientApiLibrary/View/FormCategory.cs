
using ClientApiLibrary.Controller;
using ClientApiLibrary.Model;

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
                //dataGridViewCategories.DataSource = categories; //si se dejan las columnas en inglés
                foreach(var category in categories)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewCategories);
                    row.Cells[0].Value = category.Id;
                    row.Cells[1].Value = category.Name;
                    row.Cells[2].Value = category.Description;
                    dataGridViewCategories.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Error al consultar categorías");
            }
        }
    }
}
