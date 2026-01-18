using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public class DashboardForm : Form
    {
        public DashboardForm()
        {
            this.Text = "Dashboard";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome to Dashboard!";
            lblWelcome.Font = new Font("Arial", 16, FontStyle.Bold);
            lblWelcome.Location = new Point(150, 150);
            lblWelcome.Size = new Size(300, 30);
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblWelcome);

            Button btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Location = new Point(250, 200);
            btnLogout.Size = new Size(100, 30);
            btnLogout.Click += (s, e) => Application.Restart();
            this.Controls.Add(btnLogout);
        }
    }
}