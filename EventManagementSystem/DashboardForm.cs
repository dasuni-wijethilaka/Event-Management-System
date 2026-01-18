////using System;
////using System.Collections.Generic;
////using System.Drawing;
////using System.Windows.Forms;

////namespace EventManagementSystem
////{
////    public class DashboardForm : Form
////    {
////        private List<Event> events = new List<Event>();
////        private ListBox listEvents;
////        private TextBox txtEventName, txtEventDate, txtEventLocation;
////        private Button btnAdd, btnUpdate, btnDelete, btnLogout;
////        private Label lblEventId;
////        private Label lblStatus;

////        public DashboardForm()
////        {
////            InitializeDashboard();
////            LoadSampleEvents(); 
////        }

////        private void InitializeDashboard()
////        {

////            this.Text = "Dashboard - Event Management System";
////            this.Size = new Size(1000, 500);
////            this.StartPosition = FormStartPosition.CenterScreen;
////            this.BackColor = Color.White;
////            this.FormBorderStyle = FormBorderStyle.FixedDialog;
////            this.MaximizeBox = false;

////            Label lblTitle = new Label();
////            lblTitle.Text = "EVENT MANAGEMENT SYSTEM";
////            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
////            lblTitle.ForeColor = Color.DarkBlue;
////            lblTitle.Location = new Point(200, 20);
////            lblTitle.Size = new Size(400, 40);
////            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
////            this.Controls.Add(lblTitle);

////            Label lblSubtitle = new Label();
////            lblSubtitle.Text = "Manage Your Events";
////            lblSubtitle.Font = new Font("Arial", 12, FontStyle.Italic);
////            lblSubtitle.ForeColor = Color.DarkGray;
////            lblSubtitle.Location = new Point(280, 70);
////            lblSubtitle.Size = new Size(250, 25);
////            this.Controls.Add(lblSubtitle);

////            GroupBox groupEvents = new GroupBox();
////            groupEvents.Text = "Events List";
////            groupEvents.Font = new Font("Arial", 10, FontStyle.Bold);
////            groupEvents.Location = new Point(30, 110);
////            groupEvents.Size = new Size(350, 250);
////            this.Controls.Add(groupEvents);

////            listEvents = new ListBox();
////            listEvents.Font = new Font("Arial", 10);
////            listEvents.Location = new Point(10, 25);
////            listEvents.Size = new Size(330, 180);
////            listEvents.SelectedIndexChanged += ListEvents_SelectedIndexChanged;
////            groupEvents.Controls.Add(listEvents);

////            GroupBox groupDetails = new GroupBox();
////            groupDetails.Text = "Event Details";
////            groupDetails.Font = new Font("Arial", 10, FontStyle.Bold);
////            groupDetails.Location = new Point(400, 110);
////            groupDetails.Size = new Size(350, 250);
////            this.Controls.Add(groupDetails);

////            lblEventId = new Label();
////            lblEventId.Text = "";
////            lblEventId.Visible = false;
////            groupDetails.Controls.Add(lblEventId);

////            Label lblName = new Label();
////            lblName.Text = "Event Name:";
////            lblName.Font = new Font("Arial", 10);
////            lblName.Location = new Point(20, 40);
////            lblName.Size = new Size(100, 25);
////            groupDetails.Controls.Add(lblName);

////            txtEventName = new TextBox();
////            txtEventName.Font = new Font("Arial", 10);
////            txtEventName.Location = new Point(130, 40);
////            txtEventName.Size = new Size(200, 25);
////            txtEventName.BackColor = Color.WhiteSmoke;
////            groupDetails.Controls.Add(txtEventName);

////            Label lblDate = new Label();
////            lblDate.Text = "Event Date:";
////            lblDate.Font = new Font("Arial", 10);
////            lblDate.Location = new Point(20, 80);
////            lblDate.Size = new Size(100, 25);
////            groupDetails.Controls.Add(lblDate);

////            txtEventDate = new TextBox();
////            txtEventDate.Font = new Font("Arial", 10);
////            txtEventDate.Location = new Point(130, 80);
////            txtEventDate.Size = new Size(200, 25);
////            txtEventDate.BackColor = Color.WhiteSmoke;
////            groupDetails.Controls.Add(txtEventDate);

////            Label lblLocation = new Label();
////            lblLocation.Text = "Location:";
////            lblLocation.Font = new Font("Arial", 10);
////            lblLocation.Location = new Point(20, 120);
////            lblLocation.Size = new Size(100, 25);
////            groupDetails.Controls.Add(lblLocation);

////            txtEventLocation = new TextBox();
////            txtEventLocation.Font = new Font("Arial", 10);
////            txtEventLocation.Location = new Point(130, 120);
////            txtEventLocation.Size = new Size(200, 25);
////            txtEventLocation.BackColor = Color.WhiteSmoke;
////            groupDetails.Controls.Add(txtEventLocation);

////            Label lblDateHint = new Label();
////            lblDateHint.Text = "Format: YYYY-MM-DD (e.g., 2024-12-31)";
////            lblDateHint.Font = new Font("Arial", 8);
////            lblDateHint.ForeColor = Color.Gray;
////            lblDateHint.Location = new Point(130, 105);
////            lblDateHint.Size = new Size(200, 15);
////            groupDetails.Controls.Add(lblDateHint);

////            Panel buttonPanel = new Panel();
////            buttonPanel.Location = new Point(30, 370);
////            buttonPanel.Size = new Size(720, 50);
////            this.Controls.Add(buttonPanel);

////            btnAdd = new Button();
////            btnAdd.Text = "Add Event";
////            btnAdd.Font = new Font("Arial", 10, FontStyle.Bold);
////            btnAdd.Location = new Point(50, 10);
////            btnAdd.Size = new Size(120, 35);
////            btnAdd.BackColor = Color.LightGreen;
////            btnAdd.ForeColor = Color.Black;
////            btnAdd.Click += BtnAdd_Click;
////            buttonPanel.Controls.Add(btnAdd);

