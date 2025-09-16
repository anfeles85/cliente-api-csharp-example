namespace ClientApiLibrary.View
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            menuStrip1 = new MenuStrip();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            categoríasToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            labelTitle = new Label();
            dataGridViewBooks = new DataGridView();
            labelTitle2 = new Label();
            textBoxTitle = new TextBox();
            textBoxIsbn = new TextBox();
            labelIsbn = new Label();
            textBoxId = new TextBox();
            label1 = new Label();
            labelAuthor = new Label();
            labelEditorial = new Label();
            labelCategory = new Label();
            textBoxAuthor = new TextBox();
            comboBoxEditorials = new ComboBox();
            comboBoxCategories = new ComboBox();
            pictureBoxClear = new PictureBox();
            buttonInsert = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClear).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { funcionesToolStripMenuItem, ventanaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(723, 28);
            menuStrip1.TabIndex = 14;
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
            categoríasToolStripMenuItem.Click += categoríasToolStripMenuItem_Click;
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(163, 26);
            editorialesToolStripMenuItem.Text = "Editoriales";
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
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTitle.Location = new Point(330, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(59, 23);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "Libros";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Author, Category });
            dataGridViewBooks.Location = new Point(34, 81);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(647, 214);
            dataGridViewBooks.TabIndex = 16;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // labelTitle2
            // 
            labelTitle2.AutoSize = true;
            labelTitle2.Location = new Point(34, 420);
            labelTitle2.Name = "labelTitle2";
            labelTitle2.Size = new Size(50, 20);
            labelTitle2.TabIndex = 27;
            labelTitle2.Text = "Título:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(93, 413);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(232, 27);
            textBoxTitle.TabIndex = 26;
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Location = new Point(93, 370);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(232, 27);
            textBoxIsbn.TabIndex = 25;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Location = new Point(34, 377);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(44, 20);
            labelIsbn.TabIndex = 24;
            labelIsbn.Text = "ISBN:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(93, 324);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(142, 27);
            textBoxId.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 331);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 22;
            label1.Text = "Id:";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(352, 331);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(49, 20);
            labelAuthor.TabIndex = 28;
            labelAuthor.Text = "Autor:";
            // 
            // labelEditorial
            // 
            labelEditorial.AutoSize = true;
            labelEditorial.Location = new Point(352, 377);
            labelEditorial.Name = "labelEditorial";
            labelEditorial.Size = new Size(68, 20);
            labelEditorial.TabIndex = 29;
            labelEditorial.Text = "Editorial:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(352, 420);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(77, 20);
            labelCategory.TabIndex = 30;
            labelCategory.Text = "Categoría:";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(450, 328);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(231, 27);
            textBoxAuthor.TabIndex = 31;
            // 
            // comboBoxEditorials
            // 
            comboBoxEditorials.FormattingEnabled = true;
            comboBoxEditorials.Location = new Point(450, 369);
            comboBoxEditorials.Name = "comboBoxEditorials";
            comboBoxEditorials.Size = new Size(231, 28);
            comboBoxEditorials.TabIndex = 32;
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(450, 412);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(231, 28);
            comboBoxCategories.TabIndex = 33;
            // 
            // pictureBoxClear
            // 
            pictureBoxClear.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClear.Cursor = Cursors.Hand;
            pictureBoxClear.Image = (Image)resources.GetObject("pictureBoxClear.Image");
            pictureBoxClear.Location = new Point(567, 475);
            pictureBoxClear.Name = "pictureBoxClear";
            pictureBoxClear.Size = new Size(34, 36);
            pictureBoxClear.TabIndex = 34;
            pictureBoxClear.TabStop = false;
            pictureBoxClear.Click += pictureBoxClear_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(127, 482);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 35;
            buttonInsert.Text = "Crear";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_ClickAsync;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(266, 482);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 36;
            buttonUpdate.Text = "Modificar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(419, 482);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 37;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 125;
            // 
            // Category
            // 
            Category.HeaderText = "CategoryName";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 528);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(pictureBoxClear);
            Controls.Add(comboBoxCategories);
            Controls.Add(comboBoxEditorials);
            Controls.Add(textBoxAuthor);
            Controls.Add(labelCategory);
            Controls.Add(labelEditorial);
            Controls.Add(labelAuthor);
            Controls.Add(labelTitle2);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxIsbn);
            Controls.Add(labelIsbn);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(dataGridViewBooks);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            Name = "FormBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBook";
            FormClosed += FormBook_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem funcionesToolStripMenuItem;
        private ToolStripMenuItem categoríasToolStripMenuItem;
        private ToolStripMenuItem editorialesToolStripMenuItem;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem ventanaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label labelTitle;
        private DataGridView dataGridViewBooks;
        private Label labelTitle2;
        private TextBox textBoxTitle;
        private TextBox textBoxIsbn;
        private Label labelIsbn;
        private TextBox textBoxId;
        private Label label1;
        private Label labelAuthor;
        private Label labelEditorial;
        private Label labelCategory;
        private TextBox textBoxAuthor;
        private ComboBox comboBoxEditorials;
        private ComboBox comboBoxCategories;
        private PictureBox pictureBoxClear;
        private Button buttonInsert;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Category;
    }
}