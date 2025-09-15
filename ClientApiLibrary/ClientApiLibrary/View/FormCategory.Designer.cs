
namespace ClientApiLibrary
{
    partial class FormCategory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            dataGridViewCategories = new DataGridView();
            labelTitle = new Label();
            label1 = new Label();
            textBoxId = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            buttonInsert = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            pictureBoxClear = new PictureBox();
            menuStrip1 = new MenuStrip();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            categoríasToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClear).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(37, 96);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.Size = new Size(647, 214);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.CellClick += dataGridViewCategories_CellClickAsync;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTitle.Location = new Point(318, 53);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(95, 23);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Categorías";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 361);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(146, 354);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(142, 27);
            textBoxId.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(37, 407);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 4;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(146, 400);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(232, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(146, 443);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(313, 27);
            textBoxDescription.TabIndex = 6;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(37, 450);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(88, 20);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Description:";
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(590, 352);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = "Crear";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(590, 398);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Modificar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(590, 441);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // pictureBoxClear
            // 
            pictureBoxClear.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClear.Cursor = Cursors.Hand;
            pictureBoxClear.Image = (Image)resources.GetObject("pictureBoxClear.Image");
            pictureBoxClear.Location = new Point(523, 345);
            pictureBoxClear.Name = "pictureBoxClear";
            pictureBoxClear.Size = new Size(34, 36);
            pictureBoxClear.TabIndex = 11;
            pictureBoxClear.TabStop = false;
            pictureBoxClear.Click += pictureBoxClear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionesToolStripMenuItem, ventanaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(723, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // funcionesToolStripMenuItem
            // 
            funcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoríasToolStripMenuItem, editorialesToolStripMenuItem, librosToolStripMenuItem });
            funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            funcionesToolStripMenuItem.Size = new Size(88, 24);
            funcionesToolStripMenuItem.Text = "Funciones";
            // 
            // categoríasToolStripMenuItem
            // 
            categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            categoríasToolStripMenuItem.Size = new Size(163, 26);
            categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(163, 26);
            editorialesToolStripMenuItem.Text = "Editoriales";
            editorialesToolStripMenuItem.Click += editorialesToolStripMenuItem_Click;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(163, 26);
            librosToolStripMenuItem.Text = "Libros";
            // 
            // ventanaToolStripMenuItem
            // 
            ventanaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            ventanaToolStripMenuItem.Size = new Size(76, 24);
            ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 504);
            Controls.Add(pictureBoxClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewCategories);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorías";
            FormClosed += FormCategory_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClear).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dataGridViewCategories;
        private Label labelTitle;
        private Label label1;
        private TextBox textBoxId;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private Button buttonInsert;
        private Button buttonUpdate;
        private Button buttonDelete;
        private PictureBox pictureBoxClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem categoríasToolStripMenuItem;
        private ToolStripMenuItem editorialesToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem ventanaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