////            btnUpdate = new Button();
////            btnUpdate.Text = "Update Event";
////            btnUpdate.Font = new Font("Arial", 10, FontStyle.Bold);
////            btnUpdate.Location = new Point(200, 10);
////            btnUpdate.Size = new Size(120, 35);
////            btnUpdate.BackColor = Color.LightBlue;
////            btnUpdate.ForeColor = Color.Black;
////            btnUpdate.Click += BtnUpdate_Click;
////            buttonPanel.Controls.Add(btnUpdate);

////            btnDelete = new Button();
////            btnDelete.Text = "Delete Event";
////            btnDelete.Font = new Font("Arial", 10, FontStyle.Bold);
////            btnDelete.Location = new Point(350, 10);
////            btnDelete.Size = new Size(120, 35);
////            btnDelete.BackColor = Color.LightCoral;
////            btnDelete.ForeColor = Color.Black;
////            btnDelete.Click += BtnDelete_Click;
////            buttonPanel.Controls.Add(btnDelete);

////            Button btnClear = new Button();
////            btnClear.Text = "Clear Form";
////            btnClear.Font = new Font("Arial", 10);
////            btnClear.Location = new Point(500, 10);
////            btnClear.Size = new Size(120, 35);
////            btnClear.BackColor = Color.LightGray;
////            btnClear.ForeColor = Color.Black;
////            btnClear.Click += BtnClear_Click;
////            buttonPanel.Controls.Add(btnClear);

////            btnLogout = new Button();
////            btnLogout.Text = "Logout";
////            btnLogout.Font = new Font("Arial", 10, FontStyle.Bold);
////            btnLogout.Location = new Point(650, 10);
////            btnLogout.Size = new Size(120, 35);
////            btnLogout.BackColor = Color.Orange;
////            btnLogout.ForeColor = Color.Black;
////            btnLogout.Click += BtnLogout_Click;
////            buttonPanel.Controls.Add(btnLogout);

////            lblStatus = new Label();
////            lblStatus.Text = "Total Events: 0";
////            lblStatus.Font = new Font("Arial", 10);
////            lblStatus.Location = new Point(30, 430);
////            lblStatus.Size = new Size(200, 25);
////            this.Controls.Add(lblStatus);

////        }

////        private class Event
////        {
////            public int Id { get; set; }
////            public string Name { get; set; }
////            public string Date { get; set; }
////            public string Location { get; set; }

////            public Event(int id, string name, string date, string location)
////            {
////                Id = id;
////                Name = name;
////                Date = date;
////                Location = location;
////            }

////            public override string ToString()
////            {
////                return $"{Name} - {Date} - {Location}";
////            }
////        }

////        private void LoadSampleEvents()
////        {
////            // Add some sample events
////            events.Add(new Event(1, "Annual Conference", "2024-12-15", "Convention Center"));
////            events.Add(new Event(2, "Music Festival", "2024-11-20", "Central Park"));
////            events.Add(new Event(3, "Tech Workshop", "2024-10-10", "Tech Hub"));
////            events.Add(new Event(4, "Charity Gala", "2024-12-01", "Grand Hotel"));

////            RefreshEventList();
////        }

////        private void RefreshEventList()
////        {
////            listEvents.Items.Clear();
////            foreach (var evt in events)
////            {
////                listEvents.Items.Add(evt);
////            }

////            lblStatus.Text = $"Total Events: {events.Count}";
////        }

////        private void ListEvents_SelectedIndexChanged(object sender, EventArgs e)
////        {
////            if (listEvents.SelectedIndex >= 0 && listEvents.SelectedIndex < events.Count)
////            {
////                Event selectedEvent = events[listEvents.SelectedIndex];
////                lblEventId.Text = selectedEvent.Id.ToString();
////                txtEventName.Text = selectedEvent.Name;
////                txtEventDate.Text = selectedEvent.Date;
////                txtEventLocation.Text = selectedEvent.Location;
////            }
////        }

////        private void BtnAdd_Click(object sender, EventArgs e)
////        {
////            if (string.IsNullOrWhiteSpace(txtEventName.Text))
////            {
////                MessageBox.Show("Please enter event name!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txtEventName.Focus();
////                return;
////            }

////            if (string.IsNullOrWhiteSpace(txtEventDate.Text))
////            {
////                MessageBox.Show("Please enter event date!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txtEventDate.Focus();
////                return;
////            }

////            if (!IsValidDate(txtEventDate.Text))
////            {
////                MessageBox.Show("Please enter date in YYYY-MM-DD format!\nExample: 2024-12-31", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txtEventDate.Focus();
////                txtEventDate.SelectAll();
////                return;
////            }

////            int newId = 1;
////            if (events.Count > 0)
////            {
////                int maxId = 0;
////                foreach (var evt in events)
////                {
////                    if (evt.Id > maxId)
////                        maxId = evt.Id;
////                }
////                newId = maxId + 1;
////            }

////            Event newEvent = new Event(
////                newId,
////                txtEventName.Text.Trim(),
////                txtEventDate.Text.Trim(),
////                txtEventLocation.Text.Trim()
////            );

////            events.Add(newEvent);
////            RefreshEventList();

////            MessageBox.Show($"Event '{txtEventName.Text}' added successfully!\nEvent ID: {newId}", "Success",
////                MessageBoxButtons.OK, MessageBoxIcon.Information);

////            ClearForm();
////            txtEventName.Focus();
////        }

////        private void BtnUpdate_Click(object sender, EventArgs e)
////        {
////            if (listEvents.SelectedIndex < 0)
////            {
////                MessageBox.Show("Please select an event to update!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                return;
////            }

////            if (string.IsNullOrWhiteSpace(lblEventId.Text))
////            {
////                MessageBox.Show("No event selected!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                return;
////            }

////            if (string.IsNullOrWhiteSpace(txtEventName.Text))
////            {
////                MessageBox.Show("Please enter event name!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txtEventName.Focus();
////                return;
////            }

////            if (string.IsNullOrWhiteSpace(txtEventDate.Text))
////            {
////                MessageBox.Show("Please enter event date!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txtEventDate.Focus();
////                return;
////            }

