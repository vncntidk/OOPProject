using FontAwesome.Sharp;
using OOPProject.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class FormMenu : Form
    {
        private int borderSize = 2;
        private Size formSize;
        private Form currentMenu;
        private string username;
        private LastClickedButton lastClickedButton = LastClickedButton.None;
        private bool isButton1Clicked = false;
        private bool isViewOpen = false;
        private bool isProfOpen = false;
        private bool isHomeOpen = false;
        private bool isAdminOpen = false;
        private bool isManageCuisineOpen = false;
        private bool isReportOpen = false;
        public FormMenu(string username)
        {
            InitializeComponent();
            CollapseMenu();
            hideSubMenu();
            this.Padding = new Padding(borderSize); 
            this.BackColor = Color.FromArgb(242, 242, 242);
            this.username = username;
            OpenForm(new Home(username));
            HighlightButton(btnHome);

            if (username == "admin")
            {
                btnAdmin.Visible = true;
                btnReport.Visible = false;
            }
            else
            {
                btnAdmin.Visible = false;
            }
            CheckForReplies();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();


         
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:  
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:  
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void CollapseMenu()
        {
            if (this.PanelMenu.Width > 200)  
            {
                PanelMenu.Width = 100;
                pictureBox1.Visible = false;
                buttons1.Dock = DockStyle.Top;
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {  
                PanelMenu.Width = 230;
                pictureBox1.Visible = true;
                buttons1.Dock = DockStyle.None;
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
                btnMax.Image = Image.FromFile("D:\\Downloads\\maximize (4).png");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Image = Image.FromFile("D:\\Downloads\\maximize (5).png");
                this.Size = formSize;
            }
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }


        private void FormMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            OpenForm(new Home(username));
            btnHome.BackColor = Color.FromArgb(255, 217, 179);
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

         
        protected override void WndProc(ref Message m)
        {

            const int WM_NCCALCSIZE = 0x0083;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                 
                m.Result = IntPtr.Zero;
                return;
            }
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;  
            const int SC_RESTORE = 0xF120;  
            const int WM_NCHITTEST = 0x0084; 
            const int resizeAreaSize = 10;
            #region Form Resize
             
            const int HTCLIENT = 1;  
            const int HTLEFT = 10;   
            const int HTRIGHT = 11;  
            const int HTTOP = 12;    
            const int HTTOPLEFT = 13; 
            const int HTTOPRIGHT = 14; 
            const int HTBOTTOM = 15;  
            const int HTBOTTOMLEFT = 16; 
            const int HTBOTTOMRIGHT = 17; 
             
            if (m.Msg == WM_NCHITTEST)
            {  
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal) 
                {
                    if ((int)m.Result == HTCLIENT) 
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());  
                        Point clientPoint = this.PointToClient(screenPoint);  
                        if (clientPoint.Y <= resizeAreaSize) 
                        {
                            if (clientPoint.X <= resizeAreaSize)  
                                m.Result = (IntPtr)HTTOPLEFT;  
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) 
                                m.Result = (IntPtr)HTTOP;  
                            else  
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))  
                        {
                            if (clientPoint.X <= resizeAreaSize) 
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize)) 
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize) 
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))  
                                m.Result = (IntPtr)HTBOTTOM;
                            else  
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
             
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
             
            if (m.Msg == WM_SYSCOMMAND)
            {
                 
                 
                 
                 
                 
                 
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)   
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE) 
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            hideSubMenu();
        }

        private void tblCurrentTab_Click(object sender, EventArgs e)
        {

        }

        private void hideSubMenu()
        {
            PanelSubCuisine.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnCuisines_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubCuisine);
        }


        private void OpenForm(Form current)
        {
            if (currentMenu != null)
            {
                currentMenu.Close();
            }

            currentMenu = current;
            current.TopLevel = false;
            current.FormBorderStyle = FormBorderStyle.None;
            current.Dock = DockStyle.Fill;
            pdesktop.Controls.Add(current);
            pdesktop.Tag = current;
            current.BringToFront();
            current.Show();
            tblCurrentTab.Text = current.Text;
        }

        private enum LastClickedButton
        {
            None,
            View,
            Manage,
            Prof,
            Admin,
            Report,
            Notif
        }

        
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            if (lastClickedButton == LastClickedButton.View || lastClickedButton == LastClickedButton.Manage || lastClickedButton == LastClickedButton.Prof)
            {
                currentMenu.Close();
                OpenForm(new Home(username));
                HighlightButton(btnHome);
                lastClickedButton = LastClickedButton.None;
            }
            else
            {
                 
                OpenForm(new Home(username));
                HighlightButton(btnHome);
                isHomeOpen = true;
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (lastClickedButton == LastClickedButton.View)
            {
                 
                currentMenu.Close();
                OpenForm(new Home(username));
                btnHome.BackColor = Color.FromArgb(255, 217, 179);
                btnView.BackColor = Color.Transparent;
                isViewOpen = false;
                lastClickedButton = LastClickedButton.None;
            }
            else
            {
                 
                currentMenu.Close();
                OpenForm(new ViewCuisines(username));
                HighlightButton(btnView);
                isViewOpen = true;
                lastClickedButton = LastClickedButton.View;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (lastClickedButton == LastClickedButton.Manage)
            {
                 
                currentMenu.Close();
                OpenForm(new Home(username));
                btnHome.BackColor = Color.FromArgb(255, 217, 179);
                button1.BackColor = Color.Transparent;
                isManageCuisineOpen = false;
                lastClickedButton = LastClickedButton.None;
            }
            else
            {
                 
                currentMenu.Close();
                OpenForm(new CuisineMenu(username));
                HighlightButton(button1);
                isManageCuisineOpen = true;
                lastClickedButton = LastClickedButton.Manage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lastClickedButton == LastClickedButton.Prof)
            {
                 
                currentMenu.Close();
                OpenForm(new Home(username));
                btnHome.BackColor = Color.FromArgb(255, 217, 179);
                btnProf.BackColor = Color.Transparent;
                isProfOpen = false;
                lastClickedButton = LastClickedButton.None;
            }
            else
            {
                 
                currentMenu.Close();
                OpenForm(new Profile(username));
                HighlightButton(btnProf);
                isProfOpen = true;
                lastClickedButton = LastClickedButton.Prof;
            }
        }

        private void HighlightButton(Button button)
        {
             
            btnHome.BackColor = Color.Transparent;
            btnView.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            btnProf.BackColor = Color.Transparent;
            btnAdmin.BackColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;

             
            button.BackColor = Color.FromArgb(255, 217, 179);
        }
        private void pdesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pdesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            if (lastClickedButton == LastClickedButton.Admin)
            {
                 
                currentMenu.Close();
                OpenForm(new Home(username));
                btnHome.BackColor = Color.FromArgb(255, 217, 179);
                btnAdmin.BackColor = Color.Transparent;
                isAdminOpen = false;
                lastClickedButton = LastClickedButton.None;
            }
            else
            {
                 
                currentMenu.Close();
                OpenForm(new Admin(username));
                HighlightButton(btnAdmin);
                isAdminOpen = true;
                lastClickedButton = LastClickedButton.Admin;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lastClickedButton == LastClickedButton.Report)
            {
                 
                currentMenu.Close();
                OpenForm(new Home(username));
                btnHome.BackColor = Color.FromArgb(255, 217, 179);
                btnReport.BackColor = Color.Transparent;
                isReportOpen = false;
                lastClickedButton = LastClickedButton.None;
            }
            else
            {
                 
                currentMenu.Close();
                OpenForm(new Report(username));
                HighlightButton(btnReport);
                isReportOpen = true;
                lastClickedButton = LastClickedButton.Report;
            }
        }

        private void CheckForReplies()
        {
            try
            {
                con.Open();

                 
                string replyQuery = "SELECT COUNT(*) FROM reply WHERE username = @username";
                cmd = new OleDbCommand(replyQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                int replyCount = (int)cmd.ExecuteScalar();

                if (replyCount > 0)
                {
                    MessageBox.Show("You have new replies from the admin.", "New Replies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    theReply idk = new theReply(username);
                    idk.Show();
                }

                 
                string replySuggQuery = "SELECT COUNT(*) FROM replysug WHERE username = @username";
                cmd = new OleDbCommand(replySuggQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                int replySuggCount = (int)cmd.ExecuteScalar();

                if (replySuggCount > 0)
                {
                    MessageBox.Show("You have new replies on your suggestions.", "New Replies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    theReply idk = new theReply(username);
                    idk.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
