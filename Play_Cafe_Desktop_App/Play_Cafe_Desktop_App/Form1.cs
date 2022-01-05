using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play_Cafe_Desktop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //We will invoke the customizeDesign function AFTER we initialize.
            customizeDesign();

        }

        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            //...Add any more submenu's to this method if you create them.
        }

        //This will allow us to hide the submenu's on the left side of the main form.
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }

        //This will allow us to show the submenu's on the left side of the main form.
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
        
        //The following methods will give logic to my button's once clicked.
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void btnPlaylistManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Need to update this method once I have a purpose for the button. Be sure to rename everything.
            hideSubMenu();
        }
    }
}