////            if (!IsValidDate(txtEventDate.Text))
////            {
////                MessageBox.Show("Please enter date in YYYY-MM-DD format!\nExample: 2024-12-31", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                txtEventDate.Focus();
////                txtEventDate.SelectAll();
////                return;
////            }

////            int eventId = int.Parse(lblEventId.Text);
////            Event selectedEvent = events.Find(ev => ev.Id == eventId);

////            if (selectedEvent != null)
////            {
////                string oldName = selectedEvent.Name;
////                selectedEvent.Name = txtEventName.Text.Trim();
////                selectedEvent.Date = txtEventDate.Text.Trim();
////                selectedEvent.Location = txtEventLocation.Text.Trim();

////                RefreshEventList();

////                MessageBox.Show($"Event '{oldName}' updated successfully!", "Success",
////                    MessageBoxButtons.OK, MessageBoxIcon.Information);

////                ClearForm();
////            }
////        }

////        private void BtnDelete_Click(object sender, EventArgs e)
////        {
////            if (listEvents.SelectedIndex < 0)
////            {
////                MessageBox.Show("Please select an event to delete!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                return;
////            }

////            if (string.IsNullOrWhiteSpace(lblEventId.Text))
////            {
////                MessageBox.Show("No event selected!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                return;
////            }

////            int eventId = int.Parse(lblEventId.Text);
////            Event selectedEvent = events.Find(ev => ev.Id == eventId);

////            if (selectedEvent == null)
////            {
////                MessageBox.Show("Event not found!", "Error",
////                    MessageBoxButtons.OK, MessageBoxIcon.Error);
////                return;
////            }

////            string eventName = selectedEvent.Name;

////            DialogResult result = MessageBox.Show(
////                $"Are you sure you want to delete this event?\n\nEvent: {eventName}\nDate: {selectedEvent.Date}\nLocation: {selectedEvent.Location}",
////                "Confirm Delete",
////                MessageBoxButtons.YesNo,
////                MessageBoxIcon.Question
////            );

////            if (result == DialogResult.Yes)
////            {
////                events.RemoveAll(ev => ev.Id == eventId);
////                RefreshEventList();
////                ClearForm();

////                MessageBox.Show($"Event '{eventName}' deleted successfully!", "Success",
////                    MessageBoxButtons.OK, MessageBoxIcon.Information);
////            }
////        }

////        private void BtnClear_Click(object sender, EventArgs e)
////        {
////            ClearForm();
////        }

////        private void ClearForm()
////        {
////            lblEventId.Text = "";
////            txtEventName.Text = "";
////            txtEventDate.Text = "";
////            txtEventLocation.Text = "";
////            listEvents.ClearSelected();
////            txtEventName.Focus();
////        }

////        private void BtnLogout_Click(object sender, EventArgs e)
////        {
////            DialogResult result = MessageBox.Show(
////                "Are you sure you want to logout?\nYou will be returned to the login screen.",
////                "Logout Confirmation",
////                MessageBoxButtons.YesNo,
////                MessageBoxIcon.Question
////            );

////            if (result == DialogResult.Yes)
////            {
////                this.Close();
////            }
////        }

////        private bool IsValidDate(string dateString)
////        {
////            try
////            {
////                if (string.IsNullOrWhiteSpace(dateString))
////                    return false;

////                dateString = dateString.Trim();

////                if (dateString.Length != 10)
////                    return false;

////                if (dateString[4] != '-' || dateString[7] != '-')
////                    return false;

////                string yearStr = dateString.Substring(0, 4);
////                string monthStr = dateString.Substring(5, 2);
////                string dayStr = dateString.Substring(8, 2);

////                if (!int.TryParse(yearStr, out int year) ||
////                    !int.TryParse(monthStr, out int month) ||
////                    !int.TryParse(dayStr, out int day))
////                    return false;

////                if (year < 2024 || year > 2030)
////                    return false;

////                if (month < 1 || month > 12)
////                    return false;

////                if (day < 1 || day > 31)
////                    return false;

////                if (month == 2) 
////                {
////                    if (day > 29) return false;
////                }
////                else if (month == 4 || month == 6 || month == 9 || month == 11)
////                {
////                    if (day > 30) return false;
////                }

////                return true;
////            }
////            catch (Exception)
////            {
////                return false;
////            }
////        }

////        protected override void OnLoad(EventArgs e)
////        {
////            base.OnLoad(e);

////            txtEventName.KeyDown += TextBox_KeyDown;
////            txtEventDate.KeyDown += TextBox_KeyDown;
////            txtEventLocation.KeyDown += TextBox_KeyDown;

////            txtEventName.Focus();
////        }

////        private void TextBox_KeyDown(object sender, KeyEventArgs e)
////        {
////            if (e.KeyCode == Keys.Enter)
////            {
////                e.SuppressKeyPress = true; 
////                this.SelectNextControl((Control)sender, true, true, true, true);
////            }
////        }

////        protected override void OnFormClosing(FormClosingEventArgs e)
////        {
////            base.OnFormClosing(e);

////            if (e.CloseReason == CloseReason.UserClosing)
////            {
////                DialogResult result = MessageBox.Show(
////                    "Are you sure you want to logout?",
////                    "Logout",
////                    MessageBoxButtons.YesNo,
////                    MessageBoxIcon.Question
////                );

////                if (result == DialogResult.No)
////                {
////                    e.Cancel = true;
////                }
////            }
////        }
////    }
////}



//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Windows.Forms;

//namespace EventManagementSystem
//{
//    public class DashboardForm : Form
//    {
//        private List<Event> events = new List<Event>();
//        private ListBox listEvents;
//        private TextBox txtEventName, txtEventDate, txtEventLocation;
//        private Button btnAdd, btnUpdate, btnDelete, btnLogout;
//        private Label lblEventId;
//        private Label lblStatus;

//        public DashboardForm()
//        {
//            InitializeDashboard();
//            LoadSampleEvents();
//        }

//        private void InitializeDashboard()
//        {
//            // Increased width from 800 to 1000
//            this.Text = "Dashboard - Event Management System";
//            this.Size = new Size(1000, 500); // Changed width to 1000
//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.BackColor = Color.White;
//            this.FormBorderStyle = FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;

