using ClientApiLibrary.Controller;
using ClientApiLibrary.Model;
using Newtonsoft.Json.Linq;
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
    public partial class FormLogin : Form
    {
        private AuthController authController;

        public FormLogin()
        {
            InitializeComponent();
            authController = new AuthController();
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Las credenciales son obligatorias");
            }
            else
            {
                LoginRequest loginRequest = new LoginRequest();
                loginRequest.email = textBoxEmail.Text;
                loginRequest.password = textBoxPassword.Text;
                LoginResponse loginResponse = await authController.login(loginRequest);

                if (loginResponse != null)
                {
                    //guardar token
                    Properties.Settings.Default.UserToken = loginResponse.token;
                    Properties.Settings.Default.Save();
                    
                    FormBook formBook = new FormBook();
                    formBook.Show();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }                
            }
                

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
