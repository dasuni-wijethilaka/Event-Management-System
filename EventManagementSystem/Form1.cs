using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public class Form1 : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblError;

        public Form1()
        {
            CreateForm();
        }

        private void CreateForm()
        {
            this.Text = "Login";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Event Management System";
            lblTitle.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTitle.Location = new Point(80, 30);
            lblTitle.Size = new Size(250, 30);
            this.Controls.Add(lblTitle);

            Label lblUser = new Label();
            lblUser.Text = "Username:";
            lblUser.Location = new Point(80, 100);
            lblUser.Size = new Size(80, 20);
            this.Controls.Add(lblUser);

            txtUsername = new TextBox();
            txtUsername.Location = new Point(160, 100);
            txtUsername.Size = new Size(150, 20);
            this.Controls.Add(txtUsername);

            Label lblPass = new Label();
            lblPass.Text = "Password:";
            lblPass.Location = new Point(80, 140);
            lblPass.Size = new Size(80, 20);
            this.Controls.Add(lblPass);

            txtPassword = new TextBox();
            txtPassword.Location = new Point(160, 140);
            txtPassword.Size = new Size(150, 20);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(160, 180);
            btnLogin.Size = new Size(80, 30);
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            lblError = new Label();
            lblError.Text = "";
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(80, 220);
            lblError.Size = new Size(250, 20);
            this.Controls.Add(lblError);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "password123")
            {
                lblError.Text = "";
                MessageBox.Show("Login Successful!");

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password!";
            }
        }
    }
}