//            Label lblTitle = new Label();
//            lblTitle.Text = "EVENT MANAGEMENT SYSTEM";
//            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
//            lblTitle.ForeColor = Color.DarkBlue;
//            // Centered for 1000 width: (1000 - 400)/2 = 300
//            lblTitle.Location = new Point(300, 20); // Updated X position
//            lblTitle.Size = new Size(400, 40);
//            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
//            this.Controls.Add(lblTitle);

//            Label lblSubtitle = new Label();
//            lblSubtitle.Text = "Manage Your Events";
//            lblSubtitle.Font = new Font("Arial", 12, FontStyle.Italic);
//            lblSubtitle.ForeColor = Color.DarkGray;
//            // Centered: (1000 - 250)/2 = 375
//            lblSubtitle.Location = new Point(375, 70); // Updated X position
//            lblSubtitle.Size = new Size(250, 25);
//            this.Controls.Add(lblSubtitle);

//            GroupBox groupEvents = new GroupBox();
//            groupEvents.Text = "Events List";
//            groupEvents.Font = new Font("Arial", 10, FontStyle.Bold);
//            groupEvents.Location = new Point(30, 110);
//            // Increased width to 450 (was 350)
//            groupEvents.Size = new Size(450, 250); // Increased width
//            this.Controls.Add(groupEvents);

//            listEvents = new ListBox();
//            listEvents.Font = new Font("Arial", 10);
//            listEvents.Location = new Point(10, 25);
//            // Adjusted to fit new group box width
//            listEvents.Size = new Size(430, 180); // Increased width
//            listEvents.SelectedIndexChanged += ListEvents_SelectedIndexChanged;
//            groupEvents.Controls.Add(listEvents);

//            GroupBox groupDetails = new GroupBox();
//            groupDetails.Text = "Event Details";
//            groupDetails.Font = new Font("Arial", 10, FontStyle.Bold);
//            // Positioned to the right of the first group box with more space
//            groupDetails.Location = new Point(500, 110); // Updated X position
//            // Increased width to 450 (was 350)
//            groupDetails.Size = new Size(450, 250); // Increased width
//            this.Controls.Add(groupDetails);

//            lblEventId = new Label();
//            lblEventId.Text = "";
//            lblEventId.Visible = false;
//            groupDetails.Controls.Add(lblEventId);

//            Label lblName = new Label();
//            lblName.Text = "Event Name:";
//            lblName.Font = new Font("Arial", 10);
//            lblName.Location = new Point(20, 40);
//            lblName.Size = new Size(100, 25);
//            groupDetails.Controls.Add(lblName);

//            txtEventName = new TextBox();
//            txtEventName.Font = new Font("Arial", 10);
//            txtEventName.Location = new Point(130, 40);
//            // Increased width to 300 (was 200)
//            txtEventName.Size = new Size(300, 25); // Increased width
//            txtEventName.BackColor = Color.WhiteSmoke;
//            groupDetails.Controls.Add(txtEventName);

//            Label lblDate = new Label();
//            lblDate.Text = "Event Date:";
//            lblDate.Font = new Font("Arial", 10);
//            lblDate.Location = new Point(20, 80);
//            lblDate.Size = new Size(100, 25);
//            groupDetails.Controls.Add(lblDate);

//            txtEventDate = new TextBox();
//            txtEventDate.Font = new Font("Arial", 10);
//            txtEventDate.Location = new Point(130, 80);
//            // Increased width to 300 (was 200)
//            txtEventDate.Size = new Size(300, 25); // Increased width
//            txtEventDate.BackColor = Color.WhiteSmoke;
//            groupDetails.Controls.Add(txtEventDate);

//            Label lblLocation = new Label();
//            lblLocation.Text = "Location:";
//            lblLocation.Font = new Font("Arial", 10);
//            lblLocation.Location = new Point(20, 120);
//            lblLocation.Size = new Size(100, 25);
//            groupDetails.Controls.Add(lblLocation);

//            txtEventLocation = new TextBox();
//            txtEventLocation.Font = new Font("Arial", 10);
//            txtEventLocation.Location = new Point(130, 120);
//            // Increased width to 300 (was 200)
//            txtEventLocation.Size = new Size(300, 25); // Increased width
//            txtEventLocation.BackColor = Color.WhiteSmoke;
//            groupDetails.Controls.Add(txtEventLocation);

//            Label lblDateHint = new Label();
//            lblDateHint.Text = "Format: YYYY-MM-DD (e.g., 2024-12-31)";
//            lblDateHint.Font = new Font("Arial", 8);
//            lblDateHint.ForeColor = Color.Gray;
//            lblDateHint.Location = new Point(130, 105);
//            // Increased width to 300 (was 200)
//            lblDateHint.Size = new Size(300, 15); // Increased width
//            groupDetails.Controls.Add(lblDateHint);

//            Panel buttonPanel = new Panel();
//            buttonPanel.Location = new Point(30, 370);
//            // Increased width to 940 (was 720) to match new form width
//            buttonPanel.Size = new Size(940, 50); // Increased width
//            this.Controls.Add(buttonPanel);

//            // Calculate button positions for the wider panel
//            int panelWidth = 940;
//            int buttonWidth = 120;
//            int buttonSpacing = (panelWidth - (6 * buttonWidth)) / 7; // 6 buttons with spacing

//            btnAdd = new Button();
//            btnAdd.Text = "Add Event";
//            btnAdd.Font = new Font("Arial", 10, FontStyle.Bold);
//            // Position buttons with equal spacing
//            btnAdd.Location = new Point(buttonSpacing, 10);
//            btnAdd.Size = new Size(buttonWidth, 35);
//            btnAdd.BackColor = Color.LightGreen;
//            btnAdd.ForeColor = Color.Black;
//            btnAdd.Click += BtnAdd_Click;
//            buttonPanel.Controls.Add(btnAdd);

