namespace ClientApiLibrary.View
{
    partial class FormEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorial));
            menuStrip1 = new MenuStrip();
            funcionesToolStripMenuItem = new ToolStripMenuItem();
            categoríasToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            librosToolStripMenuItem = new ToolStripMenuItem();
            ventanaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            labelTitle = new Label();
            dataGridViewEditorials = new DataGridView();
            pictureBoxClear = new PictureBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonInsert = new Button();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxId = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditorials).BeginInit();
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
            menuStrip1.TabIndex = 13;
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
            categoríasToolStripMenuItem.Size = new Size(224, 26);
            categoríasToolStripMenuItem.Text = "Categorías";
            categoríasToolStripMenuItem.Click += categoríasToolStripMenuItem_Click;
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(224, 26);
            editorialesToolStripMenuItem.Text = "Editoriales";
            editorialesToolStripMenuItem.Click += editorialesToolStripMenuItem_Click;
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(224, 26);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
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
            labelTitle.Location = new Point(304, 42);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(94, 23);
            labelTitle.TabIndex = 14;
            labelTitle.Text = "Editoriales";
            // 
            // dataGridViewEditorials
            // 
            dataGridViewEditorials.AllowUserToAddRows = false;
            dataGridViewEditorials.AllowUserToDeleteRows = false;
            dataGridViewEditorials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditorials.Location = new Point(36, 87);
            dataGridViewEditorials.Name = "dataGridViewEditorials";
            dataGridViewEditorials.ReadOnly = true;
            dataGridViewEditorials.RowHeadersWidth = 51;
            dataGridViewEditorials.Size = new Size(647, 214);
            dataGridViewEditorials.TabIndex = 15;
            dataGridViewEditorials.CellClick += dataGridViewEditorials_CellClick;
            // 
            // pictureBoxClear
            // 
            pictureBoxClear.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxClear.Cursor = Cursors.Hand;
            pictureBoxClear.Image = (Image)resources.GetObject("pictureBoxClear.Image");
            pictureBoxClear.Location = new Point(522, 329);
            pictureBoxClear.Name = "pictureBoxClear";
            pictureBoxClear.Size = new Size(34, 36);
            pictureBoxClear.TabIndex = 25;
            pictureBoxClear.TabStop = false;
            pictureBoxClear.Click += pictureBoxClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Enabled = false;
            buttonDelete.Location = new Point(589, 425);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(589, 382);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 23;
            buttonUpdate.Text = "Modificar";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(589, 336);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 22;
            buttonInsert.Text = "Crear";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(36, 434);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(65, 20);
            labelAddress.TabIndex = 21;
            labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(145, 427);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(313, 27);
            textBoxAddress.TabIndex = 20;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(145, 384);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(232, 27);
            textBoxName.TabIndex = 19;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(36, 391);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 18;
            labelName.Text = "Name:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(145, 338);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(142, 27);
            textBoxId.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 345);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 16;
            label1.Text = "Id:";
            // 
            // FormEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 504);
            Controls.Add(pictureBoxClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(dataGridViewEditorials);
            Controls.Add(labelTitle);
            Controls.Add(menuStrip1);
            Name = "FormEditorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editoriales";
            FormClosed += FormEditorial_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditorials).EndInit();
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
        private DataGridView dataGridViewEditorials;
        private PictureBox pictureBoxClear;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonInsert;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxId;
        private Label label1;
    }
}