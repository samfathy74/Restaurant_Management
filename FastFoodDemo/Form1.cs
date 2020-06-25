using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = buttonHome.Height;
            SidePanel.Top = buttonHome.Top;
            firstCustomControl1.BringToFront();
        }
        // 
        // Home
        // 
        private void buttonHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHome.Height;
            SidePanel.Top = buttonHome.Top;
            firstCustomControl1.BringToFront();
        }
        // 
        // Eat-in
        // 
        private void buttonEat_in_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonEat_in.Height;
            SidePanel.Top = buttonEat_in.Top;
           bookTabelCustomControl1.BringToFront();
        }
        // 
        // fandmentail form controls
        // 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            buttonMinimize.Visible = false;
            buttonMaximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            buttonMinimize.Visible = true;
            buttonMaximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // 
        // Menu
        // 
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            menuUserControl1.BringToFront();
            SidePanel.Height = buttonMenu.Height;
            SidePanel.Top = buttonMenu.Top;

        }
        // 
        // About
        // 
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            aboutCustmControl1.BringToFront();
        }
        // 
        // Social media
        // 
        private void buttonFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.Facebook.com");
        }

        private void buttonTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.twitter.com");
        }

        private void buttonInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.instagram.com");
        }
        // 
        // Employees
        // 
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            employeesCustomControl1.BringToFront();
            SidePanel.Height = buttonEmployees.Height;
            SidePanel.Top = buttonEmployees.Top;
        }
        // 
        // to move form
        // 
        bool mousemove = false;
        Point point;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousemove = true;
            point = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousemove)

            {
                this.Location = new Point((this.Location.X - point.X) + e.X, (this.Location.Y - point.Y) + e.Y);
                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousemove = false;
        }

    }
}