//            btnUpdate = new Button();
//            btnUpdate.Text = "Update Event";
//            btnUpdate.Font = new Font("Arial", 10, FontStyle.Bold);
//            btnUpdate.Location = new Point(buttonSpacing * 2 + buttonWidth, 10);
//            btnUpdate.Size = new Size(buttonWidth, 35);
//            btnUpdate.BackColor = Color.LightBlue;
//            btnUpdate.ForeColor = Color.Black;
//            btnUpdate.Click += BtnUpdate_Click;
//            buttonPanel.Controls.Add(btnUpdate);

//            btnDelete = new Button();
//            btnDelete.Text = "Delete Event";
//            btnDelete.Font = new Font("Arial", 10, FontStyle.Bold);
//            btnDelete.Location = new Point(buttonSpacing * 3 + buttonWidth * 2, 10);
//            btnDelete.Size = new Size(buttonWidth, 35);
//            btnDelete.BackColor = Color.LightCoral;
//            btnDelete.ForeColor = Color.Black;
//            btnDelete.Click += BtnDelete_Click;
//            buttonPanel.Controls.Add(btnDelete);

//            Button btnClear = new Button();
//            btnClear.Text = "Clear Form";
//            btnClear.Font = new Font("Arial", 10);
//            btnClear.Location = new Point(buttonSpacing * 4 + buttonWidth * 3, 10);
//            btnClear.Size = new Size(buttonWidth, 35);
//            btnClear.BackColor = Color.LightGray;
//            btnClear.ForeColor = Color.Black;
//            btnClear.Click += BtnClear_Click;
//            buttonPanel.Controls.Add(btnClear);

//            btnLogout = new Button();
//            btnLogout.Text = "Logout";
//            btnLogout.Font = new Font("Arial", 10, FontStyle.Bold);
//            btnLogout.Location = new Point(buttonSpacing * 6 + buttonWidth * 5, 10);
//            btnLogout.Size = new Size(buttonWidth, 35);
//            btnLogout.BackColor = Color.Orange;
//            btnLogout.ForeColor = Color.Black;
//            btnLogout.Click += BtnLogout_Click;
//            buttonPanel.Controls.Add(btnLogout);

//            // Add a Refresh button for better spacing
//            Button btnRefresh = new Button();
//            btnRefresh.Text = "Refresh List";
//            btnRefresh.Font = new Font("Arial", 10);
//            btnRefresh.Location = new Point(buttonSpacing * 5 + buttonWidth * 4, 10);
//            btnRefresh.Size = new Size(buttonWidth, 35);
//            btnRefresh.BackColor = Color.LightGoldenrodYellow;
//            btnRefresh.ForeColor = Color.Black;
//            btnRefresh.Click += (sender, e) => RefreshEventList();
//            buttonPanel.Controls.Add(btnRefresh);

//            lblStatus = new Label();
//            lblStatus.Text = "Total Events: 0";
//            lblStatus.Font = new Font("Arial", 10);
//            lblStatus.Location = new Point(30, 430);
//            lblStatus.Size = new Size(200, 25);
//            this.Controls.Add(lblStatus);

//        }

//        private class Event
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public string Date { get; set; }
//            public string Location { get; set; }

//            public Event(int id, string name, string date, string location)
//            {
//                Id = id;
//                Name = name;
//                Date = date;
//                Location = location;
//            }

//            public override string ToString()
//            {
//                return $"{Name} - {Date} - {Location}";
//            }
//        }

//        private void LoadSampleEvents()
//        {
//            // Add some sample events
//            events.Add(new Event(1, "Annual Conference", "2024-12-15", "Convention Center"));
//            events.Add(new Event(2, "Music Festival", "2024-11-20", "Central Park"));
//            events.Add(new Event(3, "Tech Workshop", "2024-10-10", "Tech Hub"));
//            events.Add(new Event(4, "Charity Gala", "2024-12-01", "Grand Hotel"));

//            RefreshEventList();
//        }

//        private void RefreshEventList()
//        {
//            listEvents.Items.Clear();
//            foreach (var evt in events)
//            {
//                listEvents.Items.Add(evt);
//            }

//            lblStatus.Text = $"Total Events: {events.Count}";
//        }

//        private void ListEvents_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (listEvents.SelectedIndex >= 0 && listEvents.SelectedIndex < events.Count)
//            {
//                Event selectedEvent = events[listEvents.SelectedIndex];
//                lblEventId.Text = selectedEvent.Id.ToString();
//                txtEventName.Text = selectedEvent.Name;
//                txtEventDate.Text = selectedEvent.Date;
//                txtEventLocation.Text = selectedEvent.Location;
//            }
//        }

//        private void BtnAdd_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(txtEventName.Text))
//            {
//                MessageBox.Show("Please enter event name!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEventName.Focus();
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(txtEventDate.Text))
//            {
//                MessageBox.Show("Please enter event date!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEventDate.Focus();
//                return;
//            }

//            if (!IsValidDate(txtEventDate.Text))
//            {
//                MessageBox.Show("Please enter date in YYYY-MM-DD format!\nExample: 2024-12-31", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEventDate.Focus();
//                txtEventDate.SelectAll();
//                return;
//            }

//            int newId = 1;
//            if (events.Count > 0)
//            {
//                int maxId = 0;
//                foreach (var evt in events)
//                {
//                    if (evt.Id > maxId)
//                        maxId = evt.Id;
//                }
//                newId = maxId + 1;
//            }

//            Event newEvent = new Event(
//                newId,
//                txtEventName.Text.Trim(),
//                txtEventDate.Text.Trim(),
//                txtEventLocation.Text.Trim()
//            );

//            events.Add(newEvent);
//            RefreshEventList();

//            MessageBox.Show($"Event '{txtEventName.Text}' added successfully!\nEvent ID: {newId}", "Success",
//                MessageBoxButtons.OK, MessageBoxIcon.Information);

//            ClearForm();
//            txtEventName.Focus();
//        }

//        private void BtnUpdate_Click(object sender, EventArgs e)
//        {
//            if (listEvents.SelectedIndex < 0)
//            {
//                MessageBox.Show("Please select an event to update!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(lblEventId.Text))
//            {
//                MessageBox.Show("No event selected!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(txtEventName.Text))
//            {
//                MessageBox.Show("Please enter event name!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEventName.Focus();
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(txtEventDate.Text))
//            {
//                MessageBox.Show("Please enter event date!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEventDate.Focus();
//                return;
//            }

