using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPro2
{
    public partial class DbControl : Form
    {
        public DbControl()
        {
            InitializeComponent();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (code_box.Text == Properties.Settings.Default.dbCode)
            {
                isAuthorized();
            }
        }
        private void isAuthorized()
        {
            Machine_e.Enabled = true;
            Machine_n.Enabled = true;
            Machine_p.Enabled = true;
            Machine_x.Enabled = true;
            param_db.Enabled = true;

            Machine_e.Visible = true;
            Machine_n.Visible = true;
            Machine_p.Visible = true;
            Machine_x.Visible = true;
            param_db.Visible = true;
            label2.Visible = true;
        }

        private void param_db_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the dialog's properties
                folderBrowserDialog.InitialDirectory = Properties.Settings.Default.jsonDir;
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = false; // Hide the 'New Folder' button

                // Show the dialog and get the selected folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    Properties.Settings.Default.jsonDir = selectedFolder + "\\";

                    MessageBox.Show("Selected folder: " + selectedFolder);
                }
                else
                    return;
            }
        }

        private void Machine_e_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the dialog's properties
                folderBrowserDialog.InitialDirectory = Properties.Settings.Default.dbMachineE;
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = false; // Hide the 'New Folder' button

                // Show the dialog and get the selected folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    Properties.Settings.Default.dbMachineE = selectedFolder;

                    MessageBox.Show("Selected folder: " + selectedFolder);
                }
                else
                    return;
            }
        }

        private void Machine_n_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the dialog's properties
                folderBrowserDialog.InitialDirectory = Properties.Settings.Default.dbMachineN;
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = false; // Hide the 'New Folder' button

                // Show the dialog and get the selected folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    Properties.Settings.Default.dbMachineN = selectedFolder;

                    MessageBox.Show("Selected folder: " + selectedFolder);
                }
                else
                    return;
            }
        }

        private void Machine_p_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the dialog's properties
                folderBrowserDialog.InitialDirectory = Properties.Settings.Default.dbMachineP;
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = false; // Hide the 'New Folder' button

                // Show the dialog and get the selected folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    Properties.Settings.Default.dbMachineP = selectedFolder;

                    MessageBox.Show("Selected folder: " + selectedFolder);
                }
                else
                    return;
            }
        }

        private void Machine_x_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set the dialog's properties
                folderBrowserDialog.InitialDirectory = Properties.Settings.Default.dbMachineX;
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = false; // Hide the 'New Folder' button

                // Show the dialog and get the selected folder
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    Properties.Settings.Default.dbMachineX = selectedFolder;

                    MessageBox.Show("Selected folder: " + selectedFolder);
                }
                else
                    return;
            }
        }
    }
}
