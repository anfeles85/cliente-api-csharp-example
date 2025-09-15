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
    public partial class FormEditorial : Form
    {
        private EditorialController editorialController;

        public FormEditorial()
        {
            InitializeComponent();
            editorialController = new EditorialController();
            LoadEditorials();
        }

        private async void LoadEditorials()
        {
            List<Editorial> editorials = await editorialController.findAll();
            if (editorials != null)
            {
                dataGridViewEditorials.DataSource = editorials; //si se dejan las columnas en inglés
                dataGridViewEditorials.Columns["Name"].Width = 250;
            }
            else
            {
                MessageBox.Show("Error al consultar editoriales");
            }
        }

        private bool ValidateForm(Editorial editorial)
        {
            /*if (editorial.Id == 0)
            {
                MessageBox.Show("El Id es obligatorio!");
                return false;
            }*/

            if (string.IsNullOrEmpty(editorial.name))
            {
                MessageBox.Show("El nombre es obligatorio!");
                return false;
            }

            if (string.IsNullOrEmpty(editorial.address))
            {
                MessageBox.Show("La dirección es obligatoria");
                return false;
            }

            return true;
        }

        private async void buttonInsert_Click(object sender, EventArgs e)
        {
            Editorial editorial = new Editorial();
            editorial.name = textBoxName.Text;
            editorial.address = textBoxAddress.Text;
            if (ValidateForm(editorial))
            {
                EditorialResponse response = await editorialController.store(editorial);
                MessageBox.Show(response.Message);
            }

            clear();
        }

        public void clear()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            dataGridViewEditorials.ClearSelection();
            buttonInsert.Enabled = true;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
            LoadEditorials();
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            Editorial editorial = new Editorial();
            editorial.id = int.Parse(textBoxId.Text);
            editorial.name = textBoxName.Text;
            editorial.address = textBoxAddress.Text;
            if (ValidateForm(editorial))
            {
                EditorialResponse response = await editorialController.update(editorial.id, editorial);
                MessageBox.Show(response.Message);
            }
            clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EditorialResponse response = await editorialController.delete(int.Parse(textBoxId.Text));
                MessageBox.Show(response.Message);
            }

            clear();
        }

        private async void dataGridViewEditorials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener la fila seleccionada
            DataGridViewRow row = dataGridViewEditorials.Rows[e.RowIndex];
            // Asignar valores a los TextBox
            Editorial editorial = await editorialController.findById(Convert.ToInt32(row.Cells["Id"].Value.ToString()));

            textBoxId.Text = editorial.id.ToString();
            textBoxName.Text = editorial.name;
            textBoxAddress.Text = editorial.address;

            buttonInsert.Enabled = false;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.Show();
            Dispose();
        }

        private void FormEditorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