//            if (!IsValidDate(txtEventDate.Text))
//            {
//                MessageBox.Show("Please enter date in YYYY-MM-DD format!\nExample: 2024-12-31", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                txtEventDate.Focus();
//                txtEventDate.SelectAll();
//                return;
//            }

//            int eventId = int.Parse(lblEventId.Text);
//            Event selectedEvent = events.Find(ev => ev.Id == eventId);

//            if (selectedEvent != null)
//            {
//                string oldName = selectedEvent.Name;
//                selectedEvent.Name = txtEventName.Text.Trim();
//                selectedEvent.Date = txtEventDate.Text.Trim();
//                selectedEvent.Location = txtEventLocation.Text.Trim();

//                RefreshEventList();

//                MessageBox.Show($"Event '{oldName}' updated successfully!", "Success",
//                    MessageBoxButtons.OK, MessageBoxIcon.Information);

//                ClearForm();
//            }
//        }

//        private void BtnDelete_Click(object sender, EventArgs e)
//        {
//            if (listEvents.SelectedIndex < 0)
//            {
//                MessageBox.Show("Please select an event to delete!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            if (string.IsNullOrWhiteSpace(lblEventId.Text))
//            {
//                MessageBox.Show("No event selected!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return;
//            }

//            int eventId = int.Parse(lblEventId.Text);
//            Event selectedEvent = events.Find(ev => ev.Id == eventId);

//            if (selectedEvent == null)
//            {
//                MessageBox.Show("Event not found!", "Error",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            string eventName = selectedEvent.Name;

//            DialogResult result = MessageBox.Show(
//                $"Are you sure you want to delete this event?\n\nEvent: {eventName}\nDate: {selectedEvent.Date}\nLocation: {selectedEvent.Location}",
//                "Confirm Delete",
//                MessageBoxButtons.YesNo,
//                MessageBoxIcon.Question
//            );

//            if (result == DialogResult.Yes)
//            {
//                events.RemoveAll(ev => ev.Id == eventId);
//                RefreshEventList();
//                ClearForm();

//                MessageBox.Show($"Event '{eventName}' deleted successfully!", "Success",
//                    MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        private void BtnClear_Click(object sender, EventArgs e)
//        {
//            ClearForm();
//        }

//        private void ClearForm()
//        {
//            lblEventId.Text = "";
//            txtEventName.Text = "";
//            txtEventDate.Text = "";
//            txtEventLocation.Text = "";
//            listEvents.ClearSelected();
//            txtEventName.Focus();
//        }

//        private void BtnLogout_Click(object sender, EventArgs e)
//        {
//            DialogResult result = MessageBox.Show(
//                "Are you sure you want to logout?\nYou will be returned to the login screen.",
//                "Logout Confirmation",
//                MessageBoxButtons.YesNo,
//                MessageBoxIcon.Question
//            );

//            if (result == DialogResult.Yes)
//            {
//                this.Close();
//            }
//        }

//        private bool IsValidDate(string dateString)
//        {
//            try
//            {
//                if (string.IsNullOrWhiteSpace(dateString))
//                    return false;

//                dateString = dateString.Trim();

//                if (dateString.Length != 10)
//                    return false;

//                if (dateString[4] != '-' || dateString[7] != '-')
//                    return false;

//                string yearStr = dateString.Substring(0, 4);
//                string monthStr = dateString.Substring(5, 2);
//                string dayStr = dateString.Substring(8, 2);

//                if (!int.TryParse(yearStr, out int year) ||
//                    !int.TryParse(monthStr, out int month) ||
//                    !int.TryParse(dayStr, out int day))
//                    return false;

//                if (year < 2024 || year > 2030)
//                    return false;

//                if (month < 1 || month > 12)
//                    return false;

//                if (day < 1 || day > 31)
//                    return false;

//                if (month == 2)
//                {
//                    if (day > 29) return false;
//                }
//                else if (month == 4 || month == 6 || month == 9 || month == 11)
//                {
//                    if (day > 30) return false;
//                }

//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        protected override void OnLoad(EventArgs e)
//        {
//            base.OnLoad(e);

//            txtEventName.KeyDown += TextBox_KeyDown;
//            txtEventDate.KeyDown += TextBox_KeyDown;
//            txtEventLocation.KeyDown += TextBox_KeyDown;

//            txtEventName.Focus();
//        }

//        private void TextBox_KeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                e.SuppressKeyPress = true;
//                this.SelectNextControl((Control)sender, true, true, true, true);
//            }
//        }

//        protected override void OnFormClosing(FormClosingEventArgs e)
//        {
//            base.OnFormClosing(e);

//            if (e.CloseReason == CloseReason.UserClosing)
//            {
//                DialogResult result = MessageBox.Show(
//                    "Are you sure you want to logout?",
//                    "Logout",
//                    MessageBoxButtons.YesNo,
//                    MessageBoxIcon.Question
//                );

