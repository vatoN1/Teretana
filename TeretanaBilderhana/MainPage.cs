using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.SendToBack(); 
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
        }

        private void MainPage_MouseClick(object sender, MouseEventArgs e)
        {
            Login l = new Login();
            l.Show();
            l.BringToFront();

        }
        bool flag = false;
        private void MainPage_MouseEnter(object sender, EventArgs e)
        {
            if (flag == false)
            { 
            Login l = new Login();
            l.Show();
            l.BringToFront();
            flag = true;
            }
        }

    }
}
