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
        private Button btnExit;

        public Form1()
        {
            CreateForm();
        }

        private void CreateForm()
        {
            this.Text = "Login - Event Management System";
            this.Size = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            Label lblTitle = new Label();
            lblTitle.Text = "EVENT MANAGEMENT SYSTEM";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(50, 30);
            lblTitle.Size = new Size(350, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();
            lblSubtitle.Text = "Login to Continue";
            lblSubtitle.Font = new Font("Arial", 10, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.DarkGray;
            lblSubtitle.Location = new Point(150, 75);
            lblSubtitle.Size = new Size(150, 20);
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblSubtitle);

            Label lblUser = new Label();
            lblUser.Text = "Username:";
            lblUser.Font = new Font("Arial", 10);
            lblUser.Location = new Point(100, 120);
            lblUser.Size = new Size(80, 20);
            this.Controls.Add(lblUser);

            txtUsername = new TextBox();
            txtUsername.Font = new Font("Arial", 10);
            txtUsername.Location = new Point(180, 120);
            txtUsername.Size = new Size(150, 25);
            txtUsername.BackColor = Color.WhiteSmoke;
            this.Controls.Add(txtUsername);

            Label lblPass = new Label();
            lblPass.Text = "Password:";
            lblPass.Font = new Font("Arial", 10);
            lblPass.Location = new Point(100, 160);
            lblPass.Size = new Size(80, 20);
            this.Controls.Add(lblPass);

            txtPassword = new TextBox();
            txtPassword.Font = new Font("Arial", 10);
            txtPassword.Location = new Point(180, 160);
            txtPassword.Size = new Size(150, 25);
            txtPassword.PasswordChar = '•';
            txtPassword.BackColor = Color.WhiteSmoke;
            this.Controls.Add(txtPassword);

            btnLogin = new Button();
            btnLogin.Text = "LOGIN";
            btnLogin.Font = new Font("Arial", 10, FontStyle.Bold);
            btnLogin.Location = new Point(150, 200);
            btnLogin.Size = new Size(100, 35);
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            btnExit = new Button();
            btnExit.Text = "EXIT";
            btnExit.Font = new Font("Arial", 9);
            btnExit.Location = new Point(150, 245);
            btnExit.Size = new Size(100, 30);
            btnExit.BackColor = Color.LightGray;
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);

            lblError = new Label();
            lblError.Text = "";
            lblError.Font = new Font("Arial", 9);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(100, 280);
            lblError.Size = new Size(250, 20);
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblError);

            Label lblHint = new Label();
            lblHint.Font = new Font("Arial", 8);
            lblHint.ForeColor = Color.Gray;
            lblHint.Location = new Point(120, 185);
            lblHint.Size = new Size(200, 15);
            this.Controls.Add(lblHint);

            txtPassword.KeyPress += TxtPassword_KeyPress;

            this.Load += (s, e) => txtUsername.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AuthenticateAndLogin();
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AuthenticateAndLogin();
                e.Handled = true;
            }
        }

        private void AuthenticateAndLogin()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "admin" && password == "password123")
            {
                lblError.Text = "";

                DashboardForm dashboard = new DashboardForm();

                dashboard.FormClosed += (s, e) =>
                {
                    this.Show();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                };

                dashboard.Show();
                this.Hide(); 
            }
            else
            {
                lblError.Text = "Invalid username or password!";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}