//                if (result == DialogResult.No)
//                {
//                    e.Cancel = true;
//                }
//            }
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public class DashboardForm : Form
    {
        private List<Event> events = new List<Event>();
        private ListBox listEvents;
        private TextBox txtEventName, txtEventDate, txtEventLocation;
        private Button btnAdd, btnUpdate, btnDelete, btnLogout;
        private Label lblEventId;
        private Label lblStatus;
        private bool logoutConfirmed = false;

        public DashboardForm()
        {
            InitializeDashboard();
            LoadSampleEvents();
        }

        private void InitializeDashboard()
        {
            this.Text = "Dashboard - Event Management System";
            this.Size = new Size(1000, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            Label lblTitle = new Label();
            lblTitle.Text = "EVENT MANAGEMENT SYSTEM";
            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(300, 20);
            lblTitle.Size = new Size(400, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblTitle);

            Label lblSubtitle = new Label();
            lblSubtitle.Text = "Manage Your Events";
            lblSubtitle.Font = new Font("Arial", 12, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.DarkGray;
            lblSubtitle.Location = new Point(375, 70);
            lblSubtitle.Size = new Size(250, 25);
            this.Controls.Add(lblSubtitle);

            GroupBox groupEvents = new GroupBox();
            groupEvents.Text = "Events List";
            groupEvents.Font = new Font("Arial", 10, FontStyle.Bold);
            groupEvents.Location = new Point(30, 110);
            groupEvents.Size = new Size(450, 250);
            this.Controls.Add(groupEvents);

            listEvents = new ListBox();
            listEvents.Font = new Font("Arial", 10);
            listEvents.Location = new Point(10, 25);
            listEvents.Size = new Size(430, 180);
            listEvents.SelectedIndexChanged += ListEvents_SelectedIndexChanged;
            groupEvents.Controls.Add(listEvents);

            GroupBox groupDetails = new GroupBox();
            groupDetails.Text = "Event Details";
            groupDetails.Font = new Font("Arial", 10, FontStyle.Bold);
            groupDetails.Location = new Point(500, 110);
            groupDetails.Size = new Size(450, 250);
            this.Controls.Add(groupDetails);

            lblEventId = new Label();
            lblEventId.Text = "";
            lblEventId.Visible = false;
            groupDetails.Controls.Add(lblEventId);

            Label lblName = new Label();
            lblName.Text = "Event Name:";
            lblName.Font = new Font("Arial", 10);
            lblName.Location = new Point(20, 40);
            lblName.Size = new Size(100, 25);
            groupDetails.Controls.Add(lblName);

            txtEventName = new TextBox();
            txtEventName.Font = new Font("Arial", 10);
            txtEventName.Location = new Point(130, 40);
            txtEventName.Size = new Size(300, 25);
            txtEventName.BackColor = Color.WhiteSmoke;
            groupDetails.Controls.Add(txtEventName);

            Label lblDate = new Label();
            lblDate.Text = "Event Date:";
            lblDate.Font = new Font("Arial", 10);
            lblDate.Location = new Point(20, 80);
            lblDate.Size = new Size(100, 25);
            groupDetails.Controls.Add(lblDate);

            txtEventDate = new TextBox();
            txtEventDate.Font = new Font("Arial", 10);
            txtEventDate.Location = new Point(130, 80);
            txtEventDate.Size = new Size(300, 25);
            txtEventDate.BackColor = Color.WhiteSmoke;
            groupDetails.Controls.Add(txtEventDate);

            Label lblLocation = new Label();
            lblLocation.Text = "Location:";
            lblLocation.Font = new Font("Arial", 10);
            lblLocation.Location = new Point(20, 120);
            lblLocation.Size = new Size(100, 25);
            groupDetails.Controls.Add(lblLocation);

            txtEventLocation = new TextBox();
            txtEventLocation.Font = new Font("Arial", 10);
            txtEventLocation.Location = new Point(130, 120);
            txtEventLocation.Size = new Size(300, 25);
            txtEventLocation.BackColor = Color.WhiteSmoke;
            groupDetails.Controls.Add(txtEventLocation);

            Label lblDateHint = new Label();
            lblDateHint.Text = "Format: YYYY-MM-DD (e.g., 2024-12-31)";
            lblDateHint.Font = new Font("Arial", 8);
            lblDateHint.ForeColor = Color.Gray;
            lblDateHint.Location = new Point(130, 105);
            lblDateHint.Size = new Size(300, 15);
            groupDetails.Controls.Add(lblDateHint);

            Panel buttonPanel = new Panel();
            buttonPanel.Location = new Point(30, 370);
            buttonPanel.Size = new Size(940, 50);
            this.Controls.Add(buttonPanel);

            int panelWidth = 940;
            int buttonWidth = 120;
            int buttonSpacing = (panelWidth - (6 * buttonWidth)) / 7;

            btnAdd = new Button();
            btnAdd.Text = "Add Event";
            btnAdd.Font = new Font("Arial", 10, FontStyle.Bold);
            btnAdd.Location = new Point(buttonSpacing, 10);
            btnAdd.Size = new Size(buttonWidth, 35);
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Click += BtnAdd_Click;
            buttonPanel.Controls.Add(btnAdd);

            btnUpdate = new Button();
            btnUpdate.Text = "Update Event";
            btnUpdate.Font = new Font("Arial", 10, FontStyle.Bold);
            btnUpdate.Location = new Point(buttonSpacing * 2 + buttonWidth, 10);
            btnUpdate.Size = new Size(buttonWidth, 35);
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Click += BtnUpdate_Click;
            buttonPanel.Controls.Add(btnUpdate);

            btnDelete = new Button();
            btnDelete.Text = "Delete Event";
            btnDelete.Font = new Font("Arial", 10, FontStyle.Bold);
            btnDelete.Location = new Point(buttonSpacing * 3 + buttonWidth * 2, 10);
            btnDelete.Size = new Size(buttonWidth, 35);
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Click += BtnDelete_Click;
            buttonPanel.Controls.Add(btnDelete);

            Button btnClear = new Button();
            btnClear.Text = "Clear Form";
            btnClear.Font = new Font("Arial", 10);
            btnClear.Location = new Point(buttonSpacing * 4 + buttonWidth * 3, 10);
            btnClear.Size = new Size(buttonWidth, 35);
            btnClear.BackColor = Color.LightGray;
            btnClear.ForeColor = Color.Black;
            btnClear.Click += BtnClear_Click;
            buttonPanel.Controls.Add(btnClear);

            Button btnRefresh = new Button();
            btnRefresh.Text = "Refresh List";
            btnRefresh.Font = new Font("Arial", 10);
            btnRefresh.Location = new Point(buttonSpacing * 5 + buttonWidth * 4, 10);
            btnRefresh.Size = new Size(buttonWidth, 35);
            btnRefresh.BackColor = Color.LightGoldenrodYellow;
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Click += (sender, e) => RefreshEventList();
            buttonPanel.Controls.Add(btnRefresh);

            btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Font = new Font("Arial", 10, FontStyle.Bold);
            btnLogout.Location = new Point(buttonSpacing * 6 + buttonWidth * 5, 10);
            btnLogout.Size = new Size(buttonWidth, 35);
            btnLogout.BackColor = Color.Orange;
            btnLogout.ForeColor = Color.Black;
            btnLogout.Click += BtnLogout_Click;
            buttonPanel.Controls.Add(btnLogout);

            lblStatus = new Label();
            lblStatus.Text = "Total Events: 0";
            lblStatus.Font = new Font("Arial", 10);
            lblStatus.Location = new Point(30, 430);
            lblStatus.Size = new Size(200, 25);
            this.Controls.Add(lblStatus);
        }

        private class Event
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
            public string Location { get; set; }

            public Event(int id, string name, string date, string location)
            {
                Id = id;
                Name = name;
                Date = date;
                Location = location;
            }

            public override string ToString()
            {
                return $"{Name} - {Date} - {Location}";
            }
        }

        private void LoadSampleEvents()
        {
            events.Add(new Event(1, "Annual Conference", "2024-12-15", "Convention Center"));
            events.Add(new Event(2, "Music Festival", "2024-11-20", "Central Park"));
            events.Add(new Event(3, "Tech Workshop", "2024-10-10", "Tech Hub"));
            events.Add(new Event(4, "Charity Gala", "2024-12-01", "Grand Hotel"));

            RefreshEventList();
        }

        private void RefreshEventList()
        {
            listEvents.Items.Clear();
            foreach (var evt in events)
            {
                listEvents.Items.Add(evt);
            }

            lblStatus.Text = $"Total Events: {events.Count}";
        }

        private void ListEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEvents.SelectedIndex >= 0 && listEvents.SelectedIndex < events.Count)
            {
                Event selectedEvent = events[listEvents.SelectedIndex];
                lblEventId.Text = selectedEvent.Id.ToString();
                txtEventName.Text = selectedEvent.Name;
                txtEventDate.Text = selectedEvent.Date;
                txtEventLocation.Text = selectedEvent.Location;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Please enter event name!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventDate.Text))
            {
                MessageBox.Show("Please enter event date!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventDate.Focus();
                return;
            }

            if (!IsValidDate(txtEventDate.Text))
            {
                MessageBox.Show("Please enter date in YYYY-MM-DD format!\nExample: 2024-12-31", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventDate.Focus();
                txtEventDate.SelectAll();
                return;
            }

            int newId = 1;
            if (events.Count > 0)
            {
                int maxId = 0;
                foreach (var evt in events)
                {
                    if (evt.Id > maxId)
                        maxId = evt.Id;
                }
                newId = maxId + 1;
            }

            Event newEvent = new Event(
                newId,
                txtEventName.Text.Trim(),
                txtEventDate.Text.Trim(),
                txtEventLocation.Text.Trim()
            );

            events.Add(newEvent);
            RefreshEventList();

            MessageBox.Show($"Event '{txtEventName.Text}' added successfully!\nEvent ID: {newId}", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            txtEventName.Focus();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (listEvents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an event to update!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(lblEventId.Text))
            {
                MessageBox.Show("No event selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Please enter event name!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventDate.Text))
            {
                MessageBox.Show("Please enter event date!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventDate.Focus();
                return;
            }

            if (!IsValidDate(txtEventDate.Text))
            {
                MessageBox.Show("Please enter date in YYYY-MM-DD format!\nExample: 2024-12-31", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEventDate.Focus();
                txtEventDate.SelectAll();
                return;
            }

            int eventId = int.Parse(lblEventId.Text);
            Event selectedEvent = events.Find(ev => ev.Id == eventId);

            if (selectedEvent != null)
            {
                string oldName = selectedEvent.Name;
                selectedEvent.Name = txtEventName.Text.Trim();
                selectedEvent.Date = txtEventDate.Text.Trim();
                selectedEvent.Location = txtEventLocation.Text.Trim();

                RefreshEventList();

                MessageBox.Show($"Event '{oldName}' updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listEvents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an event to delete!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(lblEventId.Text))
            {
                MessageBox.Show("No event selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int eventId = int.Parse(lblEventId.Text);
            Event selectedEvent = events.Find(ev => ev.Id == eventId);

            if (selectedEvent == null)
            {
                MessageBox.Show("Event not found!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string eventName = selectedEvent.Name;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete this event?\n\nEvent: {eventName}\nDate: {selectedEvent.Date}\nLocation: {selectedEvent.Location}",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                events.RemoveAll(ev => ev.Id == eventId);
                RefreshEventList();
                ClearForm();

                MessageBox.Show($"Event '{eventName}' deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            lblEventId.Text = "";
            txtEventName.Text = "";
            txtEventDate.Text = "";
            txtEventLocation.Text = "";
            listEvents.ClearSelected();
            txtEventName.Focus();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                logoutConfirmed = true;
                this.Close();
            }
        }

        private bool IsValidDate(string dateString)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dateString))
                    return false;

                dateString = dateString.Trim();

                if (dateString.Length != 10)
                    return false;

                if (dateString[4] != '-' || dateString[7] != '-')
                    return false;

                string yearStr = dateString.Substring(0, 4);
                string monthStr = dateString.Substring(5, 2);
                string dayStr = dateString.Substring(8, 2);

                if (!int.TryParse(yearStr, out int year) ||
                    !int.TryParse(monthStr, out int month) ||
                    !int.TryParse(dayStr, out int day))
                    return false;

                if (year < 2024 || year > 2030)
                    return false;

                if (month < 1 || month > 12)
                    return false;

                if (day < 1 || day > 31)
                    return false;

                if (month == 2)
                {
                    if (day > 29) return false;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 30) return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtEventName.KeyDown += TextBox_KeyDown;
            txtEventDate.KeyDown += TextBox_KeyDown;
            txtEventLocation.KeyDown += TextBox_KeyDown;

            txtEventName.Focus();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Only show confirmation if closing by user (clicking X) and logout wasn't confirmed by button
            if (e.CloseReason == CloseReason.UserClosing && !logoutConfirmed)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
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