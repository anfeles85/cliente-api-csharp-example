namespace ClientApiLibrary.View
{
    partial class FormLogin
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
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(42, 34);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(42, 114);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(86, 20);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Contraseña:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(165, 27);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(165, 107);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(239, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(183, 184);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Aceptar";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 259);
            Controls.Add(buttonOk);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += FormLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonOk;
    }
}